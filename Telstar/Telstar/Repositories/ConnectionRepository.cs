using Telstar.Models;

namespace Telstar.Repository
{
    public class ConnectionRepository { 
    
        private readonly CityRepository cityRepository = new CityRepository();
        private List<InternalConnection> internalConnections = new List<InternalConnection>();

        public ConnectionRepository() {
            internalConnections.Add(CreateInternalConnection(0, 3, 5));
            internalConnections.Add(CreateInternalConnection(0, 15, 8));
            internalConnections.Add(CreateInternalConnection(0, 30, 5));
            internalConnections.Add(CreateInternalConnection(1, 5, 5));
            internalConnections.Add(CreateInternalConnection(1, 7, 5));
            internalConnections.Add(CreateInternalConnection(1, 6, 4));
            internalConnections.Add(CreateInternalConnection(3, 4, 8));
            internalConnections.Add(CreateInternalConnection(3, 30, 2));
            internalConnections.Add(CreateInternalConnection(0, 3, 5));
            internalConnections.Add(CreateInternalConnection(4, 5, 4));
            internalConnections.Add(CreateInternalConnection(5, 6, 5));
            internalConnections.Add(CreateInternalConnection(7, 12, 7));
            internalConnections.Add(CreateInternalConnection(7, 11, 5));
            internalConnections.Add(CreateInternalConnection(7, 15, 7));
            internalConnections.Add(CreateInternalConnection(9, 11, 3));
            internalConnections.Add(CreateInternalConnection(9, 17, 4));
            internalConnections.Add(CreateInternalConnection(9, 27, 10));
            internalConnections.Add(CreateInternalConnection(9, 18, 11));
            internalConnections.Add(CreateInternalConnection(9, 19, 11));
            internalConnections.Add(CreateInternalConnection(10, 18, 4));
            internalConnections.Add(CreateInternalConnection(10, 28, 4));
            internalConnections.Add(CreateInternalConnection(11, 12, 6));
            internalConnections.Add(CreateInternalConnection(11, 15, 6));
            internalConnections.Add(CreateInternalConnection(12, 15, 4));
            internalConnections.Add(CreateInternalConnection(13, 20, 3));
            internalConnections.Add(CreateInternalConnection(13, 14, 6));
            internalConnections.Add(CreateInternalConnection(14, 31, 4));
            internalConnections.Add(CreateInternalConnection(14, 15, 3));
            internalConnections.Add(CreateInternalConnection(15, 16, 2));
            internalConnections.Add(CreateInternalConnection(15, 22, 4));
            internalConnections.Add(CreateInternalConnection(16, 21, 2));
            internalConnections.Add(CreateInternalConnection(17, 21, 4));
            internalConnections.Add(CreateInternalConnection(18, 19, 3));
            internalConnections.Add(CreateInternalConnection(18, 27, 5));
            internalConnections.Add(CreateInternalConnection(19, 27, 5));
            internalConnections.Add(CreateInternalConnection(20, 30, 5));
            internalConnections.Add(CreateInternalConnection(21, 23, 3));
            internalConnections.Add(CreateInternalConnection(21, 27, 6));
            internalConnections.Add(CreateInternalConnection(21, 29, 5));
            internalConnections.Add(CreateInternalConnection(22, 23, 3));
            internalConnections.Add(CreateInternalConnection(23, 24, 3));
            internalConnections.Add(CreateInternalConnection(24, 29, 6));
            internalConnections.Add(CreateInternalConnection(25, 26, 4));
            internalConnections.Add(CreateInternalConnection(27, 29, 3));
        }

        public List<InternalConnection> GetInternalConnections()
        {
            return internalConnections;
        }

        private InternalConnection CreateInternalConnection (int fromCity, int toCity, int distance)
        {
            var internalConnection = new InternalConnection
            {
                Id = new Guid(),
                FromCity = cityRepository.GetCityById(fromCity),
                ToCity = cityRepository.GetCityById(toCity),
                Distance = distance
            };
            return internalConnection;
        } 
    }
}
