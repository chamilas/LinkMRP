using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ReworkBatchBasicProductUsage
    {
        private ReworkBatch _objReworkbatch;

        public ReworkBatch ReWorkBatch
        {
            get { return _objReworkbatch; }
            set { _objReworkbatch = value; }
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

    public class ReworkBatchBasicProductUsageCollec : CollectionBase
    {
        public void Add(ReworkBatchBasicProductUsage objProductUsage)
        {
            this.InnerList.Add(objProductUsage);
        }
    }
}
