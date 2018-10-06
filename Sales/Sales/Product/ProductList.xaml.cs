using SaleModel.Model;
using SaleModel.Product;
using Sales.Model;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// <summary>
    /// Interaction logic for ProductList.xaml
    /// </summary>
    public partial class ProductList : Window
    {
      
   
        public ProductList()

        {   
            InitializeComponent();
            ProductListVM vm = new ProductListVM();
            this.DataContext = vm;
        }
        /*
     public void UpdateDatagrid()
        {
            grproduct.ItemsSource = Load();
        }
        private void insert_click(object sender, RoutedEventArgs e)
    {
         
            new ProductEdit1(this).Show();
    }

    private void update_click(object sender, RoutedEventArgs e)
    {
            ProductView row = grproduct.SelectedItem as ProductView;
            if (row == null) MessageBox.Show("Bạn chưa chọn sản phẩm ", "Thông báo");
            else
            {
            ProductEdit1 pe1= new ProductEdit1(row,this);
            pe1.Show();
             }       
    }

        private void delete_click(object sender, RoutedEventArgs e)
        {
            ProductView row = grproduct.SelectedItem as ProductView;
            if (row == null) MessageBox.Show("Bạn chưa chọn sản phẩm ", "Thông báo");
            else
            {
                ProductDao pd = new ProductDao();
                pd.Delete(row.product_cd);
                grproduct.ItemsSource = Load();
            }
        }
        private List<ProductView> Load()
        {
            List<ProductView> list=new List<ProductView>();
            ProductDao pd = new ProductDao();
            List<PRODUCT> listp = pd.getAll();
            foreach (PRODUCT p in listp)
            {
                ProductView pv = new ProductView(p);
                list.Add(pv);
            }
            return list;

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            String key = txtSearch.Text.ToLower();
            List<ProductView> result = new List<ProductView>();
            foreach(ProductView pv in listpv)
            {
                String temp = (pv.date_offer.ToString()+" " + pv.date_retire.ToString()+" " + pv.type+" " + pv.product_cd+" "+ pv.name).ToLower();
                if (temp.Contains(key)) result.Add(pv);
              }
            grproduct.ItemsSource = result;
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            Search_Click(this, e);
        }
        */
    }
}
