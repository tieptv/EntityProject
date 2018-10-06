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
    /// Interaction logic for IndividualEdit.xaml
    /// </summary>
    public partial class IndividualEdit : Window
    {
        private IndividualList il;
        private String cv;
        public IndividualEdit()
        {
            InitializeComponent();
        }
        public IndividualEdit(IndividualList il)
        {
            InitializeComponent();
            this.cv = "insert";
            this.il = il;
        }
        public IndividualEdit(INDIVIDUAL i, IndividualList il)
        {
            InitializeComponent();
            this.cv = "update";
            this.il = il;
            txtFirstname.Text = i.FIRST_NAME;
            txtLastname.Text = i.LAST_NAME;
            txtCustID.Text = i.CUST_ID.ToString();
            Birthdate.Text = i.BIRTH_DATE.ToString();
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (txtCustID.Text.Equals("") || txtFirstname.Text.Equals("")|| txtLastname.Text.Equals("")) MessageBox.Show("Bạn không được để trống CustID hoặc Họ và Tên");
            else
            {
                INDIVIDUAL i = new INDIVIDUAL();
                IndividualDao id = new IndividualDao();
                i.CUST_ID = int.Parse(txtCustID.Text);
                i.LAST_NAME = txtLastname.Text;
                i.FIRST_NAME = txtFirstname.Text;
                if (Birthdate.Text.Equals("")) i.BIRTH_DATE = null;
                else i.BIRTH_DATE = Convert.ToDateTime(Birthdate.Text);
                if (cv == "insert") id.Insert(i);
                else id.Update(i);
                this.Close();
                il.UpdateDatagrid();
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
