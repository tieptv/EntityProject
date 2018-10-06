using SaleModel.Model;
using Sales.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using SaleModel.Product;
using System.Linq;

namespace Sales.Account
{
    public class AccountVM : BaseClass
    {
        private AccountView _AccountViewObj;
        public AccountView AccountViewObj
        {
            get { return _AccountViewObj; }
            set { _AccountViewObj = value; NotifyPropertyChanged(); }
        }
        private ObservableCollection<AccountView> _AccountViewLists;
        public ObservableCollection<AccountView> AccountViewLists
        {
            get { return _AccountViewLists; }
            set { _AccountViewLists = value; NotifyPropertyChanged(); }
        }
        private Account_tran _Account_tranObj;
        public Account_tran Account_tranObj
        {
            get { return _Account_tranObj; }
            set { _Account_tranObj = value; NotifyPropertyChanged(); }
        }
        private ObservableCollection<Account_tran> _Account_tranLists;
        public ObservableCollection<Account_tran> Account_tranLists
        {
            get { return _Account_tranLists; }
            set { _Account_tranLists = value; NotifyPropertyChanged(); }
        }
        public ICommand FindCommand { get; set; }
        public ICommand EditFormCommand { get; set; }
        public ICommand NewFormCommand { get; set; }
        public ICommand DeleteRowCommand { get; set; }
        public ICommand SelectedItemCommand { get; set; }
        public ICommand NextButtonCommand { get; set; }
        public ICommand PrevButtonCommand { get; set; }
        public ICommand LastButtonCommand { get; set; }
        public ICommand FirstButtonCommand { get; set; }
        List<ProductView> listpro = new List<ProductView>();
        List<EmployeeView> listem = new List<EmployeeView>();
        public AccountVM()
        {
            List<PRODUCT> listp = ProductDao.Instance().getAll();
            List<EMPLOYEE> liste = EmployeeDao.Instance().getAll();
            foreach (PRODUCT p in listp)
            {
                ProductView pv = new ProductView(p);
                listpro.Add(pv);
            }
            foreach (EMPLOYEE p in liste)
            {
                EmployeeView pv = new EmployeeView(p);
                listem.Add(pv);
            }
            AccountViewLists = UpdateListview();
            FindCommand = new RelayCommand<FrameworkElement>((p) => { return p != null ? true : false; }, (p) => { Find(p); });
            EditFormCommand = new RelayCommand<AccountView>((p) => true, (p) => { ShowEditForm(p); });
            DeleteRowCommand = new RelayCommand<AccountView>((p) => true, (p) => { Remove(p); });
            NewFormCommand = new RelayCommand<Window>((p) => true, (p) => { NewEditForm(); });
            SelectedItemCommand = new RelayCommand<AccountView>((p) => { return p != null ? true : false; }, (p) => { SelectedItem(p); });
            NextButtonCommand = new RelayCommand<AccountView>((p) => true, (p) => { NextButton(p); });
            PrevButtonCommand = new RelayCommand<AccountView>((p) => true, (p) => { PrevButton(p); });
            FirstButtonCommand = new RelayCommand<AccountView>((p) => true, (p) => { FirstButton(p); });
            LastButtonCommand = new RelayCommand<AccountView>((p) => true, (p) => { LastButton(p); });


        }
        public ObservableCollection<AccountView> UpdateListview()
        {
            List<ACCOUNT> lista = AccountDao.Instance().getAll();

            ObservableCollection<AccountView> result = new ObservableCollection<AccountView>();
            foreach (ACCOUNT p in lista)
            {
                AccountView pv = new AccountView(p);
                result.Add(pv);
            }
            return result;

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
                var result = from e in AccountViewLists
                             where e.NameCus.Contains(id) || e.NameEm.Contains(id) || e.branch.Contains(id) || e.product.Contains(id) || e.status.Contains(id)
                             select e;
                List<AccountView> list = result.ToList();
                AccountViewLists = new ObservableCollection<AccountView>(list);
            }
            else
            {
                AccountViewLists = UpdateListview();
            }
        }
        private void ShowEditForm(AccountView pv)
        {

            if (pv != null)
            {

                AccountEdit ac = new AccountEdit();
                ac.Show();
                AccountEditVM avm = new AccountEditVM();
                ac.DataContext = avm;
                avm.vm = this;
                avm.AccountViewObj = AccountViewObj;
                avm.Account_tranObj = Account_tranObj;
                avm.CustId = AccountViewObj.customer.CUST_ID;
                avm.cv = "update";
                ac.ComBranch.ItemsSource = BranchDao.Instance().getAll();
                ac.ComProduct.ItemsSource = listpro;
                avm.listem = listem;
                ac.ComEm.ItemsSource = listem;
            }
        }
        private void NewEditForm()
        {
            if (AccountViewObj != null)
            {
                AccountEdit ac = new AccountEdit();
                ac.Show();
                AccountEditVM avm = new AccountEditVM();
                ac.DataContext = avm;
                avm.vm = this;
                avm.CustId = AccountViewObj.customer.CUST_ID;
                avm.AccountViewObj.NameCus = AccountViewObj.NameCus;
                avm.cv = "insert";
                avm.listem = listem;
                ac.ComBranch.ItemsSource = BranchDao.Instance().getAll();
                ac.ComProduct.ItemsSource = listpro;
                ac.ComEm.ItemsSource = listem;
            }
            else MessageBox.Show("Chưa có tên khách hàng");

        }
        private void Remove(AccountView pv)
        {
            AccountDao.Instance().Delete(pv.id);
            AccountViewLists.Remove(pv);

        }
        private void SelectedItem(AccountView pv)
        {
            ACC_TRANSACTION ac = Acc_transactionDao.Instance().SelectbyId(pv.id);
            Account_tranObj = new Account_tran(ac);
            Account_tranLists = new ObservableCollection<Account_tran>();
            Account_tranLists.Add(Account_tranObj);
        }
        private void NextButton(AccountView p)
        {
            int len = AccountViewLists.Count;
            if (p == null) AccountViewObj = AccountViewLists[0];
            else
            {
                for (int i = 0; i < len; i++) if (p.id == AccountViewLists[i].id && i < len - 1)
                        AccountViewObj = AccountViewLists[i + 1];
                Console.WriteLine(AccountViewObj.id);
            }
            SelectedItem(AccountViewObj);
        }
        private void PrevButton(AccountView p)
        {
            int len = AccountViewLists.Count;
            if (p != null)

            {
                for (int i = 0; i < len; i++) if (p.id == AccountViewLists[i].id && i > 0)
                        AccountViewObj = AccountViewLists[i - 1];
            }
            SelectedItem(AccountViewObj);
        }
        private void FirstButton(AccountView p)
        {
            int len = AccountViewLists.Count;
            if (len > 0)
                AccountViewObj = AccountViewLists[0];
            SelectedItem(AccountViewObj);
        }
        private void LastButton(AccountView p)
        {
            int len = AccountViewLists.Count;
            if (len > 0) AccountViewObj = AccountViewLists[len - 1];
            SelectedItem(AccountViewObj);
        }
    }
}


