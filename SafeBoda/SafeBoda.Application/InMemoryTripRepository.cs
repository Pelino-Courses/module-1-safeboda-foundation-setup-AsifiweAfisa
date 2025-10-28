using SafeBoda.Core.Models;

namespace SafeBoda.Application;

public class InMemoryTripRepository : ITripRepository
{
    public IEnumerable<Trip> GetActiveTrips()
    {
        return new List<Trip>
        {
            new Trip(
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                new Location(0.6476, 41.5825),
                new Location(0.057406, 35.4469),
                18500m,
                DateTime.Now.AddMinutes(-20)
            ),
            new Trip(
                Guid.NewGuid(),
                Guid.NewGuid(),
                Guid.NewGuid(),
                new Location(1.476, 33.5825),
                new Location(5.57406, 76.4469),
                12000m,
                DateTime.Now.AddMinutes(-45)
            )
        };
    }
}
