using NUnit.Framework;

namespace Katas.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void One_ReturnsOne()
        {
            Assert.That(FizzBuzz.Calculate(1), Is.EqualTo("1"));
        }

        [Test]
        public void Two_ReturnsTwo()
        {
            Assert.That(FizzBuzz.Calculate(2), Is.EqualTo("2"));
        }

        [Test]
        public void Three_ReturnsFizz()
        {
            Assert.That(FizzBuzz.Calculate(3), Is.EqualTo("Fizz"));
        }

        [Test]
        public void Five_ReturnsBuzz()
        {
            Assert.That(FizzBuzz.Calculate(5), Is.EqualTo("Buzz"));
        }

        [Test]
        public void Six_ReturnsFizz()
        {
            Assert.That(FizzBuzz.Calculate(6), Is.EqualTo("Fizz"));
        }
    }

    public class FizzBuzz
    {
        public static string Calculate(int n)
        {
            if (n % 3 == 0) return "Fizz";
            if (n == 5) return "Buzz";
            return n.ToString();
        } 
    }
}
