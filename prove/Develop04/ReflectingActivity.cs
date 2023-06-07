class ReflectingActivity
{
    private int _seconds;
    private List<string> _questions = new List<string>()
    {
        "What did you learn today?",
        "What was the best part of your day?",
        "What was the most challenging part of your day?",
        "What are you grateful for today?",
        "What could you have done differently today?",
        "What are you looking forward to tomorrow?"
    };

    public void startReflecting(int seconds)
    {
        _seconds = seconds;
        Console.WriteLine($"Starting reflecting activity for {_seconds} seconds...");
        reflectOnExperience();
    }

    private void reflectOnExperience()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.Elapsed < TimeSpan.FromSeconds(_seconds))
        {
            DisplayQuestion();
            promptForReflection();
        }

        stopwatch.Stop();
        Console.WriteLine($"Reflecting activity complete! You reflected for {_seconds} seconds.");
    }

    private void promptForReflection()
    {
        Console.WriteLine("Please reflect on the question and press any key to continue...");
        Console.ReadKey();
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    private void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}
