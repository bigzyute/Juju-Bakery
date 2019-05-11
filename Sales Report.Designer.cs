namespace LoginScrn
{
    partial class Sales_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Report));
            this.lblSalesReportStartDate = new System.Windows.Forms.Label();
            this.lblSalesReportEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerSR = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2SR = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateSalesReport = new System.Windows.Forms.Button();
            this.btnCancelSalesReport = new System.Windows.Forms.Button();
            this.btnExitSalesReport = new System.Windows.Forms.Button();
            this.gbSRDisplay = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNumSalesDisp = new System.Windows.Forms.TextBox();
            this.lblItemsSold = new System.Windows.Forms.Label();
            this.lblNumSales = new System.Windows.Forms.Label();
            this.gbSRDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSalesReportStartDate
            // 
            this.lblSalesReportStartDate.AutoSize = true;
            this.lblSalesReportStartDate.Location = new System.Drawing.Point(41, 42);
            this.lblSalesReportStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesReportStartDate.Name = "lblSalesReportStartDate";
            this.lblSalesReportStartDate.Size = new System.Drawing.Size(55, 13);
            this.lblSalesReportStartDate.TabIndex = 0;
            this.lblSalesReportStartDate.Text = "Start Date";
            // 
            // lblSalesReportEndDate
            // 
            this.lblSalesReportEndDate.AutoSize = true;
            this.lblSalesReportEndDate.Location = new System.Drawing.Point(41, 84);
            this.lblSalesReportEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalesReportEndDate.Name = "lblSalesReportEndDate";
            this.lblSalesReportEndDate.Size = new System.Drawing.Size(52, 13);
            this.lblSalesReportEndDate.TabIndex = 1;
            this.lblSalesReportEndDate.Text = "End Date";
            // 
            // dateTimePickerSR
            // 
            this.dateTimePickerSR.Location = new System.Drawing.Point(131, 42);
            this.dateTimePickerSR.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerSR.Name = "dateTimePickerSR";
            this.dateTimePickerSR.Size = new System.Drawing.Size(195, 20);
            this.dateTimePickerSR.TabIndex = 2;
            // 
            // dateTimePicker2SR
            // 
            this.dateTimePicker2SR.Location = new System.Drawing.Point(131, 81);
            this.dateTimePicker2SR.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2SR.Name = "dateTimePicker2SR";
            this.dateTimePicker2SR.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker2SR.TabIndex = 3;
            // 
            // btnGenerateSalesReport
            // 
            this.btnGenerateSalesReport.Location = new System.Drawing.Point(66, 253);
            this.btnGenerateSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateSalesReport.Name = "btnGenerateSalesReport";
            this.btnGenerateSalesReport.Size = new System.Drawing.Size(101, 28);
            this.btnGenerateSalesReport.TabIndex = 4;
            this.btnGenerateSalesReport.Text = "Generate Report";
            this.btnGenerateSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnCancelSalesReport
            // 
            this.btnCancelSalesReport.Location = new System.Drawing.Point(235, 253);
            this.btnCancelSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelSalesReport.Name = "btnCancelSalesReport";
            this.btnCancelSalesReport.Size = new System.Drawing.Size(63, 28);
            this.btnCancelSalesReport.TabIndex = 5;
            this.btnCancelSalesReport.Text = "Cancel";
            this.btnCancelSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnExitSalesReport
            // 
            this.btnExitSalesReport.Location = new System.Drawing.Point(367, 253);
            this.btnExitSalesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnExitSalesReport.Name = "btnExitSalesReport";
            this.btnExitSalesReport.Size = new System.Drawing.Size(59, 28);
            this.btnExitSalesReport.TabIndex = 6;
            this.btnExitSalesReport.Text = "Exit";
            this.btnExitSalesReport.UseVisualStyleBackColor = true;
            this.btnExitSalesReport.Click += new System.EventHandler(this.btnExitSalesReport_Click);
            // 
            // gbSRDisplay
            // 
            this.gbSRDisplay.Controls.Add(this.textBox1);
            this.gbSRDisplay.Controls.Add(this.txtNumSalesDisp);
            this.gbSRDisplay.Controls.Add(this.lblItemsSold);
            this.gbSRDisplay.Controls.Add(this.lblNumSales);
            this.gbSRDisplay.Location = new System.Drawing.Point(44, 128);
            this.gbSRDisplay.Name = "gbSRDisplay";
            this.gbSRDisplay.Size = new System.Drawing.Size(382, 100);
            this.gbSRDisplay.TabIndex = 7;
            this.gbSRDisplay.TabStop = false;
            this.gbSRDisplay.Text = "Display";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(157, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtNumSalesDisp
            // 
            this.txtNumSalesDisp.Location = new System.Drawing.Point(17, 57);
            this.txtNumSalesDisp.Name = "txtNumSalesDisp";
            this.txtNumSalesDisp.Size = new System.Drawing.Size(82, 20);
            this.txtNumSalesDisp.TabIndex = 3;
            // 
            // lblItemsSold
            // 
            this.lblItemsSold.AutoSize = true;
            this.lblItemsSold.Location = new System.Drawing.Point(154, 26);
            this.lblItemsSold.Name = "lblItemsSold";
            this.lblItemsSold.Size = new System.Drawing.Size(56, 13);
            this.lblItemsSold.TabIndex = 2;
            this.lblItemsSold.Text = "Items Sold";
            // 
            // lblNumSales
            // 
            this.lblNumSales.AutoSize = true;
            this.lblNumSales.Location = new System.Drawing.Point(14, 26);
            this.lblNumSales.Name = "lblNumSales";
            this.lblNumSales.Size = new System.Drawing.Size(85, 13);
            this.lblNumSales.TabIndex = 0;
            this.lblNumSales.Text = "Number of Sales";
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.gbSRDisplay);
            this.Controls.Add(this.btnExitSalesReport);
            this.Controls.Add(this.btnCancelSalesReport);
            this.Controls.Add(this.btnGenerateSalesReport);
            this.Controls.Add(this.dateTimePicker2SR);
            this.Controls.Add(this.dateTimePickerSR);
            this.Controls.Add(this.lblSalesReportEndDate);
            this.Controls.Add(this.lblSalesReportStartDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Sales_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Report";
            this.gbSRDisplay.ResumeLayout(false);
            this.gbSRDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesReportStartDate;
        private System.Windows.Forms.Label lblSalesReportEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerSR;
        private System.Windows.Forms.DateTimePicker dateTimePicker2SR;
        private System.Windows.Forms.Button btnGenerateSalesReport;
        private System.Windows.Forms.Button btnCancelSalesReport;
        private System.Windows.Forms.Button btnExitSalesReport;
        private System.Windows.Forms.GroupBox gbSRDisplay;
        private System.Windows.Forms.Label lblItemsSold;
        private System.Windows.Forms.Label lblNumSales;
        private System.Windows.Forms.TextBox txtNumSalesDisp;
        private System.Windows.Forms.TextBox textBox1;
    }
}