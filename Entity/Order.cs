using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
    public class Order
    {
        public int ID { get; set; }
        public Product Pid { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }
        public string Address { get; set; }
        public DateTime Time{ get; set; }
        public int Status { get; set; }

    }
}
