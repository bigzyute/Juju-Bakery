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
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void btnProductExit_Click(object sender, EventArgs e)
        {
            Main objMain = new Main();
            
            this.Hide();
        }

        private void BtnAddProduct_Click(object sender, EventArgs e)
        {
            using (BakeryEntitiesNew context = new BakeryEntitiesNew())
            {
                ProductsItem productsItem = new ProductsItem();
                productsItem.name = textBoxProductName.Text;
                productsItem.date = dateTimePickerAddProduct.Value;
                productsItem.cost = float.Parse(textBoxCost.Text);

                context.ProductsItems.Add(productsItem);
                context.SaveChanges();
                textBoxProductCode.Text = productsItem.Id.ToString();
            }
        }
    }
}
