using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ReworkBatchMaterialUsage
    {
        private ReworkBatch _objRework;

        public ReworkBatch ReWorkBatch
        {
            get { return _objRework; }
            set { _objRework = value; }
        }

        private String _FinishProductID;

        public String FinishProductID
        {
            get { return _FinishProductID; }
            set { _FinishProductID = value; }
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
    }

    public class ReworkBatchMaterialUsageCollec : CollectionBase
    {
        public void Add(ReworkBatchMaterialUsage objReworkBatchMaterialUsage)
        {
            this.InnerList.Add(objReworkBatchMaterialUsage);
        }
    }
}
