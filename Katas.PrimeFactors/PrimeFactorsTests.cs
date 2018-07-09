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
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(5), Is.EqualTo(ListOf(5)));
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(6), Is.EqualTo(ListOf(2, 3)));
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(7), Is.EqualTo(ListOf(7)));
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(8), Is.EqualTo(ListOf(2, 2, 2)));
            Assert.That(PrimeFactorsCalculator.PrimeFactorsOf(9), Is.EqualTo(ListOf(3, 3)));
        }
    }

    public class PrimeFactorsCalculator
    {
        public static List<int> PrimeFactorsOf(int n)
        {
            var factors = new List<int>();

            if (n > 1)
            {
                for (; n % 2 == 0; n /= 2)
                {
                    factors.Add(2);
                }

                for (; n % 3 == 0; n /= 3)
                {
                    factors.Add(3);
                }
            }

            if (n > 1)
            {
                factors.Add(n);
            }

            return factors;
        }
    }
}
