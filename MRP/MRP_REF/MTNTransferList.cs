using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MTNTransferList
    {
        private MTN _objMTN;

        public MTN MTN
        {
            get { return _objMTN; }
            set { _objMTN = value; }
        }

        private Stock _objStock;

        public Stock Stock
        {
            get { return _objStock; }
            set { _objStock = value; }
        }

        private GRN _objGRN;

        public GRN GRN
        {
            get { return _objGRN; }
            set { _objGRN = value; }
        }

        private decimal _lngQty;

        public decimal Qty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }
	
    }

    public class MTNTransferListCollec : CollectionBase
    {
        public void Add(MTNTransferList objMTNTransferList)
        {
            this.InnerList.Add(objMTNTransferList);
        }
    }
}
