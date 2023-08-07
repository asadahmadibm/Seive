using Microsoft.EntityFrameworkCore;

namespace seive2
{
    public class ShoesContext :DbContext
    {
        public ShoesContext(DbContextOptions<ShoesContext> options) : base(options)
        {
        }
   
        public DbSet<Shoe> shoes { get; set; }
    }
}
