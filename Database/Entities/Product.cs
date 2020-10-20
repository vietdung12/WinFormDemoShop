using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductBill> ProductsBills { get; set; }
    }
}
