/* name: Jackson
 * date: 12/28/02
 * Description: Lab5 NETD
 * */
using Microsoft.EntityFrameworkCore;

namespace Lab5NETD.Models
{
    public class CardContext : DbContext
    {
        //Constructor

        public CardContext(DbContextOptions<CardContext> options) : base(options)
        {

        }
        // getters and setters
        public DbSet<Card> Cards { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
