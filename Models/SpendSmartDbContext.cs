using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace SpendSmart.Models
{
    public class SpendSmartDbContext : DbContext
    {
       public DbSet<Expense> Expenses { get; set; }

        public SpendSmartDbContext(DbContextOptions <SpendSmartDbContext> options)
           : base(options)
        {
                
        }
    }
}
