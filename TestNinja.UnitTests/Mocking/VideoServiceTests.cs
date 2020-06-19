using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    public class VideoServiceTests
    {
        private Mock<IFileReader> _fileReader;
        private VideoService _videoService;
        private Mock<IVideoRepository> _mockVideoRepository;

        [SetUp]
        public void SetUp()
        {
            _fileReader = new Mock<IFileReader>();
            _videoService = new VideoService();
            _mockVideoRepository = new Mock<IVideoRepository>();
        }


        [Test]
        public void ReadVideoTitle_VideoIsNull_ReturnErrorMessage()
        {
            _fileReader.Setup(fr => fr.ReadFile("video.txt")).Returns("");

            var result = _videoService.ReadVideoTitle(_fileReader.Object);

            Assert.That(result,Does.Contain("error").IgnoreCase);
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_NoUnprocessedVideos_ReturnEmptyString()
        {
            var mockVideoRepositoryResult = new List<Video>();

            _mockVideoRepository.Setup(mvr => mvr.GetUnprocessedVideos()).Returns(mockVideoRepositoryResult);

            var result = _videoService.GetUnprocessedVideosAsCsv(_mockVideoRepository.Object);

            Assert.That(result, Is.EqualTo(""));
        }

        [Test]
        public void GetUnprocessedVideosAsCsv_FewUnprocessedVideos_ReturnIdsSeparatedByComas()
        {
            var mockVideoRepositoryResult = new List<Video>(){new Video{Id=1},new Video{Id=2} };

            _mockVideoRepository.Setup(mvr => mvr.GetUnprocessedVideos()).Returns(mockVideoRepositoryResult);

            var result = _videoService.GetUnprocessedVideosAsCsv(_mockVideoRepository.Object);

            Assert.That(result, Is.EqualTo("1,2"));
        }

    }
} 
