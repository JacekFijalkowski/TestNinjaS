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
    class StackTests
    {

        [Test]
        public void Push_AddValidObject_ValidObjectAtTopOfStack()
        {
            var stack = new Fundamentals.Stack<object>();

            var newObject = new Object();

            stack.Push(newObject);

            //Assert.That(stack.)



        }

    }
}
