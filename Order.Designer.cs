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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            this.listBoxProducts = new System.Windows.Forms.ListBox();
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
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.Items.AddRange(new object[] {
            "Banana Bread",
            "Plantain Tarts",
            "Cheese Cake"});
            this.listBoxProducts.Location = new System.Drawing.Point(236, 83);
            this.listBoxProducts.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(95, 56);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblOrderProductName
            // 
            this.lblOrderProductName.AutoSize = true;
            this.lblOrderProductName.Location = new System.Drawing.Point(144, 83);
            this.lblOrderProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderProductName.Name = "lblOrderProductName";
            this.lblOrderProductName.Size = new System.Drawing.Size(75, 13);
            this.lblOrderProductName.TabIndex = 1;
            this.lblOrderProductName.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // lblOrderQuantity
            // 
            this.lblOrderQuantity.Location = new System.Drawing.Point(429, 111);
            this.lblOrderQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.lblOrderQuantity.Name = "lblOrderQuantity";
            this.lblOrderQuantity.ReadOnly = true;
            this.lblOrderQuantity.Size = new System.Drawing.Size(68, 20);
            this.lblOrderQuantity.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(429, 83);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(67, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // lblOrderSubTotal
            // 
            this.lblOrderSubTotal.AutoSize = true;
            this.lblOrderSubTotal.Location = new System.Drawing.Point(356, 114);
            this.lblOrderSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderSubTotal.Name = "lblOrderSubTotal";
            this.lblOrderSubTotal.Size = new System.Drawing.Size(53, 13);
            this.lblOrderSubTotal.TabIndex = 5;
            this.lblOrderSubTotal.Text = "Sub-Total";
            // 
            // lblOrderGct
            // 
            this.lblOrderGct.AutoSize = true;
            this.lblOrderGct.Location = new System.Drawing.Point(374, 185);
            this.lblOrderGct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderGct.Name = "lblOrderGct";
            this.lblOrderGct.Size = new System.Drawing.Size(35, 13);
            this.lblOrderGct.TabIndex = 6;
            this.lblOrderGct.Text = "G.C.T";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.AutoSize = true;
            this.lblOrderTotal.Location = new System.Drawing.Point(375, 229);
            this.lblOrderTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(34, 13);
            this.lblOrderTotal.TabIndex = 7;
            this.lblOrderTotal.Text = "Total ";
            this.lblOrderTotal.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtOrderGct
            // 
            this.txtOrderGct.Location = new System.Drawing.Point(429, 181);
            this.txtOrderGct.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrderGct.Name = "txtOrderGct";
            this.txtOrderGct.ReadOnly = true;
            this.txtOrderGct.Size = new System.Drawing.Size(68, 20);
            this.txtOrderGct.TabIndex = 8;
            // 
            // txtOrdetTotal
            // 
            this.txtOrdetTotal.Location = new System.Drawing.Point(429, 227);
            this.txtOrdetTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrdetTotal.Name = "txtOrdetTotal";
            this.txtOrdetTotal.ReadOnly = true;
            this.txtOrdetTotal.Size = new System.Drawing.Size(68, 20);
            this.txtOrdetTotal.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 126);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Location = new System.Drawing.Point(375, 59);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(34, 13);
            this.lbl_Price.TabIndex = 11;
            this.lbl_Price.Text = "Price ";
            // 
            // txt_Pri
            // 
            this.txt_Pri.Location = new System.Drawing.Point(429, 52);
            this.txt_Pri.Name = "txt_Pri";
            this.txt_Pri.Size = new System.Drawing.Size(68, 20);
            this.txt_Pri.TabIndex = 12;
            this.txt_Pri.TextChanged += new System.EventHandler(this.Txt_Pri_TextChanged);
            // 
            // btn_OrClear
            // 
            this.btn_OrClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OrClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrClear.Location = new System.Drawing.Point(247, 273);
            this.btn_OrClear.Name = "btn_OrClear";
            this.btn_OrClear.Size = new System.Drawing.Size(55, 23);
            this.btn_OrClear.TabIndex = 13;
            this.btn_OrClear.Text = "Clear";
            this.btn_OrClear.UseVisualStyleBackColor = false;
            this.btn_OrClear.Click += new System.EventHandler(this.Btn_OrClear_Click);
            // 
            // txt_OrderNo
            // 
            this.txt_OrderNo.Location = new System.Drawing.Point(247, 12);
            this.txt_OrderNo.Name = "txt_OrderNo";
            this.txt_OrderNo.ReadOnly = true;
            this.txt_OrderNo.Size = new System.Drawing.Size(49, 20);
            this.txt_OrderNo.TabIndex = 14;
            // 
            // lbl_OrderNo
            // 
            this.lbl_OrderNo.AutoSize = true;
            this.lbl_OrderNo.Location = new System.Drawing.Point(182, 20);
            this.lbl_OrderNo.Name = "lbl_OrderNo";
            this.lbl_OrderNo.Size = new System.Drawing.Size(50, 13);
            this.lbl_OrderNo.TabIndex = 15;
            this.lbl_OrderNo.Text = "OrderNo.";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(160, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btn_OrSave
            // 
            this.btn_OrSave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OrSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrSave.Location = new System.Drawing.Point(147, 273);
            this.btn_OrSave.Name = "btn_OrSave";
            this.btn_OrSave.Size = new System.Drawing.Size(75, 23);
            this.btn_OrSave.TabIndex = 17;
            this.btn_OrSave.Text = "Save";
            this.btn_OrSave.UseVisualStyleBackColor = false;
            this.btn_OrSave.Click += new System.EventHandler(this.Btn_OrSave_Click);
            // 
            // lbl_OrCusName
            // 
            this.lbl_OrCusName.AutoSize = true;
            this.lbl_OrCusName.Location = new System.Drawing.Point(83, 163);
            this.lbl_OrCusName.Name = "lbl_OrCusName";
            this.lbl_OrCusName.Size = new System.Drawing.Size(82, 13);
            this.lbl_OrCusName.TabIndex = 18;
            this.lbl_OrCusName.Text = "Customer Name";
            // 
            // txt_OrCusName
            // 
            this.txt_OrCusName.Location = new System.Drawing.Point(171, 156);
            this.txt_OrCusName.Name = "txt_OrCusName";
            this.txt_OrCusName.Size = new System.Drawing.Size(165, 20);
            this.txt_OrCusName.TabIndex = 19;
            // 
            // lbl_OrDiscount
            // 
            this.lbl_OrDiscount.AutoSize = true;
            this.lbl_OrDiscount.Location = new System.Drawing.Point(361, 206);
            this.lbl_OrDiscount.Name = "lbl_OrDiscount";
            this.lbl_OrDiscount.Size = new System.Drawing.Size(49, 13);
            this.lbl_OrDiscount.TabIndex = 20;
            this.lbl_OrDiscount.Text = "Discount";
            // 
            // txt_OrDisco
            // 
            this.txt_OrDisco.Location = new System.Drawing.Point(429, 204);
            this.txt_OrDisco.Name = "txt_OrDisco";
            this.txt_OrDisco.Size = new System.Drawing.Size(68, 20);
            this.txt_OrDisco.TabIndex = 21;
            // 
            // btn_OrderClear
            // 
            this.btn_OrderClear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OrderClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrderClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrderClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_OrderClear.Location = new System.Drawing.Point(441, 143);
            this.btn_OrderClear.Name = "btn_OrderClear";
            this.btn_OrderClear.Size = new System.Drawing.Size(55, 23);
            this.btn_OrderClear.TabIndex = 22;
            this.btn_OrderClear.Text = "Clear";
            this.btn_OrderClear.UseVisualStyleBackColor = false;
            this.btn_OrderClear.Click += new System.EventHandler(this.Btn_OrderClear_Click);
            // 
            // btn_OrExit
            // 
            this.btn_OrExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_OrExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_OrExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OrExit.Location = new System.Drawing.Point(333, 273);
            this.btn_OrExit.Name = "btn_OrExit";
            this.btn_OrExit.Size = new System.Drawing.Size(75, 23);
            this.btn_OrExit.TabIndex = 23;
            this.btn_OrExit.Text = "Exit";
            this.btn_OrExit.UseVisualStyleBackColor = false;
            this.btn_OrExit.Click += new System.EventHandler(this.Btn_OrExit_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(552, 334);
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
            this.Controls.Add(this.listBoxProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProducts;
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