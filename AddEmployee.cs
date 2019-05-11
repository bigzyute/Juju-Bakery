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
            int telephone;
            Int32.TryParse(txtBoxAddressTelephone.Text, out telephone);
            bool validated = false;
            //Input validation
            if (string.IsNullOrWhiteSpace(txtEmpFname.Text) || string.IsNullOrWhiteSpace(txtEmpLname.Text))
            {
                MessageBox.Show("Please complete the required feilds", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rbEmpFemale.Checked == false && rbEmpMale.Checked == false)
            {
                MessageBox.Show("Please select a gender.", "Gender Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (rbEmpSingle.Checked == false && rbEmpMarried.Checked == false && rbEmpWidowed.Checked == false &&
                rbEmpDivorced.Checked == false)
            {
                MessageBox.Show("Please select a Marital Status.", "Marital Status Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (string.IsNullOrWhiteSpace(txtBoxAddressTown.Text))
            {
                MessageBox.Show("A Town must be added.", "Town Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                validated = true; //If input is validated, the variable "validated" is set to true
            } 
            
            if (validated == true) //Assigning radio buttos
            {
                if (rbEmpFemale.Checked == true)
                {
                    gender = 'f';
                }
                else if (rbEmpMale.Checked == true)
                {
                    gender = 'm';
                }
                else if (rbEmpDivorced.Checked == true)
                {
                    mStatus = "divorced";
                }
                else if (rbEmpMarried.Checked == true)
                {
                    mStatus = "married";
                }
                else if (rbEmpWidowed.Checked == true)
                {
                    mStatus = "widowed";
                }
                else
                {
                    mStatus = "single";
                }
            }

            if (validated == true)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                String query = "INSERT INTO Employee VALUES('" + txtEmpFname.Text + "', '" + txtEmpMidName.Text + "', '" + txtEmpLname.Text + "', '"
                        + dateTimePickerAddEmp.Text + "', '" + gender + "', '" + mStatus + "', '" + txtBoxAddressTown.Text + "', '" + txtBoxAddressPoBox.Text + "', '"
                        + txtBoxAddressParish.Text + "', '" + telephone + "', '" + txtBoxAddressEmail.Text + "');";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader;
                try
                {
                    connection.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Records Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    while (reader.Read())
                    {

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error Generated. Details: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }

            if (validated == true)
            {
                SqlConnection connection = new SqlConnection(connectionString);
                String query = "INSERT INTO Login VALUES('" +txtBoxUsername.Text+ "', '" +txtBoxPassword.Text+ "');";
                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader reader;
                try
                {
                    connection.Open();
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("Username and Password entered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    while (reader.Read())
                    {

                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error Generated. Details: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
