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
            this.lblSalesReportStartDate = new System.Windows.Forms.Label();
            this.lblSalesReportEndDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateSalesReport = new System.Windows.Forms.Button();
            this.btnCancelSalesReport = new System.Windows.Forms.Button();
            this.btnExitSalesReport = new System.Windows.Forms.Button();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(131, 42);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 81);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(195, 20);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // btnGenerateSalesReport
            // 
            this.btnGenerateSalesReport.Location = new System.Drawing.Point(69, 175);
            this.btnGenerateSalesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateSalesReport.Name = "btnGenerateSalesReport";
            this.btnGenerateSalesReport.Size = new System.Drawing.Size(101, 28);
            this.btnGenerateSalesReport.TabIndex = 4;
            this.btnGenerateSalesReport.Text = "Generate Report";
            this.btnGenerateSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnCancelSalesReport
            // 
            this.btnCancelSalesReport.Location = new System.Drawing.Point(233, 175);
            this.btnCancelSalesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelSalesReport.Name = "btnCancelSalesReport";
            this.btnCancelSalesReport.Size = new System.Drawing.Size(63, 28);
            this.btnCancelSalesReport.TabIndex = 5;
            this.btnCancelSalesReport.Text = "Cancel";
            this.btnCancelSalesReport.UseVisualStyleBackColor = true;
            // 
            // btnExitSalesReport
            // 
            this.btnExitSalesReport.Location = new System.Drawing.Point(360, 175);
            this.btnExitSalesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitSalesReport.Name = "btnExitSalesReport";
            this.btnExitSalesReport.Size = new System.Drawing.Size(59, 28);
            this.btnExitSalesReport.TabIndex = 6;
            this.btnExitSalesReport.Text = "Exit";
            this.btnExitSalesReport.UseVisualStyleBackColor = true;
            this.btnExitSalesReport.Click += new System.EventHandler(this.btnExitSalesReport_Click);
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnExitSalesReport);
            this.Controls.Add(this.btnCancelSalesReport);
            this.Controls.Add(this.btnGenerateSalesReport);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSalesReportEndDate);
            this.Controls.Add(this.lblSalesReportStartDate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Sales_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalesReportStartDate;
        private System.Windows.Forms.Label lblSalesReportEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnGenerateSalesReport;
        private System.Windows.Forms.Button btnCancelSalesReport;
        private System.Windows.Forms.Button btnExitSalesReport;
    }
}