using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RealTimeAuction.Server.Models;

namespace RealTimeAuction.Client.Pages
{
    public class AuctionRoomModel : PageModel
    {
        private readonly IHttpClientFactory _clientFactory;
        private readonly ILogger<AuctionRoomModel> _logger;

        public AuctionRoomModel(IHttpClientFactory clientFactory, ILogger<AuctionRoomModel> logger)
        {
            _clientFactory = clientFactory;
            _logger = logger;
            Desserts = new List<Dessert>(); // Initialize in constructor
        }

        public Auction? ActiveAuction { get; set; } // Make nullable
        public List<Dessert> Desserts { get; set; } // Already initialized in constructor

        public async Task<IActionResult> OnGetAsync()
        {
            if (User?.Identity?.IsAuthenticated != true)
            {
                return RedirectToPage("/Login");
            }

            var client = _clientFactory.CreateClient("ServerAPI");

            try
            {
                // Get active auction
                var auctionResponse = await client.GetAsync("api/auctions/active");
                if (auctionResponse.IsSuccessStatusCode)
                {
                    ActiveAuction = await auctionResponse.Content.ReadFromJsonAsync<Auction>();
                }

                // Get desserts
                var dessertsResponse = await client.GetAsync("api/desserts");
                if (dessertsResponse.IsSuccessStatusCode)
                {
                    var desserts = await dessertsResponse.Content.ReadFromJsonAsync<List<Dessert>>();
                    if (desserts != null)
                    {
                        Desserts = desserts;
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching auction data");
                return RedirectToPage("/Error");
            }

            return Page();
        }
    }
}
