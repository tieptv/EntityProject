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

namespace Sales.Individual
{
    /// <summary>
    /// Interaction logic for IndividualList.xaml
    /// </summary>
    public partial class IndividualList : Window
    {
        public List<INDIVIDUAL> listIn;
        public IndividualList()
        {
            InitializeComponent();
            this.listIn = Load();
            UpdateDatagrid();

        }
        public List<INDIVIDUAL> Load()
        {
            List<INDIVIDUAL> list = new List<INDIVIDUAL>();
            IndividualDao id = new IndividualDao();
            list = id.getAll();
            return list;

        }
        public void UpdateDatagrid()
        {
            grindividual.ItemsSource = Load();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            new IndividualEdit(this).Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            INDIVIDUAL row = grindividual.SelectedItem as INDIVIDUAL;
            if (row == null) MessageBox.Show("Bạn chưa chọn phòng nào", "Thông báo");
            else
            {
                new IndividualEdit(row, this).Show();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            INDIVIDUAL row = grindividual.SelectedItem as INDIVIDUAL;
            if (row == null) MessageBox.Show("Bạn chưa chọn phòng nào", "Thông báo");
            else
            {
                IndividualDao In = new IndividualDao();
                In.Delete(row.CUST_ID);
                UpdateDatagrid();
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            String key = txtSearch.Text.ToLower();
            List<INDIVIDUAL> result = new List<INDIVIDUAL>();
            foreach (INDIVIDUAL i in listIn)
            {
                String temp = (i.CUST_ID + " " + i.BIRTH_DATE+ " " + i.FIRST_NAME+ " " + i.LAST_NAME).ToLower();
                if (temp.Contains(key)) result.Add(i);
            }
            grindividual.ItemsSource = result;
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
