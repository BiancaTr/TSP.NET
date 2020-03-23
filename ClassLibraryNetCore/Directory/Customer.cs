using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public class Customer
    {
        public Customer() { }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}