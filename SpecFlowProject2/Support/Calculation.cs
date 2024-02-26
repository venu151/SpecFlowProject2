using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject2.Support
{
    public class Calculation
    {
        public int Fnum { get; set; }
        public int Snum { get; set; }
        public int Add()
        {
            int res;
            res = Fnum + Snum;
            return res;
        }
    }
}
