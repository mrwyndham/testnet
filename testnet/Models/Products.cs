using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testnet.Models
{
    public class Products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public int UnitPrice { get; set; }
        public string AvailableQuantity { get; set; }
    }
}
