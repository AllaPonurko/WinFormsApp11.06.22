
namespace WinFormsApp11._06._22
{
    partial class FormSale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxListProduct = new System.Windows.Forms.ListBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.listBoxSale = new System.Windows.Forms.ListBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxListProduct
            // 
            this.listBoxListProduct.FormattingEnabled = true;
            this.listBoxListProduct.ItemHeight = 15;
            this.listBoxListProduct.Location = new System.Drawing.Point(34, 36);
            this.listBoxListProduct.Name = "listBoxListProduct";
            this.listBoxListProduct.Size = new System.Drawing.Size(120, 289);
            this.listBoxListProduct.TabIndex = 0;
            this.listBoxListProduct.SelectedIndexChanged += new System.EventHandler(this.listBoxListProduct_SelectedIndexChanged);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Enabled = false;
            this.textBoxPrice.Location = new System.Drawing.Point(231, 54);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrice.TabIndex = 1;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(231, 36);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 15);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // listBoxSale
            // 
            this.listBoxSale.FormattingEnabled = true;
            this.listBoxSale.ItemHeight = 15;
            this.listBoxSale.Location = new System.Drawing.Point(422, 36);
            this.listBoxSale.Name = "listBoxSale";
            this.listBoxSale.Size = new System.Drawing.Size(120, 289);
            this.listBoxSale.TabIndex = 3;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(591, 36);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(57, 15);
            this.labelCost.TabIndex = 4;
            this.labelCost.Text = "Total cost";
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Location = new System.Drawing.Point(591, 53);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.Size = new System.Drawing.Size(100, 23);
            this.textBoxTotalCost.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 361);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(34, 332);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(120, 23);
            this.btnShow.TabIndex = 7;
            this.btnShow.Text = "Show Products";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // FormSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.listBoxSale);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.listBoxListProduct);
            this.Name = "FormSale";
            this.Text = "Sale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListBox listBoxSale;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ListBox listBoxListProduct;
        private System.Windows.Forms.Button btnShow;
    }
}

