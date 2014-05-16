using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RepackBatchMaterialUsage
    {
        private RepackBatch _objRepackBatch;

        public RepackBatch RepackBatch
        {
            get { return _objRepackBatch; }
            set { _objRepackBatch = value; }
        }

        private Material _objMaterial;

        public Material Material
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
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
    public class RepackBatchMaterialUsageCollec : CollectionBase
    {
        public void Add(RepackBatchMaterialUsage objRepackBatchMaterialUsage)
        {
            this.InnerList.Add(objRepackBatchMaterialUsage);
        }
    }
}
