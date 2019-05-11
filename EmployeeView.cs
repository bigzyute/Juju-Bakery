using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginScrn
{
    public partial class EmployeeView : Form
    {
        public EmployeeView()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=GABRIELLE;Initial Catalog=Bakery; Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            String query = "Select * From Employee";
            SqlCommand cmd = new SqlCommand(query, connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            dataGridViewEmployee.DataSource = dataSet;
            dataGridViewEmployee.DataMember = dataSet.Tables[0].ToString();
        }
    }
}
