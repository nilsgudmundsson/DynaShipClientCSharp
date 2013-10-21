using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using Bend.Util;
using ConsoleApplication1.Models;
using Newtonsoft.Json;

namespace ConsoleApplication1
{
    public class DynaShipServer : HttpServer
    {
        public DynaShipServer(int port)
            : base(port)
        {
        }

        public override void handleGETRequest(HttpProcessor p)
        {
            p.writeSuccess();
            p.outputStream.Write("Nooooo........!");
        }

        public override void handlePOSTRequest(HttpProcessor p, StreamReader inputData)
        {
            Console.WriteLine("POST request: {0}", p.http_url);
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            string data = inputData.ReadToEnd();
            var board = JsonConvert.DeserializeObject<DynaShipBoard>(data);
            var response = new DynaShipAI(board).Process();
            p.writeSuccess("application/json");
            p.outputStream.Write(String.Format("{{\"x\": {0}, \"y\": {1}}}", response.X, response.Y));

            stopWatch.Stop();
            Console.WriteLine("Time taken: " + stopWatch.Elapsed);
        }
    }
}
