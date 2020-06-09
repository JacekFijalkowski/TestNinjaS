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
        //[Ignore("Zignorowany bo tak")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1,2);

            Assert.That(result,Is.EqualTo(3));
        }

        [Test]
        [TestCase(2,1,2)]
        [TestCase(1,2,2)]
        [TestCase(1,1,1)]
        public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expectedResult)
        {
            var result = _math.Max(a,b);

            Assert.That(result,Is.EqualTo(expectedResult));
        }

        [Test]
        public void GetOddNumbers_WhenCalled_ReturnOddNumbers()
        {
            var result = _math.GetOddNumbers(5);

            Assert.That(result, Is.EquivalentTo(new [] {1,3,5}));
        }
    }
}
