using System;

namespace dateLabTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(03, 24, 2021);
            Console.WriteLine($"The date is : {date.DateTest()}");
        }
    }
}
