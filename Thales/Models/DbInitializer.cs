using Beca.Thales.Models.Entities;

namespace Beca.Thales.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            ThalesDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ThalesDbContext>();

            if (!context.Areas.Any())
            {
                context.Areas.AddRange(Areas.Select(c => c.Value));
            }

            if (!context.Actividades.Any())
            {
                context.AddRange
                (
                new Actividad { Name = "Buscando conexiones", Price = 15, Description = "Teoría de grafos para los más pequeños.", Area = Areas["Geometría y topología"], ImageUrl = "https://www.inesem.es/revistadigital/informatica-y-tics/files/2017/03/Sin-t%c3%adtulo-1.png", EdadRecomendada = "6-9 años", MasPopular = true },
                new Actividad { Name = "Descifrando Enigma", Price = 20, Description = "Sé como Alan Turing y aprende a descifrar la máquina Enigma para detener la Segunda Guerra Mundial, utilizando la criptografía. ", Area = Areas["Lógica y computación"], ImageUrl = "https://1.bp.blogspot.com/--XGJ5lXGeNc/XSZsjGbwOJI/AAAAAAAABMg/PUhIFe9PTls7EixF4IAmrk8jN_1OBRm2wCLcBGAs/s1600/descifrando-enigma-3.jpg", EdadRecomendada = "13-16 años", MasPopular = true },
                new Actividad { Name = "Juega a los barquitos en 3 dimensiones", Price = 10, Description = "Aprende a diferenciar plano y espacio y a trabajar con coordenadas, y juega a Hundir la flota en una dimensión más.", Area = Areas["Álgebra"], ImageUrl = "https://aga.frba.utn.edu.ar/wp-content/uploads/2016/08/081316_0002_PruebaMathT2.png", EdadRecomendada = "10-12 años", MasPopular = false },
                new Actividad { Name = "¿Taza o donut?", Price = 15, Description = "¿Qué significa que dos objetos son topológicamente iguales? ¿Es lo mismo una taza que un donut? Si quieres descubrirlo, ¡esta es tu actividad!", Area = Areas["Geometría y topología"], ImageUrl = "https://markdean.info/assets/img/coffee.png", EdadRecomendada = "10-12 años", MasPopular = false }

                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Area>? areas;

        public static Dictionary<string, Area> Areas
        {
            get
            {
                if (areas == null)
                {
                    var genresList = new Area[]
                    {
                        new Area{AreaName = "Álgebra"},
                        new Area{AreaName = "Geometría y topología"},
                        new Area{AreaName = "Lógica y computación"}

                    };

                    areas = new Dictionary<string, Area>();

                    foreach (Area genre in genresList)
                    {
                        areas.Add(genre.AreaName, genre);
                    }
                }

                return areas;
            }

        }
    }
}
