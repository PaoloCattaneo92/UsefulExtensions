#define BENCHMARK

using System.Text;

namespace PaoloCattaneo.UsefulExtensions;



public static class TimespanExtensions
{
    public static string ToHumanReadable_StringBuilder(this TimeSpan ts)
    {
        StringBuilder buff = new StringBuilder();
        if (ts.TotalMilliseconds < 1000)
        {
            return $"{ts.TotalMilliseconds}ms";
        }

        if (ts.TotalSeconds < 60)
        {
            buff.Append($"{ts.Seconds}s");
            if (ts.Milliseconds > 0)
            {
                buff.Append($" {ts.Milliseconds}ms");
            }
            return buff.ToString();
        }

        if (ts.TotalMinutes < 60)
        {
            buff.Append($"{ts.Minutes}m");
            if (ts.Seconds > 0)
            {
                buff.Append($" {ts.Seconds}s");
            }
            return buff.ToString();
        }

        if (ts.TotalHours < 24)
        {
            buff.Append($"{ts.Hours}h");
            if (ts.Minutes > 0)
            {
                buff.Append($" {ts.Minutes}m");
            }
            if (ts.Seconds > 0)
            {
                buff.Append($" {ts.Seconds}s");
            }
            return buff.ToString();
        }

        buff.Append($"{ts.Days}d");
        if (ts.Hours > 0)
        {
            buff.Append($" {ts.Hours}h");
        }
        if (ts.Minutes > 0)
        {
            buff.Append($" {ts.Minutes}m");
        }
        if (ts.Seconds > 0)
        {
            buff.Append($" {ts.Seconds}s");
        }
        return buff.ToString();
    }

    public static string ToHumanReadable_Concatenate(this TimeSpan ts)
    {
        string buff;
        if (ts.TotalMilliseconds < 1000)
        {
            return $"{ts.TotalMilliseconds}ms";
        }

        if (ts.TotalSeconds < 60)
        {
            buff = $"{ts.Seconds}s";
            if (ts.Milliseconds > 0)
            {
                buff += $" {ts.Milliseconds}ms";
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
        return buff;
    }
}
