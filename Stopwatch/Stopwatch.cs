using System;

namespace Stopwatch
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isStopwatchRunning;

        public void Start()
        {
            if (_isStopwatchRunning)
                throw new InvalidOperationException("Stopwatch is running... Without stop you can not start again!");
            _startTime = DateTime.Now;
            _isStopwatchRunning = true;
        }

        public void Stop()
        {
            if (!_isStopwatchRunning)
                throw new InvalidOperationException("Kindly start stopwatch first!☺. StopWatch is not running.");
            _stopTime = DateTime.Now;
            _isStopwatchRunning = false;
        }

        public TimeSpan ResulTimeSpan()
        {
            return _stopTime - _startTime;
        }

    }
}