using System.Diagnostics;

namespace SortManagerController;

public class SortTimer
{
    private Stopwatch _stopwatch;

    public double TimeInMS { get => _stopwatch.Elapsed.TotalMilliseconds; }

    public SortTimer()
    {
        _stopwatch = new Stopwatch();
    }

    public T MeasureElapsedTime<T>(Func<T> func)
    {
        _stopwatch.Reset();
        _stopwatch.Start();
        var result = func.Invoke();
        _stopwatch.Stop();
        return result;
    }
}