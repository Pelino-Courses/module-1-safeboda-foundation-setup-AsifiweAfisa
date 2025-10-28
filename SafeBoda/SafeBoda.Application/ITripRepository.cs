using SafeBoda.Core.Models;

namespace SafeBoda.Application;

public interface ITripRepository
{
    IEnumerable<Trip> GetActiveTrips();
}
