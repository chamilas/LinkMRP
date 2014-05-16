using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MRIssueList
    {
        private MR _objMR;

        public MR MR
        {
            get { return _objMR; }
            set { _objMR = value; }
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

    public class MRIssueListCollec : CollectionBase
    {
        public void Add(MRIssueList objMRIssueList)
        {
            this.InnerList.Add(objMRIssueList);
        }
    }
}
