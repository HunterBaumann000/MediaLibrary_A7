using System.Collections.Generic;
using MovieLibrary_A7;

namespace MediaLibrary_A7
{
    public interface IMenus
    {
        void getUserInput(); 
        void getTempUserInput(); 

        public List<Movie> Movies { get; set; }
        public List<Show> Shows { get; set; }
        public List<Video> Videos { get; set; } 


    }
}   