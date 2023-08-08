using System;
namespace Power
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Program Calculates the Power of any Number");
            Console.WriteLine("******************************************");
            Console.WriteLine("Enter the base Number: ");
            int base_Number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Power of the Number: ");
            int poWer = int.Parse(Console.ReadLine());
            int result = CalculatePower(base_Number, poWer);

            Console.WriteLine("The value of {0} to power {1} is {2}",base_Number,poWer,result);
        }
        public static int CalculatePower(int x, int y)
        {
            if (y == 0)
                return 1;
            else
                return x * CalculatePower(x,y-1);
        }
    }
}