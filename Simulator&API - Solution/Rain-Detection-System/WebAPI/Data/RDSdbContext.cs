using Microsoft.EntityFrameworkCore;
using WebAPI.Model;

namespace WebAPI.Data
{
    public class RDSdbContext : DbContext
    {
        public RDSdbContext(DbContextOptions<RDSdbContext> options) : base(options)
        {

        }

        public DbSet<WeatherValues> WeatherValues { get; set; }

    }


}
