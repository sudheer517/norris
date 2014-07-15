using System;
using System.Data.Entity;

namespace norris.Models
{
    public class Fact
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int Views { get; set; }

    }
    public class Discussion
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public int Votes { get; set; }
        public int Views { get; set; }

    }
    public class DiscussionPost
    {
        public int ID { get; set; }
        public int DiscussionID { get; set; }
        public string Text { get; set; }
        public string Author { get; set; }
        public int Votes { get; set; }
        public DateTime Date { get; set; }

    }
    public class FactContext : DbContext
    {
        public DbSet<Fact> Facts { get; set; }
        public DbSet<Discussion> Discussions { get; set; }
        public DbSet<DiscussionPost> DiscussionPosts { get; set; }
    }
}