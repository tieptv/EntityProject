using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SaleModel.Product
{
    public class Acc_transactionDao : IModelTemplate<ACC_TRANSACTION>
    {
        //Khoi tao doi tuong lam viec voi database
        SalesEntities3 eitity = new SalesEntities3();
        /// <summary>
        ///Them mot doi tuong vao bang ACC_TRANSACTION
        /// </summary>
        /// <param name="a">Tham so truyen vao co kieu ACC_TRANSACTION  </param>
        private static Acc_transactionDao _Instance;
        public static Acc_transactionDao Instance()
        {
            if (_Instance == null) _Instance = new Acc_transactionDao();
            return _Instance;
        }
        public void Insert(ACC_TRANSACTION a)
        {
            using (SalesEntities3 entity = new SalesEntities3())
            {
                using (var transaction = entity.Database.BeginTransaction())
                {
                    if (a != null)
                {
                    try
                    {
                        eitity.ACC_TRANSACTION.Add(a);
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
        /// <summary>
        /// Cap nhat du lieu cho bang ACC_TRANSACTION
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu ACC_TRANSACTION</param>
        public void Update(ACC_TRANSACTION a)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
               
                try
                {
                    ACC_TRANSACTION ac = (from e in eitity.ACC_TRANSACTION where e.TXN_ID == a.TXN_ID select e).First();
                    ac.AMOUNT = a.AMOUNT;
                    ac.ACCOUNT_ID = a.ACCOUNT_ID;
                    ac.EXECUTION_BRANCH_ID = a.EXECUTION_BRANCH_ID;
                    ac.FUNDS_AVAIL_DATE = a.FUNDS_AVAIL_DATE;
                    ac.TELLER_EMP_ID = a.TELLER_EMP_ID;
                    ac.TXN_DATE = a.TXN_DATE;
                    ac.TXN_TYPE_CD = a.TXN_TYPE_CD;
                    eitity.SaveChanges();
                }
                catch
                {
                    throw new Exception();
                }
            }
        }
        /// <summary>
        /// Xoa du lieu trong bang ACC_TRANSACTION
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu object</param>
        public void Delete(object a)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    int id = (int)a;
                     var temp = (from e in eitity.ACC_TRANSACTION where e.ACCOUNT_ID == id select e).FirstOrDefault();
                    if (temp != null)
                    {
                        eitity.Entry(temp).State = EntityState.Deleted;
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
        /// Lay danh sach du lieu trong bang ACC_TRANSACTION
        /// </summary>
        /// <returns>Tra ve danh sach co kieu list</returns>
        public List<ACC_TRANSACTION> getAll()
        {
            //return eitity.PRODUCT_TYPE.ToList();
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = from x in eitity.ACC_TRANSACTION select x;
                return list.ToList();
            }
        }
        public List<ACC_TRANSACTION> getListbyAccount(int e)
        {
            //return eitity.PRODUCT_TYPE.ToList();
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                var list = from x in eitity.ACC_TRANSACTION where x.ACCOUNT_ID == e select x;
                return list.ToList();
            }
        }
        /// <summary>
        /// Lay chi tiet 1 hang trong bang ACC_TRANSACTION
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu ofject</param>
        /// <returns>Tra ve 1 doi tuong co kieu ACC_TRANSACTION </returns>

        public ACC_TRANSACTION SelectbyId(object a)
        {
            using (SalesEntities3 eitity = new SalesEntities3())
            {
                try
                {
                    int id = (int)a;
                    var temp = (from e in eitity.ACC_TRANSACTION where e.ACCOUNT_ID == id select e).FirstOrDefault();
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
