using ECommerce_Sat.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_Sat.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }
        //Mapeando mi entidad para convertirla en DBSet
        public DbSet<Country> Countries { get; set; }

        //Crear Indice para la tabla countries
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }
    }
}
