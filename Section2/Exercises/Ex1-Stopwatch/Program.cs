using System;
using System.Threading;

namespace Ex1_Stopwatch
{
    public class StopWatch
    {
    private  DateTime _startTime;
    private  DateTime _stopTime;

    private bool _started = false;

         public void Start()
        {
            if (!_started)
            {
                _startTime = DateTime.Now;
                _started = true;
            }
            else
            {
                throw new InvalidOperationException("Already started the stopwatch");
            }
        }
        public void Stop ()
        { 
            if(_started)
            {
                _stopTime = DateTime.Now;
                _started = false;
            }
            else
            {
                throw new InvalidOperationException("Haven't started the stopwatch");
            }        
        }

        public TimeSpan getDuration()
        {
                var duration = _stopTime - _startTime;
                return duration;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            stopWatch.Start();
            
            Thread.Sleep(5000);
            
            stopWatch.Stop();

            System.Console.WriteLine(stopWatch.getDuration());

        }
    }
}
