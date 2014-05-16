using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RPDBatchActivityProduction
    {
        private long _RPDBatchActID;

        public long RPDBatchActID
        {
            get { return _RPDBatchActID; }
            set { _RPDBatchActID = value; }
        }

        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }

        private String _Quantity;

        public String Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
	
	
    }

    public class RPDBatchActivityProductionCollec : CollectionBase
    {
        public void Add(RPDBatchActivityProduction obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
