using SaleModel.Department;
using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Sales.Department
{
    public class DepartmentEditVM:BaseClass
    {
        /* private int _Dep_id;
         public int Dep_id
         {
             get { return _Dep_id; }
             set { _Dep_id = value; NotifyPropertyChanged(); }
         }
         private String _Name;
         public String Name
         {
             get { return _Name; }
             set { _Name = value; NotifyPropertyChanged(); }
         }
         */
        private String cv;
        private DepartmentVM dvm;
        public ICommand OKCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public DepartmentEditVM()
        {
            
            OKCommand = new RelayCommand<FrameworkElement>((p) => { return p != null ? true : false; }, (p) => { OKevent(p); });
            CancelCommand = new RelayCommand<Window>((p) => true, (p) => { p.Close(); });
        }
        public DepartmentEditVM(String cv, DepartmentVM dvm)
        {
            this.cv = cv;
            this.dvm = dvm;
            OKCommand = new RelayCommand<FrameworkElement>((p) => { return p != null ? true : false; }, (p) => { OKevent(p); });
            CancelCommand = new RelayCommand<Window>((p) => true, (p) => { p.Close(); });
        }
        private void OKevent(FrameworkElement p)
        {
            DEPARTMENT dep = new DEPARTMENT();
            var fe = p as Grid;
            if (fe != null)
            {
                foreach (var item in fe.Children)
                {
                    var tx = item as TextBox;
                    if (tx != null)
                    {
                        if (tx.Name.Equals("txtDepID"))
                            dep.DEPT_ID = int.Parse(tx.Text);
                        else if (tx.Name.Equals("txtName")) dep.NAME = tx.Text;
                    }
                }
            }
            if (dep.DEPT_ID <= DepartmentDao.Instace().GetLastID()) DepartmentDao.Instace().Update(dep);
            else DepartmentDao.Instace().Insert(dep);
            foreach (Window item in Application.Current.Windows)
            {
                if (item.DataContext == this) item.Close();
            }
            dvm.DeparmentLists = null;
            dvm.DeparmentLists = new System.Collections.ObjectModel.ObservableCollection<DEPARTMENT>(DepartmentDao.Instace().getAll());
        }
    }
}