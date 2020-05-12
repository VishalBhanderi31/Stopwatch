using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            bool _hasRunning;
            do
            {
                var stopwatch = new Stopwatch();
                // Check an Exception uncomment below line
                //stopwatch.Stop();

                stopwatch.Start();  

                //You can not start stopwatch in between
                //stopwatch.Stop();

                //To measure stopwatch exact time
                Thread.Sleep(1000);
                stopwatch.Stop();

                Console.WriteLine("Duration : {0}", stopwatch.ResulTimeSpan());
                Console.WriteLine("Press Enter to run again (or enter any key except @'Enter' to exit! ");
                var input = Console.ReadKey();
                _hasRunning = input.KeyChar == (char)13;


            } while (_hasRunning);
        }
    }
}
