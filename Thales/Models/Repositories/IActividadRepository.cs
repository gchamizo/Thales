using Beca.Thales.Models.Entities;
using System.IO.Pipelines;

namespace Beca.Thales.Models.Repositories
{
    public interface IActividadRepository
    {
        IEnumerable<Actividad> AllActividades { get; }
        IEnumerable<Actividad> ActividadesMasPopulares { get; }
        Actividad? GetActividadById(int actividadId);
        IEnumerable<Actividad> SearchActividades(string searchQuery);
    }
}
