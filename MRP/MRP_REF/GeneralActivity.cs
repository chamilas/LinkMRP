using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class GeneralActivity
    {
        private long _lngGenActID;

        public long GenActID
        {
            get { return _lngGenActID; }
            set { _lngGenActID = value; }
        }

        private ReworkBatch _objReworkBatch;

        public ReworkBatch GenActReworkBatch
        {
            get { return _objReworkBatch; }
            set { _objReworkBatch = value; }
        }

        private RepackBatch _objRePackBatch;

        public RepackBatch GenActRePackBatch
        {
            get { return _objRePackBatch; }
            set { _objRePackBatch = value; }
        }

        private MaterialReworkBatch _objMatReworkBatch;

        public MaterialReworkBatch GenActMatReworkBatch
        {
            get { return _objMatReworkBatch; }
            set { _objMatReworkBatch = value; }
        }

        private RPDBatch _objRPDBatch;

        public RPDBatch GenActRPDBatch
        {
            get { return _objRPDBatch; }
            set { _objRPDBatch = value; }
        }

        private String _strDescription;

        public String GenActDescription
        {
            get { return _strDescription; }
            set { _strDescription = value; }
        }

        private DateTime _dtStartDate;

        public DateTime GenActStartDate
        {
            get { return _dtStartDate; }
            set { _dtStartDate = value; }
        }

        private DateTime _dtEndDate;

        public DateTime GenActEndDate
        {
            get { return _dtEndDate; }
            set { _dtEndDate = value; }
        }

        private String _strRemarks;

        public String GenActRemarks
        {
            get { return _strRemarks; }
            set { _strRemarks = value; }
        }

        private Decimal _StartQty;

        public Decimal StartQty
        {
            get { return _StartQty; }
            set { _StartQty = value; }
        }


        private Decimal _EndQty;

        public Decimal EndQty
        {
            get { return _EndQty; }
            set { _EndQty = value; }
        }


        private DateTime _Date;

        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }


        private String _Superviser;

        public String Superviser
        {
            get { return _Superviser; }
            set { _Superviser = value; }
        }


        private String _WorkingProduct;

        public String WorkingProduct
        {
            get { return _WorkingProduct; }
            set { _WorkingProduct = value; }
        }
	
	
	
    }

    public class GeneralActivityCollec : CollectionBase
    {
        public void Add(GeneralActivity objGenAct)
        {
            this.InnerList.Add(objGenAct);
        }
    }
}

