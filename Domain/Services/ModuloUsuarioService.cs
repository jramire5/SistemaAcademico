using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ModuloUsuarioService
    {
        private readonly AcademiaContext _context;



        // Obtener todos los registros de ModuloUsuario
        public IEnumerable<ModuloUsuario> GetAll()
        {
            return _context.Set<ModuloUsuario>()
                .Include(mu => mu.Modulo)  // Incluir la relación con Modulo
                .Include(mu => mu.Usuario) // Incluir la relación con Usuario
                .ToList();
        }

        // Obtener un ModuloUsuario por ID
        public ModuloUsuario Get(int id)
        {
            return _context.Set<ModuloUsuario>()
                .Include(mu => mu.Modulo)
                .Include(mu => mu.Usuario)
                .FirstOrDefault(mu => mu.IdModuloUsuario == id);
        }

        // Agregar un nuevo ModuloUsuario
        public void Add(ModuloUsuario moduloUsuario)
        {
            _context.Set<ModuloUsuario>().Add(moduloUsuario);
            _context.SaveChanges();
        }

        // Actualizar un ModuloUsuario existente
        public void Update(ModuloUsuario moduloUsuario)
        {
            _context.Set<ModuloUsuario>().Update(moduloUsuario);
            _context.SaveChanges();
        }

        // Eliminar un ModuloUsuario por ID
        public void Delete(int id)
        {
            var moduloUsuario = _context.Set<ModuloUsuario>().Find(id);
            if (moduloUsuario != null)
            {
                _context.Set<ModuloUsuario>().Remove(moduloUsuario);
                _context.SaveChanges();
            }
        }
    }

}
