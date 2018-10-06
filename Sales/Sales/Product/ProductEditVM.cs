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

namespace Sales.Product
{
    public class ProductEditVM: BaseClass
    {
        private ProductListVM vm;
        private String cv;
        private String _Product_cd;
        public String Product_cd
        {
            get { return _Product_cd; }
            set { _Product_cd = value; NotifyPropertyChanged(); }
        }
        private String _Type;
        public String Type
        {
            get { return _Type; }
            set { _Type = value; NotifyPropertyChanged(); }
        }
        private String _Name;
        public String Name
        {
            get { return _Name; }
            set { _Name = value; NotifyPropertyChanged(); }
        }
        private String _Date_offer;
        public String Date_offer
        {
            get { return _Date_offer; }
            set { _Date_offer = value; NotifyPropertyChanged(); }
        }
        private String _Date_retire;
        public String Date_retire
        {
            get { return _Date_retire; }
            set { _Date_retire = value; NotifyPropertyChanged(); }
        }
        public ICommand OKCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public ProductEditVM(ProductView pt, ProductListVM vm)
        {
            if (pt == null)
            {
                this.Product_cd = "";
                this.Type = "";
                this.Name = "";
                this.Date_offer = "";
                this.Date_retire = "";
                this.cv = "insert";
            }
            else
            {
                this.Product_cd = pt.product_cd;
                this.Type = pt.type;
                this.Name = pt.name;
                this.Date_offer = pt.date_offer.ToString();
                this.Date_retire = pt.date_retire.ToString();
                this.cv = "update";
            }
            this.vm = vm;
            OKCommand = new RelayCommand<Window>((p) => { return p != null ? true : false; }, (p) => { OKevent(p); });
            CancelCommand = new RelayCommand<Window>((p) => true, (p) => { p.Close(); });
        }
        private void OKevent(Window p)
        {
            PRODUCT pro = new PRODUCT();
            pro.PRODUCT_CD = Product_cd;
            pro.PRODUCT_TYPE_CD = Product_TypeDao.Instance().SelectbyName(Type).PRODUCT_TYPE_CD;
            pro.NAME = Name;
            pro.DATE_OFFERED = Convert.ToDateTime(Date_offer);
            if (Date_retire == null || Date_retire == "") pro.DATE_RETIRED = null;
            else pro.DATE_RETIRED = Convert.ToDateTime(Date_retire);
            if (cv == "insert")
            { ProductDao.Instance().Insert(pro);
                vm.ProductViewLists = vm.UpdateListview();
            }
            else
            {
                ProductDao.Instance().Update(pro);
                vm.ProductViewLists = vm.UpdateListview();
            }
            p.Close();
            
        }
    }
}
