using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RepackBatchBasicProductUsage
    {
        private RepackBatch _objRepackBatch;

        public RepackBatch RepackBatch
        {
            get { return _objRepackBatch; }
            set { _objRepackBatch = value; }
        }
	

        private BasicProduct _objBasicProduct;

        public BasicProduct BasicProduct
        {
            get { return _objBasicProduct; }
            set { _objBasicProduct = value; }
        }

        private Decimal _lngQty;

        public Decimal Quantity
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private MR _objMR;

        public MR MR
        {
            get { return _objMR; }
            set { _objMR = value; }
        }

        private String _FinishProductID;

        public String FinishProductID
        {
            get { return _FinishProductID; }
            set { _FinishProductID = value; }
        }
    }

    public class RepackBatchBasicProductUsageCollec : CollectionBase
    {
        public void Add(RepackBatchBasicProductUsage objProductUsage)
        {
            this.InnerList.Add(objProductUsage);
        }
    }
}
