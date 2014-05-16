using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SalesForecastBatches
    {
        private SalesForecast _sf;

        public SalesForecast Sales_Forecast
        {
            get { return _sf; }
            set { _sf = value; }
        }

        private Batch _objBatch;

        public Batch Batch
        {
            get { return _objBatch; }
            set { _objBatch = value; }
        }
	
	
    }

    public class SalesForecastBatchesCollec : CollectionBase
    {
        public void Add(SalesForecastBatches obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
