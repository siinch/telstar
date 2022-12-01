using Telstar.Models;

namespace Telstar.Repository
{
    public class CityRepository
    {
        private readonly List<City> Cities = new List<City>
        {
            new City
            {
                Id = 0,
                Name = "Sahara"
            },
            new City
            {
                Id = 1,
                Name = "Timbuktu"
            },
            new City
            {
                Id = 2,
                Name = "The Canary Islands"
            },
            new City
            {
                Id = 3,
                Name = "Marrakesh"
            },
            new City
            {
                Id = 4,
                Name = "Dakar"
            },
            new City
            {
                Id = 5,
                Name = "Sierra Leone"
            },
            new City
            {
                Id = 6,
                Name = "Guld Kysten"
            },
            new City
            {
                Id = 7,
                Name = "Slavekysten"
            },
            new City
            {
                Id = 8,
                Name = "St. Helena"
            },
            new City
            {
                Id = 9,
                Name = "Luanda"
            },
            new City
            {
                Id = 10,
                Name = "Hvalbugten"
            },
            new City
            {
                Id = 11,
                Name = "Congo"
            },
            new City
            {
                Id = 12,
                Name = "Wadai"
            },
            new City
            {
                Id = 13,
                Name = "Tripoli"
            },
            new City
            {
                Id = 14,
                Name = "Omdurman"
            },
            new City
            {
                Id = 15,
                Name = "Darfur"
            },
            new City
            {
                Id = 16,
                Name = "Bahrel Ghazal"
            },
            new City
            {
                Id = 17,
                Name = "Kabalo"
            },
            new City
            {
                Id = 18,
                Name = "Viktoria Faldene"
            },
            new City
            {
                Id = 19,
                Name = "Dragebjerget"
            },
            new City
            {
                Id = 20,
                Name = "Tunis"
            },
            new City
            {
                Id = 21,
                Name = "Viktoria Søen"
            },
            new City
            {
                Id = 22,
                Name = "Suakik"
            },
            new City
            {
                Id = 23,
                Name = "Addis Abeba"
            },
            new City
            {
                Id = 24,
                Name = "Kap Guardafui"
            },
            new City
            {
                Id = 25,
                Name = "Amatave"
            },
            new City
            {
                Id = 26,
                Name = "Kap St. Marie"
            },
            new City
            {
                Id = 27,
                Name = "Mocambique"
            },
            new City
            {
                Id = 28,
                Name = "Kapstaden"
            },
            new City
            {
                Id = 29,
                Name = "Zanzibar"
            },
            new City
            {
                Id = 30,
                Name = "Tanger"
            },
            new City
            {
                Id = 31,
                Name = "Cairo"
            }
        };

        public City GetCityById (int id)
        {
            var city = Cities.Find(x => x.Id.Equals(id));
            return city;
        }

        public City GetCityByName(String name)
        {
            var city = Cities.Find(x => x.Name.ToLower().Equals(name.ToLower()));
            return city;
        }
    }
}
