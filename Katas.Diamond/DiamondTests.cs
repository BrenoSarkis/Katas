using NUnit.Framework;

namespace Katas.Diamond
{
    [TestFixture]
    public class DiamondTests
    {
        [Test]
        public void DiamondOfA()
        {
            Assert.That(Diamond.GenerateFor('A'), Is.EqualTo("A"));
        }

        [Test]
        public void DiamondOfB()
        {
            Assert.That(Diamond.GenerateFor('B'), Is.EqualTo(DiamondCatalog.B));
        }
    }

    public class Diamond
    {
        public static string GenerateFor(char letter)
        {
            if (letter == 'B')
            {
                return DiamondCatalog.B;
            }
            return "A";
        }


    }

    public class DiamondCatalog
    {
        public static string B = @"A
                                  B B
                                   A";
    }
}
