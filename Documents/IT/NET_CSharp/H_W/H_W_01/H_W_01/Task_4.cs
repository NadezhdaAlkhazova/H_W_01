namespace H_W_01;

public static class Task4 {
    public static void Run() {
        Console.WriteLine("Enter the 6-digit number: ");
        string? userInput = Console.ReadLine();

        if (!int.TryParse(userInput, out int number) || number < 100000 || number > 999999) {
            Console.WriteLine("You entered invalid number!");
            return;
        }

        int size = 6;
        int [] digits = new int[size];
        int temp = number;
        for (int i = size - 1; i >= 0; i--) {
            digits[i] = temp % 10;
            temp = temp / 10;
        }
        
        Console.WriteLine("Enter the first position (1-6): ");
        string? userInput1 = Console.ReadLine();
        if (!int.TryParse(userInput1, out int index1) || index1 < 1 || index1 > 6) {
            Console.WriteLine("You entered invalid number!");
        }
        Console.WriteLine("Enter the second position (1-6): ");
        string? userInput2 = Console.ReadLine();
        if (!int.TryParse(userInput2, out int index2) || index2 < 1 || index2 > 6) {
            Console.WriteLine("You entered invalid number!");
        }
        
        int tempDigit = digits[index1 - 1];
        digits[index1 - 1] = digits[index2 - 1];
        digits[index2 - 1] = tempDigit;

        int result = 0;
        for (int i = 0; i < size; i++) {
            result = result * 10 + digits[i];
        }
        Console.WriteLine($"New number: {result}");
    }
}