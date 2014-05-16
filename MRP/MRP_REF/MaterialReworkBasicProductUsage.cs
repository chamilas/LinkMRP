using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MaterialReworkBasicProductUsage
    {
        private MaterialReworkBatch _objMatReworkBatch;

        public MaterialReworkBatch MatReworkBatch
        {
            get { return _objMatReworkBatch; }
            set { _objMatReworkBatch = value; }
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
		
	
    }

    public class MaterialReworkBasicProductUsageCollec : CollectionBase
    {
        public void Add(MaterialReworkBasicProductUsage objMaterialReworkBasicProductUsage)
        {
            this.InnerList.Add(objMaterialReworkBasicProductUsage);
        }
    }
}
