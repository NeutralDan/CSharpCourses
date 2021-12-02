using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflowPost
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TimeCreated { get; }
        private int CurrentVotes;

        public Post(string title, string description)
        {
            TimeCreated = DateTime.Now;
            this.Title = title;
            this.Description = description;
        }

        public void UpVote()
        {
            CurrentVotes += 1;
            Console.WriteLine("Current ammount votes on {0} post is {1}", Title, CurrentVotes);
        }

        public void DownVote()
        {
            CurrentVotes -= 1;
            Console.WriteLine("Current ammount votes on {0} post is {1}", Title, CurrentVotes);
        }

        public void Display()
        {
            Console.WriteLine(Title);
            Console.WriteLine(Description);
            Console.WriteLine("Current votes for this post are " + CurrentVotes);
        }
    }
}
