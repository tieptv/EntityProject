using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel.Product
{
    public class OfficerDao : IModelTemplate<OFFICER>
    {
        //Khoi tao doi tuong lam viec voi database
        SalesEntities3 eitity = new SalesEntities3();
        private static OfficerDao _instance;
        public static OfficerDao Instance()
        {
            if (_instance == null) _instance = new OfficerDao();
            return _instance;
        }
        /// <summary>
        /// Them mot doi tuong vao bang OFFFICER
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu OFFFICER</param>
        public void Insert(OFFICER o)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
            {
                if (o != null)
                    {
                        eitity.OFFICERs.Add(o);
                        eitity.SaveChanges();
                        }
            }
            catch { throw new Exception(); }
            }
        }

        public void Update(OFFICER o)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                OFFICER of = (from e in eitity.OFFICERs where e.OFFICER_ID == o.OFFICER_ID select e).First();
            try
            {
                of.CUST_ID = o.CUST_ID;
                of.END_DATE = o.END_DATE;
                of.FIRST_NAME = o.FIRST_NAME;
                of.LAST_NAME = o.LAST_NAME;
                of.START_DATE = o.START_DATE;
                of.TITLE = o.TITLE;
                eitity.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
            }
        }

        public void Delete(object o)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
            {
                int id = (int)o;
                var temp = (from e in eitity.OFFICERs where e.OFFICER_ID == id select e).First();
                eitity.Entry(temp).State = EntityState.Deleted;
                eitity.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
            }
        }
        public void DeletebyCustID(object o)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    int id = (int)o;
                    var temp = (from e in eitity.OFFICERs where e.CUST_ID == id select e).First();
                    eitity.OFFICERs.Remove(temp);
                    eitity.SaveChanges();
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

        public List<OFFICER> getAll()
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                //return eitity.PRODUCT_TYPE.ToList();
                var list = from x in eitity.OFFICERs select x;
            return list.ToList();
            }

        }

        public OFFICER SelectbyId(object o)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
            {
                int id = (int)o;
                var temp = (from e in eitity.OFFICERs where e.OFFICER_ID == id select e).First();
                return temp;
            }
            catch
            {
                throw new Exception();
            }
            }
        }
        public OFFICER SelectbyCustId(object o)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    int id = (int)o;
                    var temp = (from e in eitity.OFFICERs where e.CUST_ID == id select e).FirstOrDefault();
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
