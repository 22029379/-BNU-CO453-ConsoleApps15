using System;
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


       
        private readonly List<Post> posts;
        private Post photo;

        public List<Post> Posts { get; set; }


        ///<summary>
        /// Construct an empty news feed.
        ///</summary>
        public NewsFeed()
        {
            Posts = new List<Post>();

        }


        ///<summary>
        /// Add a text photo to the news feed.
        /// 
        /// The text photo to be added.
        ///</summary>
        public void AddPhotoPost(PhotoPost post)
        {
            posts.Add(photo);

        }
        public void AddMessagePost(MessagePost message)
        {
            posts.Add(message);
        }
        public void RemovePost(int id)
        {
            Post post = FindPost(id);
            if (post == null)
            {
                Console.WriteLine($"\n post with ID: {id}does not exit");
            }
            else
            {
                Console.WriteLine($"\n The following Post {id} has been removed");
                posts.Remove(post);
            }
        }

        ///<summary>
        /// Show the news feed. Currently: print the news feed details to the
        /// terminal. (To do: replace this later with display in web browser.)
        ///</summary>

        private Post FindPost(int id)
        {
            foreach (Post post in posts)
            {
                if (post.PostID == id)
                {
                    return post;
                }
            }
            return null;
        }

        public void UnlikePost(int id)
        {
            Post post = FindPost(id);
            post.Unlike();
        }

        public void LikePost(int id)
        {
            Post post = FindPost(id);
            post.Like();
        }

        public void AddCommentToPost(int id, string comment)
        {
            Post post = FindPost(id);
            post.AddComment(comment);
        }

        public void Display()
        {
            // display all text posts
            foreach (Post post in Posts)
            {
                post.Display();
                Console.WriteLine();   // empty line between posts
            }


        }

       

        
    }

}
