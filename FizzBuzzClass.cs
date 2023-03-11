using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWB
{
    static class FizzBuzzClass
    {
        public static string FizzBuzz(int number)
        {
            if (number == 0) { return "A zero? How could you..."; }
            if (number % 3 == 0 && number % 5 == 0) { return "fizzbuzz"; }
            else if (number % 3 == 0) { return "fizz"; }
            else if (number % 5 == 0) { return "buzz"; }
            else { return "That wasn't divisible by three OR five..."; }
        }
    }
}