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
    /// Interaction logic for ProductTypeList.xaml
    /// </summary>
    public partial class ProductTypeList : Window
    {
        public ProductTypeList()
        {
            InitializeComponent();
            Product_typeVM ptVM = new Product_typeVM();
            this.DataContext = ptVM;
          
        }
        /*  private List<PRODUCT_TYPE> Load()
        {
            List<PRODUCT_TYPE> list = new List<PRODUCT_TYPE>();
            Product_TypeDao ptd = new Product_TypeDao();
            list = ptd.getAll();
            return list;

        }
      
        public void UpdateDatagrid()
        {
            grproduct_type.ItemsSource = Load();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            new ProductTypeEdit(this).Show();

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {   
            PRODUCT_TYPE row = grproduct_type.SelectedItem as PRODUCT_TYPE;
            if (row == null) MessageBox.Show("Bạn chưa chọn hàng nào", "Thông báo");
            else 
            new ProductTypeEdit(row,this).Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            PRODUCT_TYPE row = grproduct_type.SelectedItem as PRODUCT_TYPE;
            if (row == null) MessageBox.Show("Bạn chưa chọn loại ", "Thông báo");
            else
            {
                Product_TypeDao ptd = new Product_TypeDao();
                ptd.Delete(row.PRODUCT_TYPE_CD);
                grproduct_type.ItemsSource = Load();
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            String key = txtSearch.Text.ToLower();
            List<PRODUCT_TYPE> result = new List<PRODUCT_TYPE>();
            foreach (PRODUCT_TYPE pt in listpt)
            {
                String temp = (pt.PRODUCT_TYPE_CD+ " " + pt.NAME).ToLower();
                if (temp.Contains(key)) result.Add(pt);
            }
            grproduct_type.ItemsSource = result;
        }
    }
    */
    }
}
