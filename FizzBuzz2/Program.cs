using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fb = new FizzBuzz();

            for (var i = 1; i <= 100; i++)
            {
                Console.WriteLine(fb.ReturnFizzOrBuzz(i));
            }

            Console.Read();
        }
    }
}
