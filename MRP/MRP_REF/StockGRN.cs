using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class StockGRN
    {
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

        private DateTime _dtDate;

        public DateTime StockGRNDate
        {
            get { return _dtDate; }
            set { _dtDate = value; }
        }

        private long _lngIssuedQty;

        public long IssuedQty
        {
            get { return _lngIssuedQty; }
            set { _lngIssuedQty = value; }
        }
    }

    public class StockGRNCollec : CollectionBase
    {
        public void Add(StockGRN objStockGRN)
        {
            this.InnerList.Add(objStockGRN);
        }
    }
}
