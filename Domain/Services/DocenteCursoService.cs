﻿using Domain.Model;
using Domain.Model.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class DocenteCursoService 
{
    public async Task Add(DocenteCurso docenteCurso)
    {
        using var context = new AcademiaContext();

        context.Add(docenteCurso);
        await context.SaveChangesAsync();
    }

    public async Task Delete(int id)
    {
        using var context = new AcademiaContext();

        DocenteCurso? docenteCursoToDelete = await context.docentecurso.FindAsync(id);

        if (docenteCursoToDelete != null)
        {
            context.docentecurso.Remove(docenteCursoToDelete);
            await context.SaveChangesAsync();
        }
    }

    public async Task<DocenteCurso?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.docentecurso.FindAsync(id);
    }
    public async Task<IEnumerable<DocenteCursoDto>> GetAllByDocente(int idDocente)
    {
        using var context = new AcademiaContext();

        List<DocenteCurso> lista = await context.docentecurso.Include(d => d.Curso).ThenInclude(d => d.Comision).Include(d => d.Curso).ThenInclude(d => d.Materia).Include(d => d.Persona).Include(d => d.Cargo).Where(dc => dc.id_docente == idDocente || idDocente==0).ToListAsync();

        List<DocenteCursoDto> listadto = new List<DocenteCursoDto>();
        foreach (var item in lista)
        {
            listadto.Add(new DocenteCursoDto()
            {
                id_dictado = item.id_dictado,
                id_curso = item.id_curso,
                desc_materia = item.Curso.Materia.desc_materia,
                desc_comision = item.Curso.Comision.desc_comision,
                anio_calendario = item.Curso.anio_calendario,
                docente = $"{item.Persona.nombre} {item.Persona.apellido}",
                desc_cargo = item.Cargo?.Descripcion ?? string.Empty
            });
        }
        return listadto;

    }
    public async Task<IEnumerable<DocenteDictadoDto>> GetAll(int? idDocente)
    {
        using var context = new AcademiaContext();

        List<DocenteCurso> lista = await context.docentecurso.Include(d=>d.Curso).ThenInclude(d => d.Comision).Include(d => d.Curso).ThenInclude(d=>d.Materia).Include(d=>d.Persona).Include(d=>d.Cargo).Where(p=> idDocente == null || idDocente ==0 || p.Persona.id_persona== idDocente).ToListAsync();

        List<DocenteDictadoDto> listadto = new List<DocenteDictadoDto>();
        foreach (var item in lista)
        {
            listadto.Add(new DocenteDictadoDto()
            {
                id_dictado = item.id_dictado,
                desc_materia = item.Curso.Materia.desc_materia,
                desc_comision = item.Curso.Comision.desc_comision,
                anio_calendario = item.Curso.anio_calendario,
                docente = $"{item.Persona.nombre} {item.Persona.apellido}",
                desc_cargo = item.Cargo?.Descripcion ?? string.Empty
            });
        }
        return listadto;

    }

    public async Task Update(DocenteCurso docenteCurso)
    {
        using var context = new AcademiaContext();
        DocenteCurso? docenteCursoToUpdate = await context.docentecurso.FindAsync(docenteCurso.id_dictado);

        if (docenteCursoToUpdate != null)
        {
            docenteCursoToUpdate.id_dictado = docenteCurso.id_dictado;
            docenteCursoToUpdate.id_curso = docenteCurso.id_curso;
            docenteCursoToUpdate.id_docente = docenteCurso.id_docente;
            docenteCursoToUpdate.id_cargo = docenteCurso.id_cargo;
        
            await context.SaveChangesAsync();
        }
    }
}
