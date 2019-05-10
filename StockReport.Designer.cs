﻿namespace LoginScrn
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_StockRepStartDate = new System.Windows.Forms.Label();
            this.lbl_StockReportEndDate = new System.Windows.Forms.Label();
            this.btn_StockRepGenRep = new System.Windows.Forms.Button();
            this.btn_StockRepCancel = new System.Windows.Forms.Button();
            this.btn_StockRepExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 77);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(181, 134);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // lbl_StockRepStartDate
            // 
            this.lbl_StockRepStartDate.AutoSize = true;
            this.lbl_StockRepStartDate.Location = new System.Drawing.Point(43, 84);
            this.lbl_StockRepStartDate.Name = "lbl_StockRepStartDate";
            this.lbl_StockRepStartDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_StockRepStartDate.TabIndex = 2;
            this.lbl_StockRepStartDate.Text = "Start Date";
            // 
            // lbl_StockReportEndDate
            // 
            this.lbl_StockReportEndDate.AutoSize = true;
            this.lbl_StockReportEndDate.Location = new System.Drawing.Point(46, 140);
            this.lbl_StockReportEndDate.Name = "lbl_StockReportEndDate";
            this.lbl_StockReportEndDate.Size = new System.Drawing.Size(52, 13);
            this.lbl_StockReportEndDate.TabIndex = 3;
            this.lbl_StockReportEndDate.Text = "End Date";
            // 
            // btn_StockRepGenRep
            // 
            this.btn_StockRepGenRep.Location = new System.Drawing.Point(46, 229);
            this.btn_StockRepGenRep.Name = "btn_StockRepGenRep";
            this.btn_StockRepGenRep.Size = new System.Drawing.Size(121, 23);
            this.btn_StockRepGenRep.TabIndex = 4;
            this.btn_StockRepGenRep.Text = "Generate Report";
            this.btn_StockRepGenRep.UseVisualStyleBackColor = true;
            // 
            // btn_StockRepCancel
            // 
            this.btn_StockRepCancel.Location = new System.Drawing.Point(200, 228);
            this.btn_StockRepCancel.Name = "btn_StockRepCancel";
            this.btn_StockRepCancel.Size = new System.Drawing.Size(75, 23);
            this.btn_StockRepCancel.TabIndex = 5;
            this.btn_StockRepCancel.Text = "Cancel";
            this.btn_StockRepCancel.UseVisualStyleBackColor = true;
            // 
            // btn_StockRepExit
            // 
            this.btn_StockRepExit.Location = new System.Drawing.Point(334, 228);
            this.btn_StockRepExit.Name = "btn_StockRepExit";
            this.btn_StockRepExit.Size = new System.Drawing.Size(75, 23);
            this.btn_StockRepExit.TabIndex = 6;
            this.btn_StockRepExit.Text = "Exit ";
            this.btn_StockRepExit.UseVisualStyleBackColor = true;
            this.btn_StockRepExit.Click += new System.EventHandler(this.Btn_StockRepExit_Click);
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 334);
            this.Controls.Add(this.btn_StockRepExit);
            this.Controls.Add(this.btn_StockRepCancel);
            this.Controls.Add(this.btn_StockRepGenRep);
            this.Controls.Add(this.lbl_StockReportEndDate);
            this.Controls.Add(this.lbl_StockRepStartDate);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "StockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockReport";
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
    }
}