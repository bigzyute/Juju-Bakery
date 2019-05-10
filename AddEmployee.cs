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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void btnEmpExit_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            //objMain.Show();
            this.Hide();
        }
    }
}
