using System;
using System.Timers;

public class ListingActivity {
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private string activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    
    public void GetActivityDescription() {
        Console.WriteLine(activityDescription);
    }
    
    private string GetRandomPrompt() {
        Random random = new Random();
        int randomIndex = random.Next(prompts.Length);
        return prompts[randomIndex];
    }
    
    public void ReturnPrompt(int seconds) {
        Timer timer = new Timer(seconds * 1000);
        timer.Elapsed += (sender, e) => Console.WriteLine(GetRandomPrompt());
        
        timer.Start();
    }
}