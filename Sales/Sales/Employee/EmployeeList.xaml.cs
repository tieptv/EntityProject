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

namespace Sales.Employee
{
    /// <summary>
    /// Interaction logic for EmployeeList.xaml
    /// </summary>
    public partial class EmployeeList : Window
    {
        //private List<EmployeeView> listev;

        public EmployeeList()

        {
            InitializeComponent();
            lvemployee.SizeChanged += LV_SizeChanged;
            EmployeeVM vm = new EmployeeVM();
            this.DataContext = vm;
        }
        void LV_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            var newWidth = lvemployee.ActualWidth / GridView1.Columns.Count;
            foreach (var column in GridView1.Columns)
            {
                column.Width = newWidth;
            }
        }
        /*
        public void UpdateDatagrid()
        {
            grproduct.ItemsSource = Load();
        }
        private void insert_click(object sender, RoutedEventArgs e)
        {

            new EmployeeEdit(this).Show();
        }

        private void update_click(object sender, RoutedEventArgs e)
        {
          /*  EmployeeView row = grproduct.SelectedItem as EmployeeView;
            if (row == null) MessageBox.Show("Bạn chưa chọn sản phẩm ", "Thông báo");
            else
            {
                EmployeeEdit ee = new EmployeeEdit(row, this);
                ee.Show();
            }
            
        }

        private void delete_click(object sender, RoutedEventArgs e)
        {
            EmployeeView row = grproduct.SelectedItem as EmployeeView;
            if (row == null) MessageBox.Show("Bạn chưa chọn sản phẩm ", "Thông báo");
            else
            {
                EmployeeDao pd = new EmployeeDao();
                pd.Delete(row.id);
                grproduct.ItemsSource = Load();
            }
        }
        private List<EmployeeView> Load()
        {
            List<EmployeeView> list = new List<EmployeeView>();
            EmployeeDao ed = new EmployeeDao();
            List<EMPLOYEE> liste = ed.getAll();
            foreach (EMPLOYEE e in liste)
            {
                EmployeeView ev = new EmployeeView(e);
                list.Add(ev);
            }
            return list;

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            String key = txtSearch.Text.ToLower();
            List<EmployeeView> result = new List<EmployeeView>();
            foreach (EmployeeView ev in listev)
            {
                String temp = (ev.id + " " + ev.branch + " " + ev.department + " " + ev.end_date + " " + ev.first_name+" "+ev.last_name+" "+ev.start_date+" "+ev.SupervisorEm+" "+ev.title).ToLower();
                if (temp.Contains(key)) result.Add(ev);
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
