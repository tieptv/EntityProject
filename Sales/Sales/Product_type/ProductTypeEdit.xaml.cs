using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Sales.Product_type
{
    /// <summary>
    /// Interaction logic for ProductTypeEdit.xaml
    /// </summary>
    public partial class ProductTypeEdit : Window
    {
        public ProductTypeEdit()
        {
            InitializeComponent();
        }
        public ProductTypeEdit(PRODUCT_TYPE pt, Product_typeVM ptvm)
        {
            InitializeComponent();
            Product_typeEditVM vm = new Product_typeEditVM(pt, ptvm);
            this.DataContext = vm;
        }
        /*
        public ProductTypeEdit(PRODUCT_TYPE pt,ProductTypeList ptl)
        {
            InitializeComponent();
            this.cv = "update";
            this.ptl = ptl;
            txtProductTypecd.Text = pt.PRODUCT_TYPE_CD;
            txtName.Text= pt.NAME;
        }
        public ProductTypeEdit(ProductTypeList ptl)
        {
            InitializeComponent();
            this.cv = "insert";
            this.ptl = ptl;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (txtProductTypecd.Text.Equals("") || txtName.Text.Equals(""))
                MessageBox.Show("Bạn không được để trống cái nào", "Thông báo");
            else
            {
                Product_TypeDao ptd = new Product_TypeDao();
                PRODUCT_TYPE pt = new PRODUCT_TYPE();
                pt.PRODUCT_TYPE_CD = txtProductTypecd.Text;
                pt.NAME = txtName.Text;
                if (cv == "update") ptd.Update(pt);
                else ptd.Insert(pt);
                this.Close();
                ptl.UpdateDatagrid();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        */
    }
}
