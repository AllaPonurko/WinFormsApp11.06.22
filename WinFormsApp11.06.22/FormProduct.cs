using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp11._06._22.Data;

namespace WinFormsApp11._06._22
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        public FormProduct(FormSale sale)
        {
            InitializeComponent();
            for (int i=0;i< sale.listBoxListProduct.Items.Count;i++ )
                listBoxList.Items.Add(sale.listBoxListProduct.Items[i].ToString()) ;
        }

        
        DbContext context = new DbContext();
        private void listBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {foreach(var item in context.Products)
                if(listBoxList.SelectedItem.ToString()==item.Name)
                {
                    txtName.Text = item.Name;
                    txtPrice.Text = item.Price.ToString();
                    txtDescription.Text = item.Description;
                }
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (var item in context.Products)
                if (listBoxList.SelectedItem.ToString() == item.Name)
                {
                    item.Name = txtName.Text;
                    item.Price = Convert.ToDouble(txtPrice.Text);
                    item.Description = txtDescription.Text;
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
