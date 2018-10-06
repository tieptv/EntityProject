using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel.Product
{
    public class EmployeeDao : IModelTemplate<EMPLOYEE>
    {
        //Khoi tao doi tuong lam viec voi database
        private static EmployeeDao _instance;
        public static EmployeeDao Instance()
        {
            if(_instance==null)_instance= new EmployeeDao();
           return _instance;

           }
    /// <summary>
    /// Thêm doi tuong vao bang EMOLOYEE
    /// </summary>
    /// <param name="pt">Truyền vào 1 tham so kieu EMPLOYEE</param>
    public void Insert(EMPLOYEE e)
    {
        using (SalesEntities3 eitity = new SalesEntities3())
        {
            //Thêm sản phẩm vào database
            try
            {
                if (e != null)
                {
                    eitity.EMPLOYEEs.Add(e);
                    eitity.SaveChanges();
                }
            }
            catch
            {

                throw new Exception();
            }
        }
    }

    public void Update(EMPLOYEE ep)
    {
        using (SalesEntities3 eitity = new SalesEntities3())
        {
            EMPLOYEE em = (from e in eitity.EMPLOYEEs where e.EMP_ID == ep.EMP_ID select e).First();
            try
            {
                em.ASSIGNED_BRANCH_ID = ep.ASSIGNED_BRANCH_ID;
                em.DEPT_ID = ep.DEPT_ID;
                em.END_DATE = ep.END_DATE;
                em.FIRST_NAME = ep.FIRST_NAME;
                em.LAST_NAME = ep.LAST_NAME;
                em.START_DATE = ep.START_DATE;
                em.TITLE = ep.TITLE;
                em.SUPERIOR_EMP_ID = ep.SUPERIOR_EMP_ID;
                eitity.SaveChanges();
            }
            catch { throw new Exception(); }
        }
    }


    public void Delete(object em)
    {
        using (SalesEntities3 eitity = new SalesEntities3())
        {
            try
            {
                int id = (int)em;
                var temp = (from e in eitity.EMPLOYEEs where e.EMP_ID == id select e).First();
                eitity.Entry(temp).State = EntityState.Deleted;
                eitity.SaveChanges();
            }
            catch { throw new Exception(); }
        }
    }
    /// <summary>
    /// Lấy danh sách loại sản phẩm
    /// </summary>
    /// <returns></returns>
    public List<EMPLOYEE> getAll()
    {
        using (SalesEntities3 eitity = new SalesEntities3())
        {
            var list = from x in eitity.EMPLOYEEs select x;
            return list.ToList();
        }

    }

    public EMPLOYEE SelectbyId(object em)
    {
        using (SalesEntities3 eitity = new SalesEntities3())
        {
            try
            {

                int id = (int)em;
                var temp = (from e in eitity.EMPLOYEEs where e.EMP_ID == id select e).First();
                return temp;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
}
