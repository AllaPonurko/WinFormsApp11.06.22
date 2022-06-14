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
            Name = Name;
            Price = Price;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return Price.ToString();
        }
        public string ToStringName()
        {
            return Name;
        }
        public string ToStringDescription()
        {
            return Description;
        }
    }
}
