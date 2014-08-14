using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz2
{
    class FizzBuzz
    {
        public string ReturnFizzOrBuzz(int number)
        {
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            return number.ToString();
        }
    }
}
