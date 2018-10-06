using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Model
{
    public class Account_tran
    {
        public decimal txnid { get; set; }
        public double amount { get; set; }
        public System.DateTime fund_date { get; set; }
        public System.DateTime txndate { get; set; }
        public string txntype { get; set; }
        public String branch { get; set; }
        public String employee { get; set; }
        public Account_tran()
        {
        }
        public Account_tran(ACC_TRANSACTION at)
        {
            if(at!=null)
            {
            this.txnid = at.TXN_ID;
            this.amount = at.AMOUNT;
            this.fund_date = at.FUNDS_AVAIL_DATE;
            this.txndate = at.TXN_DATE;
            this.txntype = at.TXN_TYPE_CD;
            if(at.EXECUTION_BRANCH_ID!=null)
            this.branch = BranchDao.Instance().SelectbyId(at.EXECUTION_BRANCH_ID).NAME;
            if(at.TELLER_EMP_ID!=null)
            this.employee = EmployeeDao.Instance().SelectbyId(at.TELLER_EMP_ID).FIRST_NAME;
            }
        }
    }
}
