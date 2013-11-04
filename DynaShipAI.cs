using System;
using ConsoleApplication1.Models;

namespace ConsoleApplication1
{
    public class DynaShipAI
    {
        private readonly DynaShipBoard _board;
        public DynaShipAI(DynaShipBoard board)
        {
            _board = board;
        }

        public Coordinate Process()
        {
            var rnd = new Random();
            return new Coordinate
                       {
                           X = rnd.Next(0, _board.Size),
                           Y = rnd.Next(0, _board.Size)
                       };
        }
    }
}
