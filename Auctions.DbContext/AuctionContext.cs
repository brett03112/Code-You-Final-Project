using Microsoft.EntityFrameworkCore;
using Auctions.Models;

namespace Auctions.Context;

public class AuctionsContext : Microsoft.EntityFrameworkCore.DbContext
{
    /// <summary>
    /// Constructor for AuctionsContext that takes a DbContextOptions for the auction context.
    /// </summary>
    /// <param name="options">The options for the context.</param>
    public AuctionsContext(DbContextOptions<AuctionsContext> options)
        : base(options)
    {
    }

    public DbSet<Bid> Bids { get; set; }

    public DbSet<Listings> Listings { get; set; }

    public AuctionsContext()
    {
    }

        /// <summary>
        /// Configures the context to use a SQLite database.
        /// </summary>
        /// <param name="optionsBuilder">The options builder for the context.</param>
        /// <remarks>
        ///     The database is created in the <c>bin\Debug\net8.0</c> or
        ///     <c>bin\Release\net8.0</c> directory of the project.
        /// </remarks>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string database = "auction.db";
            string dir = Environment.CurrentDirectory;
            string path = string.Empty;

            if (dir.EndsWith("net8.0"))
            {
                // In the <project>\bin\<Debug|Release>\net8.0 directory.
                path = Path.Combine("..", "..", "..", "..", database);
            }
            else
            {
                // In the <project> directory.
                path = Path.Combine("..", database);
            }

            path = Path.GetFullPath(path); // Convert to absolute path.

            optionsBuilder.UseSqlite($"Data Source={path}");
        }
    }
}
