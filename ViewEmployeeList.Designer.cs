namespace LoginScrn
{
    partial class ViewEmployeeList
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.bakeryDataSet = new LoginScrn.BakeryDataSet();
            this.bakeryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.DataSource = this.bakeryDataSetBindingSource;
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1444, 723);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // bakeryDataSet
            // 
            this.bakeryDataSet.DataSetName = "BakeryDataSet";
            this.bakeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bakeryDataSetBindingSource
            // 
            this.bakeryDataSetBindingSource.DataSource = this.bakeryDataSet;
            this.bakeryDataSetBindingSource.Position = 0;
            // 
            // ViewEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 723);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Name = "ViewEmployeeList";
            this.Text = "ViewEmployeeList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.BindingSource bakeryDataSetBindingSource;
        private BakeryDataSet bakeryDataSet;
    }
}