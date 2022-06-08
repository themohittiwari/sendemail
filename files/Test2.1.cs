
using RefactorQPerformanceTestFramework.Configuration;
using RefactorQPerformanceTestFramework.Controller;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace RefactorQPerformanceTestFramework
{
    [Test("DemoTest", "")]
    class DemoTest : Test
    {
        public override async Task ExecuteAsync(TestSettings settings, CancellationToken cancellationToken)
        {
            string URL = "";
            string payload = "";
            string httpMethod = "GET";
            string correlationId = new LoggingFactory().GetCorrelationId(settings);
            string status = "Failed";
            var timer = new Stopwatch();
            timer.Start();
            //var response = new RequestHandler().Get(URL);
            Thread.Sleep(200);
            //if (response != null)
            //{
            //    Console.WriteLine("Response Ok");
            //    status = "Success";
            //}
            timer.Stop();
            _ = new LoggingFactory().Log("DemoClient", "Demo", "DemoTest", 100, status,correlationId);           
            await Console.Out.WriteLineAsync("Test E2E Time is "+timer.ElapsedMilliseconds+"");
        }
        public DemoTest(TestSettings settings) : base(settings)
        {
        }
    }
}