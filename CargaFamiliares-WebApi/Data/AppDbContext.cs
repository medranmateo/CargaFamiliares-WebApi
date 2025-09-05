using CargaFamiliares_WebApi.Domain.DTO;
using CargaFamiliares_WebApi.Domain.Entities;
using CargaFamiliares_WebApi.Domain.Entities.Tipos;
using Microsoft.EntityFrameworkCore;

namespace CargaFamiliares_WebApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {

        }

        public DbSet<BuscoFamiliar> BuscoFamiliar { get; set; }
        public DbSet<ActualizarPersona> ActualizarPersonas { get; set; }
        public DbSet<InsertFamiliar> InsertFamiliares { get; set; }
        public DbSet<InsertPersona> InsertPersonas { get; set; }
        
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Parentesco> Parentescos { get; set; }
        public DbSet<Escolaridad> Escolaridades { get; set; }
        public DbSet<Ocupacion> Ocupaciones { get; set; }
        public DbSet<EstadoCivil> EstadoCivil {  get; set; }
       
        public DbSet<PersonaIdDto> PersonaIds { get; set; }
        public DbSet<PersonaDTO> PersonaDTO { get; set; }
        public DbSet<FamiliarDTO> FamiliarDTO { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BuscoFamiliar>().HasNoKey();
            modelBuilder.Entity<ActualizarPersona>().HasNoKey();
            modelBuilder.Entity<InsertFamiliar>().HasNoKey();
            modelBuilder.Entity<InsertPersona>().HasNoKey();

            modelBuilder.Entity<Documento>().HasNoKey();
            modelBuilder.Entity<Parentesco>().HasNoKey();
            modelBuilder.Entity<Escolaridad>().HasNoKey();
            modelBuilder.Entity<Ocupacion>().HasNoKey();
            modelBuilder.Entity<EstadoCivil>().HasNoKey();

            modelBuilder.Entity<PersonaIdDto>().HasNoKey();
            modelBuilder.Entity<FamiliarDTO>().HasNoKey();

        }
    }
}
