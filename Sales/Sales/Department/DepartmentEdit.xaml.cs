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
    /// Interaction logic for DepartmentEdit.xaml
    /// </summary>
    public partial class DepartmentEdit : Window
    {
        public DepartmentEdit() {
            InitializeComponent();
        }
        public DepartmentEdit(String cv,DepartmentVM dvm)
        {
            InitializeComponent();
            DepartmentEditVM DeVM = new DepartmentEditVM(cv,dvm);
            this.DataContext = DeVM;
        }
        //private  DepartmentList dpl;
        //private String cv;
        //public DepartmentEdit()
        //{
        //    InitializeComponent();
        //}
        //public DepartmentEdit(DepartmentList dl)
        //{
        //    InitializeComponent();
        //    this.cv = "insert";
        //    this.dpl = dl;
        //    txtDepID.Text = (dl.listd.Count()+1).ToString();
        ////}
        //public DepartmentEdit(DEPARTMENT dp, DepartmentList dl)
        //{
        //    InitializeComponent();
        //    this.cv = "update";
        //    this.dpl = dl;
        //    txtDepID.Text = dp.DEPT_ID.ToString();
        //    txtName.Text = dp.NAME;
        //}
        //private void btnOK_Click(object sender, RoutedEventArgs e)
        //{
        //    if (txtName.Text.Equals("") || txtDepID.Text.Equals("")) MessageBox.Show("Bạn không được để trống Mã DP hoặc Tên");
        //    else
        //    {
        //        DEPARTMENT d = new DEPARTMENT();
        //        DepartmentDao dd = new DepartmentDao();
        //        d.DEPT_ID = int.Parse(txtDepID.Text);
        //        d.NAME = txtName.Text;
        //        if (cv == "insert") dd.Insert(d);
        //        else dd.Update(d);
        //        this.Close();
        //        dpl.UpdateDatagrid();
        //    }
        //}
        //private void btnCancel_Click(object sender, RoutedEventArgs e)
        //{
        //    this.Close();
        //}
    }
}
