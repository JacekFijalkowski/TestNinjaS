using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private VideoService _videoService;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _videoService = new VideoService();
        }


        [Test]
        public void ReadVideoTitle_VideoIsNull_ReturnErrorMessage()
        {
            _fileReader.Setup(fr => fr.ReadFile("video.txt")).Returns("");

            var result = _videoService.ReadVideoTitle(_fileReader.Object);

            Assert.That(result,Does.Contain("error").IgnoreCase);
        }


    }
} 
