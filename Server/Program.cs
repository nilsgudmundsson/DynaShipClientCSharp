using System;
using System.Threading;
using Bend.Util;

namespace ConsoleApplication1
{
    public class Program
    {
        public static int Main(String[] args)
        {
            HttpServer httpServer;
            if (args.GetLength(0) > 0)
            {
                httpServer = new DynaShipServer(Convert.ToInt16(args[0]));
            }
            else
            {
                httpServer = new DynaShipServer(8080);
            }
            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();
            return 0;
        }
    }
}
