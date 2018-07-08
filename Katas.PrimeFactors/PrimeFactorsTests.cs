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
        private IEnumerable<int> ListOf(int n)
        {
            yield return n;
        }

        [Test]
        public void Factors()
        {
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(1), Is.Empty);
            CollectionAssert.AreEqual(PrimeFactorsCalculator.PrimeFactorsOf(2), ListOf(2));
        }
    }

    public class PrimeFactorsCalculator
    {
        public static List<int> PrimeFactorsOf(int n)
        {
            var factors = new List<int>();
            if (n > 1)
                factors.Add(n);
            return factors;
        }
    }
}
