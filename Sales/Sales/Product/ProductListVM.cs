using SaleModel.Model;
using SaleModel.Product;
using Sales.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Sales.Product
{
    public class ProductListVM :BaseClass
    {
        private ProductView _ProductViewObj;
        public ProductView ProductViewObj
        {
            get { return _ProductViewObj; }
            set { _ProductViewObj = value; NotifyPropertyChanged(); }
        }
        private ObservableCollection<ProductView> _ProductViewLists;
        public ObservableCollection<ProductView> ProductViewLists
        {
            get { return _ProductViewLists; }
            set { _ProductViewLists = value; NotifyPropertyChanged(); }
        }
        public ICommand FindCommand { get; set; }
        public ICommand EditFormCommand { get; set; }
        public ICommand NewFormCommand { get; set; }
        public ICommand DeleteRowCommand { get; set; }
        List<PRODUCT_TYPE> listpt; 
        public ProductListVM()
        {

            listpt = Product_TypeDao.Instance().getAll();
            ProductViewLists = UpdateListview();
            FindCommand = new RelayCommand<FrameworkElement>((p) => { return p != null ? true : false; }, (p) => { FindProduct(p); });
            EditFormCommand = new RelayCommand<ProductView>((p) => true, (p) => { ShowEditForm(p); });
            DeleteRowCommand = new RelayCommand<ProductView>((p) => true, (p) => { RemoveDepartment(p); });
            NewFormCommand = new RelayCommand<Window>((p) => true, (p) => { NewEditForm(); });
        }
        public ObservableCollection<ProductView> UpdateListview()
        {   List<PRODUCT> listp=ProductDao.Instance().getAll();
          
            ObservableCollection<ProductView> result = new ObservableCollection<ProductView>();
            foreach (PRODUCT p in listp)
            {
                ProductView pv = new ProductView(p);
                result.Add(pv);
            }
            return result;

        }
        private void FindProduct(FrameworkElement p)
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
                ObservableCollection<ProductView> result =new ObservableCollection<ProductView>();
                foreach (ProductView pv in _ProductViewLists)
                {
                    String temp = (pv.date_offer.ToString() + " " + pv.date_retire.ToString() + " " + pv.type + " " + pv.product_cd + " " + pv.name).ToLower();
                    if (temp.Contains(id)) result.Add(pv);
                }
                ProductViewLists = result;
            }
            else
            {
                ProductViewLists = UpdateListview();
            }
        }
        private void ShowEditForm(ProductView pv)
        {

            if (pv != null)
            {
              
               ProductEdit1 pro = new ProductEdit1(pv, this);
               pro.Show();
               pro.txtPRODUCT_CD.IsReadOnly = true;
               pro.type.ItemsSource = listpt;
              
           }
        }
        private void NewEditForm()
        {
            ProductEdit1 pro = new ProductEdit1(null, this);
            pro.Show();
            pro.type.ItemsSource = listpt;
          
        }
        private void RemoveDepartment(ProductView pv)
        {

            ProductDao.Instance().Delete(pv.product_cd);
            ProductViewLists.Remove(pv); 
           
        }
    }
}
