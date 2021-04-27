using System.Collections.Generic;
using MediaLibrary_A7_1.MediaType;

namespace MediaLibrary_A7_1.Interfaces
{
    public interface ILibrary
    {
        List<Movie> GetAllMovies();
        List<Show> GetAllShows();
        List<Video> GetAllVideos();
    }
}