using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) : base (options){}
        
        //we need to tell EntityFramwork about our model(s). In that case we tell that we have Value objects
        public DbSet<Value> Values {get; set;}
    }
}