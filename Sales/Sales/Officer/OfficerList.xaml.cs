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

namespace Sales.Officer
{
    /// <summary>
    /// Interaction logic for OfficerList.xaml
    /// </summary>
    public partial class OfficerList : Window
    {
        public List<OFFICER> listo;
        public OfficerList()
        {
            InitializeComponent();
            this.listo = Load();
            UpdateDatagrid();

        }
        public List<OFFICER> Load()
        {
            List<OFFICER> list = new List<OFFICER>();
            OfficerDao od = new OfficerDao();
            list = od.getAll();
            return list;

        }
        public void UpdateDatagrid()
        {
            grofficer.ItemsSource = Load();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            new OfficerEdit(this).Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            OFFICER row = grofficer.SelectedItem as OFFICER;
            if (row == null) MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Thông báo");
            else
            {
                new OfficerEdit(row, this).Show();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            OFFICER row = grofficer.SelectedItem as OFFICER;
            if (row == null) MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Thông báo");
            else
            {
                OfficerDao od = new OfficerDao();
                CustomerDao cd = new CustomerDao();
                od.Delete(row.OFFICER_ID);
                cd.Delete(row.CUST_ID);
                UpdateDatagrid();
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            String key = txtSearch.Text.ToLower();
            List<OFFICER> result = new List<OFFICER>(); 
            foreach (OFFICER o in listo)
            {
                String temp = (o.OFFICER_ID+" "+o.FIRST_NAME+" "+o.LAST_NAME+" "+o.TITLE+" "+o.START_DATE.ToString()+" "+o.END_DATE.ToString()).ToLower();
                if (temp.Contains(key)) result.Add(o);
            }
            grofficer.ItemsSource = result;
        }

        private void txtSearch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            txtSearch.Text = "";

        }
        private void txtSearch_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                Search_Click(this, e);
        }
    }
}
