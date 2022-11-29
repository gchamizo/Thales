using System.IO.Pipelines;

namespace Beca.Thales.Models.Entities
{
    public class Area
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Actividad>? Actividades { get; set; }
    }
}




