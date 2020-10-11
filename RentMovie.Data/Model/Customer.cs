using System;
using System.Collections.Generic;
using System.Text;

namespace RentMovie.Data.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsSubscribe { get; set; }
        public Subscription Subscription { get; set; }
    }
}
