using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel.Product
{
    public class BranchDao : IModelTemplate<BRANCH>
    {

        private static BranchDao _instance;
        public static BranchDao Instance()
        {
            if (_instance == null) _instance = new BranchDao();
            return _instance;
        }
        /// <summary>
        ///Them mot doi tuong vao bang BRANCH
        /// </summary>
        /// <param name="a">Tham so truyen vao co kieu BRANCH </param>
        public void Insert(BRANCH b)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
            {
                if (b != null)
                {
                    eitity.BRANCHes.Add(b);
                    eitity.SaveChanges();
                }
            } catch
            {
                throw new Exception();
            }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="b"></param>
        public void Update(BRANCH b)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                BRANCH br = (from e in eitity.BRANCHes where e.BRANCH_ID==b.BRANCH_ID select e).First();
            try
            {
                br.ADDRESS = b.ADDRESS;
                br.NAME = b.NAME;
                br.STATE = b.STATE;
                br.ZIP_CODE = b.ZIP_CODE;
                br.CITY = b.CITY;
                eitity.SaveChanges();
            }
            catch 
            {
                throw new Exception();
            }
            }


        }

        public List<BRANCH> getListByName(string name)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = from e in eitity.BRANCHes where e.CITY.Contains(name) || e.NAME.Contains(name) || e.ADDRESS.Contains(name) || e.STATE.Contains(name) || e.ZIP_CODE.Contains(name) select e;
            return list.ToList();
            }
        }

        public void Delete(object b)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
            {
                int id = (int)b;
                var temp = (from e in eitity.BRANCHes where e.BRANCH_ID == id select e).First();
                eitity.Entry(temp).State = EntityState.Deleted;
                eitity.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
            }
        }

        public List<BRANCH> getAll()
        {
            //return eitity.PRODUCT_TYPE.ToList();
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = from x in eitity.BRANCHes select x;
                return list.ToList();
            }
        }

        public BRANCH SelectbyId(object a)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
            {
                int id = (int)a;
                var temp = (from e in eitity.BRANCHes where e.BRANCH_ID == id select e).First();
                var list_acc = from e in eitity.ACCOUNTs where  e.OPEN_BRANCH_ID== temp.BRANCH_ID select e;
                var list_acct = from e in eitity.ACC_TRANSACTION where e.EXECUTION_BRANCH_ID == temp.BRANCH_ID select e;
                var list_em = from e in eitity.EMPLOYEEs where e.ASSIGNED_BRANCH_ID ==temp.BRANCH_ID select e;
                temp.ACCOUNTs = list_acc.ToList();
                temp.ACC_TRANSACTION = list_acct.ToList();
                temp.EMPLOYEEs = list_em.ToList();
                return temp;
            }
            catch {
                throw new Exception();
            }
            }
        }
        public BRANCH SelectbyName(object pt)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    String id = (String)pt;
                    var temp = (from e in eitity.BRANCHes where e.NAME == id select e).FirstOrDefault();
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

