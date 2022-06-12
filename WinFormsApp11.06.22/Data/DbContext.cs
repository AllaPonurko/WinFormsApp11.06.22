using System;
using System.Collections.Generic;
using System.Text;
using WinFormsApp11._06._22.Entities;

namespace WinFormsApp11._06._22.Data
{
    public class DbContext
    {public DbContext()
        {
            Products = new List<Product>();
            Seed();
        }

        public List<Product> Products { get; set; }
        public void Seed()
        {
            new Product { Name = "Память", Price = 800.00 };
            Products.Add(new Product());
            new Product { Name = "Жёсткий диск", Price = 3000.00 };
            Products.Add(new Product());
            new Product { Name = "Монитор", Price = 4200.00 };
            Products.Add(new Product());
            new Product { Name = "Мышь", Price = 300.00 };
            Products.Add(new Product());
            new Product { Name = "Твердотельный накопитель", Price = 2500.00 };
            Products.Add(new Product());
            new Product { Name = "Процессор", Price = 4800.00 };
            Products.Add(new Product());
            new Product { Name = "Флэш-память", Price = 250.00 };
            Products.Add(new Product());
            new Product { Name = "Клавиатура", Price = 600.00 };
            Products.Add(new Product());
        }
        
    }
}
