using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RPDBatchPackingMaterialUsage
    {
        private RPDBatch _objRPDBatch;

        public RPDBatch RPDBatch
        {
            get { return _objRPDBatch; }
            set { _objRPDBatch = value; }
        }

        private Material _objMaterial;

        public Material Material
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
        }

        private decimal _lngQty;

        public decimal Quantity
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

    public class RPDBatchPackingMaterialUsageCollec : CollectionBase
    {
        public void Add(RPDBatchPackingMaterialUsage objRPDBatchBasicProductUsage)
        {
            this.InnerList.Add(objRPDBatchBasicProductUsage);
        }

        public void Delete(RPDBatchPackingMaterialUsage objRPDBatchBasicProductUsage)
        {
            this.InnerList.Remove(objRPDBatchBasicProductUsage);
        }

    }
}
