using Microsoft.EntityFrameworkCore;

namespace WebApiKalum
{
    public class KalumDbContex : DbContex
    {
        public DbSet<CarreraTecnica> CarreraTecnica {get; set;}
        public KalumDbContex(DbContexOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarreraTecnica>().Totable("CarreraTecnica").HasKey(ct => new {ct.CarreraId});
        }
    }
}