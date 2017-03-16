using FizzBuzz.Library;
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void WhenNotAMultipleOf5And3ReturnNothing([Values(1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19)] int input)
        {
            string output = FizzBuzzBasic.GetValue(input);
            Assert.AreEqual(string.Empty, output);
        }

        [Test]
        public void WhenNumIsMultipleOf3ReturnFizz([Values(3, 6, 9, 12, 18)] int input)
        {
            string output = FizzBuzzBasic.GetValue(input);
            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void WhenNumIsMultipleOf5ReturnBuzz([Values(5, 10)] int input)
        {
            string output = FizzBuzzBasic.GetValue(input);
            Assert.AreEqual("Buzz", output);
        }
    }
}
