using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.Authorization;

namespace CommunityCenter.wwwroot.js.signalr.Hubs;

public class AuctionHub : Hub
{
    public async Task UpdateBid(int dessertId, decimal newPrice, string bidderId, string bidderName)
    {
        await Clients.All.SendAsync("BidUpdated", dessertId, newPrice, bidderId, bidderName);
    }
}