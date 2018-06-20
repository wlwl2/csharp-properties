using System;

namespace UsingProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = new Date();
            Console.WriteLine(date.Month);
            Console.WriteLine("Hello World!");
        }
    }

    public class Date
    {
        private int month = 7;  // Backing store

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if ((value > 0) && (value < 13))
                {
                    month = value;
                }
            }
        }
    }
}
