using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp11._06._22.Entities
{
    public class Product
    {
        public Product()
        {
            Id = new Guid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
