using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            //listBoxList = sale.listBoxListProduct;
        }

        private void btnEditProd_Click(object sender, EventArgs e)
        {

        }

        private void listBoxList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtName.Text = listBoxList.Items.ToString();
        }
    }
}
