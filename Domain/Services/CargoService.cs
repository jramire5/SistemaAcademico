﻿using Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace Domain.Services;

public class CargoService
{   
    public async Task<Cargo?> Get(int id)
    {
        using var context = new AcademiaContext();

        return await context.Cargo.FindAsync(id);
    }

    public async Task<IEnumerable<Cargo>> GetAll()
    {
        using var context = new AcademiaContext();

        List<Cargo> lista = await context.Cargo.ToListAsync();

        return lista;

    }  
}