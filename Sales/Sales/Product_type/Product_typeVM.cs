using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Sales.Product_type
{
   public  class Product_typeVM: BaseClass
    {
        #region Varible
        /// <summary>
        /// 
        /// </summary>
        private PRODUCT_TYPE _Product_typeObj;
        public PRODUCT_TYPE Product_typeObj
        {
            get { return _Product_typeObj; }
            set { _Product_typeObj = value; NotifyPropertyChanged(); }
        }

        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<PRODUCT_TYPE> _Product_typeLists;
        public ObservableCollection<PRODUCT_TYPE> Product_typeLists
        {
            get { return _Product_typeLists; }
            set { _Product_typeLists = value; NotifyPropertyChanged(); }
        }

        public ICommand FindCommand { get; set; }
        public ICommand EditFormCommand { get; set; }
        public ICommand NewFormCommand { get; set; }
        public ICommand DeleteRowCommand { get; set; }
        #endregion

        #region Events
        /// <summary>
        /// Constructor
        /// </summary>
        public Product_typeVM()
        {
            Product_typeLists = new ObservableCollection<PRODUCT_TYPE>(Product_TypeDao.Instance().getAll());
            FindCommand = new RelayCommand<FrameworkElement>((p) => { return p != null ? true : false; }, (p) => { FindProduct_type(p); });
            EditFormCommand = new RelayCommand<PRODUCT_TYPE>((p) => true, (p) => { ShowEditForm(p); });
            DeleteRowCommand = new RelayCommand<PRODUCT_TYPE>((p) => true, (p) => { RemoveProduct_type(p); });
            NewFormCommand = new RelayCommand<Window>((p) => true, (p) => { NewEditForm(); });
        }

        private void FindProduct_type(FrameworkElement p)
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
                Product_typeLists = new ObservableCollection<PRODUCT_TYPE>(Product_TypeDao.Instance().getListByName(id));
            else
                Product_typeLists = new ObservableCollection<PRODUCT_TYPE>(Product_TypeDao.Instance().getAll());

        }
        private void ShowEditForm(PRODUCT_TYPE p)
        {

            if (p != null)
            {
                 ProductTypeEdit pt = new ProductTypeEdit(p, this);
                 pt.Show();
                 pt.txtProductTypecd.IsReadOnly = true;
            }
        }
        private void NewEditForm()
        {
            ProductTypeEdit pt = new ProductTypeEdit(null, this);
            pt.Show();
        }
        private void RemoveProduct_type(PRODUCT_TYPE pt)
        {

           Product_TypeDao.Instance().Delete(pt.PRODUCT_TYPE_CD);
           Product_typeLists = null;
           Product_typeLists = new ObservableCollection<PRODUCT_TYPE>(Product_TypeDao.Instance().getAll());
        }
        #endregion
    }
}

