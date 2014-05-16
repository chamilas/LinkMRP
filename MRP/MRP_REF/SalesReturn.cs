using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SalesReturn
    {
        private long _lngID;

        public long SalesReturnID
        {
            get { return _lngID; }
            set { _lngID = value; }
        }

        private FinishProduct _objFinishProduct;

        public FinishProduct SRFinishProduct
        {
            get { return _objFinishProduct; }
            set { _objFinishProduct = value; }
        }

        private SalesRef _objSalesRef;
                        
        public SalesRef SRSalesRef
        {
            get { return _objSalesRef; }
            set { _objSalesRef = value; }
        }

        private Decimal _lngQty;

        public Decimal SRQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private Decimal _lngAcceptQty;

        public Decimal SRAcceptQty
        {
            get { return _lngAcceptQty; }
            set { _lngAcceptQty = value; }
        }

        private Decimal _lngReworkQty;

        public Decimal SRReworkQty
        {
            get { return _lngReworkQty; }
            set { _lngReworkQty = value; }
        }

        private Decimal _lngRejectQty;

        public Decimal SRRejectQty
        {
            get { return _lngRejectQty; }
            set { _lngRejectQty = value; }
        }


        private Decimal _lngAcceptPrice;

        public Decimal SRAcceptUnitPrice
        {
            get { return _lngAcceptPrice; }
            set { _lngAcceptPrice = value; }
        }

        private Decimal _lngReworkUnitPrice;

        public Decimal SRReworkUnitPrice
        {
            get { return _lngReworkUnitPrice; }
            set { _lngReworkUnitPrice = value; }
        }

        private String _strAcceptRemarks;

        public String SRAcceptRemarks
        {
            get { return _strAcceptRemarks; }
            set { _strAcceptRemarks = value; }
        }

        private String _strReworkRemarks;

        public String SRReworkRemarks
        {
            get { return _strReworkRemarks; }
            set { _strReworkRemarks = value; }
        }

        private String _strRejectRemarks;

        public String SRRejectRemarks
        {
            get { return _strRejectRemarks; }
            set { _strRejectRemarks = value; }
        }

        public enum Status : int
        {
            Intial = 0,
            Inspection = 1,
            Finalize = 2
        }

        private Status _intStatus;

        public Status SRStatus
        {
            get { return _intStatus; }
            set { _intStatus = value; }
        }
	

        private Employee _objEmployee;

        public Employee SREnterdBy
        {
            get { return _objEmployee; }
            set { _objEmployee = value; }
        }

        private DateTime _dtEnterdDate;

        public DateTime SREnterdDate
        {
            get { return _dtEnterdDate; }
            set { _dtEnterdDate = value; }
        }

        private Batch _objbatch;

        public Batch Batch
        {
            get { return _objbatch; }
            set { _objbatch = value; }
        }
	
	
    }

    public class SalesReturnCollec : CollectionBase
    {

        public void Add(SalesReturn objSalesReturn)
        {
            this.InnerList.Add(objSalesReturn);
        }
    }
}
