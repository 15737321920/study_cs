using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input your first number:");
            string a = Console.ReadLine();
            Console.Write("Please input your second number:");
            string b = Console.ReadLine();
            Double a1 = Convert.ToDouble(a);
            Double b1 = Convert.ToDouble(b);
            Double sum = a1 + b1;
            Console.WriteLine("The sum of these two number is:"+ a + " + "+ b +" = " + sum);
            Console.ReadKey();
        }
    }
}
