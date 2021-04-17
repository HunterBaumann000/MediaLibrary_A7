using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MediaLibrary_A7_1.Interfaces;
using MediaLibrary_A7_1.MediaType;
using MovieLibrary_A7_1;
using MovieLibrary_A7_1.MediaType;

namespace MediaLibrary_A7_1
{
    public class Repository : IRepository
    {

        public void AddMovie(Movie movie)
        {
            Movie movie1 = new Movie();
            movie1.mediaId = GetAllMovies().Max(s => s.mediaId) + 1;
            movie1.title = movie.title;
            movie1.genres = movie.genres;

            string jsonString = JsonSerializer.Serialize(movie1);
            File.WriteAllText("FileOutputs/movies.json", jsonString);
        }

        public void AddShow(Show show)
        {
            //parameter for each part of the show?
            Show show1 = new Show();
            show.mediaId = GetAllShows().Max(s => s.mediaId) + 1;
            show.showSeason = show.showSeason;
            show.title = show.title;
            show.showEpisode = show.showEpisode;
            show.showWriters = show.showWriters;

            string jsonString = JsonSerializer.Serialize(show1);
            File.WriteAllText("FileOutputs/shows.json", jsonString);
        }

        public void AddVideo(Video video)
        {
            Video video1 = new Video();
            video1.mediaId = GetAllVideos().Max(s => s.mediaId) + 1;
            video1.title = video.title;
            video1.videoFormat = video.videoFormat;
            video1.videoLength = video.videoLength;
            video1.videoRegions = video.videoRegions;

            string jsonString = JsonSerializer.Serialize(video1);
            File.WriteAllText("FileOutputs/videos.json", jsonString);
        }

        public List<Movie> GetAllMovies()
        {
            return new List<Movie>();   
        }
        public List<Show> GetAllShows()
        {
            return new List<Show>(); 
        }
        public List<Video> GetAllVideos()
        {
            return new List<Video>(); 
        }
    }
}