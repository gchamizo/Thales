using Beca.Thales.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Beca.Thales.Models
{
    public class ThalesDbContext : DbContext
    {
        public ThalesDbContext(DbContextOptions<ThalesDbContext> options) : base(options)
        {

        }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
    }
}