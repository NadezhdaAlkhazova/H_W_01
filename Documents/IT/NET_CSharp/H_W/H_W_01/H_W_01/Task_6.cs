namespace H_W_01;

public static class Task6 {
    public static void Run() {
        Console.WriteLine("Enter temperature value (Celsius or Fahrenheit): ");
        string? userInput = Console.ReadLine();

        if (!double.TryParse(userInput, out double temperature)) {
            Console.WriteLine("Invalid temperature value! ");
            return;
        }
        
        Console.WriteLine("Convert to Celsius or Fahrenheit. Enter C or F: ");
        string? userInput2 = Console.ReadLine()?.ToUpper();
        
        if (userInput2 != "C" || userInput2 != "F") {
            Console.WriteLine("Invalid input! ");
            return;
        }

        if (userInput2 == "C") {
            double celsius = (temperature - 32) * 5 / 9;
            Console.WriteLine($"Celsius: {celsius:F2}");
        }
        else if (userInput2 == "F") {
            double fahrenheit = temperature * 9 / 5 + 32;
            Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
        }
        else {
            Console.WriteLine("Invalid input! ");
        }
        
    }
}