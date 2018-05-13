using System;


namespace Ex2_StackOverflowPost
{
    public class Post
    {
        private string _title {get; set;}
        private string _description {get; set;}
        public readonly DateTime CreatedOn = DateTime.Now;
        private int _upVote = 0;
        private int _downVote = 0;

        public void SetTitle(string title)
        {
            _title = title;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetDescription(string description)
        {
            _description = description;
        }

        public void UpVote()
        {
            _upVote++;
        }

        public void DownVote()
        {
            _downVote++;
        }

        public int VoteTotal()
        {
            return _upVote - _downVote;
        }
        

    }
    class Program
    {
        static void Main(string[] args)
        {
            var post1 = new Post();
            System.Console.WriteLine(post1.CreatedOn);
           post1.SetTitle("Post");
           post1.GetTitle();
            post1.UpVote();
            post1.UpVote();
            post1.DownVote();
            post1.UpVote();
            System.Console.WriteLine(post1.VoteTotal());


        }
    }
}
