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
    public partial class ViewEmployeeList : Form
    {
        public ViewEmployeeList()
        {
            InitializeComponent();
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            string ConString = @"Data Source=GABRIELLE;Initial Catalog=Bakery; Integrated Security=True;";
            string Query = "SELECT * FROM Employee";
            SqlConnection connection = new SqlConnection(ConString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(Query, connection);
            DataSet dataSet = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataSet);
            dataGridViewEmployee.DataSource = dataSet;
            dataGridViewEmployee.DataMember = dataSet.Tables[0].ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
        }
    }
}
