using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas.PrimeFactors
{
    [TestFixture]
    public class PrimeFactorsTests
    {
        [Test]
        public void Factors()
        {
            var primeFactors = PrimeFactorsCalculator.PrimeFactorsOf(1);
            Assert.That(primeFactors, Is.Empty);
        }
    }

    public class PrimeFactorsCalculator
    {
        public static List<int> PrimeFactorsOf(int n)
        {
            return new List<int>();
        }
    }
}
