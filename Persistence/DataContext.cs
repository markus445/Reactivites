using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence
{
    //DbContext represents a session with the database.
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {            
        }

        //Gets values from Domain.
        public DbSet<Value> Values {get; set;}
        public DbSet<Activity> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>().HasData(
                    new Value {Id = 1, Name = "Values101"},
                    new Value {Id = 2, Name = "Values102"},
                    new Value {Id = 3, Name = "Values103"}
                );
        }
    }
}
