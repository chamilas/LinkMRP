using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ReworkBatchProductList
   {
       private ReworkBatch _objReWork;

       public ReworkBatch ReWorkBatch
       {
           get { return _objReWork; }
           set { _objReWork = value; }
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

        private CAP _objCAP;

        public CAP CAP
        {
            get { return _objCAP; }
            set { _objCAP = value; }
        }

        private Decimal _lngActualQty;

        public Decimal ActualProductQty
        {
            get { return _lngActualQty; }
            set { _lngActualQty = value; }
        }
    }

    public class ReworkBatchProductListCollec : CollectionBase
    {
        public void Add(ReworkBatchProductList objReworkBatchProductList)
        {
            this.InnerList.Add(objReworkBatchProductList);
        }
    }
}
