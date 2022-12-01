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
        [TestCase(1, "Timbuktu", 26, "Kap St. Marie")]
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
        

        [TestCase(1, "Timbuktu", 19, "Dragebjerget")]
        [TestCase(4, "Dakar", 24, "Kap Guardafui")]
        [TestCase(28, "Kapstaden", 30, "Tanger")]
        [TestCase(25, "Amatave", 26, "Kap St. Marie")]

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

            Assert.IsNotNull(route);
            Assert.IsNotEmpty(route);
            Assert.IsTrue(route.Count < 100);
        }
    }
}
