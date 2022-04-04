using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NewsApp
    {
        public NewsFeed NewsFeed { get; set; } = new NewsFeed();

        string[] choices =
        {
            "Add a Message Post",
            "Add a Photo Post",
            "Display All Post",
            "Quit"
        };

        public void Run()
        {

            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("_______________________________________");
                Console.WriteLine("             App04   My News           ");
                Console.WriteLine("             by Narinder Kaur          ");
                Console.WriteLine("_______________________________________");
            }
            bool quit = false;
            while (quit == false)
            {
                int choice = ConsoleHelper.SelectChoice(choices);
                Console.ForegroundColor = ConsoleColor.White;
                switch (choice)
                {
                    case 1: AddMessage(); break;
                    case 2: AddPhotos(); break;
                    case 3: PrintPost(); break;
                    case 4: DisplayAll();break;
                    case 5: RemovePost(); break;
                    case 6: AddcommentToPost(); break;
                    case 7: LikePost(); break;
                    case 8: UnlikePost(); break;
                    case 9: quit = true; break; 
                        //quit 
                }
            }


        }

        private void UnlikePost()
        {
            int id = (int)ConsoleHelper.InputNumber("Please enter the Post ID: ");

            NewsFeed.UnlikePost(id);
        }

        private void LikePost()
        {
            int id = (int)ConsoleHelper.InputNumber("Please enter the post ID: ");

            NewsFeed.LikePost(id);
        }

        private void AddcommentToPost()
        {
            int id = (int)ConsoleHelper.InputNumber("Please enter the post ID: ");

            Console.WriteLine("Please enter a comment: ");
            string comment = Console.ReadLine();

            NewsFeed.AddCommentToPost(id, comment);
        }

        private void RemovePost()
        {
            ConsoleHelper.OutputTitle($"Removing a post");

            int id = (int)ConsoleHelper.InputNumber("Please enter the Post ID: ");

            NewsFeed.RemovePost(id);
        }

        private void DisplayAll()
        {
            NewsFeed.Display();
        }

        private void PrintPost()
        {
            NewsFeed.Display();

        }

        private void AddPhotos()
        {
            Console.WriteLine("Enter your Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nEnter the photo Filename: ");
            string Filename = Console.ReadLine();

            Console.WriteLine("\nEnter the Photo Caption: ");
            string Caption = Console.ReadLine();

            PhotoPost photopost = new PhotoPost(name, Filename, Caption);
            NewsFeed.AddPost(photopost);
        }

        private void AddMessage()
        {

            string name = EnterAuthor();

            Console.WriteLine(" Please enter your Message >");
            string message = Console.ReadLine();

            MessagePost post = new MessagePost(name, message);
            NewsFeed.AddPost(post);
        }

        private string EnterAuthor()
        {
            Console.Write("Please enter your name");
            string name = Console.ReadLine();
            return name;
        }
        
        
    }

}
