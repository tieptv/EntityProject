using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel.Product
{
    public class BusinessDao : IModelTemplate<BUSINESS>
    {
        private static BusinessDao _instance;
        public static BusinessDao Instance()
        {
            if (_instance == null) _instance = new BusinessDao();
            return _instance;
        }
        SalesEntities3 eitity = new SalesEntities3();
        /// <summary>
        /// Them mot doi tuong vao bang BUSINESS
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu BUSINESS</param>
        public void Insert(BUSINESS b)
        {
            try
            {
                if (b != null)
                {
                    eitity.BUSINESSes.Add(b);
                    eitity.SaveChanges();
                }
            }
            catch
            {
                throw new Exception();
            }

        }

        public void Update( BUSINESS b)
        {
            BUSINESS bu = (from e in eitity.BUSINESSes where e.CUST_ID == b.CUST_ID select e).First();
            try
            {
                bu.CUSTOMER = b.CUSTOMER;
                bu.INCORP_DATE = b.INCORP_DATE;
                bu.NAME = b.NAME;
                bu.STATE_ID = b.STATE_ID;
                eitity.SaveChanges();
            }
            catch
            {
                  throw new Exception();
            }
        }
        public void Delete(object b)
        {
            try
            {
                int id = (int)b;
                var temp = (from e in eitity.BUSINESSes where e.CUST_ID == id select e).First();
                eitity.Entry(temp).State = EntityState.Deleted;
                eitity.SaveChanges();
            }
            catch
            {
                   throw new Exception();
            }
        }

        public List<BUSINESS> getAll()
        {
            //return eitity.PRODUCT_TYPE.ToList();
            var list = from x in eitity.BUSINESSes select x;
            return list.ToList();

        }

        public BUSINESS SelectbyId(object a)
        {
            try
            {
                int id = (int)a;
                var temp = (from e in eitity.BUSINESSes where e.CUST_ID == id select e).FirstOrDefault();
                return temp;
            }
        catch{
          throw new Exception();
        }
    }
   }
}
