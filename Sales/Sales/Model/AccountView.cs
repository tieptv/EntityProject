using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Model
{
    public class AccountView
    {
        public int id { get; set; }
        public Nullable<double> avail_balance { get; set; }
        public Nullable<System.DateTime> close_date { get; set; }
        public Nullable<System.DateTime> last_date { get; set; }
        public System.DateTime open_date { get; set; }
        public Nullable<double> pending_balance { get; set; }
        public string status { get; set; }
        public String branch { get; set; }
        public EMPLOYEE employee { get; set; }
        public string product { get; set; }
        public CUSTOMER customer { get; set; }
        public String NameCus { get; set; }
        public String NameEm { get; set; }
        public AccountView()
        {
        }
        public AccountView(ACCOUNT a)
        {
            this.id = a.ACCOUNT_ID;
            this.avail_balance = a.AVAIL_BALANCE;
            this.close_date = a.CLOSE_DATE;
            this.last_date = a.LAST_ACTIVITY_DATE;
            this.open_date = a.OPEN_DATE;
            this.pending_balance = a.PENDING_BALANCE;
            this.status = a.STATUS;
            this.branch = BranchDao.Instance().SelectbyId(a.OPEN_BRANCH_ID).NAME;
            this.employee = EmployeeDao.Instance().SelectbyId(a.OPEN_EMP_ID);
            this.NameEm = employee.FIRST_NAME + " " + employee.LAST_NAME;
            this.product = ProductDao.Instance().SelectbyId(a.PRODUCT_CD).NAME;
            this.customer = CustomerDao.Instance().SelectbyId(a.CUST_ID);
            if (customer.CUST_TYPE_CD == "I")
            {
                INDIVIDUAL ind = IndividualDao.Instance().SelectbyId(a.CUST_ID);
                if (ind == null) this.NameCus = "";
                else
                    this.NameCus = ind.FIRST_NAME + " " + ind.LAST_NAME;
            }
            else
            {
                OFFICER off = OfficerDao.Instance().SelectbyCustId(a.CUST_ID);
                if (off == null) this.NameCus = "";
                else
                    this.NameCus = off.FIRST_NAME + " " + off.LAST_NAME;
            }
        }
    }
}
