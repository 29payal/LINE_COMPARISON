using System;

namespace Linecomparison
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Choose option\n 1.Calculate Length");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CalculateLength.calcalulatelength();
                    break;
                    default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
