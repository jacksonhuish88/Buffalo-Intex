using Microsoft.EntityFrameworkCore;

namespace Buffalo_Intex.Models
{
    public class SupervisedResponseContext : DbContext
    {

        public SupervisedResponseContext(DbContextOptions<SupervisedResponseContext> options) : base(options) 
        { 
        
        }

        public DbSet<SupervisedResponse> Responses { get; set; }
    }
}
