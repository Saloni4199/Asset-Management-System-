using Microsoft.EntityFrameworkCore;
using AssetMS.Models;

namespace AssetMS.DataBase
{

    public class DataBaseContext : DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
                  : base(options)
        {
        }
        public DbSet<Book> BookCollection { get; set; }
        public DbSet<Hardware> HardwareCollection { get; set; }

        public DbSet<Software> SoftwareCollection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}