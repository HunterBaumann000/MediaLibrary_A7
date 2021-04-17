using System.Collections.Generic;
using MediaLibrary_A7_1.Interfaces;
using MediaLibrary_A7_1;
using MovieLibrary_A7_1.MediaType;
using MediaLibrary_A7_1.MediaType;

namespace MovieLibrary_A7_1
{
    public class Menus
    {
        //For the matching title
        static MediaFile media = new MediaFile();

        //adding to csv
        static MediaContext context = new Menus();

        //adding to Json
        static Repository repo = new Repository();

        public static void DisplayMainMenu() {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("What would you like to do?");
            System.Console.WriteLine("   1.) Add a Media.");
            System.Console.WriteLine("   2.) Display a list of media.");
            System.Console.WriteLine("   3.) End Program ('.') ");
            System.Console.Write("Choice: ");
        }

        public static void DisplayMediaTypeMenu() {
            System.Console.WriteLine("What type of media would you like?");
            System.Console.WriteLine("   1.) A Movie. ");
            System.Console.WriteLine("   2.) A Show. ");
            System.Console.WriteLine("   3.) A Video. ");
        }

        public static void DisplayReadMediaMenu() {
            System.Console.WriteLine("What File would you like to read?");
            System.Console.WriteLine("   1.) The Movie File. ");
            System.Console.WriteLine("   2.) The Show File. ");
            System.Console.WriteLine("   3.) The Video File. ");
        }

        public static void AskUserForMovie() {

            // Add movie
            Movie movie = new Movie();
            string tempInput = "";

            // ask user to input movie title
            System.Console.WriteLine("What is the movie titled");
            movie.title = System.Console.ReadLine();

            // check if the title matches another title
            if (!media.hasSameTitle(movie.title, "movie")){
                       
                do
                {
                    // ask user to enter genre
                    System.Console.WriteLine("Enter a genre. ('.' to stop) ");
                    tempInput = System.Console.ReadLine();
                    //adds to genrelist
                    movie.genres.Add(tempInput);
                } 
                while (tempInput != ".");

                //movie never gets created if the title matches another
                context.AddMovie(movie);
                repo.AddMovie(movie);
                //sys out the media they added
                System.Console.WriteLine(movie.title + " has been added! ");
            }
        }   

        public static void AskUserForShow() {

            // Add show
            Show show = new Show();
            string tempInput = "";

            // ask user to input show title
            System.Console.WriteLine("What is the show titled");
            show.title = System.Console.ReadLine();

            // check if the title matches another title
            if (!media.hasSameTitle(show.title, "show")){
                       
                System.Console.WriteLine("What Season?");
                show.showSeason = int.Parse(System.Console.ReadLine());

                System.Console.WriteLine("What Episode?");
                show.showEpisode = int.Parse(System.Console.ReadLine());
            
                do
                {
                    // ask user to enter a writer
                    System.Console.WriteLine("Enter a Writer. ('.' to stop) ");
                    tempInput = System.Console.ReadLine();

                    show.showWriters.Add(tempInput);
                            
                } while (tempInput != ".");

                //show never gets created if the title matches another
                context.AddShow(show);
                repo.AddShow(show);
                //sys out the media they added
                System.Console.WriteLine(show.title + " has been added! ");
            }   
        }

        public static void AskUserForVideo() {

            // Add video
            Video video = new Video();
            string tempInput = "";

            // ask user to input video title
            System.Console.WriteLine("What is the video titled");
            video.title = System.Console.ReadLine();

            System.Console.WriteLine("What is the video format?");
            video.videoFormat = System.Console.ReadLine();

            System.Console.WriteLine("How many minutes long is the video?");
            video.videoLength = int.Parse(System.Console.ReadLine());

            // check if the title matches another title
            if (!media.hasSameTitle(video.title, "video")){
                       
                do
                {
                    // ask user to enter region
                    System.Console.WriteLine("Enter a Region (type '.' to stop) ");
                    tempInput = System.Console.ReadLine();

                    video.videoRegions.Add(tempInput);
                            
                } while (tempInput != ".");
           
                //video never gets created if the title matches another
                context.AddVideo(video);
                repo.AddVideo(video);
                //sys out the media they added
                System.Console.WriteLine(video.title + " has been added! ");
            }
        }
    }   
}
