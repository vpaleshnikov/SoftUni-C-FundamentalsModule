using System;
using System.Globalization;

public class DateModifier
{
    private DateTime firstDate;
    private DateTime lastDate;

    public DateTime FirstDate
    {
        get { return firstDate; }
        set { firstDate = value; }
    }

    public DateTime LastDate
    {
        get { return lastDate; }
        set { lastDate = value; }
    }

    public DateTime StringToDateTime(string input)
    {
        return DateTime.ParseExact(input, "yyyy MM dd", DateTimeFormatInfo.InvariantInfo);
    }

    public double DaysDifferenceCalculator(DateTime firstDate, DateTime lastDate)
    {
        return Math.Abs((lastDate - firstDate).TotalDays);
    }
}

