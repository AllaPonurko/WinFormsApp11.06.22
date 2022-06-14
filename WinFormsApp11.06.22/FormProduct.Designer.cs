
namespace WinFormsApp11._06._22
{
    partial class FormProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxList = new System.Windows.Forms.ListBox();
            this.labelListProd = new System.Windows.Forms.Label();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBoxList
            // 
            this.listBoxList.FormattingEnabled = true;
            this.listBoxList.ItemHeight = 15;
            this.listBoxList.Location = new System.Drawing.Point(39, 54);
            this.listBoxList.Name = "listBoxList";
            this.listBoxList.Size = new System.Drawing.Size(120, 274);
            this.listBoxList.TabIndex = 0;
            this.listBoxList.SelectedIndexChanged += new System.EventHandler(this.listBoxList_SelectedIndexChanged);
            // 
            // labelListProd
            // 
            this.labelListProd.AutoSize = true;
            this.labelListProd.Location = new System.Drawing.Point(39, 13);
            this.labelListProd.Name = "labelListProd";
            this.labelListProd.Size = new System.Drawing.Size(75, 15);
            this.labelListProd.TabIndex = 1;
            this.labelListProd.Text = "List Ptoducts";
            // 
            // btnEditProd
            // 
            this.btnEditProd.Location = new System.Drawing.Point(39, 353);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(120, 23);
            this.btnEditProd.TabIndex = 2;
            this.btnEditProd.Text = "Edit product";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(229, 54);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(229, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Product\'s name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(412, 54);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 23);
            this.txtDescription.TabIndex = 5;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(412, 13);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(67, 15);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "Description";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(571, 13);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(33, 15);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(571, 54);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 8;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnEditProd);
            this.Controls.Add(this.labelListProd);
            this.Controls.Add(this.listBoxList);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxList;
        private System.Windows.Forms.Label labelListProd;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}