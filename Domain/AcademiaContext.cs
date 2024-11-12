using Domain.EfConfigs;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain;


internal class AcademiaContext : DbContext
{
    // String connectionString = "server=localhost;port=3306;user=root;password=root2;database=academia;";
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
    public DbSet<DocenteCurso> DocenteCurso { get; set; }
    public DbSet<TipoPersona> TipoPersona { get; set; }
    public DbSet<Condicion> Condicion { get; set; }
    public DbSet<Cargo> Cargo { get; set; }
    public DbSet<Nota> Nota { get; set; }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {      
        modelBuilder.ApplyConfiguration(new AlumnoInscripcionConfig());
        modelBuilder.ApplyConfiguration(new ComisionConfig());
        modelBuilder.ApplyConfiguration(new CursoConfig());
        modelBuilder.ApplyConfiguration(new EspecialidadConfig());
        modelBuilder.ApplyConfiguration(new MateriaConfig());
        modelBuilder.ApplyConfiguration(new ModuloConfig());
        modelBuilder.ApplyConfiguration(new ModuloUsuarioConfig());
        modelBuilder.ApplyConfiguration(new PersonaConfig());
        modelBuilder.ApplyConfiguration(new PlanConfig());
        modelBuilder.ApplyConfiguration(new UsuarioConfig());
        modelBuilder.ApplyConfiguration(new DocenteCursoConfig());
        modelBuilder.ApplyConfiguration(new TipoPersonaConfig());
        modelBuilder.ApplyConfiguration(new CondicionConfig());
        modelBuilder.ApplyConfiguration(new CargoConfig());
        modelBuilder.ApplyConfiguration(new NotaConfig());
    }
    internal AcademiaContext()
    {
        this.Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        
        optionsBuilder.UseMySQL(DbConfigService.GetDbConnectionString());
        //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=AcademiaDb");
}
