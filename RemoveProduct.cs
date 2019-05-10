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
    public partial class RemoveProduct : Form
    {
        public RemoveProduct()
        {
            InitializeComponent();
        }

        private void btnRemoveProductExit_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            // objMain.Show();
            this.Hide();
        }

        private void BtnRemoveProductDelete_Click(object sender, EventArgs e)
        {
            txt_removeProductCode.ResetText();
            txt_removeProductResult.ResetText();
        }

        private void BtnRemoveProduct_Click(object sender, EventArgs e)
        {
            using (BakeryEntitiesNew context = new BakeryEntitiesNew())
            {
                ProductsItem productsItem = context.ProductsItems.FirstOrDefault();
                if (txt_removeProductCode.Text == productsItem.Id.ToString())
                {
                    context.ProductsItems.Remove(productsItem);
                    context.SaveChanges();
                    MessageBox.Show("Deleted!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_removeProductCode.ResetText();
                    txt_removeProductResult.ResetText();
                }
                else
                {
                    MessageBox.Show("Nothing to delete!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_removeProductCode.ResetText();
                    txt_removeProductResult.ResetText();
                }
            }
        }

        private void BtnRemoveProductSearch_Click(object sender, EventArgs e)
        {
            using (BakeryEntitiesNew context = new BakeryEntitiesNew())
            {
                ProductsItem productsItem = context.ProductsItems.FirstOrDefault();
                if (txt_removeProductCode.Text == productsItem.Id.ToString())
                {
                    txt_removeProductResult.Text = productsItem.name;
                }
                else
                {
                    MessageBox.Show("No records found", "Result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_removeProductCode.ResetText();
                    txt_removeProductResult.ResetText();
                    txt_removeProductCode.Focus();
                }
            }
        }
    }
}
