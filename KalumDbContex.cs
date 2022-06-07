using Microsoft.EntityFrameworkCore;

namespace WebApiKalum
{
    public class KalumDbContex : DbContex
    {
        public DbSet<CarreraTecnica> CarreraTecnica {get; set;}
        public DbSet<Jornada> Aspirante{get; set;}
        public DbSet<ExamenAdmision> ExamenAdmision {get; set;}
        public DbSet<Inscripcion> Inscripcion {get; set;}
        public DbSet<Aspierante> Aspirante {get; set;}
        public DbSet<Cargo> Cargo {get; set;}
        public DbSet<CuentasPorCobrar> CuentasPorCobrar {get; set;}
        public DbSet<InversionCarreraTecnica> InversionCarreraTecnica {get; set;}
        public DbSet<InscripcionPago> InscripcionPago {get; set;}
        public DbSet<ResultadoExamenAdmision> ResultadoExamenAdmision {get; set;}

        }
        public KalumDbContex(DbContexOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarreraTecnica>().Totable("CarreraTecnica").HasKey(ct => new {ct.CarreraId});
            modelBuilder.Entity<Jornada>().Totable("Jornada").HasKey(j  => new {j.Jornada});
            modelBuilder.Entity<aspirante>().Totable("aspierante").HasKey(ct => new {a.NoExpediente});
            modelBuilder.Entity<ExamenAdmision>().Totable("ExamenAdmision").HasKey(a => new {a.NoExpediente});
            modelBuilder.Entity<Inscripcion>().Totable("Inscripcion").HasKey(i => new {i.InscripcionId});
            modelBuilder.Entity<Alumno>().Totable("Alumno").HasKey(a => new {a.Carne});
            modelBuilder.Entity<Cargo>().Totable("Cargo").HasKey( c => new {c.CargoId});
            modelBuilder.Entity<CuentasPorCobrar>("CuentasPorCobrar").HasKey(co => new {a.Carne, Anio, Correlativo});
            modelBuilder.Entity<InversionCarreraTecnica>("InversionCarreraTecnica").HasKey(in => new {in.InversidadId});
            modelBuilder.Entity<InscripcionPago>("InscripcionPago").HasKey( p => new {p.BoletaPago, NoExpediente, Anio});
            modelBuilder.Entity<ResultadoExamenAdmision>("ResultadoExamenAdmision").HasKey( r => new {a.NoExpediente, Anio});


            modelBuilder.Entity<aspirante>()
            .HasOne<CarreraTecnica>( a => a.CarreraTecnica)
            .WithMany(ct => ct.Aspirante)
            .HasForeignKey(a => a.CarreraId);
            modelBuilder.Entity<Aspirante>()
            .HasOne<Jornada>( a => a.Jornada)
            .WithMany(j => j.Aspirante)
            .HasForeignKey(a => a.Jornada);

            modelBuilder.Entity<Aspirante>()
            .HasOne<ExamenAdmision>(a => a.ExamenAdmision)
            .WithMany(ct => ct.Aspirante)
            .HasForeignKey(a => a.CarreraId);   

            modelBuilder.Entity<Inscripcion>()
            .HasOne<CarreraTecnica>( i => i.CarreraTecnica)
            .WithMany(ct => ct.Inscripciones)
            .HasForeignKey( i => i.CarreraId);

            modelBuilder.Entity<Inscripcion>
            .HasOne<Jornada>(i => i.Jornada)
            .WithMany(j => j.Inscripcion)
            .HasForeignKey(i => i.JornadaId);

            modelBuilder.Entity<Inscripcion>()
            .HasOne<Alumno>( i => i.Alumno)
            .WithMany(a => a.Inscripcion)
            .HasForeignKey(i => i.Carne);

            modelBuilder.Entity<CuentasPorCobrar>()
            .HasOne<CuentasPorCobrar>(i => i.CuentasPorCobrar)
            .WithMany(co => a.CuentasPorCobrar)
            .HasForeignKey(i => i.CuentasPorCobrar);

            modelBuilder.Entity<InversionCarreraTecnica>()
            .HasOne<InversionCarreraTecnica>(i => i.InversionCarreraTecnica)
            .WithMany( in => in.InversionCarreraTecnica)
            .HasForeignKey(i => i.InversidadId);

            modelBuilder.Entity<InscripcionPago>()
            .HasOne<InscripcionPago>(i => i.InscripcionPago)
            .WithMany(p => p.InscripcionPago)
            .HasForeignKey( i => i.Inscripcion);

            ModelBuilder.Entity<ResultadoExamenAdmision>()
            .HasOne<ResultadoExamenAdmision>(i => i.ResultadoExamenAdmision)
            .WithMany(r => r.ResultadoExamenAdmision)
            .HasForeignKey( i => i.ResultadoExamenAdmision);

        }
    }
}
