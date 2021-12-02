using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var Post = new Post("Test Title","blah blah blah");
            Post.UpVote();
            Post.UpVote();
            Post.DownVote();
            Post.UpVote();
            Post.Display();
        }
    }
}
