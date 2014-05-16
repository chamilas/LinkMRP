using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class PODeliveryShedule
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

        private int _DeliveryID;

        public int DeliveryID
        {
            get { return _DeliveryID; }
            set { _DeliveryID = value; }
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


        private DateTime _ExpectedDate;

        public DateTime ExpectedDate
        {
            get { return _ExpectedDate; }
            set { _ExpectedDate = value; }
        }

        private DateTime _ShipmentDate;

        public DateTime ShipmentDate
        {
            get { return _ShipmentDate; }
            set { _ShipmentDate = value; }
        }



    }

    public class PODeliverySheduleCollec : CollectionBase
    {
        public void Add(PODeliveryShedule objPODeliveryShedule)
        {
            this.InnerList.Add(objPODeliveryShedule);
        }
    }
}
