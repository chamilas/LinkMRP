using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MaterialReworkMaterialUsage
    {
        private MaterialReworkBatch _objMatReworkBatch;

        public MaterialReworkBatch MatReworkBatch
        {
            get { return _objMatReworkBatch; }
            set { _objMatReworkBatch = value; }
        }

        private Material _objMaterial;

        public Material Material
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
        }
	

        private long _lngQty;

        public long Quantity
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

    public class MaterialReworkMaterialUsageCollec : CollectionBase
    {
        public void Add(MaterialReworkMaterialUsage objMaterialReworkMaterialUsage)
        {
            this.InnerList.Add(objMaterialReworkMaterialUsage);
        }
    }
}
