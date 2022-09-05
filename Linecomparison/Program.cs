using System;

namespace Linecomparison
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Choose option\n 1.Calculate Length\t 2. Length of lines\t 3. Check the both lines");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CalculateLength.calcalulatelength();
                    break;
                case 2:
                    LengthOfLinee.LengthOfLine1();
                    break;
                case 3:
                    CompareTwoLine.CheckBothLine();
                    break;
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }
        }
    }
}
