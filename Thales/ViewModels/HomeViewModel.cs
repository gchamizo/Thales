
using Beca.Thales.Models.Entities;

namespace Beca.Thales.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Actividad> ActividadesMasPopulares { get; }

        public HomeViewModel(IEnumerable<Actividad> maspopular)
        {
            ActividadesMasPopulares = maspopular;
        }
    }
}
