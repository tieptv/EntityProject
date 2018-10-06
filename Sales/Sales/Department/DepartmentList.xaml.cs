using SaleModel.Department;
using SaleModel.Model;
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

namespace Sales.Department
{
    /// <summary>
    /// Interaction logic for DepartmentList.xaml
    /// </summary>
    public partial class DepartmentList : Window
    {
      //  public List<DEPARTMENT> listd;
        public DepartmentList()
        {
            InitializeComponent();
            //this.listd = Load();
            //UpdateDatagrid();

        }
        //private List<DEPARTMENT> Load()
        //{
        //    List<DEPARTMENT> list = new List<DEPARTMENT>();
        //    DepartmentDao dd = new DepartmentDao();
        //    list = dd.getAll();
        //    return list;

        //}
        //public void UpdateDatagrid()
        //{
        //    grdepartment.ItemsSource = Load();
        //}

        //private void btnInsert_Click(object sender, RoutedEventArgs e)
        //{
        //    new DepartmentEdit(this).Show();
        //}

        //private void btnUpdate_Click(object sender, RoutedEventArgs e)
        //{
        //    DEPARTMENT row = grdepartment.SelectedItem as DEPARTMENT;
        //    if (row == null) MessageBox.Show("Bạn chưa chọn phòng nào", "Thông báo");
        //    else
        //    {
        //        new DepartmentEdit(row, this).Show();
        //    }
        //}

        //private void btnDelete_Click(object sender, RoutedEventArgs e)
        //{
        //    DEPARTMENT row = grdepartment.SelectedItem as DEPARTMENT;
        //    if (row == null) MessageBox.Show("Bạn chưa chọn phòng nào", "Thông báo");
        //    else
        //    {
        //        DepartmentDao dd = new DepartmentDao();
        //        dd.Delete(row.DEPT_ID);
        //        UpdateDatagrid();
        //    }
        //}

        //private void Search_Click(object sender, RoutedEventArgs e)
        //{
        //    String key = txtSearch.Text.ToLower();
        //    List<DEPARTMENT> result = new List<DEPARTMENT>();
        //    foreach (DEPARTMENT d in listd)
        //    {
        //        String temp = (d.DEPT_ID + " " + d.NAME).ToLower();
        //        if (temp.Contains(key)) result.Add(d);
        //    }
        //    grdepartment.ItemsSource = result;
        //}

        //private void txtSearch_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        //{
        //    txtSearch.Text = "";

        //}
        //private void txtSearch_PreviewKeyUp(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == System.Windows.Input.Key.Enter)
        //        Search_Click(this,e);
        //}
    }
}
