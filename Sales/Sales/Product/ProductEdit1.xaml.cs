using SaleModel.Model;
using SaleModel.Product;
using Sales.Model;
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

namespace Sales.Product
{
    
    public partial class ProductEdit1 : Window
    {

      /*  private Product_TypeDao ptd = new Product_TypeDao();
        private ProductDao pd = new ProductDao();
        private String cv;
        private List<PRODUCT_TYPE> listpt;
        ProductList pl;
        */
        public ProductEdit1(ProductList pl)
        {
            InitializeComponent();
          

        }
        public ProductEdit1(ProductView pv,ProductListVM plvm)
        {
            InitializeComponent();
            ProductEditVM vm = new ProductEditVM(pv, plvm);
            this.DataContext = vm;
        }
        /*
        private void cancel_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtNAME.Text.Equals("") || txtPRODUCT_CD.Text.Equals("")||type.Text.Equals(""))
                MessageBox.Show("Bạn không được để trống mã sản phẩm, tên hoặc loại sản phẩm");
            else
            {
            PRODUCT p = new PRODUCT();
            p.PRODUCT_CD = txtPRODUCT_CD.Text;
            if (type.Text.Equals("")) p.PRODUCT_TYPE_CD = null;
            else 
            p.PRODUCT_TYPE_CD = ptd.SelectbyName(type.Text).PRODUCT_TYPE_CD;
            if (date_offer.Text.Equals(""))
                p.DATE_OFFERED = null;
            else p.DATE_OFFERED = Convert.ToDateTime(date_offer.Text);
            if (date_retire.Text.Equals(""))
                p.DATE_RETIRED = null;
            else
            p.DATE_RETIRED = Convert.ToDateTime(date_retire.Text);
            p.NAME = txtNAME.Text;
                if (cv == "insert") pd.Insert(p);
                else pd.Update(p);
                this.Close();
                pl.UpdateDatagrid();
             
            }

        }
        */
    }
}
