using Beca.Thales.Models.Entities;
using static Beca.Thales.Models.Repositories.AreaRepository;

namespace Beca.Thales.Models.Repositories
{
    public class AreaRepository : IAreaRepository
    {

        private readonly ThalesDbContext _thalesDbContext;

        public AreaRepository(ThalesDbContext thalesDbContext)
        {
            _thalesDbContext = thalesDbContext;
        }

        public IEnumerable<Area> AllAreas => _thalesDbContext.Areas.OrderBy(p => p.AreaName);
    }
}




