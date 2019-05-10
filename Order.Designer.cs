namespace LoginScrn
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblOrderProductName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderQuantity = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblOrderSubTotal = new System.Windows.Forms.Label();
            this.lblOrderGct = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.txtOrderGct = new System.Windows.Forms.TextBox();
            this.txtOrdetTotal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_Pri = new System.Windows.Forms.TextBox();
            this.btn_OrClear = new System.Windows.Forms.Button();
            this.txt_OrderNo = new System.Windows.Forms.TextBox();
            this.lbl_OrderNo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_OrSave = new System.Windows.Forms.Button();
            this.lbl_OrCusName = new System.Windows.Forms.Label();
            this.txt_OrCusName = new System.Windows.Forms.TextBox();
            this.lbl_OrDiscount = new System.Windows.Forms.Label();
            this.txt_OrDisco = new System.Windows.Forms.TextBox();
            this.btn_OrderClear = new System.Windows.Forms.Button();
            this.btn_OrExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Banana Bread",
            "Plantain Tarts",
            "Cheese Cake"});
            this.listBox1.Location = new System.Drawing.Point(315, 102);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(125, 68);
            this.listBox1.TabIndex = 0;
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
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.Location = new System.Drawing.Point(572, 137);
            this.lblOrderQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.ReadOnly = true;
            this.lblOrderQuantity.Size = new System.Drawing.Size(89, 22);
            this.lblOrderQuantity.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(572, 102);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 22);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
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
            // lblOrderGct
            // 
            this.lblOrderGct.AutoSize = true;
            this.lblOrderGct.Location = new System.Drawing.Point(499, 228);
            this.lblOrderGct.Name = "lblOrderGct";
            this.lblOrderGct.Size = new System.Drawing.Size(45, 17);
            this.lblOrderGct.TabIndex = 6;
            this.lblOrderGct.Text = "G.C.T";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(500, 282);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(44, 17);
            this.lblOrderTotal.TabIndex = 7;
            this.lblOrderTotal.Text = "Total ";
            this.lblOrderTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtOrderGct
            // 
            this.txtOrderGct.Location = new System.Drawing.Point(572, 223);
            this.txtOrderGct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrderGct.Name = "txtOrderGct";
            this.txtOrderGct.ReadOnly = true;
            this.txtOrderGct.Size = new System.Drawing.Size(89, 22);
            this.txtOrderGct.TabIndex = 8;
            // 
            // txtOrdetTotal
            // 
            this.txtOrdetTotal.Location = new System.Drawing.Point(572, 279);
            this.txtOrdetTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOrdetTotal.Name = "txtOrdetTotal";
            this.txtOrdetTotal.ReadOnly = true;
            this.txtOrdetTotal.Size = new System.Drawing.Size(89, 22);
            this.txtOrdetTotal.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 140);
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
            this.txt_Pri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Pri.Name = "txt_Pri";
            this.txt_Pri.Size = new System.Drawing.Size(89, 22);
            this.txt_Pri.TabIndex = 12;
            this.txt_Pri.TextChanged += new System.EventHandler(this.Txt_Pri_TextChanged);
            // 
            // btn_OrClear
            // 
            this.btn_OrClear.Location = new System.Drawing.Point(329, 336);
            this.btn_OrClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OrClear.Name = "btn_OrClear";
            this.btn_OrClear.Size = new System.Drawing.Size(73, 28);
            this.btn_OrClear.TabIndex = 13;
            this.btn_OrClear.Text = "Clear";
            this.btn_OrClear.UseVisualStyleBackColor = true;
            this.btn_OrClear.Click += new System.EventHandler(this.Btn_OrClear_Click);
            // 
            // txt_OrderNo
            // 
            this.txt_OrderNo.Location = new System.Drawing.Point(329, 15);
            this.txt_OrderNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_OrderNo.Name = "txt_OrderNo";
            this.txt_OrderNo.ReadOnly = true;
            this.txt_OrderNo.Size = new System.Drawing.Size(64, 22);
            this.txt_OrderNo.TabIndex = 14;
            // 
            // lbl_OrderNo
            // 
            this.lbl_OrderNo.AutoSize = true;
            this.lbl_OrderNo.Location = new System.Drawing.Point(243, 25);
            this.lbl_OrderNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrderNo.Name = "lbl_OrderNo";
            this.lbl_OrderNo.Size = new System.Drawing.Size(67, 17);
            this.lbl_OrderNo.TabIndex = 15;
            this.lbl_OrderNo.Text = "OrderNo.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 48);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // btn_OrSave
            // 
            this.btn_OrSave.Location = new System.Drawing.Point(196, 336);
            this.btn_OrSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OrSave.Name = "btn_OrSave";
            this.btn_OrSave.Size = new System.Drawing.Size(100, 28);
            this.btn_OrSave.TabIndex = 17;
            this.btn_OrSave.Text = "Save";
            this.btn_OrSave.UseVisualStyleBackColor = true;
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
            this.txt_OrCusName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_OrCusName.Name = "txt_OrCusName";
            this.txt_OrCusName.Size = new System.Drawing.Size(219, 22);
            this.txt_OrCusName.TabIndex = 19;
            // 
            // lbl_OrDiscount
            // 
            this.lbl_OrDiscount.AutoSize = true;
            this.lbl_OrDiscount.Location = new System.Drawing.Point(481, 254);
            this.lbl_OrDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_OrDiscount.Name = "lbl_OrDiscount";
            this.lbl_OrDiscount.Size = new System.Drawing.Size(63, 17);
            this.lbl_OrDiscount.TabIndex = 20;
            this.lbl_OrDiscount.Text = "Discount";
            // 
            // txt_OrDisco
            // 
            this.txt_OrDisco.Location = new System.Drawing.Point(572, 251);
            this.txt_OrDisco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_OrDisco.Name = "txt_OrDisco";
            this.txt_OrDisco.Size = new System.Drawing.Size(89, 22);
            this.txt_OrDisco.TabIndex = 21;
            // 
            // btn_OrderClear
            // 
            this.btn_OrderClear.Location = new System.Drawing.Point(605, 176);
            this.btn_OrderClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OrderClear.Name = "btn_OrderClear";
            this.btn_OrderClear.Size = new System.Drawing.Size(56, 28);
            this.btn_OrderClear.TabIndex = 22;
            this.btn_OrderClear.Text = "Clear";
            this.btn_OrderClear.UseVisualStyleBackColor = true;
            this.btn_OrderClear.Click += new System.EventHandler(this.Btn_OrderClear_Click);
            // 
            // btn_OrExit
            // 
            this.btn_OrExit.Location = new System.Drawing.Point(444, 336);
            this.btn_OrExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_OrExit.Name = "btn_OrExit";
            this.btn_OrExit.Size = new System.Drawing.Size(100, 28);
            this.btn_OrExit.TabIndex = 23;
            this.btn_OrExit.Text = "Exit";
            this.btn_OrExit.UseVisualStyleBackColor = true;
            this.btn_OrExit.Click += new System.EventHandler(this.Btn_OrExit_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 411);
            this.Controls.Add(this.btn_OrExit);
            this.Controls.Add(this.btn_OrderClear);
            this.Controls.Add(this.txt_OrDisco);
            this.Controls.Add(this.lbl_OrDiscount);
            this.Controls.Add(this.txt_OrCusName);
            this.Controls.Add(this.lbl_OrCusName);
            this.Controls.Add(this.btn_OrSave);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_OrderNo);
            this.Controls.Add(this.txt_OrderNo);
            this.Controls.Add(this.btn_OrClear);
            this.Controls.Add(this.txt_Pri);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtOrdetTotal);
            this.Controls.Add(this.txtOrderGct);
            this.Controls.Add(this.lblOrderTotal);
            this.Controls.Add(this.lblOrderGct);
            this.Controls.Add(this.lblOrderSubTotal);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblOrderQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOrderProductName);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblOrderProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblOrderQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lblOrderSubTotal;
        private System.Windows.Forms.Label lblOrderGct;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.TextBox txtOrderGct;
        private System.Windows.Forms.TextBox txtOrdetTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txt_Pri;
        private System.Windows.Forms.Button btn_OrClear;
        private System.Windows.Forms.TextBox txt_OrderNo;
        private System.Windows.Forms.Label lbl_OrderNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_OrSave;
        private System.Windows.Forms.Label lbl_OrCusName;
        private System.Windows.Forms.TextBox txt_OrCusName;
        private System.Windows.Forms.Label lbl_OrDiscount;
        private System.Windows.Forms.TextBox txt_OrDisco;
        private System.Windows.Forms.Button btn_OrderClear;
        private System.Windows.Forms.Button btn_OrExit;
    }
}