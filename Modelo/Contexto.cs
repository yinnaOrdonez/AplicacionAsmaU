using Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto : DbContext
    {
        public Contexto() : base()
        {

        }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Genero> Genero { get; set; }
        public DbSet<TipoDocumento> TiposDocumentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ocupacion> Ocupacion { get; set; }
        public DbSet<Regimen> Regimen { get; set; }
        public DbSet<NivelEscolaridad> NivelEscolaridad { get; set; }
        public DbSet<EPS> EPS { get; set; }
        public DbSet<EstadoCivil> EstadoCivil { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["AplicacionAsma"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TipoDocumento>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.TipoDocumento)
                .HasForeignKey(e => e.IdTipoDocumento);

            builder.Entity<Genero>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.Genero)
                .HasForeignKey(e => e.IdGenero);

            builder.Entity<Ciudad>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.Ciudad)
                .HasForeignKey(e => e.IdCiudad);

            builder.Entity<Ocupacion>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.Ocupacion)
                .HasForeignKey(e => e.IdOcupacion);

            builder.Entity<Ocupacion>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.Ocupacion)
                .HasForeignKey(e => e.IdOcupacion);

            builder.Entity<EstadoCivil>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.EstadoCivil)
                .HasForeignKey(e => e.IdEstadoCivil);

            builder.Entity<NivelEscolaridad>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.NivelEscolaridad)
                .HasForeignKey(e => e.IdNivelEscolaridad);

            builder.Entity<EPS>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.EPS)
                .HasForeignKey(e => e.IdEPS);

            builder.Entity<Regimen>()
                .HasMany(e => e.Pacientes)
                .WithOne(e => e.Regimen)
                .HasForeignKey(e => e.IdRegimen);
        }

    }
}
