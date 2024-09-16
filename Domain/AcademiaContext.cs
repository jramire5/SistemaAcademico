using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Domain
{
    
    internal class AcademiaContext : DbContext
    {
        String connectionString = "server=localhost;port=3306;user=root;password=root;database=academia;";
        internal DbSet<Persona> Personas { get; set; }
        internal DbSet<Usuario> Usuarios { get; set; }

        internal DbSet<Materia> Materia { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>().HasKey(p => p.id_persona);

            modelBuilder.Entity<Materia>().HasKey(p => p.IdMateria);
            modelBuilder.Entity<Materia>().Property("DescMateria").HasMaxLength(50);
        }
        internal AcademiaContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            
            //optionsBuilder.UseMySQL(connectionString);
                optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=AcademiaDb");
    }
}
