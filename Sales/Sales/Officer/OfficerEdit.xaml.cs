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
    /// Interaction logic for OfficerEdit.xaml
    /// </summary>
    public partial class OfficerEdit : Window
    {
        public OfficerEdit()
        {
            InitializeComponent();
        }
        private OfficerList ol;
        private String cv;
        public OfficerEdit(OfficerList ol)
        {
            InitializeComponent();
            this.cv = "insert";
            this.ol = ol;
            CustomerDao cus = new CustomerDao();
            txtOfficerID.Text = (ol.listo.Count() + 1).ToString();
            txtCustID.Text = (cus.getAll().Count+1).ToString();
        }
        public OfficerEdit(OFFICER o, OfficerList ol)
        {
            InitializeComponent();
            this.cv = "update";
            this.ol = ol;
            CustomerDao cd = new CustomerDao();
            CUSTOMER cus = new CUSTOMER();
            cus = cd.SelectbyId(o.CUST_ID);
            txtAdress.Text = cus.ADDRESS;
            txtCity.Text = cus.CITY;
            txtCustType.Text = cus.CUST_TYPE_CD;
            txtFedID.Text = cus.FED_ID;
            txtPostcode.Text = cus.POSTAL_CODE;
            txtState.Text = cus.STATE;
            txtFirstname.Text = o.FIRST_NAME;
            txtLastname.Text = o.LAST_NAME;
            txtTitle.Text = o.TITLE;
            DateEnd.Text = o.END_DATE.ToString();
            StartDate.Text = o.START_DATE.ToString();
            txtOfficerID.Text = o.OFFICER_ID.ToString();
            txtCustID.Text = o.CUST_ID.ToString();
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (txtCustType == null || txtFedID == null || txtFirstname == null || txtLastname == null || StartDate == null)
                MessageBox.Show("Bạn không được để trống họ ,tên, ngày bắt đầu, FED ID và loại khách");
            else
            {
                OFFICER o = new OFFICER();
                CustomerDao cd = new CustomerDao();
                CUSTOMER cus = new CUSTOMER();
                OfficerDao od = new OfficerDao();
                //
                //set data cho Customer
                cus.ADDRESS = txtAdress.Text;
                cus.CITY = txtCity.Text;
                cus.CUST_TYPE_CD = txtCustType.Text;
                cus.POSTAL_CODE = txtPostcode.Text;
                cus.STATE = txtState.Text;
                cus.FED_ID = txtFedID.Text;
                cus.CUST_ID = int.Parse(txtCustID.Text);
                //
                //set data cho Officer
                o.OFFICER_ID = int.Parse(txtOfficerID.Text);
                o.LAST_NAME = txtLastname.Text;
                o.FIRST_NAME = txtFirstname.Text;
                o.START_DATE = Convert.ToDateTime(StartDate.Text);
                o.END_DATE = Convert.ToDateTime(DateEnd.Text);
                o.TITLE = txtTitle.Text;
                o.CUST_ID = int.Parse(txtCustID.Text);
                if (DateEnd==null) o.END_DATE = null;
                else o.END_DATE = Convert.ToDateTime(DateEnd.Text);
                //
                if (cv == "insert")
                {
                    cd.Insert(cus);
                    od.Insert(o);
                   
                   
                }
                else
                {
                    cd.Update(cus);
                    od.Update(o);
                }
                this.Close();
                ol.UpdateDatagrid();
            }
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
