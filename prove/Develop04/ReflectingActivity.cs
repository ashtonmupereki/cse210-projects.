public class ReflectingActivity : Activity
{
    private List<string> _promptList = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you failed at something."
    };
    private List<string> _questionList = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What was your motivation?"
    };
    private List<string> _useQuestionsList = new List<string>();

    private string _prompt;
    private string _question;
    private string _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    public void GetActivityDescription()
    {
        Console.WriteLine(_description);
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptList.Count);
        _prompt = _promptList[index];
        return _prompt;
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questionList.Count);
        _question = _questionList[index];
        while (_useQuestionsList.Contains(_question))
        {
            index = random.Next(_questionList.Count);
            _question = _questionList[index];
        }
        _useQuestionsList.Add(_question);
        return _question;
    }

    public void GetPromptAndQuestions()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n--- {_prompt} ---");
        Console.WriteLine($"\nWhen you have something in mind, press enter to continue.");

        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");

        foreach (string question in _questionList)
            Console.WriteLine($"\n- {GetRandomQuestion()}");
    }
}