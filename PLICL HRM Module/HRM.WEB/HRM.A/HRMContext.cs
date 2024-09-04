using HRM.A.Entities;
using HRM.A.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.A
{
    public class HRMContext : DbContext
    {
        public HRMContext(DbContextOptions<HRMContext> options) : base(options) 
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HRM_ACTIVITY_STAT>().HasKey("ActivityCd");

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);


            base.OnModelCreating(modelBuilder);
        }

       public  DbSet<HRM_ACTIVITY_STAT> HRM_ACTIVITY_STATs { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<Category> Categories { get; set; }
    }
}
