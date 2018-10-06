using SaleModel.Department;
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

namespace Sales.Employee
{
   public  class EmployeeEditVM :BaseClass
    {   private String cv;
        private EmployeeVM _evm;
        public EmployeeVM evm
        {
            get { return _evm; }
            set { _evm = value; NotifyPropertyChanged(); }
        }
        private EmployeeView _EmployeeViewObj;
        public EmployeeView EmployeeViewObj
        {
            get { return _EmployeeViewObj; }
            set { _EmployeeViewObj = value; NotifyPropertyChanged(); }
        }
        public ICommand OKCommand { get; set; }
        public ICommand CancelCommand { get; set; }
        public EmployeeEditVM()
        {
            if (EmployeeViewObj == null)
            { cv = "insert";
                EmployeeViewObj = new EmployeeView();
                EmployeeViewObj.start_date = DateTime.Now;
            }
            else cv = "update";
            OKCommand = new RelayCommand<Window>((p) => { return p != null ? true : false; }, (p) => { OKevent(p); });
            CancelCommand = new RelayCommand<Window>((p) => true, (p) => { p.Close(); });
        }
        private void OKevent(Window p)
        {
            EMPLOYEE em = new EMPLOYEE();
            em.FIRST_NAME =EmployeeViewObj.first_name;
            em.LAST_NAME = EmployeeViewObj.last_name ;
            em.TITLE = EmployeeViewObj.title;
            em.START_DATE = EmployeeViewObj.start_date;
            em.END_DATE = EmployeeViewObj.end_date;
            em.ASSIGNED_BRANCH_ID = BranchDao.Instance().SelectbyName(EmployeeViewObj.branch).BRANCH_ID;
            em.DEPT_ID =DepartmentDao.Instace().SelectbyName(EmployeeViewObj.department).DEPT_ID;
            em.SUPERIOR_EMP_ID = null;
            if (cv == "insert")
            {
                EmployeeDao.Instance().Insert(em);
                evm.EmployeeViewLists=evm.UpdateListview();
            }
            else
            {
                em.EMP_ID = EmployeeViewObj.id;
                EmployeeDao.Instance().Update(em);
                 evm.EmployeeViewLists=evm.UpdateListview();
            }
            p.Close();

        }

    }
}
