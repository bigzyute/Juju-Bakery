using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            numericUpDown1.ResetText();
            lblOrderQuantity.Clear();
            txt_OrCusName.Clear();
            txtOrderGct.Clear();
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
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
