using System;
using System.Collections.Generic;
using MediaLibrary_A7.Interfaces;

namespace MovieLibrary_A7.MediaType
{
    public class Video : Media
    {
        public string videoFormat{get; set;}
        public int videoLength{get; set;}
        public List<string> videoRegions { get; set; }

        // constructor
        public Video()
        {
            videoRegions = new List<string>();
        }

        public override string Display()
        {
            return $"Id: {mediaId}, Title: {title}, Format: {videoFormat}, Length: {videoLength} minutes, VideoRegions: {string.Join(", ", videoRegions)}";
        }
    }
}