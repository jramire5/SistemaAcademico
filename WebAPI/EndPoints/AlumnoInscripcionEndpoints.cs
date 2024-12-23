﻿using Domain.Model;
using Domain.Services;

namespace WebAPI.EndPoints;

// Endpoints/AlumnoInscripcionEndpoints.cs
public static class AlumnoInscripcionEndpoints
{
    public static void MapAlumnoInscripcionEndpoints(this IEndpointRouteBuilder routes)
    {
        routes.MapPost("/alumnos-inscripciones", async (AlumnoInscripcion alumnoInscripcion, AlumnoInscripcionService alumnoInscripcionService) =>
        {
            await alumnoInscripcionService.Add(alumnoInscripcion);
            return Results.Created($"/alumnos-inscripciones/{alumnoInscripcion.id_inscripcion}", alumnoInscripcion);
        });

        routes.MapGet("/alumnos-inscripcion/{id}", async (int id, AlumnoInscripcionService alumnoInscripcionService) =>
        {
            var inscripcion = await alumnoInscripcionService.Get(id);
            return inscripcion is not null ? Results.Ok(inscripcion) : Results.NotFound();
        });
        routes.MapGet("/alumnos-inscripciones-curso/{idCurso}", async (int idCurso, AlumnoInscripcionService alumnoInscripcionService) =>
        {
            var alumnosEnCurso = await alumnoInscripcionService.GetAlumnosPorCurso(idCurso);
            return alumnosEnCurso is not null ? Results.Ok(alumnosEnCurso) : Results.NotFound();
        });

        routes.MapGet("/alumnos-inscripciones/{idAlumno}", async (int ? idAlumno,AlumnoInscripcionService alumnoInscripcionService) =>
        {
            var inscripciones = await alumnoInscripcionService.GetAll(idAlumno);
            return Results.Ok(inscripciones);
        });

        routes.MapPut("/alumnos-inscripciones", async (AlumnoInscripcion alumnoInscripcion, AlumnoInscripcionService alumnoInscripcionService) =>
        {
            await alumnoInscripcionService.Update(alumnoInscripcion);
            return Results.NoContent();
        });

        routes.MapDelete("/alumnos-inscripciones/{id}", async (int id, AlumnoInscripcionService alumnoInscripcionService) =>
        {
            await alumnoInscripcionService.Delete(id);
            return Results.NoContent();
        });
    }
}

