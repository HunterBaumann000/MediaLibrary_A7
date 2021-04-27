using MediaLibrary_A7_1.MediaType;

namespace MediaLibrary_A7_1.Interfaces
{
    public interface IRepository
    {
        void AddMovie(Movie movie);
        void AddShow(Show show);
        void AddVideo(Video video);
    }
}