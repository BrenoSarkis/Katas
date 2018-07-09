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
    }

    public class FizzBuzz
    {
        public static string Calculate(int n)
        {
            if (n == 3) return "Fizz";
            return n.ToString();
        } 
    }
}
