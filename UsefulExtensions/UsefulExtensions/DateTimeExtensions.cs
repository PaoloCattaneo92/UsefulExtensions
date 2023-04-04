namespace PaoloCattaneo.UsefulExtensions;

public static class DateTimeExtensions
{
    public static bool IsBetween(this DateTime value, DateTime from, DateTime to, bool inclusive = true)
    {
        return inclusive 
            ? value >= from && value <= to 
            : value > from && value < to;
    }

    public static DateTime ToDayStart(this DateTime d)
    {
        return new DateTime(d.Year, d.Month, d.Day, 0, 0, 0, 0);
    }

    public static DateTime ToDayEnd(this DateTime d)
    {
        return new DateTime(d.Year, d.Month, d.Day, 23, 59, 59, 999);
    }

    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek = DayOfWeek.Monday)
    {
        int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
        return dt.AddDays(-1 * diff).ToDayStart();
    }

    public static DateTime StartOfMonth(this DateTime dt)
    {
        return new DateTime(dt.Year, dt.Month, 1).ToDayStart();
    }

    public static TimeSpan ToNow(this DateTime dt)
    {
        return DateTime.Now - dt;
    }

    public static TimeSpan ToUtcNow(this DateTime dt)
    {
        return DateTime.UtcNow - dt;
    }
}
