let connection = new signalR.HubConnectionBuilder()
    .withUrl("https://localhost:7241/auctionHub", {
        skipNegotiation: true,
        transport: signalR.HttpTransportType.WebSockets
    })
    .withAutomaticReconnect()
    .build();