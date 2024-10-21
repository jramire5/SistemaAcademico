using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Domain
{
    
    internal class AcademiaContext : DbContext
    {
        String connectionString = "server=localhost;port=3306;user=root;password=root2;database=academia;";
        internal DbSet<Persona> Personas { get; set; }
        internal DbSet<Usuario> Usuarios { get; set; }
        internal DbSet<Materia> Materia { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Comision> Comisiones { get; set; }
        public DbSet<Plan> Planes { get; set; }
        public DbSet<AlumnoInscripcion> AlumnosInscripciones { get; set; }
        public DbSet<Especialidad> Especialidades { get; set; }
        internal DbSet<Modulo> Modulos { get; set; }

        internal DbSet<ModuloUsuario> moduloUsuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().HasKey(p => p.id_persona);
            modelBuilder.Entity<Usuario>().HasKey(p => p.id_usuario);

            modelBuilder.Entity<Materia>().HasKey(p => p.id_materia);
            modelBuilder.Entity<Materia>().Property("desc_materia").HasMaxLength(50);
            
            modelBuilder.Entity<Modulo>().HasKey(p => p.Id_modulo);
            modelBuilder.Entity<ModuloUsuario>().HasKey(p => p.IdModuloUsuario);
        }
        internal AcademiaContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            
            optionsBuilder.UseMySQL(connectionString);
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=AcademiaDb");
    }
}
