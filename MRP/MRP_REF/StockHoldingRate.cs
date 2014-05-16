using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class StockHoldingRate
    {

        private Decimal _ID;

        public Decimal ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
	
        private DateTime? _FromDate;

        public DateTime? FromDate
        {
            get { return _FromDate; }
            set { _FromDate = value; }
        }

        private DateTime? _ToDate;

        public DateTime? ToDate
        {
            get { return _ToDate; }
            set { _ToDate = value; }
        }

        private Decimal _Cost;

        public Decimal Cost
        {
            get { return _Cost; }
            set { _Cost = value; }
        }

        private String _ChangedBy;

        public String ChangedBy
        {
            get { return _ChangedBy; }
            set { _ChangedBy = value; }
        }
	}

    public class StockHoldingRateCollec : CollectionBase
    {
        public void Add(StockHoldingRate obj)
        {
            InnerList.Add(obj);
        }
    }
}
