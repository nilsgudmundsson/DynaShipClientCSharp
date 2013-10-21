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
            return new Coordinate
                       {
                           X = 2,
                           Y = 2
                       };
        }
    }
}
