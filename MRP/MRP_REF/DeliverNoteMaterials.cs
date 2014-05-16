using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class DeliverNoteMaterials
    {
        private long _lngID;

        public long ID
        {
            get { return _lngID; }
            set { _lngID = value; }
        }
	
        private string _materialCode;

        public String MaterialCode
        {
            get { return _materialCode; }
            set { _materialCode = value; }
        }


        private string _materialName;

        public String MaterialName
        {
            get { return _materialName; }
            set { _materialName = value; }
        }

        private string _DeliverNote;

        public string DeliverNote
        {
            get { return _DeliverNote; }
            set { _DeliverNote = value; }
        }

        private Decimal _lngQty;

        public Decimal DeleverdMaterialQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private Decimal _lngActualQty;

        public Decimal ActualReceivedQty
        {
            get { return _lngActualQty; }
            set { _lngActualQty = value; }
        }
	

        private Decimal _lngAcceptQty;

        public Decimal AcceptQty
        {
            get { return _lngAcceptQty; }
            set { _lngAcceptQty = value; }
        }

        private Decimal _lngReworkQty;

        public Decimal ReworkQty
        {
            get { return _lngReworkQty; }
            set { _lngReworkQty = value; }
        }

        private Decimal _lngRejectQty;

        public Decimal RejectQty
        {
            get { return _lngRejectQty; }
            set { _lngRejectQty = value; }
        }

        private String _strReworkRemarks;

        public String ReworkRemarks
        {
            get { return _strReworkRemarks; }
            set { _strReworkRemarks = value; }
        }

        private String _strRejectRemarks;

        public String RejectRemarks
        {
            get { return _strRejectRemarks; }
            set { _strRejectRemarks = value; }
        }

        private Decimal _decReworkUnitPrice;

        public Decimal ReworkUnitPrice
        {
            get { return _decReworkUnitPrice; }
            set { _decReworkUnitPrice = value; }
        }

        private string _unit;

        public string Unit
        {
            get { return _unit; }
            set { _unit = value; }
        }


        private int _Status;

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }


    }

    public class DeliverNoteMaterialsCollec : CollectionBase
    {
        public void Add(DeliverNoteMaterials objDeliverNoteMaterials)
        {
            this.InnerList.Add(objDeliverNoteMaterials);
        }
    }
}
