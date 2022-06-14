using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp11._06._22.Data;
using WinFormsApp11._06._22.Entities;

namespace WinFormsApp11._06._22
{
    public partial class FormSale : Form
    {/// <summary>
    /// ИНИЦИАЛИЗАЦИЯ ФОРМЫ
    /// </summary>
        public FormSale()
        {
            InitializeComponent();
            listBoxListProduct.Items.Add(new Product() { Name = "Память", Price = 800.00 }.ToStringName());
            listBoxListProduct.Items.Add(new Product() { Name = "Монитор", Price = 4200.00 }.ToStringName());
            listBoxListProduct.Items.Add(new Product() { Name = "Жёсткий диск", Price = 3000.00 }.ToStringName());
            listBoxListProduct.Items.Add(new Product() { Name = "Мышь", Price = 300.00 }.ToStringName());
            listBoxListProduct.Items.Add(new Product() { Name = "Твердотельный накопитель", Price = 2500.00 }.ToStringName());
            listBoxListProduct.Items.Add(new Product() { Name = "Процессор", Price = 4800.00 }.ToStringName());
            listBoxListProduct.Items.Add(new Product() { Name = "Флэш-память", Price = 250.00 }.ToStringName());
            listBoxListProduct.Items.Add(new Product() { Name = "Клавиатура", Price = 600.00 }.ToStringName());
            //    listBoxListProduct.SelectedIndexChanged += listBoxListProduct_SelectedIndexChanged;
        }
        /// <summary>
        /// создаём контекст содержащий данные о комплектующих
        /// </summary>
        DbContext context = new DbContext();
        private void listBoxListProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach(var item in context.Products)
            {
                if (listBoxListProduct.SelectedItem.ToString() == item.Name)
                    textBoxPrice.Text = item.Price.ToString();
                textBoxTotalCost.Text= item.Price.ToString();
            }
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct(this);
            formProduct.Show();
            
        }
        double sum = 0.00;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            listBoxSale.Items.Add(listBoxListProduct.SelectedItem.ToString());
            
            foreach (var item in context.Products)
            {
                if (listBoxListProduct.SelectedItem.ToString() == item.Name)
                    sum += item.Price;
                textBoxTotalCost.Text = sum.ToString();
            }

        }
    }
}
