using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Sales.Branch
{
    public class BranchEditVM:BaseClass
    {
        private BranchVM vm;
        private String cv;
        private String _Branch_id;
        public String Branch_id
        {
            get { return _Branch_id; }
            set { _Branch_id = value; NotifyPropertyChanged(); }
        }
        private String _Address;
        public String Address
        {
            get { return _Address; }
            set { _Address = value; NotifyPropertyChanged(); }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set { _Name = value; NotifyPropertyChanged(); }
        }
        private String _City;
        public String City
        {
            get { return _City; }
            set { _City = value; NotifyPropertyChanged(); }
        }
        private String _State;
        public String State
        {
            get { return _State; }
            set { _State = value; NotifyPropertyChanged(); }
        }
        private String _Zip_code;
        public String Zip_code
        {
            get { return _Zip_code; }
            set { _Zip_code = value; NotifyPropertyChanged(); }
        }
        public ICommand OKCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public BranchEditVM(BRANCH b, BranchVM vm)
        {
            if (b == null)
            {
                this.Branch_id = "";
                this.Address = "";
                this.Name = "";
                this.City = "";
                this.State = "";
                this.Zip_code = "";
                this.cv = "insert";
            }
            else
            {
                this.Branch_id = b.BRANCH_ID.ToString();
                this.Address = b.ADDRESS;
                this.Name = b.NAME;
                this.City = b.CITY;
                this.State = b.STATE;
                this.Zip_code = b.ZIP_CODE;
                this.cv = "update";
            }
            this.vm = vm;
            OKCommand = new RelayCommand<Window>((p) => { return p != null ? true : false; }, (p) => { OKevent(p); });
            CancelCommand = new RelayCommand<Window>((p) => true, (p) => { p.Close(); });
        }
        private void OKevent(Window p)
        {
            BRANCH bra = new BRANCH();
            bra.BRANCH_ID = int.Parse(Branch_id);
            bra.CITY = City;
            bra.ADDRESS = Address;
            bra.STATE = State;
            bra.NAME = Name;
            bra.ZIP_CODE = Zip_code;
            if (cv == "insert")
            {
                BranchDao.Instance().Insert(bra);
                vm.BranchLists = new ObservableCollection<BRANCH>(BranchDao.Instance().getAll());
            }
            else
            {
                BranchDao.Instance().Update(bra);
                vm.BranchLists = new ObservableCollection<BRANCH>(BranchDao.Instance().getAll());
            }
            p.Close();

        }
    }
}
