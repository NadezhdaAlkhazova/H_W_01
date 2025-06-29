namespace H_W_01;

public static class Task7 {
    public static void Run() {
        Console.WriteLine("Enter the first number: ");
        string? userInput1 = Console.ReadLine();
        Console.WriteLine("Enter the second number: ");
        string? userInput2 = Console.ReadLine();

        if (!int.TryParse(userInput1, out int num1) || !int.TryParse(userInput2, out int num2)) {
            Console.WriteLine("Invalid input! ");
            return;
        }
        
        int start = Math.Min(num1, num2);
        int end = Math.Max(num1, num2);

        for (int i = start; i <= end; i++) {
            if (i % 2 == 0) {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}