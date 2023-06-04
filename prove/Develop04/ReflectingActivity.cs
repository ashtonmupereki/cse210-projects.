public class ReflectingActivity : Activity
{
    public override void Start()
    {
        Console.WriteLine("Welcome to Reflecting Activity.");
        Console.WriteLine("This activity will help you to reflect on times in your life when you have shown strength and resilience.");
        Console.Write("How long in seconds will you want for the session? ");
        int time = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("Think of the time you did something difficult");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("You may begin:");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
        // simulate reflecting activity
        Console.Write("How did you feel when it was complete? ");
        string answer1 = Console.ReadLine();
        System.Threading.Thread.Sleep(2000);
        Console.Write("What is your favorite thing about this experience? ");
        string answer2 = Console.ReadLine();
        System.Threading.Thread.Sleep(2000);
        Console.WriteLine($"Well done! You have completed another {time} seconds for the reflecting activity.");
    }
}
