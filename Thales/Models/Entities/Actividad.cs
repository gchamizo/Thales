namespace Beca.Thales.Models.Entities
{
    public class Actividad
    {
        public int ActividadId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? EdadRecomendada { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public bool MasPopular { get; set; }
        public int AreaId { get; set; }
        public Area Area { get; set; } = default!;
    }
}
