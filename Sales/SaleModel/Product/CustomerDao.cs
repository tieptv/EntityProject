using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel.Product
{
    public class CustomerDao : IModelTemplate<CUSTOMER>
    {


        private static CustomerDao _instance;
        public static CustomerDao Instance()
        {
            if (_instance == null) _instance = new CustomerDao();
            return _instance;
        }
        //Khoi tao doi tuong lam viec voi database

        /// <summary>
        /// Them vao bang CUTOSMER
        /// </summary>
        /// <param name="c">Truyen vao 1 CUTOSMER</param>
        public void Insert(CUSTOMER c)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                //Thêm sản phẩm vào database
                try
                {
                    if (c != null)
                    {
                        eitity.CUSTOMERs.Add(c);
                        eitity.SaveChanges();

                    }
                }
                catch
                {
                    throw new Exception();
                }
            }
        }
        /// <summary>
        /// Cap nhat du lieu bang CUTOSMER
        /// </summary>
        /// <param name="t">Truyen vao 1 CUTOSMER</param>

        public void Update(CUSTOMER t)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                CUSTOMER cus = (from e in eitity.CUSTOMERs where e.CUST_ID == t.CUST_ID select e).First();
            try
            {
                cus.ADDRESS = t.ADDRESS;
                cus.CITY = t.CITY;
                cus.CUST_TYPE_CD = t.CUST_TYPE_CD;
                cus.FED_ID = t.FED_ID;
                cus.POSTAL_CODE = t.POSTAL_CODE;
                cus.STATE = t.STATE;
                eitity.SaveChanges();
            }
            catch 
            {
                throw new Exception();
            }
            }


        }
        /// <summary>
        /// Xoa du lieu bang CUTOSMER
        /// </summary>
        /// <param name="c">Truyen tham so co kieu object</param>
        public void Delete(object c)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {

                try
            {
                int id = (int)c;
                var customer = (from e in eitity.CUSTOMERs where e.CUST_ID == id select e).FirstOrDefault();
                var business = (from e in eitity.BUSINESSes where e.CUST_ID == id select e).FirstOrDefault();
                var individual = (from e in eitity.INDIVIDUALs where e.CUST_ID == id select e).FirstOrDefault();
                var officer = (from e in eitity.OFFICERs where e.CUST_ID == id select e).FirstOrDefault();
                    if(business!=null)
                    eitity.BUSINESSes.Remove(business);
                    if (individual != null)
                        eitity.INDIVIDUALs.Remove(individual);
                    if (officer != null)
                        eitity.OFFICERs.Remove(officer);
                    eitity.CUSTOMERs.Remove(customer);
                   
                eitity.SaveChanges();
            }
            catch
            {
                throw new Exception();

            }
            }
        }
        /// <summary>
        /// Lay danh sach trong bang CUTOSMER
        /// </summary>
        /// <returns></returns>
        public List<CUSTOMER> getAll()
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = from x in eitity.CUSTOMERs select x;
                return list.ToList();
            }
        }
        /// <summary>
        /// Lay chi tiet 1 hang trong bang CUTOSMER
        /// </summary>
        /// <param name="c">Truyen tham so co kieu object</param>
        /// <returns></returns>
        public CUSTOMER SelectbyId(object c)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
            {
                int id = (int)c;
                var temp = (from e in eitity.CUSTOMERs where e.CUST_ID == id select e).First();
                var list_ac = from e in eitity.ACCOUNTs where e.CUST_ID == temp.CUST_ID select e;
                var list_of = from e in eitity.OFFICERs where e.CUST_ID == temp.CUST_ID select e;
                temp.ACCOUNTs = list_ac.ToList();
                temp.OFFICERs = list_of.ToList();
                return temp;
            }
            catch {
                throw new Exception();
            }
            }
        }
        public CUSTOMER LastCUST()
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var temp = eitity.CUSTOMERs.ToArray().LastOrDefault();
                return temp;
            }
        }


    }
}
