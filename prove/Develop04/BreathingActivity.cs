class BreathingActivity : BaseActivity
{
    // Attributes
    private int _breathIn;
    private int _breathOut;
    private string _message = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    // Constructor
    public BreathingActivity(string activityName, int activityDuration, int breathIn, int breathOut) : base(activityName, activityDuration)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
    }

    // Method to display the "Breath In" message
    public void BreathIn()
    {
        Console.WriteLine($"Breath in for {_breathIn} seconds.");
    }

    // Method to display the "Breath Out" message
    public void BreathOut()
    {
        Console.WriteLine($"Breath out for {_breathOut} seconds.");
    }

    // Method to start the activity
    public override void Start()
    {
        Console.WriteLine(_message);
        GetReady();
        Console.WriteLine("Enter the number of seconds to breath in:");
        int breathInTime = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number of seconds to breath out:");
        int breathOutTime = Convert.ToInt32(Console.ReadLine());
        BreathIn();
        CountTime(breathInTime);
        BreathOut();
        CountTime(breathOutTime);
    }
}
