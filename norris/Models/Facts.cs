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

    }

    public class FactContext : DbContext
    {
        public DbSet<Fact> Facts { get; set; }
    }
}