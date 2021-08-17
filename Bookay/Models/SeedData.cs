using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace Bookay.Models
{
    public class SeedData
    {
        private BookayDbContext context;
        private ILogger<SeedData> logger;
        private readonly List<Hotel> data = new List<Hotel> {
            new Hotel {
                Name = "Capella Ubud, Bali, Indonesia",
                ShortDescription = "“Marvelous” is how one reader succinctly described the experience at this year’s top hotel",
                Description = "Another said the property has the “best personalized service. Staff is super attentive, and the Bill Bensley design is unique.” The star designer’s efforts are surrounded by small villages, shrines, and acres of green rice paddies in Ubud’s Keliki Valley — another strong point, voters said. A suspension bridge leads guests here to their tented suites, and the interiors have the aura of an old-world explorer’s hideaway — but in the most luxurious way, with teak flooring, vintage steamer trunks, and antique furnishings. Here, guests feel truly immersed in the jungle, with dense forest on all sides and the River Wos rushing below. “It’s a magical experience on the isle of gods,” as one guest said",
                NumberOfStars = 5,
                NumberOfAvailableRooms = 101
            },
            new Hotel {
                Name = "Hotel Amparo, San Miguel de Allende, Mexico",
                ShortDescription = "Dive into pleasure",
                Description = "In the heart of San Miguel de Allende, Hotel Amparo combines Spanish-colonial heirlooms and antiques with edgy contemporary art and textiles. Its location in the Zona Centro Histórico means it’s just a short walk to local sights like the Jardín Principal, the Plaza de la Soledad, and the Mercado de Artesanias.",
                NumberOfStars = 5, 
                NumberOfAvailableRooms = 49
            },
            new Hotel {
                Name = "Fogo Island Inn, Newfoundland, Canada",
                ShortDescription = "The views of the rocky coast are as dramatically beautiful as you’d imagine.",
                Description = "Set on the largest offshore island in Newfoundland and Labrador, the 29-room Fogo Island Inn was designed by Newfoundland-born architect Todd Saunders, who festooned the property with objects from the area’s fishing communities and craftspeople, handcrafted quilts, and wood-burning stoves. The views of the rocky coast — through floor-to-ceiling windows — are as dramatically beautiful as you’d imagine.",
                NumberOfStars = 5, 
                NumberOfAvailableRooms = 29
            },
            new Hotel {
                Name = "The Ritz-Carlton, Bali, Indonesia",
                ShortDescription = "A beachfront resort that combines modern tropical style and Balinese architectural elements",
                Description = "A beachfront resort that combines modern tropical style and Balinese architectural elements, the Ritz-Carlton is a sprawling, family-friendly resort known for its excellent service. With six restaurants, a spa, numerous swimming pools, and a kids’ club, readers said they often didn’t leave the decadent property.",
                NumberOfStars = 5, 
                NumberOfAvailableRooms = 42
            }
        };

        public SeedData(BookayDbContext dataContext, ILogger<SeedData> _logger)
        {
            context = dataContext;
            logger = _logger;
        }

        public void SeedDatabase()
        {
            context.Database.Migrate();
            if (context.Hotels.Count() == 0)
            {
                logger.LogInformation("Preparing to seed database");
                context.Hotels!.AddRange(data);
                context.SaveChanges();
                logger.LogInformation("Database seeded");
            }
            else
            {
                logger.LogInformation("Database not seeded");
            }
        } 
    }
}
