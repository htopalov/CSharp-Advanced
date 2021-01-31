using System;

namespace DateModifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            DateModifier dm = new DateModifier();
            dm.DateDifference(firstDate, secondDate);
        }
    }
}
