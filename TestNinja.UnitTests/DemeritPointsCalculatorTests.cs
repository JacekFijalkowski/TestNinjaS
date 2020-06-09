using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class DemeritPointsCalculatorTests
    {
        [Test]
        public void CalculateDemeritPoints_SpeedBelowMaxSpeed_Return0()
        {
            var calculator = new DemeritPointsCalculator();

            var result = calculator.CalculateDemeritPoints(42);

            Assert.That(result, Is.EqualTo(0));
        }
        [Test]
        public void CalculateDemeritPoints_SpeedAboveMaxSpeed_ReturnPoints()
        {
            var calculator = new DemeritPointsCalculator();

            var result = calculator.CalculateDemeritPoints(71);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void CalculateDemeritPoints_SpeedOutOfRange_ReturnArgumentOutOfRangeException()
        {
            var calculator = new DemeritPointsCalculator();

            Assert.That(() => calculator.CalculateDemeritPoints(-3), Throws.Exception.TypeOf<ArgumentOutOfRangeException>());
        }

    }
}
