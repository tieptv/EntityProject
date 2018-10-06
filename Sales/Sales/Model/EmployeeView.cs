using SaleModel.Department;
using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Model
{
    public class EmployeeView
    {
        public int id { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public System.DateTime start_date { get; set; }
        public string title{ get; set; }
        public string branch { get; set; }
        public string department{ get; set; }
        public string SupervisorEm { get; set; }
        public string NameEm { get; set; }
        public EmployeeView(EMPLOYEE e)
        {
            BranchDao bd = new BranchDao();
            DepartmentDao dd = new DepartmentDao();
            EmployeeDao ed = new EmployeeDao();
            this.id = e.EMP_ID;
            this.end_date = e.END_DATE;
            this.first_name = e.FIRST_NAME;
            this.last_name = e.LAST_NAME;
            this.NameEm = e.FIRST_NAME + " " + e.LAST_NAME;
            this.start_date = e.START_DATE;
            this.title = e.TITLE;
            if (e.ASSIGNED_BRANCH_ID == null) this.branch = "";
            else 
            this.branch = bd.SelectbyId(e.ASSIGNED_BRANCH_ID).NAME;
            if (e.DEPT_ID == null) this.department = "";
            else
                this.department = dd.SelectbyId(e.DEPT_ID).NAME;
            if (e.SUPERIOR_EMP_ID ==null) this.SupervisorEm = "";
            else
            this.SupervisorEm = ed.SelectbyId(e.SUPERIOR_EMP_ID).FIRST_NAME;


        }
        public EmployeeView()
        {

        }
    }
}
