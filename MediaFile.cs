using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MediaLibrary_A7_1.Interfaces;
using MediaLibrary_A7_1.MediaType;
using MovieLibrary_A7_1.MediaType;

namespace MediaLibrary_A7_1
{
    public class MediaFile : Repository
    {

        public static void ReadMoviesFromFile(string filePath)
        {
            // read movie line
            try
            {
                StreamReader sr = new StreamReader(filePath);
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    // instance of Movie
                    Movie movie = new Movie();
                    string line = sr.ReadLine();

                    //gets input and converts to string
                    string[] movieLine = line.Split(',');

                    //fields that go into the string
                    movie.mediaId = int.Parse(movieLine[0]);
                    movie.title = movieLine[1];
                    movie.genres = movieLine[2].Split('|').ToList();
                    
                    //adds movie to file
                    Console.WriteLine(movieLine);
                }
                // close file when done
                sr.Close();
            }
            catch (Exception e)
            {
                //catch error
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadShowsFromFile(string filePath)
        {
            // read show line
            try
            {
                StreamReader sr = new StreamReader(filePath);
                sr.ReadLine();

                while (!sr.EndOfStream)
                {
                    // instance of Show
                    Show show = new Show();
                    string line = sr.ReadLine();

                    string[] showLine = line.Split(',');
                    show.mediaId = int.Parse(showLine[0]);
                    show.title = showLine[1];
                    show.showSeason = int.Parse(showLine[2]);
                    show.showEpisode = int.Parse(showLine[3]);
                    show.showWriters = showLine[4].Split('|').ToList();
                    
                    Console.WriteLine(showLine);
                }
                // close file
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void ReadVideosFromFile(string filePath)
        {
            // read video line
            try
            {
                //creates streamreader
                StreamReader sr = new StreamReader(filePath);
                sr.ReadLine();

                //loops until the end of stream
                while (!sr.EndOfStream)
                {
                    // instance of Video
                    Video video = new Video();
                    string line = sr.ReadLine();

                    string[] videoLine = line.Split(',');
                    video.mediaId = int.Parse(videoLine[0]);
                    video.title = videoLine[1];
                    video.videoFormat = videoLine[2];
                    video.videoLength = int.Parse(videoLine[3]);
                    video.videoRegions = videoLine[4].Split('|').ToList();
                    
                    Console.WriteLine(videoLine);
                }
                // close file when done
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public bool hasSameTitle(string title, string mediaType)
        {

            // bool match string
            if(mediaType.Equals(("movie"))) {
                //convert all movie objects to lowercase, and if that instance contains the title, return true
                if (GetAllMovies().ConvertAll(m => m.title.ToLower()).Contains(title.ToLower())){
                    Console.WriteLine("{Title} is a duplicate in the file", title);
                    return true;
                }
                return false;
            }
            else if(mediaType.Equals(("video"))) {
                //convert all video objects to lowercase, and if that instance contains the title, return true
                if (GetAllVideos().ConvertAll(v => v.title.ToLower()).Contains(title.ToLower()))
                {
                    Console.WriteLine("{Title} is a duplicate in the file", title);
                    return true;
                }
                return false;
            }
            else if(mediaType.Equals(("show"))){
                //convert all show objects to lowercase, and if that instance contains the title, return true
                if (GetAllShows().ConvertAll(s => s.title.ToLower()).Contains(title.ToLower()))
                {
                    Console.WriteLine("{Title} is a duplicate in the file", title);
                    return true;
                }
            }
            return false;
        }
    }
}