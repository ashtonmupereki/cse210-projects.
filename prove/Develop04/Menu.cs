using System;

public class Menu {
    private string[] _menu;
    private int _userChoice;
    
    public Menu(string[] menu) {
        _menu = menu;
    }
    
    public void DisplayMenu() {
        Console.WriteLine("Menu options");
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        for (int i = 0; i < _menu.Length; i++) {
            Console.WriteLine($"{i + 1}. {_menu[i]}");
        }
    }
    
    public void GetUserChoice() {
        Console.Write("Select an option from the menu: ");
        string userInput = Console.ReadLine();
        if (int.TryParse(userInput, out int userChoice)) {
            _userChoice = userChoice;
        } else {
            Console.WriteLine("Invalid input. Please enter a number.");
            GetUserChoice();
        }
    }
    
    public int UserChoice {
        get { return _userChoice; }
    }
}
