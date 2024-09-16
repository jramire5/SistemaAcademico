using Domain.Model;

namespace Domain.Services;

public class MateriaService
{
    public void Add(Materia materia)
    {
        using var context = new AcademiaContext();

        context.Materia.Add(materia);
        context.SaveChanges();
    }

    public void Delete(int id)
    {
        using var context = new AcademiaContext();

        Materia? materiaToDelete = context.Materia.Find(id);

        if (materiaToDelete != null)
        {
            context.Materia.Remove(materiaToDelete);
            context.SaveChanges();
        }
    }

    public Materia? Get(int id)
    {
        using var context = new AcademiaContext();

        return context.Materia.Find(id);
    }

    public IEnumerable<Materia> GetAll()
    {
        using var context = new AcademiaContext();

        return context.Materia.ToList();
    }

    public void Update(Materia materia)
    {
        using var context = new AcademiaContext();

        Materia? materiaToUpdate = context.Materia.Find(materia.IdMateria);

        if (materiaToUpdate != null)
        {
            materiaToUpdate.IdMateria = materia.IdMateria;
            materiaToUpdate.DescMateria = materia.DescMateria;
            materiaToUpdate.HsSemanales = materia.HsSemanales;
            materiaToUpdate.HsTotales = materia.HsTotales;
            materiaToUpdate.IdPlan = materia.IdPlan;
            context.SaveChanges();
        }
    }
}
