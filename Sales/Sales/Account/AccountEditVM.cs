using SaleModel.Model;
using SaleModel.Product;
using Sales.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Sales.Account
{
    public class AccountEditVM : BaseClass
    {
        public AccountVM vm;
        public String cv;
        private AccountView _AccountViewObj;
        public AccountView AccountViewObj
        {
            get { return _AccountViewObj; }
            set { _AccountViewObj = value; NotifyPropertyChanged(); }
        }
        private Account_tran _Account_tranObj;
        public Account_tran Account_tranObj
        {
            get { return _Account_tranObj; }
            set { _Account_tranObj = value; NotifyPropertyChanged(); }
        }
        public ICommand OKCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public List<EmployeeView> listem;
        public int CustId;
        public AccountEditVM()
        {
            if (AccountViewObj == null)
            {
                AccountViewObj = new AccountView();
                AccountViewObj.open_date = DateTime.Now;
                AccountViewObj.last_date = DateTime.Now;
                Account_tranObj = new Account_tran();
                Account_tranObj.fund_date = DateTime.Now;
                Account_tranObj.txndate = DateTime.Now;
            }

            OKCommand = new RelayCommand<Window>((p) => { return p != null ? true : false; }, (p) => { OKevent(p); });
            CancelCommand = new RelayCommand<Window>((p) => true, (p) => { p.Close(); });
        }
        private void OKevent(Window p)
        {
            ACCOUNT ac = new ACCOUNT();
            ACC_TRANSACTION tran = new ACC_TRANSACTION();
            ac.AVAIL_BALANCE = AccountViewObj.avail_balance;
            ac.CLOSE_DATE = AccountViewObj.close_date;
            ac.OPEN_DATE = AccountViewObj.open_date;
            ac.PENDING_BALANCE = AccountViewObj.pending_balance;
            ac.STATUS = AccountViewObj.status;
            ac.PRODUCT_CD = ProductDao.Instance().SelectbyName(AccountViewObj.product).PRODUCT_CD;
            ac.LAST_ACTIVITY_DATE = AccountViewObj.last_date;
            ac.OPEN_BRANCH_ID = BranchDao.Instance().SelectbyName(AccountViewObj.branch).BRANCH_ID;
            ac.OPEN_EMP_ID = FindEm(AccountViewObj.NameEm, listem);
            ac.CUST_ID = CustId;

            tran.EXECUTION_BRANCH_ID = null;
            tran.TELLER_EMP_ID = null;
            tran.FUNDS_AVAIL_DATE = Account_tranObj.fund_date;
            tran.AMOUNT = Account_tranObj.amount;
            tran.TXN_DATE = Account_tranObj.txndate;
            tran.TXN_TYPE_CD = Account_tranObj.txntype;
            if (cv == "insert")
            {

                try
                {
                    AccountDao.Instance().Insert(ac, tran);
                }
                catch
                {
                    throw new Exception();
                }

            }
            else
            {
                using (SalesEntities3 entity = new SalesEntities3())
                {

                    try
                    {
                        ac.ACCOUNT_ID = AccountViewObj.id;
                        tran.ACCOUNT_ID = AccountViewObj.id;
                        tran.TXN_ID = Account_tranObj.txnid;
                        AccountDao.Instance().Update(ac,tran);
                    }
                    catch
                    {
                        throw new Exception();
                    }
                }
            }
            p.Close();
            vm.AccountViewLists = vm.UpdateListview();
        }
        private static int FindEm(String name, List<EmployeeView> list)
        {
            foreach (EmployeeView em in list)
                if (name.Equals(em.NameEm)) return em.id;
            return 0;
        }
        private static int FindCus(String name, List<EmployeeView> list)
        {
            foreach (EmployeeView em in list)
                if (name.Equals(em.NameEm)) return em.id;
            return 0;
        }
    }
}
