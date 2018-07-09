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
    }

    public class FizzBuzz
    {
        public static string Calculate(int n)
        {
            return n.ToString();
        } 
    }
}
