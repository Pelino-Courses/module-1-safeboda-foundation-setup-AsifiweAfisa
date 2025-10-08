using SafeBoda.Core.Models;

public interface ITripRepository
{
    IEnumerable<Trip> GetActiveTrips();
}