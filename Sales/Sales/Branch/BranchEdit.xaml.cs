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
    /// Interaction logic for BranchEdit.xaml
    /// </summary>
    public partial class BranchEdit : Window
    {
        /*private BranchList bl;
        private String cv;
        */
        public BranchEdit()
        {
            InitializeComponent();
        }
        public BranchEdit(BRANCH b,BranchVM brvm)
        {
            InitializeComponent();
            BranchEditVM vm = new BranchEditVM(b, brvm);
            this.DataContext = vm;
        }
        /*
        public BranchEdit(BRANCH b, BranchList bl)
        {
            InitializeComponent();
            this.cv = "update";
            this.bl = bl;
            txtBranchID.Text = b.BRANCH_ID.ToString();
            txtNAME.Text= b.NAME;
            txtCODE.Text = b.ZIP_CODE;
            txtAdrress.Text = b.ADDRESS;
            txtCITY.Text = b.CITY;
            txtSTATE.Text = b.STATE;
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (txtBranchID.Text.Equals("") ||txtNAME.Text.Equals("")) MessageBox.Show("Bạn không được để trống Mã chi nhánh hoặc Tên");
            else
            {
                BRANCH b = new BRANCH();
                BranchDao bd = new BranchDao();
                b.BRANCH_ID = int.Parse(txtBranchID.Text);
                b.NAME = txtNAME.Text;
                b.ADDRESS = txtAdrress.Text;
                b.CITY = txtCITY.Text;
                b.STATE = txtSTATE.Text;
                b.ZIP_CODE = txtCODE.Text;
                if (cv == "insert") bd.Insert(b);
                else bd.Update(b);
                this.Close();
                bl.UpdateDatagrid();
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        */
    }
}
