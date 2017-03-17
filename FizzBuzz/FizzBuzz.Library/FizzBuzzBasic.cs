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
            return ((input % 3) == 0 ? "Fizz" : string.Empty) + 
                ((input % 5) == 0 ? "Buzz" : "");
        }
    }
}
