class BreathingActivity
{
    private int _seconds;

    public void startBreathing(int seconds)
    {
        _seconds = seconds;
        Console.WriteLine($"Starting breathing activity for {_seconds} seconds...");
        TrackTime();
    }

    private void BreathIn()
    {
        Console.WriteLine("Breathing in...");
    }

    private void BreathOut()
    {
        Console.WriteLine("Breathing out...");
    }

    private void TrackTime()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed < TimeSpan.FromSeconds(_seconds))
        {
            BreathIn();
            Thread.Sleep(2000);
            BreathOut();
            Thread.Sleep(2000);
        }

        stopwatch.Stop();
        Console.WriteLine($"Breathing activity complete! You breathed for {_seconds} seconds.");
    }
}
