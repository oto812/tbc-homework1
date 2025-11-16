namespace homework1.oop2and3;

public static class DateTimeExtensions
{
    public static string StringDayOfWeek(this DateTime dateTime)
    {
        string formatted = $"{dateTime.DayOfWeek} {dateTime:dd/MM/yyyy HH:mm:ss:fff}";
        return formatted;    
    }

    public static bool InRange(this DateTime dateTime, DateTime from, DateTime to)
    {
        return dateTime >= from && dateTime <= to;
    }

    public static int CalculateAge(this DateTime dateTime)
    {
        var age = DateTime.Today.Year - dateTime.Year;
        return age < 0 ? 0 : age;
    }
}