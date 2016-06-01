namespace AccesoDatos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class IntegracionContext : DbContext
    {
        public IntegracionContext()
            : base("name=Integracioncontext")
        {
        }

        public virtual DbSet<CONSULTA> CONSULTAS { get; set; }
        public virtual DbSet<EMPRESA> EMPRESAs { get; set; }
        public virtual DbSet<RESERVA> RESERVAS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CONSULTA>()
                .Property(e => e.TIMESTAMP_C)
                .IsFixedLength();

            modelBuilder.Entity<CONSULTA>()
                .Property(e => e.ORIGEN_C)
                .IsUnicode(false);

            modelBuilder.Entity<CONSULTA>()
                .Property(e => e.DESTINO_C)
                .IsUnicode(false);

            modelBuilder.Entity<CONSULTA>()
                .Property(e => e.CONSULTA_C)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.NOMBRE_E)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.SITO_WEB_E)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.CREATED_E)
                .IsFixedLength();

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.EMAIL_E)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.CIUDAD_E)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESA>()
                .Property(e => e.DESCRIPCION_E)
                .IsUnicode(false);

            modelBuilder.Entity<RESERVA>()
                .Property(e => e.TIMESTAMP_R)
                .IsFixedLength();

            modelBuilder.Entity<RESERVA>()
                .Property(e => e.ORIGEN_R)
                .IsUnicode(false);

            modelBuilder.Entity<RESERVA>()
                .Property(e => e.PRECIO_TOTAL_R)
                .HasPrecision(8, 2);
        }
    }
}
