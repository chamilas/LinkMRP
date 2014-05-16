using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RPDBatchActualProduction
    {

        private long _RPDBatchID;

        public long RPDBatchID
        {
            get { return _RPDBatchID; }
            set { _RPDBatchID = value; }
        }


        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }

        private Decimal _Quantity;

        public Decimal Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
	
	
	
    }

    public class RPDBatchActualProductionCollec : CollectionBase
    {
        public void Add(RPDBatchActualProduction obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
