using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace TestNinja.Mocking
{
    public class VideoService
    {
        public string ReadVideoTitle(IFileReader fileReader)
        {
            var str = fileReader.ReadFile("video.txt");
            var video = JsonConvert.DeserializeObject<Video>(str);
            if (video == null)
                return "Error parsing the video.";
            return video.Title;
        }

        public string GetUnprocessedVideosAsCsv(IVideoRepository videoRepository)
        {
            var videoIds = new List<int>(); 

            var videos = videoRepository.GetUnprocessedVideos();

            foreach (var v in videos)
                    videoIds.Add(v.Id);

            return String.Join(",", videoIds);

        }
    }

    public class FileReader : IFileReader
    {
        public string ReadFile(string path)
        {
            return File.ReadAllText(path);
        }
    }

    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}