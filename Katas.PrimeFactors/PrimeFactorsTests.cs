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
        private IEnumerable<int> ListOf(params int[] n)
        {
            return n;
        }

        [Test]
        public void Factors()
        {
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(1), Is.Empty);
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(2), Is.EqualTo(ListOf(2)));
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(3), Is.EqualTo(ListOf(3)));
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(4), Is.EqualTo(ListOf(2, 2)));
        }
    }

    public class PrimeFactorsCalculator
    {
        public static List<int> PrimeFactorsOf(int n)
        {
            var factors = new List<int>();

            if (n > 1)
            {
                if (n % 2 == 0)
                {
                    factors.Add(2);
                    n /= 2;
                }

                if (n > 1)
                {
                    factors.Add(n);
                }
            }

            return factors;
        }
    }
}
