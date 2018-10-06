using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel.Product
{
    public class ProductDao : IModelTemplate<PRODUCT>
    {
        private static ProductDao _instance;
        public static ProductDao Instance()
        {
            if (_instance == null) _instance = new ProductDao();
            return _instance;
        }
        public void Delete(object id)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {

                    String p = (String)id;
                    var temp = (from e in eitity.PRODUCTs where e.PRODUCT_CD == p select e).First();
                    eitity.Entry(temp).State = EntityState.Deleted;
                    eitity.SaveChanges();

                }

                catch
                {
                    throw new Exception();

                }
            }
        }

        public List<PRODUCT> getAll()
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = from x in eitity.PRODUCTs select x;
                return list.ToList();

            }
        }

        //Khoi tao doi tuong lam viec voi database
        /// <summary>
        /// Them mot doi tuong vao bang PRODUCT
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu PRODUCT</param>
        public void Insert(PRODUCT p)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                //Thêm sản phẩm vào database
                try
                {
                    if (p != null)
                    {
                        eitity.PRODUCTs.Add(p);
                        eitity.SaveChanges();

                    }
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

        public PRODUCT SelectbyId(object id)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {

                    String p = (String)id;
                    var temp = (from e in eitity.PRODUCTs where e.PRODUCT_CD == p select e).First();
                    return temp;
                }

                catch
                {
                    throw new Exception();
                }
            }
        }
        public PRODUCT SelectbyName(object id)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {

                    String p = (String)id;
                    var temp = (from e in eitity.PRODUCTs where e.NAME == p select e).First();
                    return temp;
                }

                catch
                {
                    throw new Exception();
                }
            }
        }
        public void Update(PRODUCT t)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {

                try
                {
                    PRODUCT pr = (from e in eitity.PRODUCTs where e.PRODUCT_CD == t.PRODUCT_CD select e).First();
                    pr.PRODUCT_TYPE_CD = t.PRODUCT_TYPE_CD;
                    pr.DATE_RETIRED = t.DATE_RETIRED;
                    pr.DATE_OFFERED = t.DATE_OFFERED;
                    pr.NAME = t.NAME;
                    eitity.SaveChanges();
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

    
}
}
