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

        private void btnEditProd_Click(object sender, EventArgs e)
        {

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
    }
}
