using System;

namespace DateModifier
{
    public class DateModifier
    {
        public void DateDifference(string firstDate, string secondDate)
        {
            TimeSpan span = DateTime.Parse(firstDate) - DateTime.Parse(secondDate);
            int days = Math.Abs(span.Days);
            Console.WriteLine(days);
        }
    }
}
