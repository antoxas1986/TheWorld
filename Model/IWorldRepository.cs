using System.Collections.Generic;

namespace TheWorld.Model
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
        IEnumerable<Trip> GetAllTripsWithStops();
    }
}