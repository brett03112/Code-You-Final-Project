var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Code_You_Auction_App>("code-you-auction-app");

builder.Build().Run();
