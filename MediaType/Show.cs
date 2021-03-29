using System;
using System.Collections.Generic;
using MediaLibrary_A7.Interfaces;

namespace MovieLibrary_A7.MediaType
{

    public class Show : Media
    {
        public int showSeason{get; set;}
        public int showEpisode{get; set;}
        public List<string> showWriters { get; set; }

        // constructor
        public Show()
        {
            showWriters = new List<string>();
        }

        public override string Display()
        {
            return $"ID: {mediaId}, Title: {title}, Season {showSeason} Ep. {showEpisode}, Writers: {string.Join(", ", showWriters)}";
        }

        public static implicit operator List<object>(Show v)
        {
            throw new NotImplementedException();
        }
    }
}