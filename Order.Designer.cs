﻿namespace LoginScrn
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.lblOrderProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSubTotal = new System.Windows.Forms.TextBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblOrderSubTotal = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.txtOrdetTotal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_Pri = new System.Windows.Forms.TextBox();
            this.btn_OrClear = new System.Windows.Forms.Button();
            this.dateTimePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.btn_OrSave = new System.Windows.Forms.Button();
            this.lbl_OrCusName = new System.Windows.Forms.Label();
            this.txt_OrCusName = new System.Windows.Forms.TextBox();
            this.lbl_OrDiscount = new System.Windows.Forms.Label();
            this.txt_OrDisco = new System.Windows.Forms.TextBox();
            this.btn_OrExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 16;
            this.listBoxProducts.Location = new System.Drawing.Point(315, 102);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(125, 68);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblOrderProductName
            // 
            this.lblOrderProductName.AutoSize = true;
            this.lblOrderProductName.Location = new System.Drawing.Point(192, 102);
            this.lblOrderProductName.Name = "lblOrderProductName";
            this.lblOrderProductName.Size = new System.Drawing.Size(98, 17);
            this.lblOrderProductName.TabIndex = 1;
            this.lblOrderProductName.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // txtBoxSubTotal
            // 
            this.txtBoxSubTotal.Location = new System.Drawing.Point(572, 137);
            this.txtBoxSubTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBoxSubTotal.Name = "txtBoxSubTotal";
            this.txtBoxSubTotal.ReadOnly = true;
            this.txtBoxSubTotal.Size = new System.Drawing.Size(89, 22);
            this.txtBoxSubTotal.TabIndex = 3;
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(572, 102);
            this.numericUpDownQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(89, 22);
            this.numericUpDownQuantity.TabIndex = 4;
            this.numericUpDownQuantity.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // lblOrderSubTotal
            // 
            this.lblOrderSubTotal.AutoSize = true;
            this.lblOrderSubTotal.Location = new System.Drawing.Point(475, 140);
            this.lblOrderSubTotal.Name = "lblOrderSubTotal";
            this.lblOrderSubTotal.Size = new System.Drawing.Size(70, 17);
            this.lblOrderSubTotal.TabIndex = 5;
            this.lblOrderSubTotal.Text = "Sub-Total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(500, 245);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(44, 17);
            this.lblOrderTotal.TabIndex = 7;
            this.lblOrderTotal.Text = "Total ";
            this.lblOrderTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtOrdetTotal
            // 
            this.txtOrdetTotal.Location = new System.Drawing.Point(572, 242);
            this.txtOrdetTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrdetTotal.Name = "txtOrdetTotal";
            this.txtOrdetTotal.ReadOnly = true;
            this.txtOrdetTotal.Size = new System.Drawing.Size(89, 22);
            this.txtOrdetTotal.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 142);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(500, 73);
            this.lbl_Price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(44, 17);
            this.lbl_Price.TabIndex = 11;
            this.lbl_Price.Text = "Price ";
            // 
            // txt_Pri
            // 
            this.txt_Pri.Location = new System.Drawing.Point(572, 64);
            this.txt_Pri.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Pri.Name = "txt_Pri";
            this.txt_Pri.ReadOnly = true;
            this.txt_Pri.Size = new System.Drawing.Size(89, 22);
            this.txt_Pri.TabIndex = 12;
            this.txt_Pri.TextChanged += new System.EventHandler(this.Txt_Pri_TextChanged);
            // 
            // btn_OrClear
            // 
            this.btn_OrClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OrClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrClear.Location = new System.Drawing.Point(329, 336);
            this.btn_OrClear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrClear.Name = "btn_OrClear";
            this.btn_OrClear.Size = new System.Drawing.Size(73, 28);
            this.btn_OrClear.TabIndex = 13;
            this.btn_OrClear.Text = "Clear";
            this.btn_OrClear.UseVisualStyleBackColor = false;
            this.btn_OrClear.Click += new System.EventHandler(this.Btn_OrClear_Click);
            // 
            // dateTimePickerSaleDate
            // 
            this.dateTimePickerSaleDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSaleDate.Location = new System.Drawing.Point(315, 64);
            this.dateTimePickerSaleDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerSaleDate.Name = "dateTimePickerSaleDate";
            this.dateTimePickerSaleDate.Size = new System.Drawing.Size(125, 22);
            this.dateTimePickerSaleDate.TabIndex = 16;
            this.dateTimePickerSaleDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_OrSave
            // 
            this.btn_OrSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OrSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrSave.Location = new System.Drawing.Point(196, 336);
            this.btn_OrSave.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrSave.Name = "btn_OrSave";
            this.btn_OrSave.Size = new System.Drawing.Size(100, 28);
            this.btn_OrSave.TabIndex = 17;
            this.btn_OrSave.Text = "Save";
            this.btn_OrSave.UseVisualStyleBackColor = false;
            this.btn_OrSave.Click += new System.EventHandler(this.Btn_OrSave_Click);
            // 
            // lbl_OrCusName
            // 
            this.lbl_OrCusName.AutoSize = true;
            this.lbl_OrCusName.Location = new System.Drawing.Point(111, 201);
            this.lbl_OrCusName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrCusName.Name = "lbl_OrCusName";
            this.lbl_OrCusName.Size = new System.Drawing.Size(109, 17);
            this.lbl_OrCusName.TabIndex = 18;
            this.lbl_OrCusName.Text = "Customer Name";
            // 
            // txt_OrCusName
            // 
            this.txt_OrCusName.Location = new System.Drawing.Point(228, 192);
            this.txt_OrCusName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OrCusName.Name = "txt_OrCusName";
            this.txt_OrCusName.Size = new System.Drawing.Size(219, 22);
            this.txt_OrCusName.TabIndex = 19;
            // 
            // lbl_OrDiscount
            // 
            this.lbl_OrDiscount.AutoSize = true;
            this.lbl_OrDiscount.Location = new System.Drawing.Point(481, 217);
            this.lbl_OrDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrDiscount.Name = "lbl_OrDiscount";
            this.lbl_OrDiscount.Size = new System.Drawing.Size(63, 17);
            this.lbl_OrDiscount.TabIndex = 20;
            this.lbl_OrDiscount.Text = "Discount";
            // 
            // txt_OrDisco
            // 
            this.txt_OrDisco.Location = new System.Drawing.Point(572, 214);
            this.txt_OrDisco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OrDisco.Name = "txt_OrDisco";
            this.txt_OrDisco.Size = new System.Drawing.Size(89, 22);
            this.txt_OrDisco.TabIndex = 21;
            this.txt_OrDisco.Text = "0";
            // 
            // btn_OrExit
            // 
            this.btn_OrExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OrExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrExit.Location = new System.Drawing.Point(444, 336);
            this.btn_OrExit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_OrExit.Name = "btn_OrExit";
            this.btn_OrExit.Size = new System.Drawing.Size(100, 28);
            this.btn_OrExit.TabIndex = 23;
            this.btn_OrExit.Text = "Exit";
            this.btn_OrExit.UseVisualStyleBackColor = false;
            this.btn_OrExit.Click += new System.EventHandler(this.Btn_OrExit_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(736, 411);
            this.Controls.Add(this.btn_OrExit);
            this.Controls.Add(this.txt_OrDisco);
            this.Controls.Add(this.lbl_OrDiscount);
            this.Controls.Add(this.txt_OrCusName);
            this.Controls.Add(this.lbl_OrCusName);
            this.Controls.Add(this.btn_OrSave);
            this.Controls.Add(this.dateTimePickerSaleDate);
            this.Controls.Add(this.btn_OrClear);
            this.Controls.Add(this.txt_Pri);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOrdetTotal);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.lblOrderSubTotal);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.txtBoxSubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrderProductName);
            this.Controls.Add(this.listBoxProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Label lblOrderProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSubTotal;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Label lblOrderSubTotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.TextBox txtOrdetTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txt_Pri;
        private System.Windows.Forms.Button btn_OrClear;
        private System.Windows.Forms.DateTimePicker dateTimePickerSaleDate;
        private System.Windows.Forms.Button btn_OrSave;
        private System.Windows.Forms.Label lbl_OrCusName;
        private System.Windows.Forms.TextBox txt_OrCusName;
        private System.Windows.Forms.Label lbl_OrDiscount;
        private System.Windows.Forms.TextBox txt_OrDisco;
        private System.Windows.Forms.Button btn_OrExit;
    }
}