using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel.Product
{
    /// <summary>
    /// Y nghia cua class
    /// </summary>
    public class Product_TypeDao : IModelTemplate<PRODUCT_TYPE>
    {


        private static Product_TypeDao _instance;
        public static Product_TypeDao Instance()
        {
            if (_instance == null) _instance = new Product_TypeDao();
            return _instance;
        }

        /// <summary>
        /// Thêm loại sản phẩm
        /// </summary>
        /// <param name="pt">Truyền vào 1 Product_type</param>
        public void Insert(PRODUCT_TYPE pt)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                //Thêm sản phẩm vào database
                try
                {
                    if (pt != null)
                    {
                        eitity.PRODUCT_TYPE.Add(pt);
                        eitity.SaveChanges();
                    }
                }
                catch
                {
                    throw new Exception();

                }
            }
        }

        public void Update(PRODUCT_TYPE pt)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    PRODUCT_TYPE temp = (from e in eitity.PRODUCT_TYPE where e.PRODUCT_TYPE_CD == pt.PRODUCT_TYPE_CD select e).First();
                    temp.NAME = pt.NAME;
                    eitity.SaveChanges();
                }
                catch
                {
                    throw new Exception();
                }
            }
        }





        public void Delete(object pt)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    String id = (String)pt;
                    var temp = (from e in eitity.PRODUCT_TYPE where e.PRODUCT_TYPE_CD == id select e).First();
                    eitity.Entry(temp).State = EntityState.Deleted;
                    eitity.SaveChanges();
                }
                catch
                {
                    throw new Exception();
                }
            }
        }

        public List<PRODUCT_TYPE> getAll()
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = from x in eitity.PRODUCT_TYPE select x;
                return list.ToList();
            }

        }
        public List<PRODUCT_TYPE> getListByName(string name)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = eitity.PRODUCT_TYPE.Where(p => p.NAME.Contains(name)).ToList();
                return list.ToList();
            }
        }

        public PRODUCT_TYPE SelectbyId(object pt)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    String id = (String)pt;
                    var temp = (from e in eitity.PRODUCT_TYPE where e.PRODUCT_TYPE_CD == id select e).First();
                    return temp;
                }
                catch
                {
                    throw new Exception();
                }
            }
        }
        public PRODUCT_TYPE SelectbyName(object pt)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    String id = (String)pt;
                    var temp = (from e in eitity.PRODUCT_TYPE where e.NAME == id select e).FirstOrDefault();
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

