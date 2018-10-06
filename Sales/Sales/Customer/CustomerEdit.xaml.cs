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
    /// Interaction logic for CustomerEdit.xaml
    /// </summary>
    public partial class CustomerEdit : Window
    {
        /*private CustomerList cl;
        private string cv;
        private int cust_id;
        OfficerDao od = new OfficerDao();
        IndividualDao id = new IndividualDao();
        BusinessDao bd = new BusinessDao();
        CustomerDao cd = new CustomerDao();

        INDIVIDUAL ind = new INDIVIDUAL();
        OFFICER off = new OFFICER();
        BUSINESS bus = new BUSINESS();
        String cust_type;
        */
        public CustomerEdit()
        {
            InitializeComponent();
        }
        public CustomerEdit(CUSTOMER cus, CustomerVM cvm)
        {
            InitializeComponent();
            CustomerEditVM vm = new CustomerEditVM(cus,cvm);
            this.DataContext = vm;
            List<String> list = new List<String>();
            list.Add("I");
            list.Add("B");
            cus_custypeid.ItemsSource = list;
        }
        /*
        public CustomerEdit(CUSTOMER c, CustomerList cl)
        {
            InitializeComponent();
            this.cl = cl;
            this.cv = "update";
            this.cust_id = c.CUST_ID;
            ind = id.SelectbyId(cust_id);
            off = od.SelectbyCustId(cust_id);
            bus = bd.SelectbyId(cust_id);
            cus_address.Text = c.ADDRESS;
            cus_city.Text = c.CITY;
            cus_custypeid.Text = c.CUST_TYPE_CD;
            cus_fedid.Text = c.FED_ID;
            cus_postalcode.Text = c.POSTAL_CODE;
            cus_state.Text = c.STATE;
            cust_type = c.CUST_TYPE_CD;
            if (ind != null)
            {
                in_lastname.Text = ind.LAST_NAME;
                in_firstname.Text = ind.FIRST_NAME;
                in_birthdate.Text = ind.BIRTH_DATE.ToString();
                
                
            }
            if (off != null&& bus!=null)
            {
                of_lastname.Text = off.LAST_NAME;
                of_firstname.Text = off.FIRST_NAME;
                of_title.Text = off.TITLE;
                of_startdate.Text = off.START_DATE.ToString();
                of_enddate.Text = off.END_DATE.ToString();
                bu_name.Text = bus.NAME;
                bu_stateid.Text = bus.STATE_ID;
                bu_incorpdate.Text = bus.INCORP_DATE.ToString();
            
            }

        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (validate_customer() == true)
            {

                CUSTOMER cus = new CUSTOMER();
                cus.ADDRESS = cus_address.Text;
                cus.CITY = cus_city.Text;
                cus.CUST_TYPE_CD = cus_custypeid.Text;
                cus.FED_ID = cus_fedid.Text;
                cus.POSTAL_CODE = cus_postalcode.Text;
                cus.STATE = cus_state.Text;
                if (cv == "insert")
                {
                    int last_cus = cd.LastCUST().CUST_ID;
                    off.CUST_ID = last_cus;
                    ind.CUST_ID = last_cus;
                    bus.CUST_ID = last_cus;
                    if (cus_custypeid.Text == "I")
                    {
                        if (validate_individual() == true)
                        {
                            if (in_birthdate.Text.Equals("")) ind.BIRTH_DATE = null;
                            else
                                ind.BIRTH_DATE = Convert.ToDateTime(in_birthdate.Text);
                            ind.FIRST_NAME = in_firstname.Text;
                            ind.LAST_NAME = in_lastname.Text;
                            cd.Insert(cus);
                            id.Insert(ind);
                        }
                        else MessageBox.Show("Bạn điền thiếu thông tin Individual!", "Thông báo");
                    }
                    else
                    {
                        if (validate_officer() == true && validate_business() == true)
                        {
                            bus.NAME = bu_name.Text;
                            bus.STATE_ID = bu_stateid.Text;
                            if (bu_incorpdate.Text.Equals("")) bus.INCORP_DATE = null;
                            else
                                bus.INCORP_DATE = Convert.ToDateTime(bu_incorpdate.Text);
                            off.LAST_NAME = of_lastname.Text;
                            off.FIRST_NAME = of_firstname.Text;
                            off.TITLE = of_title.Text;
                            off.START_DATE = Convert.ToDateTime(of_startdate.Text);
                            if (of_enddate.Text.Equals("")) bus.INCORP_DATE = null;
                            else
                                off.END_DATE = Convert.ToDateTime(of_enddate.Text);
                            cd.Insert(cus);
                            od.Insert(off);
                            bd.Insert(bus);
                        }
                        else MessageBox.Show("Bạn điền thiếu thông tin Officer và Business!", "Thông báo");
                    }
                }
                else
                {
                    cus.CUST_ID = cust_id;
                    if (cust_type == "I")
                    {
                        if (validate_individual() == true)
                        {
                            if (in_birthdate.Text.Equals("")) ind.BIRTH_DATE = null;
                            else
                                ind.BIRTH_DATE = Convert.ToDateTime(in_birthdate.Text);
                            ind.FIRST_NAME = in_firstname.Text;
                            ind.LAST_NAME = in_lastname.Text;
                            cd.Update(cus);
                            id.Update(ind);
                        }
                        else MessageBox.Show("Bạn điền thiếu thông tin Individual!", "Thông báo");

                    }
                    else
                    {
                        if (validate_officer() == true && validate_business() == true)
                        {
                            bus.NAME = bu_name.Text;
                            bus.STATE_ID = bu_stateid.Text;
                            if (bu_incorpdate.Text.Equals("")) bus.INCORP_DATE = null;
                            else
                                bus.INCORP_DATE = Convert.ToDateTime(bu_incorpdate.Text);
                            off.LAST_NAME = of_lastname.Text;
                            off.FIRST_NAME = of_firstname.Text;
                            off.TITLE = of_title.Text;
                            off.START_DATE = Convert.ToDateTime(of_startdate.Text);
                            if (of_enddate.Text.Equals("")) bus.INCORP_DATE = null;
                            else
                                off.END_DATE = Convert.ToDateTime(of_enddate.Text);
                            cd.Update(cus);
                            od.Update(off);
                            bd.Update(bus);
                        }
                        else MessageBox.Show("Bạn điền thiếu thông tin Officer và Business!", "Thông báo");
                    }

                  
                }
                this.Close();
              //  cl.UpdateDatagrid();
            }
            else MessageBox.Show("Customer:Bạn điền thiếu thông tin!", "Thông báo");
        }
        private Boolean validate_customer()
        {
            if (cus_city.Text == "" || cus_fedid.Text == "") return false;
            return true;
        }
        private Boolean validate_individual()
        {
            if (in_lastname.Text == "" || in_firstname.Text == "") return false;
            return true;
        }
        private Boolean validate_officer()
        {
            if (of_lastname.Text == "" || of_firstname.Text == "" ||of_startdate.Text=="") return false;
            return true;
        }
        private Boolean validate_business()
        {
            if (bu_name.Text == "" || bu_stateid.Text == "" ) return false;
            return true;
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      
        */
        private void cus_custypeid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            if (cus_custypeid.Text== "I")
            {
                in_birthdate.IsEnabled = false;
                in_firstname.IsReadOnly = true;
                in_lastname.IsReadOnly = true;

                bu_name.IsReadOnly = false;
                bu_stateid.IsReadOnly = false;
                bu_incorpdate.IsEnabled = true;

                of_lastname.IsReadOnly = false;
                of_firstname.IsReadOnly = false;
                of_title.IsReadOnly = false;
                of_startdate.IsEnabled = true;
                of_enddate.IsEnabled = true ;
            }
            if (cus_custypeid.Text == "B")

            {
                bu_name.IsReadOnly = true;
                bu_stateid.IsReadOnly = true;
                bu_incorpdate.IsEnabled = false;

                of_lastname.IsReadOnly = true;
                of_firstname.IsReadOnly = true;
                of_title.IsReadOnly = true;
                of_startdate.IsEnabled = false;
                of_enddate.IsEnabled = false;

                in_birthdate.IsEnabled = true;
                in_firstname.IsReadOnly = false;
                in_lastname.IsReadOnly = false;
            
            }
        }
        
    }
}
