namespace LoginScrn
{
    partial class s
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
            this.gbProductInfo = new System.Windows.Forms.GroupBox();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCost = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.btnProductExit = new System.Windows.Forms.Button();
            this.pictureBoxAddProduct = new System.Windows.Forms.PictureBox();
            this.dateTimePickerAddProduct = new System.Windows.Forms.DateTimePicker();
            this.gbProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductInfo
            // 
            this.gbProductInfo.Controls.Add(this.textBoxCost);
            this.gbProductInfo.Controls.Add(this.textBoxProductName);
            this.gbProductInfo.Controls.Add(this.textBoxProductCode);
            this.gbProductInfo.Controls.Add(this.lblProductCost);
            this.gbProductInfo.Controls.Add(this.lblProductName);
            this.gbProductInfo.Controls.Add(this.lblProductCode);
            this.gbProductInfo.Location = new System.Drawing.Point(305, 11);
            this.gbProductInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gbProductInfo.Name = "gbProductInfo";
            this.gbProductInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gbProductInfo.Size = new System.Drawing.Size(217, 213);
            this.gbProductInfo.TabIndex = 0;
            this.gbProductInfo.TabStop = false;
            this.gbProductInfo.Text = "Product Info";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(88, 86);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(116, 20);
            this.textBoxCost.TabIndex = 5;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(88, 54);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(116, 20);
            this.textBoxProductName.TabIndex = 4;
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Location = new System.Drawing.Point(88, 23);
            this.textBoxProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.ReadOnly = true;
            this.textBoxProductCode.Size = new System.Drawing.Size(116, 20);
            this.textBoxProductCode.TabIndex = 3;
            // 
            // lblProductCost
            // 
            this.lblProductCost.AutoSize = true;
            this.lblProductCost.Location = new System.Drawing.Point(4, 90);
            this.lblProductCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCost.Name = "lblProductCost";
            this.lblProductCost.Size = new System.Drawing.Size(68, 13);
            this.lblProductCost.TabIndex = 2;
            this.lblProductCost.Text = "Product Cost";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(4, 61);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(4, 30);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product Code";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(59, 259);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(55, 25);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.Location = new System.Drawing.Point(249, 259);
            this.btnCancelProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(57, 25);
            this.btnCancelProduct.TabIndex = 2;
            this.btnCancelProduct.Text = "Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = true;
            // 
            // btnProductExit
            // 
            this.btnProductExit.Location = new System.Drawing.Point(429, 259);
            this.btnProductExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductExit.Name = "btnProductExit";
            this.btnProductExit.Size = new System.Drawing.Size(57, 25);
            this.btnProductExit.TabIndex = 3;
            this.btnProductExit.Text = "Exit";
            this.btnProductExit.UseVisualStyleBackColor = true;
            this.btnProductExit.Click += new System.EventHandler(this.btnProductExit_Click);
            // 
            // pictureBoxAddProduct
            // 
            this.pictureBoxAddProduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxAddProduct.Location = new System.Drawing.Point(12, 11);
            this.pictureBoxAddProduct.Name = "pictureBoxAddProduct";
            this.pictureBoxAddProduct.Size = new System.Drawing.Size(155, 118);
            this.pictureBoxAddProduct.TabIndex = 4;
            this.pictureBoxAddProduct.TabStop = false;
            // 
            // dateTimePickerAddProduct
            // 
            this.dateTimePickerAddProduct.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerAddProduct.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAddProduct.Location = new System.Drawing.Point(12, 168);
            this.dateTimePickerAddProduct.Name = "dateTimePickerAddProduct";
            this.dateTimePickerAddProduct.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAddProduct.TabIndex = 6;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.dateTimePickerAddProduct);
            this.Controls.Add(this.pictureBoxAddProduct);
            this.Controls.Add(this.btnProductExit);
            this.Controls.Add(this.btnCancelProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.gbProductInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "s";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewProduct";
            this.gbProductInfo.ResumeLayout(false);
            this.gbProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductInfo;
        private System.Windows.Forms.Label lblProductCost;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCancelProduct;
        private System.Windows.Forms.Button btnProductExit;
        private System.Windows.Forms.PictureBox pictureBoxAddProduct;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddProduct;
    }
}