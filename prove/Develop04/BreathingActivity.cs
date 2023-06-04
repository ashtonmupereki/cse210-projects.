public class BreathingActivity : Activity
{
    public override void Start()
    {
        Console.WriteLine("Welcome to Breathing Activity.");
        Console.WriteLine("This activity will help you to relax by walking through breathing in and out slowly.");
        Console.WriteLine("Clear your mind and focus on your breath.");
        Console.Write("How long in seconds would you like for the session? ");
        int time = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        // simulate breathing activity
        for (int i = time; i > 0; i--)
        {
            Console.WriteLine($"Breathing in... {i}");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine($"Breathing out... {i}");
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("Goodbye!");
    }
}
