using System.CodeDom;
using NUnit.Framework;

namespace Katas.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(6, "Fizz")]
        [TestCase(9, "Fizz")]
        [TestCase(10, "Buzz")]
        [TestCase(13, "Fizz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(20, "Buzz")]
        [TestCase(23, "Fizz")]
        [TestCase(30, "FizzBuzz")]
        [TestCase(511, "Buzz")]
        public void FizzBuzzTest(int n, string expectedResult)
        {
            Assert.That(FizzBuzz.Calculate(n), Is.EqualTo(expectedResult));
        }
    }

    public class FizzBuzz
    {
        public static string Calculate(int n)
        {
            if (n % 3 == 0 && n % 5 == 0) return "FizzBuzz";
            if (n % 3 == 0 || n.ToString().Contains("3")) return "Fizz";
            if (n % 5 == 0 || n.ToString().Contains("5")) return "Buzz";
            return n.ToString();
        }
    }
}
