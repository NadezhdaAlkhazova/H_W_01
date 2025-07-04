namespace H_W_01;

public static class Task5 {
    public static void Run() {
        Console.WriteLine("Enter a date(for example 21.02.2012)");
        string? userInput = Console.ReadLine();

        if (!DateTime.TryParse(userInput, out DateTime date)) {
            Console.WriteLine("Enter a valid date(for example 21.02.2012)");
            return;
        }
        
        string dayOfWeek = date.DayOfWeek.ToString();
        int month = date.Month;
        string season;

        switch (month) {
            case 1:
            case 2:
            case 12:
                season = "Winter";
                break;
            case 3:
            case 4:
            case 5:
                season = "Spring";
                break;
            case 6:
            case 7:
            case 8:
                season = "Summer";
                break;
            case 9:
            case 10:
            case 11:
                season = "Autumn";
                break;
            default: 
                season = "Unknown";
                break;
                
                
        }
        
        Console.WriteLine($"{season} {dayOfWeek}");
    }
}