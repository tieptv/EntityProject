using SaleModel.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleModel.Product
{
    public class AccountDao : IModelTemplate<ACCOUNT>
    {
        private static AccountDao _Instance;
        public static AccountDao Instance()
        {
            if (_Instance == null) _Instance = new AccountDao();
            return _Instance;
        }
        //Khoi tao doi tuong lam viec voi database
        /// <summary>
        /// Them mot doi tuong vao bang ACCOUNT
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu ACCOUNT</param>

        public void Insert(ACCOUNT a,ACC_TRANSACTION tran)
        {
            using (SalesEntities3 entity = new SalesEntities3())
            {
                using (var transaction = entity.Database.BeginTransaction())
                {
                    if (a != null)
                    {
                        try
                        {
                            entity.ACCOUNTs.Add(a);
                            a.ACC_TRANSACTION.Add(tran);
                            entity.SaveChanges();
                            transaction.Commit();
                        }
                        catch
                        {
                            MessageBox.Show("Error: Insert!");
                        }
                    }
                }
            }

        }
        /// <summary>
        /// Cap nhat du lieu cho bang ACCOUNT
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu ACCOUNT</param>
        public void Update(ACCOUNT a,ACC_TRANSACTION ac_tran)
        {
            using (SalesEntities3 entity = new SalesEntities3())
            {
                using (var transaction = entity.Database.BeginTransaction())
                {
                    try
                    {
                        ACCOUNT ac = (from e in entity.ACCOUNTs where e.ACCOUNT_ID == a.ACCOUNT_ID select e).First();
                        ACC_TRANSACTION tran = (from e in entity.ACC_TRANSACTION where e.TXN_ID == ac_tran.TXN_ID select e).First();
                        ac.AVAIL_BALANCE = a.AVAIL_BALANCE;
                        ac.CLOSE_DATE = a.CLOSE_DATE;
                        ac.CUST_ID = a.CUST_ID;
                        ac.LAST_ACTIVITY_DATE = a.LAST_ACTIVITY_DATE;
                        ac.OPEN_BRANCH_ID = a.OPEN_BRANCH_ID;
                        ac.OPEN_DATE = a.OPEN_DATE;
                        ac.PENDING_BALANCE = a.PENDING_BALANCE;
                        ac.STATUS = a.STATUS;
                        ac.PRODUCT_CD = a.PRODUCT_CD;
                        ac.OPEN_EMP_ID = a.OPEN_EMP_ID;

                        tran.AMOUNT = ac_tran.AMOUNT;
                        tran.EXECUTION_BRANCH_ID = ac_tran.EXECUTION_BRANCH_ID;
                        tran.FUNDS_AVAIL_DATE = ac_tran.FUNDS_AVAIL_DATE;
                        tran.TELLER_EMP_ID = ac_tran.TELLER_EMP_ID;
                        tran.TXN_DATE = ac_tran.TXN_DATE;
                        tran.TXN_TYPE_CD = ac_tran.TXN_TYPE_CD;
                        entity.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        MessageBox.Show("Error: Update!");
                    }
                }
            }
        }
        /// <summary>
        ///  Xoa du lieu trong bang ACCOUNT
        /// </summary>
        /// <param name="a">Tham so truyen vao co kieu object</param>
        public void Delete(object a)
        {
            using (SalesEntities3 entity = new SalesEntities3())
            {
                using (var transaction = entity.Database.BeginTransaction())
                {
                    try
                    {
                        int id = (int)a;
                        var ac = (from e in entity.ACCOUNTs where e.ACCOUNT_ID == id select e).First();
                        var tran=(from e in entity.ACC_TRANSACTION where e.ACCOUNT_ID == id select e).First();
                        entity.Entry(ac).State = EntityState.Deleted;
                        entity.Entry(tran).State = EntityState.Deleted;
                        entity.SaveChanges();
                        transaction.Commit();
                    }
                    catch
                    {
                        MessageBox.Show("Error: Delete!");
                    }
                }
            }
        }
        /// <summary>
        /// Lay danh sach du lieu trong bang ACCOUNT
        /// </summary>
        /// <returns>Tra ve danh sach co kieu list</returns>
        public List<ACCOUNT> getAll()
        {
            using (SalesEntities3 entity = new SalesEntities3())
            {
                using (var transaction = entity.Database.BeginTransaction())
                {
                    //return entity.PRODUCT_TYPE.ToList();
                    var list = from x in entity.ACCOUNTs select x;
                    return list.ToList();
                }
            }
        }
        /// <summary>
        /// Lay chi tiet 1 hang trong bang ACCOUNT
        /// </summary>
        /// <param name="a"> Tham so truyen vao co kieu ofject</param>
        /// <returns>Tra ve 1 doi tuong co kieu ACCOUNT </returns>
        public ACCOUNT SelectbyId(object a)
        {
            using (SalesEntities3 entity = new SalesEntities3())
            {
                    try
                    {
                        int id = (int)a;
                        var temp = (from e in entity.ACCOUNTs where e.ACCOUNT_ID == id select e).First();
                        var list = from e in entity.ACC_TRANSACTION where e.ACCOUNT_ID == temp.ACCOUNT_ID select e;
                        temp.ACC_TRANSACTION = list.ToList();
                        return temp;
                    }
                    catch
                    {

                        throw new Exception();
                    }
            }
        }
        public int LastId()
        {
            using (SalesEntities3 entity = new SalesEntities3())
            {
                    try
                    {
                        var temp = entity.ACCOUNTs.ToArray().LastOrDefault();
                        return temp.ACCOUNT_ID;
                    }
                    catch
                    {

                        throw new Exception();
                    }
            }
        }

        public void Insert(ACCOUNT t)
        {
            throw new NotImplementedException();
        }

        public void Update(ACCOUNT t)
        {
            throw new NotImplementedException();
        }
    }
}
