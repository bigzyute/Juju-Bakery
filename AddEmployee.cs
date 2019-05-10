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
            char gender = 'm';
            string mStatus = "single";
            //Gender validation and assignment
            if (string.IsNullOrWhiteSpace(txtEmpFname.Text) || string.IsNullOrWhiteSpace(txtEmpLname.Text))
            {
                MessageBox.Show("Please complete the required feilds", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbEmpFemale.Checked == false && rbEmpMale.Checked == false)
            {
                MessageBox.Show("Please select a gender.", "Gender Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (rbEmpSingle.Checked == false || rbEmpMarried.Checked == false || rbEmpWidowed.Checked == false ||
                rbEmpDivorced.Checked == false)
            {
                MessageBox.Show("Please select a Marital Status.", "Marital Status Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (string.IsNullOrWhiteSpace(txtBoxAddressTown.Text))
            {
                MessageBox.Show("An address must be selected.", "Gender Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (rbEmpFemale.Checked == true)
            {
                gender = 'f';
            } else
            {
                gender = 'm';
            }

            if (rbEmpSingle.Checked == true)
            {
                mStatus = "single";
            } else if (rbEmpMarried.Checked == true)
            {
                mStatus = "married";
            }
            else if (rbEmpWidowed.Checked == true)
            {
                mStatus = "widowed";
            }
            else
            {
                mStatus = "divorced";
            }

            /*using(SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Employee VALUES('"+txtEmpFname.Text+"', '"+txtEmpMidName.Text+"', '"+txtEmpLname.Text+"', '"
                    +dateTimePickerAddEmp+"', '"+gender+"', '"+mStatus+"', '"+txtBoxAddressTown.Text+"', '"+txtBoxAddressPoBox.Text+"', '"
                    +txtBoxAddressParish.Text+"', )";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
            }*/
        }
    }
}
