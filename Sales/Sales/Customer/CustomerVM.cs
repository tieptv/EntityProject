using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace Sales.Customer
{
    public class CustomerVM : BaseClass
    {

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
        private CUSTOMER _CUSTOMERObj;
        public CUSTOMER CUSTOMERObj
        {
            get { return _CUSTOMERObj; }
            set { _CUSTOMERObj = value; NotifyPropertyChanged(); }
        }
        private ObservableCollection<CUSTOMER> _CustomerLists;
        public ObservableCollection<CUSTOMER> CustomerLists
        {
            get { return _CustomerLists; }
            set { _CustomerLists = value; NotifyPropertyChanged(); }
        }
        public ICommand FindCommand { get; set; }
        public ICommand EditFormCommand { get; set; }
        public ICommand NewFormCommand { get; set; }
        public ICommand DeleteRowCommand { get; set; }
        public ICommand SelectedItemCommand { get; set; }

        public CustomerVM()
        {
            CustomerLists = new ObservableCollection<CUSTOMER>(CustomerDao.Instance().getAll());
            FindCommand = new RelayCommand<FrameworkElement>((p) => { return p != null ? true : false; }, (p) => { Find(p); });
            EditFormCommand = new RelayCommand<CUSTOMER>((p) => true, (p) => { ShowEditForm(p); });
            DeleteRowCommand = new RelayCommand<CUSTOMER>((p) => true, (p) => { RemoveDepartment(p); });
            NewFormCommand = new RelayCommand<Window>((p) => true, (p) => { NewEditForm(); });
            SelectedItemCommand = new RelayCommand<CUSTOMER>((p) => { return p != null ? true : false; }, (p) => { SelectedItem(p); });
        }
        /*   public ObservableCollection<CUSTOMER> UpdateListview()
           {
               List<EMPLOYEE> listp = CustomerDao.Instance().getAll();

               ObservableCollection<CUSTOMER> result = new ObservableCollection<CUSTOMER>();
               foreach (EMPLOYEE p in listp)
               {
                   CUSTOMER pv = new CUSTOMER(p);
                   result.Add(pv);
               }
               return result;

           }
           */
        private void SelectedItem(CUSTOMER p)
        {
            ResetView();
            OFFICER of = OfficerDao.Instance().SelectbyCustId(p.CUST_ID);
            BUSINESS bu = BusinessDao.Instance().SelectbyId(p.CUST_ID);
            INDIVIDUAL ind = IndividualDao.Instance().SelectbyId(p.CUST_ID);
            if (ind != null)
            {
                In_lastname = ind.LAST_NAME;
                In_firstname = ind.FIRST_NAME;
                In_birthdate = ind.BIRTH_DATE.ToString();
            }
            if (of != null)
            {
                Of_lastname = of.LAST_NAME;
                Of_firstname = of.FIRST_NAME;
                Of_title = of.TITLE;
                Of_startdate = of.START_DATE.ToString();
                Of_enddate = of.END_DATE.ToString();
            }
            if (bu != null)
            {
                Bu_name = bu.NAME;
                Bu_stateid = bu.STATE_ID;
                Bu_incorpdate = bu.INCORP_DATE.ToString();
            }
        }
        private void Find(FrameworkElement p)
        {
            string id = "";
            if (p != null)
            {
                var fe = p as Grid;
                if (fe != null)
                {
                    foreach (var item in fe.Children)
                    {
                        var tx = item as TextBox;
                        if (tx != null)
                        {
                            if (tx.Name.Equals("txtSearch"))
                            {
                                id = tx.Text;
                            }
                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(id))
            {
                String key = id.ToLower();
                ObservableCollection<CUSTOMER> result = new ObservableCollection<CUSTOMER>();
                foreach (CUSTOMER c in CustomerLists)
                {
                    OFFICER of = OfficerDao.Instance().SelectbyCustId(c.CUST_ID);
                    BUSINESS bu = BusinessDao.Instance().SelectbyId(c.CUST_ID);
                    INDIVIDUAL ind = IndividualDao.Instance().SelectbyId(c.CUST_ID);
                    String temp = c.CUST_ID.ToString() + " " + c.ADDRESS + " " + c.CITY + " " + c.FED_ID + " " + c.POSTAL_CODE + " " + c.STATE + " ";
                    if (of != null && bu != null) temp +=
                                         of.FIRST_NAME + " " + of.LAST_NAME + " " + of.OFFICER_ID + " " + of.TITLE + " " + of.START_DATE.ToString() + " " + of.END_DATE.ToString() + " " +
                                         bu.NAME + "  " + bu.STATE_ID + " " + bu.INCORP_DATE.ToString() + " ";
                    if (ind != null) temp += ind.LAST_NAME + " " + ind.FIRST_NAME + " " + ind.BIRTH_DATE.ToString();
                    temp.ToLower();
                    if (temp.Contains(key)) result.Add(c);
                }
                CustomerLists = result;
            }
            else
            {
                CustomerLists = new ObservableCollection<CUSTOMER>(CustomerDao.Instance().getAll());
            }
        }
        private void ShowEditForm(CUSTOMER pv)
        {

            if (pv != null)
            {

                CustomerEdit pro = new CustomerEdit(pv, this);
                pro.Show();
       
            }
        }
        private void NewEditForm()
        {
            CustomerEdit pro = new CustomerEdit(null, this);
            pro.Show();
           
         

        }
        private void RemoveDepartment(CUSTOMER pv)
        {

            CustomerDao.Instance().Delete(pv.CUST_ID);
            CustomerLists.Remove(pv);

        }
        private void ResetView()
        {
            In_lastname = "";
            In_firstname = "";
            In_birthdate = "";
            Of_lastname = "";
            Of_firstname = "";
            Of_title = "";
            Of_startdate = "";
            Of_enddate = "";
            Bu_name = "";
            Bu_stateid = "";
            Bu_incorpdate = "";

        }
    }
}
