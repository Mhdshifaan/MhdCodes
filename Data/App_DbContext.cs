using Microsoft.EntityFrameworkCore;
using Tools.Models;

namespace Tools.Data
{
    public class App_DbContext : DbContext
    {
         public App_DbContext(DbContextOptions<App_DbContext> options) : base(options) 
        { 

        }

        public DbSet<Samples> Samples { get; set; }
    }
}
