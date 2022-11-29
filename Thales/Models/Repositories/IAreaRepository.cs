using Beca.Thales.Models.Entities;

namespace Beca.Thales.Models.Repositories
{
    public interface IAreaRepository
    {
        IEnumerable<Area> AllAreas { get; }
    }
}
