using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.Repositories.Config;

namespace WebApi.Repositories
{
    public class RepositoryContext:DbContext
    {
        public RepositoryContext(DbContextOptions optionsBuilder):base(optionsBuilder)
        {
            
        }


        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig());
        }
    }
}
