namespace H_W_01;

public static class Task1 {
    public static void Run() {
        Console.WriteLine("Enter the number from 1 tp 100: ");
        string? userInput = Console.ReadLine();
        int number;
        if (!int.TryParse(userInput, out number)) {
            Console.WriteLine("You entered not a number!");
            return;
        }

        
        if (number > 100 || number < 1) {
            Console.WriteLine("Invalid number");
        }
        else {
            if (number % 5 == 0 && number % 3 == 0) {
                Console.WriteLine("Fizz Buzz");
            } else if (number % 3 == 0) {
                Console.WriteLine("Fizz");
            } else if (number % 5 == 0) {
                Console.WriteLine("Buzz");
            }
            else {
                Console.WriteLine(number);
            }
        }

        
    }
}