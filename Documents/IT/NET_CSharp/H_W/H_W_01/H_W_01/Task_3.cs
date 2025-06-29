namespace H_W_01;

public static class Task3 {
    public static void Run() {
        int size = 4;
        int [] digits = new int[size];
        for (int i = 0; i < size; i++) {
            Console.WriteLine($"Enter a digit (0-9) {i + 1}: ");
            string? userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out int number) || number > 9 || number < 0) {
                Console.WriteLine("Invalid input. Enter a digit (0-9)!");
                i--;
                continue;
            }

            digits[i] = number;
        }
        
        int result = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];
        Console.WriteLine($"Your result: {result}");
    }
}