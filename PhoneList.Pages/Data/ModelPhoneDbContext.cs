using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PhoneList.Pages.Data
{
    public partial class ModelPhoneDbContext : DbContext
    {
        public ModelPhoneDbContext()
            : base("name=ModelPhoneDbContext1")
        {
        }

        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<ContactoEmail> ContactoEmail { get; set; }
        public virtual DbSet<ContactoFechaImportante> ContactoFechaImportante { get; set; }
        public virtual DbSet<ContactoTelefono> ContactoTelefono { get; set; }
        public virtual DbSet<Email> Email { get; set; }
        public virtual DbSet<EtiquetaEmail> EtiquetaEmail { get; set; }
        public virtual DbSet<EtiquetaFecha> EtiquetaFecha { get; set; }
        public virtual DbSet<EtiquetaTelefono> EtiquetaTelefono { get; set; }
        public virtual DbSet<FechaImportante> FechaImportante { get; set; }
        public virtual DbSet<Telefono> Telefono { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contacto>()
                .Property(e => e.Foto)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Compania)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .HasMany(e => e.ContactoEmail)
                .WithRequired(e => e.Contacto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contacto>()
                .HasMany(e => e.ContactoFechaImportante)
                .WithRequired(e => e.Contacto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contacto>()
                .HasMany(e => e.ContactoTelefono)
                .WithRequired(e => e.Contacto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Email>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Email>()
                .HasMany(e => e.ContactoEmail)
                .WithRequired(e => e.Email)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EtiquetaEmail>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<EtiquetaEmail>()
                .HasMany(e => e.Email)
                .WithOptional(e => e.EtiquetaEmail)
                .HasForeignKey(e => e.EtiquetaId);

            modelBuilder.Entity<EtiquetaFecha>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<EtiquetaFecha>()
                .HasMany(e => e.FechaImportante)
                .WithOptional(e => e.EtiquetaFecha)
                .HasForeignKey(e => e.EtiquetaId);

            modelBuilder.Entity<EtiquetaTelefono>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<EtiquetaTelefono>()
                .HasMany(e => e.Telefono)
                .WithOptional(e => e.EtiquetaTelefono)
                .HasForeignKey(e => e.EtiquetaId);

            modelBuilder.Entity<FechaImportante>()
                .HasMany(e => e.ContactoFechaImportante)
                .WithRequired(e => e.FechaImportante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Telefono>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Telefono>()
                .HasMany(e => e.ContactoTelefono)
                .WithRequired(e => e.Telefono)
                .WillCascadeOnDelete(false);
        }
    }
}
