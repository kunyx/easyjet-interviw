using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyjet_interviw.Interfaces
{
    public interface IRepository<T> where T : IStoreable
    {
        IEnumerable<T> All();
        void Save(T item);
        T FindById(IComparable id);
        void Delete(IComparable id);
    }
}
