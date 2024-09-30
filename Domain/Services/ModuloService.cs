using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Model;
namespace Domain.Services
{
    public class ModuloService
    {
        public void Add (Modulo modulo)
        {
            using var context = new AcademiaContext();
            context.Modulos.Add(modulo);
            context.SaveChanges();
        }
        public Modulo Get(int id)
        {
            using var context = new AcademiaContext();
            return context.Modulos.Find(id);
        }

        public IEnumerable<Modulo> GetAll()
        {
            using var context = new AcademiaContext();

            return context.Modulos.ToList();
        }

        public void Update(Modulo modulo)
        {
            using var context = new AcademiaContext();
            context.Modulos.Update(modulo);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            using var context = new AcademiaContext();
            Modulo moduloABorrar = context.Modulos.Find(id);
            if (moduloABorrar != null)
            {
                context.Modulos.Remove(moduloABorrar);
                context.SaveChanges();
            }
        }
    }
}
