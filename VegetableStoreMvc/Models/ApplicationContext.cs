using Microsoft.EntityFrameworkCore;
using System.Data;

namespace VegetableStoreMvc.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :
        base(options)
        {
        }

        // Exponerar våra databas-modeller via properties av typen DbSet<T> 
        public DbSet<Vegetable> Vegetables { get; set; }
        public DbSet<Customer> customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }



    }
}
