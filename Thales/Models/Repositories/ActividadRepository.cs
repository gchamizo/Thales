using Beca.Thales.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.IO.Pipelines;

namespace Beca.Thales.Models.Repositories
{
    public class ActividadRepository : IActividadRepository
    {
        private readonly ThalesDbContext _thalesDbContext;

        public ActividadRepository(ThalesDbContext thalesDbContext)
        {
            _thalesDbContext = thalesDbContext;
        }

        public IEnumerable<Actividad> AllActividades
        {
            get
            {
                return _thalesDbContext.Actividades.Include(c => c.Area);
            }
        }

        public IEnumerable<Actividad> ActividadesMasPopulares
        {
            get
            {
                return _thalesDbContext.Actividades.Include(c => c.Area).Where(p => p.MasPopular);
            }
        }

        public Actividad? GetActividadById(int actividadId)
        {
            return _thalesDbContext.Actividades.FirstOrDefault(p => p.ActividadId == actividadId);
        }

        public IEnumerable<Actividad> SearchActividades(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }


}


