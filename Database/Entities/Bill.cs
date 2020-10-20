using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Bill
    {
        public int Id { get; set; }      
        public int Quantity { get; set; }
        public DateTime DateCreated { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
