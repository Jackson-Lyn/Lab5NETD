using Microsoft.EntityFrameworkCore;

namespace Lab5NETD.Models
{
    public class CardContext : DbContext
    {
        //Constructor

        public CardContext(DbContextOptions<CardContext> options) : base(options)
        {

        }
        public DbSet<Card> Cards { get; set; }
    }
}
