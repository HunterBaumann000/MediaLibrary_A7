using System;
using System.Collections.Generic;
using MediaLibrary_A7_1.MediaType;
using MovieLibrary_A7_1;
using MovieLibrary_A7_1.MediaType;

namespace MediaLibrary_A7_1.Interfaces
{
    public class MediaContext : IMediaFile
    {
        private readonly IRepository _Repo;
        public MediaContext(IRepository repository)
        {
            _Repo = repository;
        }

        public void AddMovie(Movie movie)
        {
            _Repo.AddMovie(movie);
        }

        public void AddShow(Show show)
        {
            _Repo.AddShow(show);
        }
        public void AddVideo(Video video)
        {
            _Repo.AddVideo(video);
        }

        public List<Movie> GetMovies()
        {
            return _Repo.GetAllMovies();
        }

        public List<Show> GetShows()
        {
            return _Repo.GetAllShows();
        }

        public List<Video> GetVideos()
        {
            return _Repo.GetAllVideos();
        }

        public static implicit operator MediaContext(Menus v)
        {
            throw new NotImplementedException();
        }
    }
}