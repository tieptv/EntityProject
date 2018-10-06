using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SaleModel.Model;
using SaleModel.Product;
using System.Transactions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private Product_TypeDao ptd = new Product_TypeDao();
        private ProductDao pd = new ProductDao();
        private CustomerDao cd = new CustomerDao();
        private AccountDao ad = new AccountDao();
        private EmployeeDao ed = new EmployeeDao();
        [TestMethod]
        public void Product_type_insert()
        {
            PRODUCT_TYPE pt = new PRODUCT_TYPE();
            pt.NAME = "suc nu";
            pt.PRODUCT_TYPE_CD = "sn";
            ptd.Insert(pt);
        }
        [TestMethod]
        public void Product_type_update()
        {

            PRODUCT_TYPE pt = new PRODUCT_TYPE();
            pt.NAME = "suc nam";
            pt.PRODUCT_TYPE_CD = "sn";
            ptd.Update(pt);
        }
        [TestMethod]
        public void Product_type_delete()
        {

            String id = "sn";
            ptd.Delete(id);
        }
        [TestMethod]
        public void Product_type_getall()
        {

           
            ptd.getAll();
        }
        [TestMethod]
        public void Product_insert()
        {
            PRODUCT p = new PRODUCT();
            p.PRODUCT_CD = "abc";
            p.PRODUCT_TYPE_CD = "LOAN";
            p.NAME = "ABC";
            p.DATE_OFFERED= new DateTime(2018, 9, 8);
            p.DATE_RETIRED = null;
            pd.Insert(p);
        }

      //  [TestMethod]
      //  public void Product_delete()
     //   {
      //      String id = "abc";
       //     pd.Delete(id);
       // }
        [TestMethod]
        public void Account_insert()
        {
            using (TransactionScope trans = new TransactionScope())
            {
                ACCOUNT a = new ACCOUNT();
                a.AVAIL_BALANCE = 12.5;
                a.CLOSE_DATE = new DateTime(2018, 9, 8);
                a.LAST_ACTIVITY_DATE = new DateTime(2018, 9, 8);
                a.OPEN_DATE = new DateTime(2018, 9, 8);
                a.PENDING_BALANCE = 12.5;
                a.STATUS = "active";
                a.CUST_ID = 1;
                a.OPEN_BRANCH_ID = 1;
                a.OPEN_EMP_ID = 1;
                a.PRODUCT_CD = "AUT";

                ad.Insert(a);
            }
        }
        [TestMethod]
        public void Account_update()
        {
            ACCOUNT a = new ACCOUNT();
            a.ACCOUNT_ID = 1;
            a.AVAIL_BALANCE = 12.5;
            a.CLOSE_DATE = new DateTime(2018, 9, 8);
            a.LAST_ACTIVITY_DATE = new DateTime(2018, 9, 7);
            a.OPEN_DATE = new DateTime(2018, 9, 8);
            a.PENDING_BALANCE = 12.58;
            a.STATUS = "hidden";
            a.CUST_ID = 1;
            a.OPEN_BRANCH_ID = 1;
            a.OPEN_EMP_ID = 1;
            a.PRODUCT_CD = "AUT";
            ad.Update(a);
        }
        [TestMethod]
        public void Customer_insert()
        {
            CUSTOMER a = new CUSTOMER();
            a.ADDRESS = "k";
            a.CITY = "f";
            a.CUST_ID = 14;
            a.FED_ID = "f";
            a.CUST_TYPE_CD = "f";
            a.POSTAL_CODE = "f";
            a.STATE = "f";
            cd.Insert(a);
        }

    }
}
