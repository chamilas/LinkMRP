using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SESD.MRP.REF
{
    public class Region
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public long ASM { set; get; }
        public string Province { set; get; }
        public string ProductCatID { set; get; }
        public string SalesMethodID { set; get; }
    }
}
