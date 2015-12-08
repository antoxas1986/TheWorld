using System;

namespace TheWorld.Model
{
    public class Stop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Long { get; set; }
        public double Lat { get; set; }
        public DateTime Arrival { get; set; }
        public int Order { get; set; }
    }
}