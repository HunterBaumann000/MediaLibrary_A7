using System;
using System.Collections.Generic;

namespace MovieLibrary_A7.MediaType
{
    public class Video
    {
        public int videoId { get; set; }
        public string videoTitle{get; set;}
        public string videoFormat{get; set;}
        public int videoLength{get; set;}
        public List<string> videoRegions { get; set; }

        // constructor
        public Video()
        {
            videoRegions = new List<string>();
        }

        public string displayVideoFormatted()
        {
            return $"Id: {videoId}, Title: {videoTitle}, Format: {videoFormat}, Length: {videoLength} minutes, VideoRegions: {string.Join(", ", videoRegions)}";
        }

        internal static int Max(Func<object, object> p)
        {
            throw new NotImplementedException();
        }
    }
}