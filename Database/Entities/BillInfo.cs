using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class BillInfo
    {
        public int BillId { get; set; }
        public Bill Bill { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }     
    }
}
