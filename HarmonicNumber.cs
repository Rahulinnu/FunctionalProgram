using System;
namespace BasicFunction
{
    public class HarmonicNumber
    {
        public void HaNu()
        {
            Console.WriteLine("Welcome to Harmonic Number Problem");
            Console.WriteLine("Please Enter the Range: ");
            int range = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 1; i < range; i++)
            {
                result = (1 / (Convert.ToDouble(i)));
                if (i == range)
                {
                    Console.WriteLine($"1/{i} = ");
                }
                else
                {
                    Console.WriteLine($"1/{i} + ");
                }

            }
            Console.WriteLine("The sum is =" + result);
            Console.ReadLine();
        }
    }
}
