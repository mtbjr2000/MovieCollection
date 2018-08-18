using System;
using System.Collections.Generic;
using System.Text;

namespace MovieCollection.Data.Entities
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
    }
}
