using SaleModel.Model;
using SaleModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Model
{
     public class ProductView
    {
   
        public Nullable<System.DateTime> date_offer { get; set; }
        public Nullable<System.DateTime> date_retire { get; set; }
        public string name { get; set; }
        public string product_cd{ get; set; }
        public string type { get; set; }
        public ProductView(PRODUCT p)
        {
            Product_TypeDao ptd=new Product_TypeDao();
            this.type=ptd.SelectbyId(p.PRODUCT_TYPE_CD).NAME;
            this.product_cd=p.PRODUCT_CD;
            this.name=p.NAME;
            this.date_retire=p.DATE_RETIRED;
            this.date_offer = p.DATE_OFFERED;
          }
        public ProductView() { 
        
           }
     }
 }