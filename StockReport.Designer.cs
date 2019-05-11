namespace LoginScrn
{
    partial class StockReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockReport));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_StockRepStartDate = new System.Windows.Forms.Label();
            this.lbl_StockReportEndDate = new System.Windows.Forms.Label();
            this.btn_StockRepGenRep = new System.Windows.Forms.Button();
            this.btn_StockRepCancel = new System.Windows.Forms.Button();
            this.btn_StockRepExit = new System.Windows.Forms.Button();
            this.gbDisplayStockReport = new System.Windows.Forms.GroupBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDisplayStockReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(181, 91);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // lbl_StockRepStartDate
            // 
            this.lbl_StockRepStartDate.AutoSize = true;
            this.lbl_StockRepStartDate.Location = new System.Drawing.Point(43, 46);
            this.lbl_StockRepStartDate.Name = "lbl_StockRepStartDate";
            this.lbl_StockRepStartDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_StockRepStartDate.TabIndex = 2;
            this.lbl_StockRepStartDate.Text = "Start Date";
            // 
            // lbl_StockReportEndDate
            // 
            this.lbl_StockReportEndDate.AutoSize = true;
            this.lbl_StockReportEndDate.Location = new System.Drawing.Point(46, 91);
            this.lbl_StockReportEndDate.Name = "lbl_StockReportEndDate";
            this.lbl_StockReportEndDate.Size = new System.Drawing.Size(52, 13);
            this.lbl_StockReportEndDate.TabIndex = 3;
            this.lbl_StockReportEndDate.Text = "End Date";
            // 
            // btn_StockRepGenRep
            // 
            this.btn_StockRepGenRep.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_StockRepGenRep.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StockRepGenRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StockRepGenRep.Location = new System.Drawing.Point(46, 279);
            this.btn_StockRepGenRep.Name = "btn_StockRepGenRep";
            this.btn_StockRepGenRep.Size = new System.Drawing.Size(121, 23);
            this.btn_StockRepGenRep.TabIndex = 4;
            this.btn_StockRepGenRep.Text = "Generate Report";
            this.btn_StockRepGenRep.UseVisualStyleBackColor = false;
            // 
            // btn_StockRepCancel
            // 
            this.btn_StockRepCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_StockRepCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StockRepCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StockRepCancel.Location = new System.Drawing.Point(216, 279);
            this.btn_StockRepCancel.Name = "btn_StockRepCancel";
            this.btn_StockRepCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_StockRepCancel.TabIndex = 5;
            this.btn_StockRepCancel.Text = "Cancel";
            this.btn_StockRepCancel.UseVisualStyleBackColor = false;
            // 
            // btn_StockRepExit
            // 
            this.btn_StockRepExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_StockRepExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StockRepExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StockRepExit.Location = new System.Drawing.Point(346, 279);
            this.btn_StockRepExit.Name = "btn_StockRepExit";
            this.btn_StockRepExit.Size = new System.Drawing.Size(75, 23);
            this.btn_StockRepExit.TabIndex = 6;
            this.btn_StockRepExit.Text = "Exit ";
            this.btn_StockRepExit.UseVisualStyleBackColor = false;
            this.btn_StockRepExit.Click += new System.EventHandler(this.Btn_StockRepExit_Click);
            // 
            // gbDisplayStockReport
            // 
            this.gbDisplayStockReport.BackColor = System.Drawing.Color.LightGray;
            this.gbDisplayStockReport.Controls.Add(this.txtItemName);
            this.gbDisplayStockReport.Controls.Add(this.txtItemAmount);
            this.gbDisplayStockReport.Controls.Add(this.label2);
            this.gbDisplayStockReport.Controls.Add(this.label1);
            this.gbDisplayStockReport.Location = new System.Drawing.Point(46, 144);
            this.gbDisplayStockReport.Name = "gbDisplayStockReport";
            this.gbDisplayStockReport.Size = new System.Drawing.Size(375, 100);
            this.gbDisplayStockReport.TabIndex = 7;
            this.gbDisplayStockReport.TabStop = false;
            this.gbDisplayStockReport.Text = "Display";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(170, 60);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 3;
            // 
            // txtItemAmount
            // 
            this.txtItemAmount.Location = new System.Drawing.Point(21, 60);
            this.txtItemAmount.Name = "txtItemAmount";
            this.txtItemAmount.Size = new System.Drawing.Size(100, 20);
            this.txtItemAmount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Amount";
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(554, 334);
            this.Controls.Add(this.gbDisplayStockReport);
            this.Controls.Add(this.btn_StockRepExit);
            this.Controls.Add(this.btn_StockRepCancel);
            this.Controls.Add(this.btn_StockRepGenRep);
            this.Controls.Add(this.lbl_StockReportEndDate);
            this.Controls.Add(this.lbl_StockRepStartDate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockReport";
            this.gbDisplayStockReport.ResumeLayout(false);
            this.gbDisplayStockReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbl_StockRepStartDate;
        private System.Windows.Forms.Label lbl_StockReportEndDate;
        private System.Windows.Forms.Button btn_StockRepGenRep;
        private System.Windows.Forms.Button btn_StockRepCancel;
        private System.Windows.Forms.Button btn_StockRepExit;
        private System.Windows.Forms.GroupBox gbDisplayStockReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemAmount;
    }
}