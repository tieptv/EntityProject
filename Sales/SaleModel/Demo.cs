using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleModel
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   Product_TypeDao ptd =new Product_TypeDao();
            PRODUCT_TYPE pt = new PRODUCT_TYPE();
            pt.NAME = txt.Text;
            ptd.Insert(pt);
        }
    }
}
