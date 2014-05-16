using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RepackBatchProductList
    {
        private RepackBatch _objRepackBatch;

        public RepackBatch RePackBatch
        {
            get { return _objRepackBatch; }
            set { _objRepackBatch = value; }
        }

        private FinishProduct _objFinishProduct;

        public FinishProduct FinishProduct
        {
            get { return _objFinishProduct; }
            set { _objFinishProduct = value; }
        }

        private Batch _objBatch;

        public Batch Batch
        {
            get { return _objBatch; }
            set { _objBatch = value; }
        }



        private Decimal _lngQty;

        public Decimal ProductQuantity
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private Decimal _UnitCost;

        public Decimal UnitCost
        {
            get { return _UnitCost; }
            set { _UnitCost = value; }
        }
	
	
	
    }

    public class RepackBatchProductListCollec : CollectionBase
    {
        public void Add(RepackBatchProductList objRepackBatchProductList)
        {
            this.InnerList.Add(objRepackBatchProductList);
        }
    }
}
