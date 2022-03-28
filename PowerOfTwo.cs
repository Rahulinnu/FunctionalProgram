using System;
namespace BasicFunction
{
    public class PowerOfTwo
    {
        public void Pot()
        {
            Console.WriteLine("Wlcome to Power Of Two program");
            Console.WriteLine("Please Enter the range: ");
            int range = int.Parse(Console.ReadLine());
            if (range >= 31)
            {
                Console.WriteLine("Please input the range with in 31");
            }
            else
            {
                int n = range;
                int result = 1;
                while (range > 0)
                {
                    result = result * 2;
                    range--;
                }
                Console.WriteLine("Result of 2^" + n + "is: " + result);
            }
            Console.ReadLine();
        }
    }
}
