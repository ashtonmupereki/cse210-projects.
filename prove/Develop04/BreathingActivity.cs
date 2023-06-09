class BreathingActivity : Activity
{
   // Attributes
   private int _breathsPerMinute;
   private int _breathIn;
   private int _breathOut;
   public string _message;

   // Constructors
   public BreathingActivity(string activityName, int activityTime, int breathIn, int breathOut, string message) : base(activityName, activityTime)
   {
       _breathIn = breathIn;
       _breathOut = breathOut;
       _message =  "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
   }

   // Methods
   public void SetBreathsPerMinute(int breathsPerMinute)
   {
       _breathsPerMinute = breathsPerMinute;
   }

   public int GetBreathsPerMinute()
   {
       return _breathsPerMinute;
   }

   public void Breathe()
   {
       Console.WriteLine($"{_message}\n");
       while (true)
       {
           Console.WriteLine($"Breathe in for {_breathIn} seconds...");
           Thread.Sleep(_breathIn * 1000);
           Console.WriteLine("Hold your breath...");
           Thread.Sleep(3000);
           Console.WriteLine($"Breathe out for {_breathOut} seconds...");
           Thread.Sleep(_breathOut * 1000);
       }
   }
}