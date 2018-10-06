using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel.Product
{
     public class IndividualDao : IModelTemplate<INDIVIDUAL>
    {
        //Khoi tao doi tuong lam viec voi database
        private static IndividualDao _instance;
        public static IndividualDao Instance()
        {
            if (_instance == null) _instance = new IndividualDao();
            return _instance;
        }
        SalesEntities3 eitity = new SalesEntities3();
        /// <summary>
        /// Them mot doi tuong vao bang INDIVIDUALT
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu INDIVIDUAL</param>
        public void Insert(INDIVIDUAL i)
        {
            try
            {
                if (i != null)
                {
                    eitity.INDIVIDUALs.Add(i);
                    eitity.SaveChanges();
                }
            }
            catch
            {
                throw new Exception();
            }

        }

        public void Update(INDIVIDUAL i)
        {
            INDIVIDUAL ind = (from e in eitity.INDIVIDUALs where e.CUST_ID == i.CUST_ID select e).First();
            try
            {
                ind.BIRTH_DATE = i.BIRTH_DATE;
                ind.CUSTOMER = i.CUSTOMER;
                ind.FIRST_NAME = i.FIRST_NAME;
                ind.LAST_NAME = i.LAST_NAME;
                eitity.SaveChanges();
            }
            catch
            {

                throw new Exception();
            }
        }
        public void Delete(object i)
        {
            try
            {
                int id = (int)i;
                var temp = (from e in eitity.INDIVIDUALs where e.CUST_ID == id select e).First();
                eitity.Entry(temp).State = EntityState.Deleted;
                eitity.SaveChanges();
            }
            catch
            {
                throw new Exception();
            }
        }

        public List<INDIVIDUAL> getAll()
        {
            //return eitity.PRODUCT_TYPE.ToList();
            var list = from x in eitity.INDIVIDUALs select x;
            return list.ToList();

        }

        public INDIVIDUAL SelectbyId(object i)
        {
            try
            {
                int id = (int)i;
                var temp = (from e in eitity.INDIVIDUALs where e.CUST_ID == id select e).FirstOrDefault();
                return temp;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
