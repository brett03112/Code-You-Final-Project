using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using CommunityCenter.Data;
using CommunityCenter.wwwroot.js.signalr.Hubs;
using Microsoft.AspNetCore.SignalR;
using static CommunityCenter.Models.CommunityCenterModels;

[Authorize]
public class AuctionController : Controller
{
    private readonly AuctionDbContext _context;
    private readonly IHubContext<AuctionHub> _hubContext;

    public AuctionController(AuctionDbContext context, IHubContext<AuctionHub> hubContext)
    {
        _context = context;
        _hubContext = hubContext;
    }

    public async Task<IActionResult> Index()
    {
        var activeDesserts = await _context.Desserts
            .Include(d => d.WinningBidder)
            .Where(d => d.IsActive)
            .OrderBy(d => d.EndTime)
            .ToListAsync();
        return View(activeDesserts);
    }

    [HttpPost]
    public async Task<IActionResult> PlaceBid(int dessertId, decimal bidAmount)
    {
        var dessert = await _context.Desserts.FindAsync(dessertId);
        if (dessert == null || !dessert.IsActive || bidAmount <= dessert.CurrentPrice)
        {
            return Json(new { success = false, message = "Invalid bid" });
        }

        var bid = new Bid
        {
            DessertId = dessertId,
            BidderId = User.Identity.Name,
            Amount = bidAmount,
            TimeStamp = DateTime.UtcNow
        };

        dessert.CurrentPrice = bidAmount;
        dessert.WinningBidderId = User.Identity.Name;

        _context.Bids.Add(bid);
        await _context.SaveChangesAsync();

        await _hubContext.Clients.All.SendAsync("BidUpdated",
            dessertId,
            bidAmount,
            User.Identity.Name,
            User.Identity.Name);

        return Json(new { success = true });
    }

    [Authorize(Roles = "Admin")]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Create(Dessert dessert)
    {
        if (ModelState.IsValid)
        {
            dessert.IsActive = true;
            dessert.CurrentPrice = dessert.StartingPrice;
            _context.Add(dessert);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(dessert);
    }
}
