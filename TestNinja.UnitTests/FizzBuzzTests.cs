using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class FizzBuzzTests
    {
        [Test]
        public void GetOutput_ArgumentDevisibleBy3and5_ReturnFizzBuzz()
        {
            var result = FizzBuzz.GetOutput(15);

            Assert.That(result, Is.EqualTo("FizzBuzz"));
        }

        [Test]
        public void GetOutput_ArgumentDevisibleBy3andNot5_ReturnFizz()
        {
            var result = FizzBuzz.GetOutput(12);

            Assert.That(result, Is.EqualTo("Fizz"));
        }

        [Test]
        public void GetOutput_ArgumentDevisibleBy5andNot3_ReturnBuzz()
        {
            var result = FizzBuzz.GetOutput(10);

            Assert.That(result, Is.EqualTo("Buzz"));
        }

        [Test]
        public void GetOutput_ArgumentNotDevisibleBy5and3_ReturnArgumenet()
        {
            var result = FizzBuzz.GetOutput(11);

            Assert.That(result, Is.EqualTo("11"));
        }


    }
}
