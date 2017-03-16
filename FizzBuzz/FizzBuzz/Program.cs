using FizzBuzz.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");

            var input = Console.ReadLine();
            int num1;

            bool res = int.TryParse(input, out num1);
            if (res == false)
            {
                Console.WriteLine($"'{input}' is not a valid number.");
            }
            else
            {
                Console.WriteLine(FizzBuzzBasic.GetValue(num1));
            }
        }
    }
}
