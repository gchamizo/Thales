using Beca.Thales.Models;
using Beca.Thales.Models.Entities;
using System.IO.Pipelines;

namespace Beca.Thales.ViewModels
{
    public class ActividadListViewModel
    {
        public IEnumerable<Actividad> Actividades { get; }
        public string? CurrentArea { get; }

        public ActividadListViewModel(IEnumerable<Actividad> actividades, string? currentArea)
            {
              Actividades = actividades;
              CurrentArea = currentArea;
            }
        
    }
}
