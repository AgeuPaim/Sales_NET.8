using Microsoft.EntityFrameworkCore;

namespace Sales_NET8.Data.Entities
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options) 
        {
        }
        public DbSet<Country> Countries { get; set; }
    }
}
