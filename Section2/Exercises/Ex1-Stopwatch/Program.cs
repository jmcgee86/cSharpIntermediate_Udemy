using System;
using System.Threading;

namespace Ex1_Stopwatch
{
    public class StopWatch
    {
    private DateTime StartTime { get;  set; }
    private DateTime StopTime { get;  set; }

    private bool started = false;

         public void Start(DateTime start)
        {
            if (!started)
            {
                StartTime = start;
                started = true;
            }
            else
            {
                throw new InvalidOperationException("Already started the stopwatch");
            }
        }
        public void Stop (DateTime stop)
        { 
            if(started)
            {
                StopTime = stop;
                started = false;
            }        
        }

        public TimeSpan getDuration()
        {
            
                var duration = StopTime - StartTime;
                return duration;
            
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            stopWatch.Start(DateTime.Now);
            
            Thread.Sleep(5000);
            
            stopWatch.Stop(DateTime.Now);

            System.Console.WriteLine(stopWatch.getDuration());

        }
    }
}
