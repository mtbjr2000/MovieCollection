using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.ViewModels
{
    public class MovieViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string Cast { get; set; }
        public string Poster { get; set; }
    }
}
