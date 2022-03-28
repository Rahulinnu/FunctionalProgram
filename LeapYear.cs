using System;
namespace BasicFunction
{
    public class LeapYear
    {
        public void CalcLeapYear()
        {
            Console.WriteLine("Welcome to Leap Year Program");
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year.", Year);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year.", Year);
            }
            Console.ReadLine();
        }
    }
}
