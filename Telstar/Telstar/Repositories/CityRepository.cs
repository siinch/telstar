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
                Name = "Canary Islands"
            },
            new City
            {
                Id = 3,
                Name = "Morocco"
            },
            new City
            {
                Id = 4,
                Name = "Cape Verde"
            },
            new City
            {
                Id = 5,
                Name = "Sierra Leone"
            },
            new City
            {
                Id = 6,
                Name = "Goald Coast"
            },
            new City
            {
                Id = 7,
                Name = "Slave Coast"
            },
            new City
            {
                Id = 8,
                Name = "St. Helena"
            },
            new City
            {
                Id = 9,
                Name = "Congo"
            },
            new City
            {
                Id = 10,
                Name = "Whalefish Bay"
            },
            new City
            {
                Id = 11,
                Name = "Kandjama"
            },
            new City
            {
                Id = 12,
                Name = "Ain-Galaka"
            },
            new City
            {
                Id = 13,
                Name = "Tripoli"
            },
            new City
            {
                Id = 14,
                Name = "Egypt"
            },
            new City
            {
                Id = 15,
                Name = "Dar-Fur"
            },
            new City
            {
                Id = 16,
                Name = "Bahr El Ghasal"
            },
            new City
            {
                Id = 17,
                Name = "Ocomba"
            },
            new City
            {
                Id = 18,
                Name = "Victoria Falls"
            },
            new City
            {
                Id = 19,
                Name = "Dragon Mountain"
            },
            new City
            {
                Id = 20,
                Name = "Tunis"
            },
            new City
            {
                Id = 21,
                Name = "Lake Victoria"
            },
            new City
            {
                Id = 22,
                Name = "Suakin"
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
                Name = "Tamatave"
            },
            new City
            {
                Id = 26,
                Name = "Cape St. Marie"
            },
            new City
            {
                Id = 27,
                Name = "Mozambique"
            },
            new City
            {
                Id = 28,
                Name = "Capetown"
            },
            new City
            {
                Id = 29,
                Name = "Daressalam"
            },
            new City
            {
                Id = 30,
                Name = "Tangier"
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
