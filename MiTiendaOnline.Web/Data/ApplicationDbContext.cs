using Microsoft.EntityFrameworkCore;
using MiTiendaOnline.Web.Models;

namespace MiTiendaOnline.Web.Data
{
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>()
                .HasIndex(t=>t.Name)
                .IsUnique();
        }

    }
}
