using Domain.Services;
using Domain.Model;
using WebAPI.EndPoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

builder.Services.AddScoped<CursoService>();
builder.Services.AddScoped<ComisionService>();
builder.Services.AddScoped<EspecialidadService>();
builder.Services.AddScoped<AlumnoInscripcionService>();
builder.Services.AddScoped<MateriaService>();
builder.Services.AddScoped<ModuloUsuarioService>();
builder.Services.AddScoped<PlanService>();
builder.Services.AddScoped<PersonaService>();

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

//Actualmente estamos usando los objetos del Domain Model, deberiamos usar ViewModels o DTOs         

app.MapCursoEndpoints();
app.MapComisionEndpoints();
app.MapEspecialidadEndpoints();
app.MapAlumnoInscripcionEndpoints();
app.MapMateriaEndpoints();
app.MapPlanEndpoints();
app.MapPersonaEndpoints();


/* Usuarios */
app.MapGet("/usuarios/{id}", (int id) =>
{
    UsuarioService usuarioService = new UsuarioService();

    return usuarioService.Get(id);
})
.WithName("GetUsuario")
.WithOpenApi();

app.MapGet("/usuarios", () =>
{
    UsuarioService usuarioService = new UsuarioService();

    return usuarioService.GetAll();
})
.WithName("GetAllUsuarios")
.WithOpenApi();

app.MapPost("/usuarios", (Usuario usuario) =>
{
    UsuarioService usuarioService = new UsuarioService();

    usuarioService.Add(usuario);
})
.WithName("AddUsuario")
.WithOpenApi();

app.MapPut("/usuarios", (Usuario usuario) =>
{
    UsuarioService usuarioService = new UsuarioService();

    usuarioService.Update(usuario);
})
.WithName("UpdateUsuario")
.WithOpenApi();

app.MapDelete("/usuarios/{id}", (int id) =>
{
    UsuarioService usuarioService = new UsuarioService();

    usuarioService.Delete(id);
})
.WithName("DeleteUsuario")
.WithOpenApi();

//Fin Usuarios

//Modulos 

app.MapGet("/modulos/{id}", (int id) =>
{
    ModuloService moduloService = new ModuloService();

    return moduloService.Get(id);
})
.WithName("GetModulo")
.WithOpenApi();

app.MapGet("/modulos", () =>
{
    ModuloService moduloService = new ModuloService();

    return moduloService.GetAll();
})
.WithName("GetAllModulos")
.WithOpenApi();

app.MapPost("/modulos", (Modulo modulo) =>
{
    ModuloService moduloService = new ModuloService();

    moduloService.Add(modulo);
})
.WithName("AddModulo")
.WithOpenApi();

app.MapPut("/modulos", (Modulo modulo) =>
{
    ModuloService moduloService = new ModuloService();

    moduloService.Update(modulo);
})
.WithName("UpdateModulo")
.WithOpenApi();

app.MapDelete("/modulos/{id}", (int id) =>
{
    ModuloService moduloService = new ModuloService();

    moduloService.Delete(id);
})
.WithName("DeleteModulo")
.WithOpenApi();

//Fin Modulos

// Inicio ModuloUsuario

app.MapGet("/modulosusuarios", (ModuloUsuarioService moduloUsuarioService) =>
{
    return Results.Ok(moduloUsuarioService.GetAll());
})
.WithName("GetAllModuloUsuarios")
.WithOpenApi();

app.MapGet("/modulosusuarios/{id}", (int id, ModuloUsuarioService moduloUsuarioService) =>
{
    var moduloUsuario = moduloUsuarioService.Get(id);
    if (moduloUsuario == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(moduloUsuario);
})
.WithName("GetModuloUsuario")
.WithOpenApi();

app.MapPost("/modulosusuarios", (ModuloUsuario moduloUsuario, ModuloUsuarioService moduloUsuarioService) =>
{
    moduloUsuarioService.Add(moduloUsuario);
    return Results.Created($"/modulosusuarios/{moduloUsuario.IdModuloUsuario}", moduloUsuario);
})
.WithName("AddModuloUsuario")
.WithOpenApi();

app.MapPut("/modulosusuarios", (ModuloUsuario moduloUsuario, ModuloUsuarioService moduloUsuarioService) =>
{
    moduloUsuarioService.Update(moduloUsuario);
    return Results.NoContent();
})
.WithName("UpdateModuloUsuario")
.WithOpenApi();

app.MapDelete("/modulosusuarios/{id}", (int id, ModuloUsuarioService moduloUsuarioService) =>
{
    moduloUsuarioService.Delete(id);
    return Results.NoContent();
})
.WithName("DeleteModuloUsuario")
.WithOpenApi();

//Fin ModuloUsuario

app.Run();
