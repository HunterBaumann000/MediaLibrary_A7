using System.Collections.Generic;
using MovieLibrary_A7.MediaType;

namespace MediaLibrary_A7.Interfaces
{
    public interface IMenus
    {
        //users input
        void getUserInput(); 
        void getTempUserInput(); 

        //lists
        public List<Movie> Movies { get; set; }
        public List<Show> Shows { get; set; }
        public List<Video> Videos { get; set; } 


    }
}   