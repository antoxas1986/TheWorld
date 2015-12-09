using System;
using System.Collections.Generic;
using System.Linq;

namespace TheWorld.Model
{
    public class WorldContextSeedData
    {
        private IWorldContext _context;

        public WorldContextSeedData(IWorldContext context)
        {
            _context = context;
        }
        public void EnsureSeedData()
        {
            if (!_context.Trips.Any())
            {
                
                var usTrip = new Trip()
                {
                    Name = "US Trip",
                    Created = DateTime.UtcNow,
                    UserName = "",
                    Stops = new List<Stop>()
                    {
                        new Stop() {  Name = "Atlanta, GA", Arrival = new DateTime(2014, 6, 4), Lat = 33.748995, Long = -84.387982, Order = 0 },
            new Stop() {  Name = "New York, NY", Arrival = new DateTime(2014, 6, 9), Lat = 40.712784, Long = -74.005941, Order = 1 },
            new Stop() {  Name = "Boston, MA", Arrival = new DateTime(2014, 7, 1), Lat = 42.360082, Long = -71.058880, Order = 2 },
            new Stop() {  Name = "Chicago, IL", Arrival = new DateTime(2014, 7, 10), Lat = 41.878114, Long = -87.629798, Order = 3 },
            new Stop() {  Name = "Seattle, WA", Arrival = new DateTime(2014, 8, 13), Lat = 47.606209, Long = -122.332071, Order = 4 },
            new Stop() {  Name = "Atlanta, GA", Arrival = new DateTime(2014, 8, 23), Lat = 33.748995, Long = -84.387982, Order = 5 },
                    }
                };
                _context.Trips.Add(usTrip);
                _context.Stops.AddRange(usTrip.Stops);
                var worldTrip = new Trip()
                {
                    Name = "World Trip",
                    Created = DateTime.UtcNow,
                    UserName = "",
                    Stops = new List<Stop>()
          {
            new Stop() { Order = 0, Lat =  33.748995, Long =  -84.387982, Name = "Atlanta, Georgia", Arrival = DateTime.Parse("Jun 3, 2014") },
            new Stop() { Order = 1, Lat =  48.856614, Long =  2.352222, Name = "Paris, France", Arrival = DateTime.Parse("Jun 4, 2014") },
            new Stop() { Order = 2, Lat =  50.850000, Long =  4.350000, Name = "Brussels, Belgium", Arrival = DateTime.Parse("Jun 25, 2014") },
            new Stop() { Order = 3, Lat =  51.209348, Long =  3.224700, Name = "Bruges, Belgium", Arrival = DateTime.Parse("Jun 28, 2014") },
            new Stop() { Order = 4, Lat =  48.856614, Long =  2.352222, Name = "Paris, France", Arrival = DateTime.Parse("Jun 30, 2014") },
            new Stop() { Order = 5, Lat =  51.508515, Long =  -0.125487, Name = "London, UK", Arrival = DateTime.Parse("Jul 8, 2014") },
            new Stop() { Order = 6, Lat =  51.454513, Long =  -2.587910, Name = "Bristol, UK", Arrival = DateTime.Parse("Jul 24, 2014") },
            new Stop() { Order = 7, Lat =  52.078000, Long =  -2.783000, Name = "Stretton Sugwas, UK", Arrival = DateTime.Parse("Jul 29, 2014") },
            new Stop() { Order = 8, Lat =  51.864211, Long =  -2.238034, Name = "Gloucestershire, UK", Arrival = DateTime.Parse("Jul 30, 2014") },
            new Stop() { Order = 9, Lat =  52.954783, Long =  -1.158109, Name = "Nottingham, UK", Arrival = DateTime.Parse("Jul 31, 2014") },
            new Stop() { Order = 10, Lat =  51.508515, Long =  -0.125487, Name = "London, UK", Arrival = DateTime.Parse("Aug 1, 2014") },
            new Stop() { Order = 11, Lat =  55.953252, Long =  -3.188267, Name = "Edinburgh, UK", Arrival = DateTime.Parse("Aug 5, 2014") },
            new Stop() { Order = 12, Lat =  55.864237, Long =  -4.251806, Name = "Glasgow, UK", Arrival = DateTime.Parse("Aug 6, 2014") },
            new Stop() { Order = 13, Lat =  57.149717, Long =  -2.094278, Name = "Aberdeen, UK", Arrival = DateTime.Parse("Aug 7, 2014") },
            new Stop() { Order = 14, Lat =  55.953252, Long =  -3.188267, Name = "Edinburgh, UK", Arrival = DateTime.Parse("Aug 8, 2014") },
            new Stop() { Order = 15, Lat =  51.508515, Long =  -0.125487, Name = "London, UK", Arrival = DateTime.Parse("Aug 10, 2014") },
            new Stop() { Order = 16, Lat =  52.370216, Long =  4.895168, Name = "Amsterdam, Netherlands", Arrival = DateTime.Parse("Aug 14, 2014") },
            new Stop() { Order = 17, Lat =  48.583148, Long =  7.747882, Name = "Strasbourg, France", Arrival = DateTime.Parse("Aug 17, 2014") },
            new Stop() { Order = 18, Lat =  46.519962, Long =  6.633597, Name = "Lausanne, Switzerland", Arrival = DateTime.Parse("Aug 19, 2014") },
            new Stop() { Order = 19, Lat =  46.021073, Long =  7.747937, Name = "Zermatt, Switzerland", Arrival = DateTime.Parse("Aug 27, 2014") },
            new Stop() { Order = 20, Lat =  46.519962, Long =  6.633597, Name = "Lausanne, Switzerland", Arrival = DateTime.Parse("Aug 29, 2014") },
            new Stop() { Order = 21, Lat =  53.349805, Long =  -6.260310, Name = "Dublin, Ireland", Arrival = DateTime.Parse("Sep 2, 2014") },
            new Stop() { Order = 22, Lat =  54.597285, Long =  -5.930120, Name = "Belfast, Northern Ireland", Arrival = DateTime.Parse("Sep 7, 2014") },
            new Stop() { Order = 23, Lat =  53.349805, Long =  -6.260310, Name = "Dublin, Ireland", Arrival = DateTime.Parse("Sep 9, 2014") },
            new Stop() { Order = 24, Lat =  47.368650, Long =  8.539183, Name = "Zurich, Switzerland", Arrival = DateTime.Parse("Sep 16, 2014") },
            new Stop() { Order = 25, Lat =  48.135125, Long =  11.581981, Name = "Munich, Germany", Arrival = DateTime.Parse("Sep 19, 2014") },
            new Stop() { Order = 26, Lat =  50.075538, Long =  14.437800, Name = "Prague, Czech Republic", Arrival = DateTime.Parse("Sep 21, 2014") },
            new Stop() { Order = 27, Lat =  51.050409, Long =  13.737262, Name = "Dresden, Germany", Arrival = DateTime.Parse("Oct 1, 2014") },
            new Stop() { Order = 28, Lat =  50.075538, Long =  14.437800, Name = "Prague, Czech Republic", Arrival = DateTime.Parse("Oct 4, 2014") },
            new Stop() { Order = 29, Lat =  42.650661, Long =  18.094424, Name = "Dubrovnik, Croatia", Arrival = DateTime.Parse("Oct 10, 2014") },
            new Stop() { Order = 30, Lat =  42.697708, Long =  23.321868, Name = "Sofia, Bulgaria", Arrival = DateTime.Parse("Oct 16, 2014") },
            new Stop() { Order = 31, Lat =  45.658928, Long =  25.539608, Name = "Brosov, Romania", Arrival = DateTime.Parse("Oct 20, 2014") },
            new Stop() { Order = 32, Lat =  41.005270, Long =  28.976960, Name = "Istanbul, Turkey", Arrival = DateTime.Parse("Nov 1, 2014") },
            new Stop() { Order = 33, Lat =  45.815011, Long =  15.981919, Name = "Zagreb, Croatia", Arrival = DateTime.Parse("Nov 11, 2014") },
            new Stop() { Order = 34, Lat =  41.005270, Long =  28.976960, Name = "Istanbul, Turkey", Arrival = DateTime.Parse("Nov 15, 2014") },
            new Stop() { Order = 35, Lat =  50.850000, Long =  4.350000, Name = "Brussels, Belgium", Arrival = DateTime.Parse("Nov 25, 2014") },
            new Stop() { Order = 36, Lat =  50.937531, Long =  6.960279, Name = "Cologne, Germany", Arrival = DateTime.Parse("Nov 30, 2014") },
            new Stop() { Order = 37, Lat =  48.208174, Long =  16.373819, Name = "Vienna, Austria", Arrival = DateTime.Parse("Dec 4, 2014") },
            new Stop() { Order = 38, Lat =  47.497912, Long =  19.040235, Name = "Budapest, Hungary", Arrival = DateTime.Parse("Dec 28,2014") },
            new Stop() { Order = 39, Lat =  37.983716, Long =  23.729310, Name = "Athens, Greece", Arrival = DateTime.Parse("Jan 2, 2015") },
            new Stop() { Order = 40, Lat =  -25.746111, Long =  28.188056, Name = "Pretoria, South Africa", Arrival = DateTime.Parse("Jan 19, 2015") },
            new Stop() { Order = 41, Lat =  43.771033, Long =  11.248001, Name = "Florence, Italy", Arrival = DateTime.Parse("Feb 1, 2015") },
            new Stop() { Order = 42, Lat =  45.440847, Long =  12.315515, Name = "Venice, Italy", Arrival = DateTime.Parse("Feb 9, 2015") },
            new Stop() { Order = 43, Lat =  43.771033, Long =  11.248001, Name = "Florence, Italy", Arrival = DateTime.Parse("Feb 13, 2015") },
            new Stop() { Order = 44, Lat =  41.872389, Long =  12.480180, Name = "Rome, Italy", Arrival = DateTime.Parse("Feb 17, 2015") },
            new Stop() { Order = 45, Lat =  28.632244, Long =  77.220724, Name = "New Delhi, India", Arrival = DateTime.Parse("Mar 4, 2015") },
            new Stop() { Order = 46, Lat =  27.700000, Long =  85.333333, Name = "Kathmandu, Nepal", Arrival = DateTime.Parse("Mar 10, 2015") },
            new Stop() { Order = 47, Lat =  28.632244, Long =  77.220724, Name = "New Delhi, India", Arrival = DateTime.Parse("Mar 11, 2015") },
            new Stop() { Order = 48, Lat =  22.1667, Long =  113.5500, Name = "Macau", Arrival = DateTime.Parse("Mar 21, 2015") },
            new Stop() { Order = 49, Lat =  22.396428, Long =  114.109497, Name = "Hong Kong", Arrival = DateTime.Parse("Mar 24, 2015") },
            new Stop() { Order = 50, Lat =  39.904030, Long =  116.407526, Name = "Beijing, China", Arrival = DateTime.Parse("Apr 19, 2015") },
            new Stop() { Order = 51, Lat =  22.396428, Long =  114.109497, Name = "Hong Kong", Arrival = DateTime.Parse("Apr 24, 2015") },
            new Stop() { Order = 52, Lat =  1.352083, Long =  103.819836, Name = "Singapore", Arrival = DateTime.Parse("Apr 30, 2015") },
            new Stop() { Order = 53, Lat =  3.139003, Long =  101.686855, Name = "Kuala Lumpor, Malaysia", Arrival = DateTime.Parse("May 7, 2015") },
            new Stop() { Order = 54, Lat =  13.727896, Long =  100.524123, Name = "Bangkok, Thailand", Arrival = DateTime.Parse("May 24, 2015") },
            new Stop() { Order = 55, Lat =  33.748995, Long =  -84.387982, Name = "Atlanta, Georgia", Arrival = DateTime.Parse("Jun 17, 2015") },
          }
                };
                _context.Trips.Add(worldTrip);
                _context.Stops.AddRange(worldTrip.Stops);

                _context.SaveChanges();

            }
        }
    }
}
