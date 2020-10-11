using System;
using System.Collections.Generic;
using System.Text;

namespace RentMovie.Data.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public GenreType Genre { get; set; }
        public int Quantity { get; set; }
        public float  Cost { get; set; }
    }
}
