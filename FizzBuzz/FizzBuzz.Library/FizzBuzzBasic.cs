using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library
{
    public class FizzBuzzBasic
    {
        public static string GetValue(int input)
        {
            string output = string.Empty;

            output += (input % 3) == 0 ? "Fizz" : "";
            output += (input % 5) == 0 ? "Buzz" : "";

            return output;
        }
    }
}
