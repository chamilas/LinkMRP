using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class POMaterials
    {

        private string _strPONO;

        public string PONO
        {
            get { return _strPONO; }
            set { _strPONO = value; }
        }


        private string _strMaterialCode;

        public string MaterialCode
        {
            get { return _strMaterialCode; }
            set { _strMaterialCode = value; }
        }


        private string _strMaterial;

        public string Material
        {
            get { return _strMaterial; }
            set { _strMaterial = value; }
        }


        private Decimal _lngPOQty;

        public Decimal POQty
        {
            get { return _lngPOQty; }
            set { _lngPOQty = value; }
        }



        private Decimal _lngUnitPrice;

        public Decimal UnitPrice
        {
            get { return _lngUnitPrice; }
            set { _lngUnitPrice = value; }
        }

    }

    public class POMaterialsCollec : CollectionBase
    {
        public void Add(POMaterials objPOMaterials)
        {
            this.InnerList.Add(objPOMaterials);
        }
    }
}
