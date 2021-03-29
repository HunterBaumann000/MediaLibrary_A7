using System.Collections.Generic;
using MovieLibrary_A7.MediaType;

namespace MediaLibrary_A7.Interfaces
{
    public interface IRepository
    {
        public List<Movie> GetMovies { get; set; }
        void AddMovie(Movie movie);
        
        public List<Show> GetShows { get; set; }
        void AddShow(Show show);

        List<Video> GetVideos { get; set; }
        void AddVideo(Video video);
        
    }
}