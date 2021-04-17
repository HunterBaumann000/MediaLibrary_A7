using System.Collections.Generic;
using MediaLibrary_A7_1.MediaType;
using MovieLibrary_A7_1.MediaType;

namespace MediaLibrary_A7_1.Interfaces
{
    public interface IRepository
    {
        void AddMovie(Movie movie);
        List<Movie> GetAllMovies();

        void AddShow(Show show);
        List<Show> GetAllShows();

        void AddVideo(Video video);
        List<Video> GetAllVideos();
    }
}