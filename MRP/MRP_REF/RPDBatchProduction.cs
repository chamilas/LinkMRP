using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RPDBatchProduction
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
        public decimal MaterialQuantity
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }


	}

    public class RPDBatchProductionCollec : CollectionBase
    {
        public void Add(RPDBatchProduction objRPDBatchProduction)
        {
            this.InnerList.Add(objRPDBatchProduction);
        }

        public void Delete(RPDBatchProduction objRPDBatchProduction)
        {
            this.InnerList.Remove(objRPDBatchProduction);
        }
    }
}
