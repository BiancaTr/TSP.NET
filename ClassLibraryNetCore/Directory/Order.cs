using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public class Order
    {

        public int OrderId { get; set; }
        public int TotalValue { get; set; }
        public System.DateTime Date { get; set; }
        public virtual Customer Customer { get; set; }

        public Order()
        {

        }
    }
}