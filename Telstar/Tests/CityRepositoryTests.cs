using NUnit;
using NUnit.Framework;
using Telstar.Models;
using Telstar.Repository;

namespace Telstar.Tests
{
    [TestFixture]
    public class CityRepositoryTests
    {
        private readonly CityRepository cityRepository = new CityRepository();
        [Test]
        public void TestGetCityById()
        {
            var expectedCity = new City
            {
                Id = 1,
                Name = "Timbuktu"
            };

            var city = cityRepository.GetCityById(1);

            Assert.AreEqual(expectedCity.Id, city.Id);
            Assert.AreEqual(expectedCity.Name, city.Name);
        }
    }
}
