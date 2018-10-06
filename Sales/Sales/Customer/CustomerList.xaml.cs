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

namespace Sales.Customer
{
    /// <summary>
    /// Interaction logic for CustomerList.xaml
    /// </summary>
    public partial class CustomerList : Window
    {
       /* public List<CUSTOMER> listcus;
        OfficerDao od = new OfficerDao();
        IndividualDao id = new IndividualDao();
        BusinessDao bd = new BusinessDao();
        CustomerDao cd = new CustomerDao();
        */
        public CustomerList()
        {
            InitializeComponent();
            CustomerVM vm = new CustomerVM();
            this.DataContext = vm;


        }
        /*    public List<CUSTOMER> Load()
           {
               List<CUSTOMER> list = new List<CUSTOMER>();
               list = cd.getAll();
               return list;

           }
          public void UpdateDatagrid()
           {
               grcustomer.ItemsSource = Load();
           }
           private void btnDelete_Click(object sender, RoutedEventArgs e)
           {
               CUSTOMER row = grcustomer.SelectedItem as CUSTOMER;
               if (row == null) MessageBox.Show("Bạn chưa chọn hàng nào", "Thông báo");
               else
               {   
                   cd.Delete(row.CUST_ID);
                   UpdateDatagrid();
               }

           }
           private void btnUpdate_Click(object sender, RoutedEventArgs e)
           {
               CUSTOMER row = grcustomer.SelectedItem as CUSTOMER;
               if (row == null) MessageBox.Show("Bạn chưa chọn hàng nào", "Thông báo");
               else new CustomerEdit(row,this).Show();

           }

           private void btnInsert_Click(object sender, RoutedEventArgs e)
           {
               new CustomerEdit(this).Show();

           }
           private void ResetView()
           {
               in_lastname.Text = "";
               in_firstname.Text = "";
               in_birthdate.Text = "";
               of_lastname.Text = "";
               of_firstname.Text = "";
               of_title.Text = "";
               of_startdate.Text = "";
               of_enddate.Text = "";
               bu_name.Text = "";
               bu_stateid.Text = "";
               bu_incorpdate.Text = "";

           }

           private void grcustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
           {
               ResetView();
               CUSTOMER row = grcustomer.SelectedItem as CUSTOMER;
               if(row!=null)
               {
               OFFICER of = od.SelectbyCustId(row.CUST_ID);
               BUSINESS bu = bd.SelectbyId(row.CUST_ID);
               INDIVIDUAL ind = id.SelectbyId(row.CUST_ID);
               if (ind != null)
               {
                   in_lastname.Text = ind.LAST_NAME;
                   in_firstname.Text = ind.FIRST_NAME;
                   in_birthdate.Text = ind.BIRTH_DATE.ToString();
               }
               if (of != null)
               {
                   of_lastname.Text = of.LAST_NAME;
                   of_firstname.Text = of.FIRST_NAME;
                   of_title.Text = of.TITLE;
                   of_startdate.Text = of.START_DATE.ToString();
                   of_enddate.Text = of.END_DATE.ToString();
               }
               if (bu != null)
               {
                   bu_name.Text = bu.NAME;
                   bu_stateid.Text = bu.STATE_ID;
                   bu_incorpdate.Text = bu.INCORP_DATE.ToString();
               }
               }
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

           private void Search_Click(object sender, RoutedEventArgs e)
           {
               String key = txtSearch.Text.ToLower();
               List<CUSTOMER> result = new List<CUSTOMER>();
               foreach (CUSTOMER c  in listcus)
               {
                   OFFICER of = od.SelectbyCustId(c.CUST_ID);
                   BUSINESS bu = bd.SelectbyId(c.CUST_ID);
                   INDIVIDUAL ind = id.SelectbyId(c.CUST_ID);
                   String temp = c.CUST_ID.ToString() + " " + c.ADDRESS + " " + c.CITY + " " + c.FED_ID + " " + c.POSTAL_CODE + " " + c.STATE + " " ;
                   if (of != null && bu != null) temp +=
                                        of.FIRST_NAME + of.LAST_NAME + of.OFFICER_ID + of.TITLE + of.START_DATE.ToString() + of.END_DATE.ToString() +" "+
                                        bu.NAME + "  "+ bu.STATE_ID + " " + bu.INCORP_DATE.ToString();
                   if (ind != null)temp+= ind.LAST_NAME + " " + ind.FIRST_NAME + " " + ind.BIRTH_DATE.ToString();
                   temp.ToLower();
                   if (temp.Contains(key)) result.Add(c);
               }
               grcustomer.ItemsSource = result;
           }
           */
    }
}