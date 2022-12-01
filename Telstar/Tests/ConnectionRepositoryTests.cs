using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telstar.Models;
using Telstar.Repository;

namespace Tests
{
    [TestFixture]
    internal class ConnectionRepositoryTests
    {
        private readonly ConnectionRepository connectionRepository = new ConnectionRepository();
        [Test]
        public void TestGetInternalConnections ()
        {
            var expectedFromCityId = 0;
            var expectedToCityIdA = 3;
            var expectedToCityIdB = 15;
            var expectedToCityIdC = 30;
            var expectedDistanceA = 5;
            var expectedDistanceB = 8;
            var expectedDistanceC = 5;

            var internalConnections = connectionRepository.GetInternalConnections();

            Assert.NotNull(internalConnections.Find(x => x.FromCity.Id == expectedFromCityId && x.ToCity.Id == expectedToCityIdA && x.Distance == expectedDistanceA));
            Assert.NotNull(internalConnections.Find(x => x.FromCity.Id == expectedFromCityId && x.ToCity.Id == expectedToCityIdB && x.Distance == expectedDistanceB));
            Assert.NotNull(internalConnections.Find(x => x.FromCity.Id == expectedFromCityId && x.ToCity.Id == expectedToCityIdC && x.Distance == expectedDistanceC));
        }
    }
}
