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

namespace Sales.Branch
{
    /// <summary>
    /// Interaction logic for BranchList.xaml
    /// </summary>
    public partial class BranchList : Window
    {
       // public List<BRANCH> listb;
        public BranchList()
        {
            BranchVM vm = new BranchVM();
            this.DataContext = vm;

        }
        /*
        public List<BRANCH> Load()
        {
            List<BRANCH> list = new List<BRANCH>();
            BranchDao bd = new BranchDao();
            list = bd.getAll();
            return list;

        }
        public void UpdateDatagrid()
        {
            grbranch.ItemsSource = Load();
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            new BranchEdit(this).Show();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            BRANCH row = grbranch.SelectedItem as BRANCH;
            if (row == null) MessageBox.Show("Bạn chưa chọn phòng nào", "Thông báo");
            else
            {
                new BranchEdit(row, this).Show();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            BRANCH row = grbranch.SelectedItem as BRANCH;
            if (row == null) MessageBox.Show("Bạn chưa chọn phòng nào", "Thông báo");
            else
            {
                BranchDao bd = new BranchDao();
                bd.Delete(row.BRANCH_ID);
                UpdateDatagrid();
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            String key = txtSearch.Text.ToLower();
            List<BRANCH> result = new List<BRANCH>();
            foreach (BRANCH b in listb)
            {
                String temp = (b.BRANCH_ID + " " + b.NAME+" "+b.ADDRESS+" "+b.CITY+" "+b.STATE+" "+b.ZIP_CODE).ToLower();
                if (temp.Contains(key)) result.Add(b);
            }
            grbranch.ItemsSource = result;
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
        */
    }
    
}
