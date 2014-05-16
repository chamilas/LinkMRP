using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class BatchProduction
    {
        private Batch _objBatch;

        public Batch ProductionBatch
        {
            get { return _objBatch; }
            set { _objBatch = value; }
        }

        private FinishProduct _objFinishProduct;

        public FinishProduct BatchFinishProduct
        {
            get { return _objFinishProduct; }
            set { _objFinishProduct = value; }
        }


        private Decimal _lngQty;

        public Decimal FinishProductQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private Decimal _lngUnitCost;

        public Decimal ProductUnitCost
        {
            get { return _lngUnitCost; }
            set { _lngUnitCost = value; }
        }
	
	
    }

    public class BatchProductionCollec : CollectionBase
    {
        public void Add(BatchProduction objBachProduction)
        {
            this.InnerList.Add(objBachProduction);
        }

        public void Delete(BatchProduction objBachProduction)
        {
            this.InnerList.Remove(objBachProduction);
        }
    }
}
