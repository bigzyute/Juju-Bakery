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
    public partial class AddEmployee : Form
    {
        string connectionString = @"Data Source=GABRIELLE;Initial Catalog=Bakery; Integrated Security=True;";
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnEmpExit_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            this.Hide();
        }

        private void BtnEmpAdd_Click(object sender, EventArgs e)
        {
            //Gender validation and assignment
            if (string.IsNullOrWhiteSpace(txtEmpFname.Text) || string.IsNullOrWhiteSpace(txtEmpLname.Text))
            {
                MessageBox.Show("Please complete the required feilds", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbEmpFemale.Checked == false && rbEmpMale.Checked == false)
            {
                MessageBox.Show("Please select a gender.", "Gender Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (rbEmpSingle.Checked == true)
            {
                string status = "single";
            } else if (rbEmpMarried.Checked == true)
            {
                string status = "married";
            } else if (rbEmpWidowed.Checked == true)
            {
                string status = "widowed";
            } else if (rbEmpDivorced.Checked == true)
            {
                string status = "divorced";
            } else
            {
                MessageBox.Show("Please select a Marital Status", "Marital Status Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employee VALUES('"+txtEmpFname+"', '"+txtEmpMidName+"', '"+txtEmpLname+"', '"
                    +dateTimePickerAddEmp+"', '"+gender+"')";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
            }*/
        }
    }
}
