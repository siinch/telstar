using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telstar.Models;
using Telstar.BusinessLogic;
using System.Xml.Linq;

namespace Tests
{
    [TestFixture]
    internal class RouteFindingTests
    {
        private readonly RouteFindingAlgorithm routeFinder = new RouteFindingAlgorithm();
        [TestCase(1, "Timbuktu", 26, "Cape St. Marie")]
        [TestCase(1, "Timbuktu", 1, "Timbuktu")]
        [TestCase(323, "Timbddd", 26, "Kap St. Marie")]
        public void TestInvalidRouteFinding(int fromCityId, string fromCityName, int toCityId, string toCityName)
        {
            var fromCity = new City
            {
                Id = fromCityId,
                Name = fromCityName
            };
            var toCity = new City
            {
                Id = toCityId,
                Name = toCityName
            };

            var route = routeFinder.CalculateRoute(fromCity, toCity);

            Assert.IsNull(route);
        }
        

        [TestCase(1, "Timbuktu", 19, "Dragon Mountain")]
        [TestCase(4, "Cape Verde", 24, "Kap Guardafui")]
        [TestCase(28, "Capetown", 30, "Tangier")]
        [TestCase(25, "Tamatave", 26, "Cape St. Marie")]

        public void TestValidRouteFinding(int fromCityId, string fromCityName, int toCityId, string toCityName)
        {
            var fromCity = new City
            {
                Id = fromCityId,
                Name = fromCityName
            };
            var toCity = new City
            {
                Id = toCityId,
                Name = toCityName
            };

            var route = routeFinder.CalculateRoute(fromCity, toCity);

            Assert.IsNotNull(route.connections);
            Assert.IsNotEmpty(route.connections);
        }
    }
}
