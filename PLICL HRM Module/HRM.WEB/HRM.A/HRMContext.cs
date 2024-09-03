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
           
        }

       public  DbSet<HRM_ACTIVITY_STAT> HRM_ACTIVITY_STATs { get; set; }
    }
}
