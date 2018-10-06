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

namespace Sales.Branch
{
   public  class BranchVM :BaseClass
    {
        private BRANCH _BranchObj;
        public BRANCH BranchObj
        {
            get { return _BranchObj; }
            set { _BranchObj = value; NotifyPropertyChanged(); }
        }

        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<BRANCH> _BranchLists;
        public ObservableCollection<BRANCH> BranchLists
        {
            get { return _BranchLists; }
            set { _BranchLists = value; NotifyPropertyChanged(); }
        }

        public ICommand FindCommand { get; set; }
        public ICommand EditFormCommand { get; set; }
        public ICommand NewFormCommand { get; set; }
        public ICommand DeleteRowCommand { get; set; }


       
        public BranchVM()
        {
            BranchLists = new ObservableCollection<BRANCH>(BranchDao.Instance().getAll());
            FindCommand = new RelayCommand<FrameworkElement>((p) => { return p != null ? true : false; }, (p) => { Find(p); });
            EditFormCommand = new RelayCommand<BRANCH>((p) => true, (p) => { ShowEditForm(p); });
            DeleteRowCommand = new RelayCommand<BRANCH>((p) => true, (p) => { Remove(p); });
            NewFormCommand = new RelayCommand<Window>((p) => true, (p) => { NewEditForm(); });
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
                BranchLists = new ObservableCollection<BRANCH>(BranchDao.Instance().getListByName(id));
            else
                BranchLists = new ObservableCollection<BRANCH>(BranchDao.Instance().getAll());

        }
        private void ShowEditForm(BRANCH p)
        {
            
            if (p != null)
            {
                BranchEdit pt = new BranchEdit(p, this);
  
            }
            
        }
        private void NewEditForm()
        {
            BranchEdit pt = new BranchEdit(null, this);
            pt.Show();
            
        }
        private void Remove(BRANCH pt)
        {
            
            BranchDao.Instance().Delete(pt.BRANCH_ID);

            BranchLists.Remove(pt);
        }
    }
}
