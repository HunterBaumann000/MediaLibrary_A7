using System.Collections.Generic;
using MediaLibrary_A7.Interfaces;
using MovieLibrary_A7.MediaType;

namespace MediaLibrary_A7
{
    public class Repository : IRepository
    {
        public List<Movie> Movies { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<Show> Shows { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public List<Video> Videos { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void AddMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public void AddShow(Show show)
        {
            throw new System.NotImplementedException();
        }

        public void AddVideo(Video video)
        {
            throw new System.NotImplementedException();
        }
    }
}