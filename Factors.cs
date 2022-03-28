using System;
namespace BasicFunction
{
    public class Factors
    {
        public void Fact()
        {
            Console.WriteLine("Welcome to Factor");
            int ronit = 1;
            Console.WriteLine("Enter a number to check: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                ronit = ronit * i;
            }
            Console.WriteLine("The factorial of " + num + " is: " + ronit);
            Console.ReadLine();
        }
    }
}
