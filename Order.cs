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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Btn_OrExit_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
           // objMain.Show();
            this.Hide();
        }

        private void Btn_OrClear_Click(object sender, EventArgs e)
        {
            txt_Pri.Clear();
            numericUpDownQuantity.ResetText();
            txtBoxSubTotal.Clear();
            txt_OrCusName.Clear();
            txt_OrDisco.Clear();
            txtOrdetTotal.Clear();
        }

        private void Txt_Pri_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_OrderClear_Click(object sender, EventArgs e)
        {

        }

        private void Btn_OrSave_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=GABRIELLE;Initial Catalog=Bakery; Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            String query = "INSERT INTO SalesOrder VALUES('"+dateTimePickerSaleDate.Text+"', '"+float.Parse(numericUpDownQuantity.Value.ToString())+"', '"+txt_OrCusName.Text+"', '"
                +float.Parse(txtBoxSubTotal.Text)+"', '"+float.Parse(txt_OrDisco.Text)+ "', '"+float.Parse(txtOrdetTotal.Text)+ "', '"+listBoxProducts.Text+"');";
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            float price = 0, quantity = 0, subtotal = 0, total = 0, discount = 0;
            string connectionString = @"Data Source=GABRIELLE;Initial Catalog=Bakery; Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            String query = "Select [cost] From ProductsItems Where name='"+listBoxProducts.Text+"'";
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                price = float.Parse(reader.GetValue(0).ToString());
            }
            txt_Pri.Text = price.ToString();
            quantity = float.Parse(numericUpDownQuantity.Value.ToString());
            subtotal = quantity * price;
            txtBoxSubTotal.Text = subtotal.ToString();
            discount = float.Parse(txt_OrDisco.Text);
            if (discount > 0)
            {
                total = subtotal * ((100 - discount) /100);
                txtOrdetTotal.Text = total.ToString();
            }else
            {
                total = subtotal;
                txtOrdetTotal.Text = total.ToString();
            }            
        }

        private void Order_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=GABRIELLE;Initial Catalog=Bakery; Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            String query = "Select * From ProductsItems";
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            connection.Open();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                listBoxProducts.Items.Add(row["name"].ToString());
            }
            connection.Close();
        }
    }
}
