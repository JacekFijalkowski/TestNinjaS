using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1,2);

            Assert.That(result,Is.EqualTo(3));
        }

        [Test]
        public void Sum_FirstArgumentGreater_ReturnFirstArgument()
        {
            var result = _math.Max(2,1);

            Assert.That(result,Is.EqualTo(2));
        }

        [Test]
        public void Sum_SecondArgumentGreater_ReturnSecondArgument()
        {
            var result = _math.Max(1,2);

            Assert.That(result,Is.EqualTo(2));
        }

        [Test]
        public void Sum_BothArgumentsEquall_ReturnFirstArgument()
        {
            var result = _math.Max(1,1);

            Assert.That(result,Is.EqualTo(1));
        }

    }
}
