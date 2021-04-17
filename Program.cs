using System;
using MovieLibrary_A7_1.MediaType;
using MediaLibrary_A7_1;


namespace MovieLibrary_A7_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaring userInput so the scanner menu input works
            string userInput = "";

            do
            {
                // displays main menu
                Menus.DisplayMainMenu();
                userInput = Console.ReadLine();

                //nested if-statements for users input
                if (userInput == "1") 
                {
                    //displays which MediaType they want to add
                    Menus.DisplayMediaTypeMenu();
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            //movie menu
                            Menus.AskUserForMovie();
                            break;
                        case "2":
                            //show menu
                            Menus.AskUserForShow();
                            break;
                        case "3":
                            //video menu
                            Menus.AskUserForVideo();
                            break;
                    }
                }
                else if (userInput == "2")
                {
                    //displays menu for reading the media from the file
                    Menus.DisplayReadMediaMenu();
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            //movie menu
                            MediaFile.ReadMoviesFromFile("FileOutputs/movies.csv");
                            break;
                        case "2":
                            //show menu
                            MediaFile.ReadShowsFromFile("FileOutputs/shows.csv");
                            break;
                        case "3":
                            //video menu
                            MediaFile.ReadVideosFromFile("FileOutputs/videos.csv");
                            break;
                    }
                }
            } while (userInput != ".");

            Console.WriteLine("Program Ended");
        }
    }
}