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
            if (IsDivisibleByThree(n) && IsDivisibleByFive(n)) return "FizzBuzz";
            if (IsDivisibleByThree(n) || ContainsAThree(n)) return "Fizz";
            if (IsDivisibleByFive(n) || ContainsAFive(n)) return "Buzz";
            return n.ToString();
        }

        private static bool IsDivisibleByThree(int n)
        {
            return n % 3 == 0;
        }
        private static bool IsDivisibleByFive(int n)
        {
            return n % 5 == 0;
        }

        private static bool ContainsAThree(int n)
        {
            return n.ToString().Contains("3");
        }

        private static bool ContainsAFive(int n)
        {
            return n.ToString().Contains("5");
        }
    }
}
