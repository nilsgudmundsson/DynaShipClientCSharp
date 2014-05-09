using System.Collections.Generic;

namespace ConsoleApplication1.Models
{
    public class DynaShipBoard
    {
        public int Size { get; set; }
        public List<Shot> Shots { get; set; }
        public List<Ship> Ships { get; set; }
    }

    public class Ship
    {
        public int Id { get; set; }
        public int Length { get; set; }
        public bool Alive { get; set; }
    }

    public class Shot
    {
        public Coordinate Coordinates { get; set; }
        public ShotState State { get; set; }
        public int? ShipId { get; set; }
    }

    public enum ShotState
    {
        Missed = 0,
        Seaworthy,
        Capsized
    }
}
