using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyjet_interviw.Interfaces
{
    public interface IStoreable
    {
        IComparable Id { get; set; }
        string Item { get; set; }
    }
}
