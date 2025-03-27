using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.Context
{
    public class AppDbContext: DbContext
    {
        //Constructor test
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        //DbSet
        public DbSet<Person> Persons { get; set; }
    }
}
