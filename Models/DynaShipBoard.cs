using System.Collections.Generic;

namespace ConsoleApplication1.Models
{
    public class DynaShipBoard
    {
        public List<Shot> Shots { get; set; }
        public List<Boat> Boats { get; set; }
    }

    public class Boat
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public bool Alive { get; set; }
    }

    public class Shot
    {
        public int X { get; set; }
        public int Y { get; set; }
        //public ShotState State { get; set; }
        public int? ShipId { get; set; }
    }

    public enum ShotState
    {
        Missed = 0
    }
}
