﻿using System;
using System.Collections.Generic;


namespace ConsoleAppProject.App04
{
    ///<summary>
    /// The NewsFeed class stores news posts for the news feed in a social network 
    /// application.
    /// 
    /// Display of the posts is currently simulated by printing the details to the
    /// terminal. (Later, this should display in a browser.)
    /// 
    /// This version does not save the data to disk, and it does not provide any
    /// search or ordering functions.
    ///</summary>
    ///<author>
    ///  Narinder Kaur 
    ///  3 April 2022
    ///  version 0.1
    ///</author> 
    public class NewsFeed
    {
        private MessagePost Messagepost;
        private PhotoPost Photopost;

        public List<MessagePost> Feeds { get; set; }
        public List<PhotoPost> Photos { get; set; }

        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Feeds = new List<MessagePost>();
            Photos = new List<PhotoPost>(); 
        }


        ///<summary>
        /// Add a text post to the news feed.
        /// 
        /// The text post to be added.
        ///</summary>
        public void AddPost(Post post)
        {
            Feeds.Add(Messagepost);
            Photos.Add(Photopost);
        }

        
        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>
        public void Display()
        {
            // display all text posts
            foreach (Post post in Feeds)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }


        }
    }

}
