using Microsoft.EntityFrameworkCore;
using WebApiPerson.Models;

namespace WebApiPerson.Context
{
    public class AppDbContext: DbContext
    {
        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }
        //DbSet
        public DbSet<Person> Persons { get; set; }
    }
}
