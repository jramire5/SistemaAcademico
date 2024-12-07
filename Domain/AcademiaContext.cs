using Domain.EfConfigs;
using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain;


internal class AcademiaContext : DbContext
{
    // String connectionString = "server=localhost;port=3306;user=root;password=root2;database=academia;";
    internal DbSet<Persona> personas { get; set; }
    internal DbSet<Usuario> usuarios { get; set; }
    internal DbSet<Materia> materia { get; set; }
    public DbSet<Curso> cursos { get; set; }
    public DbSet<Comision> comisiones { get; set; }
    public DbSet<Plan> planes { get; set; }
    public DbSet<AlumnoInscripcion> alumnosinscripciones { get; set; }
    public DbSet<Especialidad> especialidades { get; set; }
    internal DbSet<Modulo> modulos { get; set; }
    internal DbSet<ModuloUsuario> modulousuarios { get; set; }
    public DbSet<DocenteCurso> docentecurso { get; set; }
    public DbSet<TipoPersona> tipopersona { get; set; }
    public DbSet<Condicion> condicion { get; set; }
    public DbSet<Cargo> cargo { get; set; }
    public DbSet<Nota> nota { get; set; }
    

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
