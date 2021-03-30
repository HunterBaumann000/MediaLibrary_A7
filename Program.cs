using System;
using System.IO;
using System.Collections.Generic;
using MovieLibrary_A7.MediaType;
using Newtonsoft.Json;

namespace MovieLibrary_A7
{
    class Program
    {
        static void Main(string[] args)
        {
            //class with file-path parameter
            MovieFile movieFile = new MovieFile("movies.csv");
            ShowFile showFile = new ShowFile("shows.csv");
            VideoFile videoFile = new VideoFile("video.csv");

            //menu class
            Menus menus = new Menus();

            //declaring userInput so the scanner menu input works
            string userInput = "";

            do
            {
                // displays main menu
                menus.DisplayMainMenu();
                // scanner
                userInput = Console.ReadLine();

                //nested if-statements for users input
                if (userInput == "1") 
                {
                    //displays which MediaType they want to add
                    menus.DisplayMediaTypeMenu();
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            //movie menu
                            Menus.askUserForMovie(userInput);
                            break;
                        case "2":
                            //show menu
                            Menus.askUserForShow(userInput);
                            break;
                        case "3":
                            //video menu
                            Menus.askUserForVideo(userInput);
                            break;
                    }
                }
                else if (userInput == "2")
                {
                    //displays menu for reading the media from the file
                    menus.DisplayReadMediaMenu();
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
                            {
                                // Display All Movies
                                for (int i = 0; i < movieFile.Movies.Count; i++)
                                {
                                    //Movie m = JsonConvert.DeserializeObject<Movie>(json);

                                    Movie m = movieFile.Movies[i];
                                    Console.WriteLine(m.Display());
                                }

                                break;
                            }

                        case "2":
                            {
                                // Display All Shows
                                System.Collections.IList list = showFile.Shows;
                                for (int i = 0; i < list.Count; i++)
                                {
                                    //Show s = JsonConvert.DeserializeObject<Show>(json);

                                    Show s = (Show)list[i];
                                    Console.WriteLine(s.Display());
                                }

                                break;
                            }

                        case "3":
                            {
                                // Display All Videos
                                System.Collections.IList list = videoFile.Videos;
                                for (int i = 0; i < list.Count; i++)
                                {
                                    //Video v = JsonConvert.DeserializeObject<Video>(json);

                                    Video v = (Video)list[i];
                                    Console.WriteLine(v.Display());
                                }

                                break;
                            }
                    }
                }
            } while (userInput == "1" || userInput == "2" || userInput == "3");

            Console.WriteLine("Program Ended");
        }
    }
}