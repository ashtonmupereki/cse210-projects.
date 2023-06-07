class Activity
{
    private DateTime _startTime;
    private DateTime _endTime;
    private int _activityTimeSeconds;
    private int _activityTimeSession;

    public void startActivity()
    {
        _startTime = DateTime.Now;
        Console.WriteLine("Activity started.");
    }

    public void endActivity()
    {
        _endTime = DateTime.Now;
        Console.WriteLine("Activity ended.");
        activityTimeSeconds = (int)(_endTime - _startTime).TotalSeconds;
        activityTimeSession++;
    }

    public int activityTimeSeconds
    {
        get { return _activityTimeSeconds; }
        set { _activityTimeSeconds = value; }
    }

    public int activityTimeSession
    {
        get { return _activityTimeSession; }
        set { _activityTimeSession = value; }
    }
}
