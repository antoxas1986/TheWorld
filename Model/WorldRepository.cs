using Microsoft.Data.Entity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TheWorld.Model
{
    public class WorldRepository : IWorldRepository

    {
        private IWorldContext _context;
        private ILogger<WorldRepository> _logger;

        public WorldRepository(IWorldContext context, ILogger<WorldRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
        public IEnumerable<Trip> GetAllTrips()
        {
            try {
                return _context.Trips.OrderBy(t => t.Name).ToList();
            }
            catch (Exception e)
            {
                _logger.LogError("Bla bla bla", e);
                return null;
            }
        }
        public IEnumerable<Trip> GetAllTripsWithStops()
        {
            try
            {
                return _context.Trips.Include(t => t.Stops).OrderBy(t => t.Name).ToList();
            }
            catch (Exception e)
            {
                _logger.LogError("Bla bla bla", e);
                return null;
            }
        }
    }
}
