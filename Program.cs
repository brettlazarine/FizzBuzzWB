using System;

namespace FizzBuzzWB
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isInt = false;
            int number;
            do
            {
                Console.Write("Please input an integer: ");
                isInt = int.TryParse(Console.ReadLine(), out number);
            } while (!isInt);
            Console.WriteLine(FizzBuzzClass.FizzBuzz(number));
        }
    }
}