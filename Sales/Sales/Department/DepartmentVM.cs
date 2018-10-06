using SaleModel.Department;
using SaleModel.Model;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Sales.Department
{
    /// <summary>
    /// Viewmodel for Department list function
    /// </summary>
    public class DepartmentVM : BaseClass
    {
        #region Varible
        /// <summary>
        /// 
        /// </summary>
        private DEPARTMENT _deparmentObj;
        public DEPARTMENT DeparmentObj
        {
            get { return _deparmentObj; }
            set { _deparmentObj = value; NotifyPropertyChanged(); }
        }

        /// <summary>
        /// 
        /// </summary>
        private ObservableCollection<DEPARTMENT> _deparmentLists;
        public ObservableCollection<DEPARTMENT> DeparmentLists
        {
            get { return _deparmentLists; }
            set { _deparmentLists = value; NotifyPropertyChanged(); }
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
        public DepartmentVM()
        {
            DeparmentLists = new ObservableCollection<DEPARTMENT>(DepartmentDao.Instace().getAll());
            FindCommand = new RelayCommand<FrameworkElement>((p) => { return p != null ? true : false; }, (p) => { FindDepartment(p); });
            EditFormCommand = new RelayCommand<DEPARTMENT>((p) => true, (p) => { ShowEditForm(p); });
            DeleteRowCommand = new RelayCommand<DEPARTMENT>((p) => true, (p) => { RemoveDepartment(p); });
            NewFormCommand = new RelayCommand<Window>((p) => true , (p) => { NewEditForm(); });
        }

        private void FindDepartment(FrameworkElement p)
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
                DeparmentLists = new ObservableCollection<DEPARTMENT>(DepartmentDao.Instace().getListByName(id));
            else
                DeparmentLists = new ObservableCollection<DEPARTMENT>(DepartmentDao.Instace().getAll());

        }
        private void ShowEditForm(DEPARTMENT p)
        {
           
            if (p != null)
            {
                DepartmentEdit depart = new DepartmentEdit("update", this);
                depart.Show();
                depart.txtDepID.Text = p.DEPT_ID.ToString();
                depart.txtDepID.IsReadOnly = true;
                depart.txtName.Text = p.NAME;
            }
        }
        private void NewEditForm()
        {
            DepartmentEdit depart = new DepartmentEdit("insert", this);
            depart.txtDepID.Text = (DepartmentDao.Instace().GetLastID() + 1).ToString();
            depart.txtDepID.IsReadOnly = true;
            depart.Show();       
        }
        private void RemoveDepartment(DEPARTMENT d)
        {

            DepartmentDao.Instace().Delete(d.DEPT_ID);
            DeparmentLists = null;
            DeparmentLists= new ObservableCollection<DEPARTMENT>(DepartmentDao.Instace().getAll());
        }
        #endregion
    }
}
