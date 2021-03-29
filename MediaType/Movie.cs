using System;
using System.Collections.Generic;
using MediaLibrary_A7.Interfaces;

namespace MovieLibrary_A7.MediaType
{
    public class Movie : Media
    {
        public Movie()
        {
            //list of movieGenres so other class can access
            genres = new List<string>();
        }

        public override string Display()
        {
            //formatted fields for console.writeLine 
            return $"Id: {mediaId}, Title: {title}, Genres: {string.Join(", ", genres)}";
        }
    }
}