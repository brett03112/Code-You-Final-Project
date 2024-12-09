using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using RealTimeAuction.Server.Data;


namespace RealTimeAuction.Server.Hubs
{
    /*
    Class Definition: The AuctionHub class is a SignalR hub that 
    manages real-time auction functionality, specifically handling 
    bids on desserts. It has two private fields: _context for database 
    access and _logger for logging.

    Methods:

    Constructor (AuctionHub): Initializes the hub with a database context 
    and a logger.

    PlaceBid:   Places a bid on a dessert with the specified ID, updates 
    the current bid and user if the bid is higher, and notifies all connected 
    clients to update the bid.
    */

    public class AuctionHub : Hub
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<AuctionHub> _logger;

        /// <summary>
        /// Constructor for AuctionHub.
        /// </summary>
        /// <param name="context">The application database context.</param>
        /// <param name="logger">The logger for the hub.</param>
        public AuctionHub(ApplicationDbContext context, ILogger<AuctionHub> logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        /// Places a bid on a dessert.
        /// </summary>
        /// <param name="dessertId">The id of the dessert to place the bid on.</param>
        /// <param name="bidAmount">The amount of the bid.</param>
        /// <param name="userId">The id of the user placing the bid.</param>
        /// <remarks>
        /// If the bid amount is higher than the current bid on the dessert, updates the current bid and user.
        /// Sends a message to all connected clients to update the bid.
        /// </remarks>
        public async Task PlaceBid(int dessertId, decimal bidAmount, string userId)
        {
            var dessert = await _context.Desserts.FindAsync(dessertId);
            if (dessert != null && bidAmount > dessert.CurrentBid)
            {
                dessert.CurrentBid = bidAmount;
                dessert.CurrentBidUser = userId;
                dessert.NewBid = bidAmount;

                await _context.SaveChangesAsync();
                await Clients.All.SendAsync("UpdateBid", dessertId, bidAmount, userId);
            }
        }
    }
}