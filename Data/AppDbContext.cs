using Microsoft.EntityFrameworkCore;
using desafioNubank.Models;

namespace desafioNubank.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public required DbSet<Client> Clients { get; set; }
        public required DbSet<Contact> Contacts { get; set; }
    }
}
