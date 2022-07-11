using Microsoft.EntityFrameworkCore;

namespace ASPNet_Core_6_TicketTracker.Models
{
    public class TicketDbContext:DbContext
    {
        public TicketDbContext(DbContextOptions<TicketDbContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }

    }
}
