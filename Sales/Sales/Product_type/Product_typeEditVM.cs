using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Sales.Product_type
{
   public class Product_typeEditVM : BaseClass
    {
        private Product_typeVM vm;
        private String cv;
        private String _Product_type_cd;
        public String Product_type_cd
        {
            get { return _Product_type_cd; }
            set { _Product_type_cd = value; NotifyPropertyChanged(); }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set { _Name = value; NotifyPropertyChanged(); }
        }
      
        public ICommand OKCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public Product_typeEditVM(PRODUCT_TYPE pt, Product_typeVM vm)
        {
            if(pt==null)
            {
                this.Product_type_cd = "";
                this.Name = "";
                this.cv = "insert";
            }
            else
            {
                this.Product_type_cd = pt.PRODUCT_TYPE_CD;
                this.Name = pt.NAME;
                this.cv = "update";
            }
            this.vm = vm;
            OKCommand = new RelayCommand<Window>((p) => { return p != null ? true : false; }, (p) => { OKevent(p); });
            CancelCommand = new RelayCommand<Window>((p) => true, (p) => { p.Close(); });
        }
        private void OKevent(Window p)
        {
            PRODUCT_TYPE pt = new PRODUCT_TYPE();
            pt.PRODUCT_TYPE_CD = Product_type_cd;
            pt.NAME = Name;
            if (cv == "insert") Product_TypeDao.Instance().Insert(pt);
            else Product_TypeDao.Instance().Update(pt);
            vm.Product_typeLists = null;
            vm.Product_typeLists = new System.Collections.ObjectModel.ObservableCollection<PRODUCT_TYPE>(Product_TypeDao.Instance().getAll());
            p.Close();
        }
    }
}
