using Domain.Services;
using Domain.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpLogging(o => { });

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

//PERSONAS
app.MapGet("/personas/{id}", (int id) =>
{
    PersonaService personaService = new PersonaService();

    return personaService.Get(id);
})
.WithName("GetPersona")
.WithOpenApi();

app.MapGet("/personas", () =>
{
    PersonaService personaService = new PersonaService();

    return personaService.GetAll();
})
.WithName("GetAllPersonas")
.WithOpenApi();

app.MapPost("/personas", (Persona persona) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Add(persona);
})
.WithName("AddPersona")
.WithOpenApi();

app.MapPut("/personas", (Persona persona) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Update(persona);
})
.WithName("UpdatePersonas")
.WithOpenApi();

app.MapDelete("/personas/{id}", (int id) =>
{
    PersonaService personaService = new PersonaService();

    personaService.Delete(id);
})
.WithName("DeletePersona")
.WithOpenApi();

//Persona



/*Materia*/
app.MapGet("/materia/{id}", (int id) =>
{
    MateriaService materiaService = new MateriaService();

    //return materiaService.Get(id);
})
.WithName("GetMateria")
.WithOpenApi();

app.MapGet("/materias", () =>
{
    MateriaService materiaService = new MateriaService();

    return materiaService.GetAll();
})
.WithName("GetAllMaterias")
.WithOpenApi();

app.MapPost("/materias", (Materia materia) =>
{
    MateriaService materiaService = new MateriaService();

    materiaService.Add(materia);
})
.WithName("AddMateria")
.WithOpenApi();

app.MapPut("/materias", (Materia materia) =>
{
    MateriaService materiaService = new MateriaService();

    materiaService.Update(materia);
})
.WithName("UpdateMaterias")
.WithOpenApi();

app.MapDelete("/materias/{id}", (int id) =>
{
    MateriaService materiaService = new MateriaService();

    materiaService.Delete(id);
})
.WithName("DeleteMateria")
.WithOpenApi();

/*Fin Materia*/

/* Usuarios */
app.MapGet("/usuarios", () =>
{
    UsuarioService usuarioService = new UsuarioService();
    return usuarioService.GetAll();
}).WithName("GetUsuarios").WithOpenApi();

app.MapGet("/usuarios", (int id) =>
{
    UsuarioService usuarioService = new UsuarioService();
    return usuarioService.Get(id);
});

app.MapPost("/usuarios", (Usuario usuario) =>
{
    UsuarioService usuarioService = new UsuarioService();
    usuarioService.Add(usuario);
});

app.MapPut("/usuarios", (Usuario usuario) =>
{
    UsuarioService usuarioService = new UsuarioService();
    usuarioService.Update(usuario);
});

app.MapDelete("/usuarios", (int id) =>
{
    UsuarioService usuarioService = new UsuarioService();
    usuarioService.Delete(id);
});

app.Run();
