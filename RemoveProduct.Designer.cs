namespace LoginScrn
{
    partial class RemoveProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveProduct));
            this.lblRPTitle = new System.Windows.Forms.Label();
            this.lblRemoveProductCode = new System.Windows.Forms.Label();
            this.txt_removeProductCode = new System.Windows.Forms.TextBox();
            this.txt_removeProductResult = new System.Windows.Forms.TextBox();
            this.btnRemoveProductSearch = new System.Windows.Forms.Button();
            this.lblRemoveProductResult = new System.Windows.Forms.Label();
            this.btnRemoveProductDelete = new System.Windows.Forms.Button();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnRemoveProductExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRPTitle
            // 
            this.lblRPTitle.AutoSize = true;
            this.lblRPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRPTitle.Location = new System.Drawing.Point(153, 21);
            this.lblRPTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRPTitle.Name = "lblRPTitle";
            this.lblRPTitle.Size = new System.Drawing.Size(250, 20);
            this.lblRPTitle.TabIndex = 0;
            this.lblRPTitle.Text = "Enter Product Code to Search";
            // 
            // lblRemoveProductCode
            // 
            this.lblRemoveProductCode.AutoSize = true;
            this.lblRemoveProductCode.Location = new System.Drawing.Point(36, 85);
            this.lblRemoveProductCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveProductCode.Name = "lblRemoveProductCode";
            this.lblRemoveProductCode.Size = new System.Drawing.Size(72, 13);
            this.lblRemoveProductCode.TabIndex = 1;
            this.lblRemoveProductCode.Text = "Product Code";
            // 
            // txt_removeProductCode
            // 
            this.txt_removeProductCode.Location = new System.Drawing.Point(141, 83);
            this.txt_removeProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.txt_removeProductCode.Name = "txt_removeProductCode";
            this.txt_removeProductCode.Size = new System.Drawing.Size(156, 20);
            this.txt_removeProductCode.TabIndex = 2;
            // 
            // txt_removeProductResult
            // 
            this.txt_removeProductResult.Location = new System.Drawing.Point(141, 135);
            this.txt_removeProductResult.Margin = new System.Windows.Forms.Padding(2);
            this.txt_removeProductResult.Name = "txt_removeProductResult";
            this.txt_removeProductResult.ReadOnly = true;
            this.txt_removeProductResult.Size = new System.Drawing.Size(156, 20);
            this.txt_removeProductResult.TabIndex = 3;
            // 
            // btnRemoveProductSearch
            // 
            this.btnRemoveProductSearch.Location = new System.Drawing.Point(340, 80);
            this.btnRemoveProductSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProductSearch.Name = "btnRemoveProductSearch";
            this.btnRemoveProductSearch.Size = new System.Drawing.Size(62, 24);
            this.btnRemoveProductSearch.TabIndex = 5;
            this.btnRemoveProductSearch.Text = "&Search";
            this.btnRemoveProductSearch.UseVisualStyleBackColor = true;
            this.btnRemoveProductSearch.Click += new System.EventHandler(this.BtnRemoveProductSearch_Click);
            // 
            // lblRemoveProductResult
            // 
            this.lblRemoveProductResult.AutoSize = true;
            this.lblRemoveProductResult.Location = new System.Drawing.Point(36, 139);
            this.lblRemoveProductResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemoveProductResult.Name = "lblRemoveProductResult";
            this.lblRemoveProductResult.Size = new System.Drawing.Size(37, 13);
            this.lblRemoveProductResult.TabIndex = 6;
            this.lblRemoveProductResult.Text = "Result";
            // 
            // btnRemoveProductDelete
            // 
            this.btnRemoveProductDelete.Location = new System.Drawing.Point(340, 132);
            this.btnRemoveProductDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProductDelete.Name = "btnRemoveProductDelete";
            this.btnRemoveProductDelete.Size = new System.Drawing.Size(62, 24);
            this.btnRemoveProductDelete.TabIndex = 7;
            this.btnRemoveProductDelete.Text = "&Clear";
            this.btnRemoveProductDelete.UseVisualStyleBackColor = true;
            this.btnRemoveProductDelete.Click += new System.EventHandler(this.BtnRemoveProductDelete_Click);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Location = new System.Drawing.Point(80, 226);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(167, 27);
            this.btnRemoveProduct.TabIndex = 8;
            this.btnRemoveProduct.Text = "&Remove Product";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.BtnRemoveProduct_Click);
            // 
            // btnRemoveProductExit
            // 
            this.btnRemoveProductExit.Location = new System.Drawing.Point(293, 226);
            this.btnRemoveProductExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProductExit.Name = "btnRemoveProductExit";
            this.btnRemoveProductExit.Size = new System.Drawing.Size(142, 27);
            this.btnRemoveProductExit.TabIndex = 10;
            this.btnRemoveProductExit.Text = "E&xit";
            this.btnRemoveProductExit.UseVisualStyleBackColor = true;
            this.btnRemoveProductExit.Click += new System.EventHandler(this.btnRemoveProductExit_Click);
            // 
            // RemoveProduct
            // 
            this.AcceptButton = this.btnRemoveProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 298);
            this.Controls.Add(this.btnRemoveProductExit);
            this.Controls.Add(this.btnRemoveProduct);
            this.Controls.Add(this.btnRemoveProductDelete);
            this.Controls.Add(this.lblRemoveProductResult);
            this.Controls.Add(this.btnRemoveProductSearch);
            this.Controls.Add(this.txt_removeProductResult);
            this.Controls.Add(this.txt_removeProductCode);
            this.Controls.Add(this.lblRemoveProductCode);
            this.Controls.Add(this.lblRPTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RemoveProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRPTitle;
        private System.Windows.Forms.Label lblRemoveProductCode;
        private System.Windows.Forms.TextBox txt_removeProductCode;
        private System.Windows.Forms.TextBox txt_removeProductResult;
        private System.Windows.Forms.Button btnRemoveProductSearch;
        private System.Windows.Forms.Label lblRemoveProductResult;
        private System.Windows.Forms.Button btnRemoveProductDelete;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnRemoveProductExit;
    }
}