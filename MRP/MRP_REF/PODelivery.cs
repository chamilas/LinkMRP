using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PODelivery
    {

        private int _intID;

        public int ID
        {
            get { return _intID; }
            set { _intID = value; }
        }


        private String _strPONO;

        public String PONO
        {
            get { return _strPONO; }
            set { _strPONO = value; }
        }



        private String _strMaterialCode;

        public String MaterialCode
        {
            get { return _strMaterialCode; }
            set { _strMaterialCode = value; }
        }


        private Decimal _lngQty;

        public Decimal Qty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }


    }

    public class PODeliveryCollec : CollectionBase
    {
        public void Add(PODelivery objPODelivery)
        {
            this.InnerList.Add(objPODelivery);
        }
    }
}
