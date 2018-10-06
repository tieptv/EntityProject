using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel.Department
{
    public class DepartmentDao : IModelTemplate<DEPARTMENT>
    {
        /// <summary>
        /// Singleton
        /// </summary>
        private static DepartmentDao _instance;
        public static DepartmentDao Instace()
        {
            if (_instance == null) _instance = new DepartmentDao();
            return _instance;
        }

        SalesEntities3 eitity = new SalesEntities3();
        /// <summary>
        /// Thêm vao bang DEPARTMENT
        /// </summary>
        /// <param name="pt">Truyền vào 1 DEPARTMENT</param>
        public void Insert(DEPARTMENT d)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                //Thêm sản phẩm vào database
                try
                {
                    if (d != null)
                    {
                        eitity.DEPARTMENTs.Add(d);
                        eitity.SaveChanges();
                    }
                }
                catch
                {
                    throw new Exception();

                }
            }
        }

        public void Update(DEPARTMENT d)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                DEPARTMENT dt = (from e in eitity.DEPARTMENTs where e.DEPT_ID == d.DEPT_ID select e).First();
                try
                {
                    dt.NAME = d.NAME;
                    eitity.SaveChanges();
                }
                catch
                {
                    throw new Exception();

                }
            }
        }


        public void Delete(object d)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    int id = (int)d;
                    var temp = (from e in eitity.DEPARTMENTs where e.DEPT_ID == id select e).First();
                    eitity.Entry(temp).State = EntityState.Deleted;
                    eitity.SaveChanges();
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

        /// <summary>
        /// Lay tat ca
        /// </summary>
        /// <returns> Danh sach Depart</returns>
        public List<DEPARTMENT> getAll()
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = from x in eitity.DEPARTMENTs select x;
                return list.ToList();
            }
        }
        /// <summary>
        /// Lay tat ca
        /// </summary>
        /// <returns> Danh sach Depart</returns>
        public List<DEPARTMENT> getListByName(string name)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = eitity.DEPARTMENTs.Where(p => p.NAME.Contains(name)).ToList();
                return list.ToList();
            }
        }
        public int GetLastID()
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = eitity.DEPARTMENTs.ToList().Last();
                return list.DEPT_ID;
            }
        }
        public DEPARTMENT SelectbyId(object d)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    int id = (int)d;
                    var temp = (from e in eitity.DEPARTMENTs where e.DEPT_ID == id select e).First();
                    var list_em = from e in eitity.EMPLOYEEs where e.DEPT_ID == temp.DEPT_ID select e;
                    temp.EMPLOYEEs = list_em.ToList();
                    return temp;
                }
                catch
                {
                    throw new Exception();
                }
            }
        }
        public DEPARTMENT SelectbyName(object pt)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    String id = (String)pt;
                    var temp = (from e in eitity.DEPARTMENTs where e.NAME == id select e).FirstOrDefault();
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
