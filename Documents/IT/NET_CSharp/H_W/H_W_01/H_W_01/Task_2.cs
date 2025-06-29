namespace H_W_01;

public static class Task2 {
    public static void Run() {
        Console.WriteLine("Enter the number: ");
        string? userInput1 = Console.ReadLine();
        if (!double.TryParse(userInput1, out double num1)) {
            Console.WriteLine("You entered not a number!");
            return;
        }
        Console.WriteLine("Enter the percentage: ");
        string? userInput2 = Console.ReadLine();
        if (!double.TryParse(userInput2, out double num2)) {
            Console.WriteLine("You entered not a number!");
            return;
        }
        
        double result = num1 * num2 / 100.0;
        Console.WriteLine($"{num2}% of {num1} is {result}");
        
    }
    
}