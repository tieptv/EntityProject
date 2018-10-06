using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleModel
{
    public interface IModelTemplate<T> where T : class
    {
        void Insert(T t);
        void Update( T t);
        void Delete(object id);
        List<T> getAll();
        T SelectbyId(object id);
    }
}
