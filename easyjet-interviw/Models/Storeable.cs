using easyjet_interviw.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyjet_interviw.Models
{
    public class Storeable : IStoreable
    {
        public IComparable Id { get; set; }
        public string Item { get; set; }
    }
}
