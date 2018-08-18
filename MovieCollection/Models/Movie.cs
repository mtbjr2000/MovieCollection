using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }
    }
}