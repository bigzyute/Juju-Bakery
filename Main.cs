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
    public partial class Main : Form
    {
        public Main()
        {
           
            InitializeComponent();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddEmployee")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                AddEmployee objAE = new AddEmployee();
                objAE.MdiParent = this;
                objAE.Show();
            }            
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AddNewProduct")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                addProduct objANP = new addProduct();
                objANP.MdiParent = this;
                objANP.Show();
            }
        }

        private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "RemoveProduct")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                RemoveProduct objRP = new RemoveProduct();
                objRP.MdiParent = this;
                objRP.Show();
            }            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void OrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Order")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                Order objOrd = new Order();
                objOrd.MdiParent = this;
                objOrd.Show();
            }            
        }

        private void CustomerDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void StockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "StockReport")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                StockReport objSTR = new StockReport();
                objSTR.MdiParent = this;
                objSTR.Show();
            }            
        }

        private void SalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Sales_Report")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                Sales_Report objSLR = new Sales_Report();
                objSLR.MdiParent = this;
                objSLR.Show();
            }         

        }
        private void RemoveEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "EmployeeView")
                {
                    isOpen = true;
                    f.BringToFront();
                    break;
                }
            }
            if (isOpen == false)
            {
                EmployeeView objEV = new EmployeeView();
                objEV.MdiParent = this;
                objEV.Show();
            }
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = SystemIcons.Application;
                notifyIcon1.BalloonTipText = "Your Form has been minimized";
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notifyIcon1.BalloonTipText = "Form Restored";
                notifyIcon1.ShowBalloonTip(1000);
            }
            
           

        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
