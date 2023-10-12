var saturdayCount = 150;
var sundayCount = 200;

var day = DateTime.Today;

var totalSaturday = 0;
var totalSunday = 0;

while(day.Year < 2024)
{

    if(day.DayOfWeek == DayOfWeek.Saturday)
    {
        totalSaturday += saturdayCount;
        Console.ResetColor();
        Console.Write($"{day.Day}/{day.Month} - coffee count: {saturdayCount} ");
    }
    if(day.DayOfWeek == DayOfWeek.Sunday)
    {
        totalSunday += sundayCount;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write($"{day.Day}/{day.Month} - coffee count: {sundayCount} ");
    }

    day = day.AddDays(1);
}

var total = totalSaturday + totalSunday;
Console.WriteLine($"Total coffee count: {total} - {total * 2,5} EUR");