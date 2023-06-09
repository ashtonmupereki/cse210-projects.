using System;
using System.Threading;

public class Activity
{
    // Attributes
    private string _activityName;
    private int _activityTime;
    private string _message = "Lets get started";

    // Constructors
    public Activity(string activityName, int activityTime)
    {
        _activityName = activityName;
        _activityTime = activityTime;
    }
    public void GetActivityName()
    {
        Console.WriteLine($"Welcome to the {_activityName} \n");
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public int GetActivityTime()
    {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int userSeconds = Int32.Parse(Console.ReadLine());
        _activityTime = userSeconds;
        return userSeconds;
    }
    public void SetActivityTime(int activityTime)
    {
        _activityTime = activityTime;
    }

    // Methods
    public void GetReady()
    {
        Console.Clear();
        Roller roller = new Roller();
        roller.ShowRollerReady();
    }

    public void GetDone()
    {
        Roller roller = new Roller();
        roller.ShowRollerDone();
        Console.WriteLine($"\nYou have completed another {_activityTime} seconds of the {_activityName} Activity!");
        roller.ShowRoller();
    }
     public void CountDown(int time)
    {
        Console.WriteLine();  //insert blank line to start
        for (int i = time; i > 0; i--)
        {
            Console.Write($"{_message}{i}");
            Thread.Sleep(1000);
            string blank = new string('\b', (_message.Length + 5));  // Overwrite line
            Console.Write(blank);
        }
        
    }


}
