
using Api_Blazor_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Blazor_Project.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

          public DbSet<Post> posts { get; set; }


    }
}
