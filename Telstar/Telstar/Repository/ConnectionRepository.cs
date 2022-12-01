using Telstar.Models;

namespace Telstar.Repository
{
    public class ConnectionRepository
    {
        private readonly List<InternalConnection> internalConnections = new List<InternalConnection>
        {
            new InternalConnection
            {
                Id = new Guid(),
                FromCity = new City {
                    Id = 30,
                    Name = "Tanger"
                },
                ToCity= new City
                {
                    Id = 
                }
            }
        };

    }
}
