using System.Collections.Generic;
using MediaLibrary_A7_1.MediaType;
using MovieLibrary_A7_1.MediaType;

namespace MediaLibrary_A7_1.Interfaces
{
    public interface IMediaFile
    {
        //possible use in the future
        List<Movie> GetMovies();

        List<Show> GetShows();

        List<Video> GetVideos();
    }
}