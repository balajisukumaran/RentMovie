using System;
using System.Collections.Generic;
using System.Text;

namespace RentMovie.Data.Model
{
    public class CustomerMovie
    {
        public Movie Movie { get; set; }
        public Customer Customer { get; set; }
        public int Quantity { get; set; }

    }
}
