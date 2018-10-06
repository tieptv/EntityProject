using SaleModel.Department;
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

namespace Sales.Employee
{
    public class EmployeeVM : BaseClass
    {
        private EmployeeView _EmployeeViewObj;
        public EmployeeView EmployeeViewObj
        {
            get { return _EmployeeViewObj; }
            set { _EmployeeViewObj = value; NotifyPropertyChanged(); }
        }
        private ObservableCollection<EmployeeView> _EmployeeViewLists;
        public ObservableCollection<EmployeeView> EmployeeViewLists
        {
            get { return _EmployeeViewLists; }
            set { _EmployeeViewLists = value; NotifyPropertyChanged(); }
        }
        public ICommand FindCommand { get; set; }
        public ICommand EditFormCommand { get; set; }
        public ICommand NewFormCommand { get; set; }
        public ICommand DeleteRowCommand { get; set; }
        public EmployeeVM()
        {


            EmployeeViewLists = UpdateListview();
            FindCommand = new RelayCommand<FrameworkElement>((p) => { return p != null ? true : false; }, (p) => { FindEmployee(p); });
            EditFormCommand = new RelayCommand<EmployeeView>((p) => true, (p) => { ShowEditForm(p); });
            DeleteRowCommand = new RelayCommand<EmployeeView>((p) => true, (p) => { Remove(p); });
            NewFormCommand = new RelayCommand<Window>((p) => true, (p) => { NewEditForm(); });
        }
        public ObservableCollection<EmployeeView> UpdateListview()
        {
            List<EMPLOYEE> listp = EmployeeDao.Instance().getAll();

            ObservableCollection<EmployeeView> result = new ObservableCollection<EmployeeView>();
            foreach (EMPLOYEE p in listp)
            {
                EmployeeView pv = new EmployeeView(p);
                result.Add(pv);
            }
            return result;

        }
        private void FindEmployee(FrameworkElement p)
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
                String id1 = id.ToLower();
                ObservableCollection<EmployeeView> result = new ObservableCollection<EmployeeView>();
                foreach (EmployeeView pv in _EmployeeViewLists)
                {
                  
                    String temp = (pv.start_date.ToString() + " " + pv.end_date.ToString() + " " + pv.department + " " + pv.branch + " " + pv.first_name
                        + " " + pv.last_name + " " + pv.title + " " + pv.SupervisorEm).ToLower();
                    if (temp.Contains(id1)) result.Add(pv);
                }
                EmployeeViewLists = result;
            }
            else
            {
                EmployeeViewLists = UpdateListview();
            }
        }
        private void ShowEditForm(EmployeeView pv)
        {

            if (pv != null)
            {

                EmployeeEdit pro = new EmployeeEdit();
                EmployeeEditVM eevm = new EmployeeEditVM();
                eevm.evm = this;
                eevm.EmployeeViewObj = pv;
                pro.DataContext = eevm;
                pro.Show();
                pro.txtID.IsReadOnly = true;
                pro.txtBranch.ItemsSource = BranchDao.Instance().getAll();
                pro.txtDepartment.ItemsSource = DepartmentDao.Instace().getAll();
            }
        }
        private void NewEditForm()
        {
            EmployeeEdit pro = new EmployeeEdit();
            EmployeeEditVM eevm = new EmployeeEditVM();
            eevm.evm = this;
            pro.DataContext = eevm;
            pro.Show();
            pro.txtID.IsReadOnly = true;
            pro.txtBranch.ItemsSource = BranchDao.Instance().getAll();
            pro.txtDepartment.ItemsSource = DepartmentDao.Instace().getAll();

        }
        private void Remove(EmployeeView pv)
        {

            EmployeeDao.Instance().Delete(pv.id);
            EmployeeViewLists.Remove(pv);

        }
    }
}
