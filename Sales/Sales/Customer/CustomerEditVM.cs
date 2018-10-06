using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;


namespace Sales.Customer
{
    public class CustomerEditVM : BaseClass
    {
        private CustomerVM vm;
        private String cv;
        private int custid;
        private INDIVIDUAL ind;
        private OFFICER off;
        private BUSINESS bus;
        private String _In_firstname;
        public String In_firstname
        {
            get { return _In_firstname; }
            set { _In_firstname = value; NotifyPropertyChanged(); }
        }

        private String _In_lastname;
        public String In_lastname
        {
            get { return _In_lastname; }
            set { _In_lastname = value; NotifyPropertyChanged(); }
        }

        private String _In_birthdate;
        public String In_birthdate
        {
            get { return _In_birthdate; }
            set { _In_birthdate = value; NotifyPropertyChanged(); }
        }

        private String _Bu_stateid;
        public String Bu_stateid
        {
            get { return _Bu_stateid; }
            set { _Bu_stateid = value; NotifyPropertyChanged(); }
        }

        private String _Bu_name;
        public String Bu_name
        {
            get { return _Bu_name; }
            set { _Bu_name = value; NotifyPropertyChanged(); }
        }

        private String _Bu_incorpdate;
        public String Bu_incorpdate
        {
            get { return _Bu_incorpdate; }
            set { _Bu_incorpdate = value; NotifyPropertyChanged(); }
        }

        private String _Of_firstname;
        public String Of_firstname
        {
            get { return _Of_firstname; }
            set { _Of_firstname = value; NotifyPropertyChanged(); }
        }

        private String _Of_lastname;
        public String Of_lastname
        {
            get { return _Of_lastname; }
            set { _Of_lastname = value; NotifyPropertyChanged(); }
        }

        private String _Of_title;
        public String Of_title
        {
            get { return _Of_title; }
            set { _Of_title = value; NotifyPropertyChanged(); }
        }

        private String _Of_startdate;
        public String Of_startdate
        {
            get { return _Of_startdate; }
            set { _Of_startdate = value; NotifyPropertyChanged(); }
        }

        private String _Of_enddate;
        public String Of_enddate
        {
            get { return _Of_enddate; }
            set { _Of_enddate = value; NotifyPropertyChanged(); }
        }
        private String _Cus_address;
        public String Cus_address
        {
            get { return _Cus_address; }
            set { _Cus_address = value; NotifyPropertyChanged(); }
        }

        private String _Cus_city;
        public String Cus_city
        {
            get { return _Cus_city; }
            set { _Cus_city = value; NotifyPropertyChanged(); }
        }

        private String _Cus_custype;
        public String Cus_custype
        {
            get { return _Cus_custype; }
            set { _Cus_custype = value; NotifyPropertyChanged(); }
        }

        private String _Cus_fedid;
        public String Cus_fedid
        {
            get { return _Cus_fedid; }
            set { _Cus_fedid = value; NotifyPropertyChanged(); }
        }

        private String _Cus_postalcode;
        public String Cus_postalcode
        {
            get { return _Cus_postalcode; }
            set { _Cus_postalcode = value; NotifyPropertyChanged(); }
        }
        private String _Cus_state;
        public String Cus_state
        {
            get { return _Cus_state; }
            set { _Cus_state = value; NotifyPropertyChanged(); }
        }

        public ICommand OKCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public CustomerEditVM(CUSTOMER c, CustomerVM vm)
        {
            if (c == null)
            {
                this.In_firstname = "";
                this.In_lastname = "";
                this.In_birthdate = "";

                this.Bu_name = "";
                this.Bu_stateid = "";
                this.Bu_incorpdate = "";

                this.Of_enddate = "";
                this.Of_firstname = "";
                this.Of_startdate = "";
                this.Of_title = "";
                this.Of_lastname = "";

                this.Cus_address = "";
                this.Cus_city = "";
                this.Cus_custype = "";
                this.Cus_postalcode = "";
                this.Cus_fedid = "";
                this.Cus_state = "";
                this.cv = "insert";



            }
            else
            {
                ind = IndividualDao.Instance().SelectbyId(c.CUST_ID);
                bus = BusinessDao.Instance().SelectbyId(c.CUST_ID);
                off = OfficerDao.Instance().SelectbyCustId(c.CUST_ID);
                if (ind != null)
                {
                    In_lastname = ind.LAST_NAME;
                    In_firstname = ind.FIRST_NAME;
                    In_birthdate = ind.BIRTH_DATE.ToString();


                }
                if (off != null && bus != null)
                {
                    Of_lastname = off.LAST_NAME;
                    Of_firstname = off.FIRST_NAME;
                    Of_title = off.TITLE;
                    Of_startdate = off.START_DATE.ToString();
                    Of_enddate = off.END_DATE.ToString();
                    Bu_name = bus.NAME;
                    Bu_stateid = bus.STATE_ID;
                    Bu_incorpdate = bus.INCORP_DATE.ToString();

                }

                this.Cus_address = c.ADDRESS;
                this.Cus_city = c.CITY;
                this.Cus_custype = c.CUST_TYPE_CD;
                this.Cus_postalcode = c.POSTAL_CODE;
                this.Cus_fedid = c.FED_ID;
                this.Cus_state = c.STATE;
                this.cv = "update";
                this.custid = c.CUST_ID;
            }
            this.vm = vm;
            OKCommand = new RelayCommand<Window>((p) => { return p != null ? true : false; }, (p) => { OKevent(p); });
            CancelCommand = new RelayCommand<Window>((p) => true, (p) => { p.Close(); });
        }
        private void OKevent(Window p)
        {
            if (validate_customer() == true)
            {

                CUSTOMER cus = new CUSTOMER();
                cus.ADDRESS = Cus_address;
                cus.CITY = Cus_city;
                cus.CUST_TYPE_CD = Cus_custype;
                cus.FED_ID = Cus_fedid;
                cus.POSTAL_CODE = Cus_postalcode;
                cus.STATE = Cus_state;
                if (cv == "insert")
                {
                    CustomerDao.Instance().Insert(cus);
                    off = new OFFICER();
                    ind = new INDIVIDUAL();
                    bus = new BUSINESS();
                    int last_cus = CustomerDao.Instance().LastCUST().CUST_ID;
                    off.CUST_ID = last_cus;
                    ind.CUST_ID = last_cus;
                    bus.CUST_ID = last_cus;
                    if (Cus_custype == "I")
                    {
                        if (validate_individual() == true)
                        {
                            if (In_birthdate.Equals("")) ind.BIRTH_DATE = null;
                            else
                                ind.BIRTH_DATE = Convert.ToDateTime(In_birthdate);
                            ind.FIRST_NAME = In_firstname;
                            ind.LAST_NAME = In_lastname;

                            IndividualDao.Instance().Insert(ind);
                        }
                        else MessageBox.Show("Bạn điền thiếu thông tin Individual!", "Thông báo");
                    }
                    else
                    {
                        if (validate_officer() == true && validate_business() == true)
                        {
                            bus.NAME = Bu_name;
                            bus.STATE_ID = Bu_stateid;
                            if (Bu_incorpdate.Equals("")) bus.INCORP_DATE = null;
                            else
                                bus.INCORP_DATE = Convert.ToDateTime(Bu_incorpdate);
                            off.LAST_NAME = Of_lastname;
                            off.FIRST_NAME = Of_firstname;
                            off.TITLE = Of_title;
                            off.START_DATE = Convert.ToDateTime(Of_startdate);
                            if (Of_enddate.Equals("")) bus.INCORP_DATE = null;
                            else
                                off.END_DATE = Convert.ToDateTime(Of_enddate);

                            OfficerDao.Instance().Insert(off);
                            BusinessDao.Instance().Insert(bus);
                        }
                        else MessageBox.Show("Bạn điền thiếu thông tin Officer và Business!", "Thông báo");
                    }
                }
                else
                {
                    cus.CUST_ID = custid;
                    if (Cus_custype == "I")
                    {
                        if (validate_individual() == true)
                        {
                            if (In_birthdate.Equals("")) ind.BIRTH_DATE = null;
                            else
                                ind.BIRTH_DATE = Convert.ToDateTime(In_birthdate);
                            ind.FIRST_NAME = In_firstname;
                            ind.LAST_NAME = In_lastname;
                            CustomerDao.Instance().Update(cus);
                            IndividualDao.Instance().Update(ind);
                        }
                        else MessageBox.Show("Bạn điền thiếu thông tin Individual!", "Thông báo");

                    }
                    else
                    {
                        if (validate_officer() == true && validate_business() == true)
                        {
                            bus.NAME = Bu_name;
                            bus.STATE_ID = Bu_stateid;
                            if (Bu_incorpdate.Equals("")) bus.INCORP_DATE = null;
                            else
                                bus.INCORP_DATE = Convert.ToDateTime(Bu_incorpdate);
                            off.LAST_NAME = Of_lastname;
                            off.FIRST_NAME = Of_firstname;
                            off.TITLE = Of_title;
                            off.START_DATE = Convert.ToDateTime(Of_startdate);
                            if (Of_enddate.Equals("")) bus.INCORP_DATE = null;
                            else
                                off.END_DATE = Convert.ToDateTime(Of_enddate);
                            CustomerDao.Instance().Update(cus);
                            OfficerDao.Instance().Update(off);
                            BusinessDao.Instance().Update(bus);
                        }
                        else MessageBox.Show("Bạn điền thiếu thông tin Officer và Business!", "Thông báo");
                    }


                }
                p.Close();
                vm.CustomerLists = new ObservableCollection<CUSTOMER>(CustomerDao.Instance().getAll());
            }
            else MessageBox.Show("Customer:Bạn điền thiếu thông tin!", "Thông báo");

        }
        private Boolean validate_customer()
        {
            if (Cus_city == "" || Cus_fedid == "") return false;
            return true;
        }
        private Boolean validate_individual()
        {
            if (In_lastname == "" || In_firstname == "") return false;
            return true;
        }
        private Boolean validate_officer()
        {
            if (Of_lastname == "" || Of_firstname == "" || Of_startdate == "") return false;
            return true;
        }
        private Boolean validate_business()
        {
            if (Bu_name == "" || Bu_stateid == "") return false;
            return true;
        }
    }
}
