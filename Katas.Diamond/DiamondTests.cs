using NUnit.Framework;

namespace Katas.Diamond
{
    [TestFixture]
    public class DiamondTests
    {
        [Test]
        public void DiamondA()
        {
            Assert.That(Diamond.GenerateFor('C'), Is.EqualTo("A"));
        }
    }

    public class Diamond
    {
        public static string GenerateFor(char letter)
        {
            return "A";
        }
    }
}
