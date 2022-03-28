using System;
namespace BasicFunction
{
    public class LargestThree
    {
        public void LaTh()
        {
            Console.WriteLine("Welcome to largest among three number program: ");
            Console.WriteLine("Please enter 3 number: ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            if (first >= second && first >= third)
            {
                Console.WriteLine("The largest number is: " + first);
            }
            else if (second >= third)
            {
                Console.WriteLine("The Largest Number is: " + second);
            }
            else
            {
                Console.WriteLine("The largest Number is: " + third);
            }
            Console.ReadLine();
        }
    }
}
