﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class HtmlFormatterTests
    {
        [Test]
        public void  FormatAsBold_WhenCalled_ReturnStringEnclosedInStrongElement()
        {
            //Arrange
            var htmlFormatter= new HtmlFormatter();

            //Act
            var result = htmlFormatter.FormatAsBold("abc");

            //Assert - specific
            Assert.That(result,Is.EqualTo("<strong>abc</strong>"));

            //Assert - general
            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
            Assert.That(result, Does.Contain("abc"));

        }
    }
}
