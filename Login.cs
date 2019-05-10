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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=GABRIELLE;Initial Catalog=Bakery; Integrated Security=True;");
            SqlDataAdapter adapter = new SqlDataAdapter(@"select * from [Login] where username = '"+txtboxUserName.Text.Trim()+"' and password = '"+txtboxPassword.Text.Trim()+"'", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            if (dataTable.Rows.Count==1)
            {
                Main objM = new Main();
                objM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please enter correct username and password", "Login Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtboxUserName.Focus();
            }            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtboxUserName.Clear();
            txtboxPassword.Clear();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
