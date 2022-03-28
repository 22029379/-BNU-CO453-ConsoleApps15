using ConsoleAppProject.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App04
{
    public class NewsApp
    {
        public NewsFeed NewsFeed { get ; set; } = new NewsFeed();

        string[] choices =
        {
            "Add a Message Post",
            "Add a Photo Post",
            "Display All Post",
            "Quit"
        };
    
        public void Run()
        {
            Console.WriteLine("App04 My News");
            Console.ForegroundColor = ConsoleColor.White;
            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
            {
                case 1: AddMessage();break;
                case 2: AddPhotos();break;
                case 3: PrintPost();break;
                case 4: break; //quit 
            }
        }

        private void PrintPost()
        {
            NewsFeed.Display();

        }

        private void AddPhotos()
        {
            throw new NotImplementedException();
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
            string name = Console .ReadLine();  
            return name;
        }
    }
    
}
