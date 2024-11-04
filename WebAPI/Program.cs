using Domain.Services;
using Domain.Model;
using WebAPI.EndPoints;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });
builder.Services.AddCors();

/*Servicios para DI*/
builder.Services.AddScoped<CursoService>();
builder.Services.AddScoped<ComisionService>();
builder.Services.AddScoped<EspecialidadService>();
builder.Services.AddScoped<AlumnoInscripcionService>();
builder.Services.AddScoped<MateriaService>();
builder.Services.AddScoped<ModuloUsuarioService>();
builder.Services.AddScoped<PlanService>();
builder.Services.AddScoped<PersonaService>();
builder.Services.AddScoped<UsuarioService>();
builder.Services.AddScoped<DocenteCursoService>();
builder.Services.AddScoped<TipoPersonaService>();
builder.Services.AddScoped<AutenticacionService>();
builder.Services.AddScoped<ModuloService>();
builder.Services.AddScoped<ModuloUsuarioService>();
builder.Services.AddScoped<CondicionService>();
builder.Services.AddScoped<CargoService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    //Falta configurar de manera correcta        
    app.UseHttpLogging();
}

app.UseHttpsRedirection();


app.MapCursoEndpoints();
app.MapComisionEndpoints();
app.MapEspecialidadEndpoints();
app.MapAlumnoInscripcionEndpoints();
app.MapMateriaEndpoints();
app.MapPlanEndpoints();
app.MapPersonaEndpoints();
app.MapUsuarioEndpoints();
app.MapDocenteCursoEndpoints();
app.MapTipoPersonaEndpoints();
app.MapAutenticacionEndpoints();
app.MapModuloEndpoints();
app.MapModuloUsuarioEndpoints();
app.MapCondicionEndpoints();
app.MapCargoEndpoints();

app.UseCors(x => x.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader()
.SetIsOriginAllowed((host) => true)
.WithExposedHeaders("Content-Dispositon")
);

app.Run();
