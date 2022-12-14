using Microsoft.EntityFrameworkCore;
using PetPal_Model.Models;

namespace PetPal_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Animal> Animals { get; set; }
    }
}
