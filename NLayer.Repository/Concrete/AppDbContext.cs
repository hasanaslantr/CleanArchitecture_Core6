using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using NLayer.Core.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using static System.Formats.Asn1.AsnWriter;
using System.Security.Claims;

namespace NLayer.Repository.Concrete
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerType> CustomerTypes { get; set; }
        
    }
}
