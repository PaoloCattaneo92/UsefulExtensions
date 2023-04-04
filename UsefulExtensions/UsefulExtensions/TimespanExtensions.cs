#define BENCHMARK


namespace PaoloCattaneo.UsefulExtensions;



public static class TimespanExtensions
{
    public static string ToHumanReadable(this TimeSpan ts)
    {
        string buff;
        if (ts.TotalMilliseconds < 1000)
        {
            return $"{ts.TotalMilliseconds}f";
        }

        if (ts.TotalSeconds < 60)
        {
            buff = $"{ts.Seconds}s";
            if (ts.Milliseconds > 0)
            {
                buff += $" {ts.Milliseconds}f";
            }
            return buff;
        }

        if (ts.TotalMinutes < 60)
        {
            buff = $"{ts.Minutes}m";
            if (ts.Seconds > 0)
            {
                buff += $" {ts.Seconds}s";
            }
            return buff;
        }

        if (ts.TotalHours < 24)
        {
            buff = $"{ts.Hours}h";
            if (ts.Minutes > 0)
            {
                buff += $" {ts.Minutes}m";
            }
            if (ts.Seconds > 0)
            {
                buff += $" {ts.Seconds}s";
            }
            return buff;
        }

        buff = $"{ts.Days}d";
        if (ts.Hours > 0)
        {
            buff += $" {ts.Hours}h";
        }
        if (ts.Minutes > 0)
        {
            buff += $" {ts.Minutes}m";
        }
        if (ts.Seconds > 0)
        {
            buff += $" {ts.Seconds}s";
        }
        if(ts.Milliseconds > 0)
        {
            buff += $" {ts.Milliseconds}f";
        }
        return buff;
    }

    public static TimeSpan FromHumanReadable(string s)
    {
        var buff = s;
        if (buff.StartsWith("$"))
        {
            buff = buff.Substring(1);
        }

        int days = 0;
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
        int milliseconds = 0;

        var spl = buff.Split('d');
        if (spl.Length > 1)
        {
            days = int.Parse(spl[0]);
            buff = spl[1];
        }

        spl = buff.Split('h');
        if (spl.Length > 1)
        {
            hours = int.Parse(spl[0]);
            buff = spl[1];
        }

        spl = buff.Split('m');
        if (spl.Length > 1)
        {
            minutes = int.Parse(spl[0]);
            buff = spl[1];
        }

        spl = buff.Split('s');
        if (spl.Length > 1)
        {
            seconds = int.Parse(spl[0]);
            buff = spl[1];
        }

        spl = buff.Split('f');
        if (spl.Length > 1)
        {
            milliseconds = int.Parse(spl[0]);
        }

        return new TimeSpan(days, hours, minutes, seconds, milliseconds);
    }
}
