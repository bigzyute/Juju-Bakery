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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEmployeeList));
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.bakeryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bakeryDataSet = new LoginScrn.BakeryDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet)).BeginInit();
=======
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.btnGetData = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
>>>>>>> 4dae96a5f559972b1e16966a8c8b33dfa53d634e
            this.SuspendLayout();
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AllowUserToOrderColumns = true;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowTemplate.Height = 24;
<<<<<<< HEAD
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1028, 587);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // bakeryDataSetBindingSource
=======
            this.dataGridViewEmployee.Size = new System.Drawing.Size(1777, 480);
            this.dataGridViewEmployee.TabIndex = 0;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(314, 575);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(214, 64);
            this.btnGetData.TabIndex = 1;
            this.btnGetData.Text = "&Submit";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // btnCancel
>>>>>>> 4dae96a5f559972b1e16966a8c8b33dfa53d634e
            // 
            this.btnCancel.Location = new System.Drawing.Point(1155, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(214, 64);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "E&xit";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // bakeryDataSet
            // 
            this.bakeryDataSet.DataSetName = "BakeryDataSet";
            this.bakeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ViewEmployeeList
            // 
<<<<<<< HEAD
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1028, 587);
            this.Controls.Add(this.dataGridViewEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewEmployeeList";
            this.Text = "ViewEmployeeList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bakeryDataSet)).EndInit();
=======
            this.AcceptButton = this.btnGetData;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1779, 723);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.dataGridViewEmployee);
            this.MaximizeBox = false;
            this.Name = "ViewEmployeeList";
            this.Text = "ViewEmployeeList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
>>>>>>> 4dae96a5f559972b1e16966a8c8b33dfa53d634e
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.Button btnCancel;
    }
}