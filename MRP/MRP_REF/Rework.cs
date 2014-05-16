using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Rework
    {

        private long _lngReworkID;

        public long ReworkID
        {
            get { return _lngReworkID; }
            set { _lngReworkID = value; }
        }

        private TGRN _objTGRN;

        public TGRN ReworkTGRN
        {
            get { return _objTGRN; }
            set { _objTGRN = value; }
        }

        private MTN _objMtn;

        public MTN ReworkMTN
        {
            get { return _objMtn; }
            set { _objMtn = value; }
        }

        private Material _objMaterial;

        public Material ReworkMaterial
        {
            get { return _objMaterial; }
            set { _objMaterial = value; }
        }

        private long _lngQty;

        public long ReworkQty
        {
            get { return _lngQty; }
            set { _lngQty = value; }
        }

        private long _lngFinalQty;

        public long ReworkFinalQty
        {
            get { return _lngFinalQty; }
            set { _lngFinalQty = value; }
        }

        private long _lngAddedCost;

        public long ReworkAddedCost
        {
            get { return _lngAddedCost; }
            set { _lngAddedCost = value; }
        }

        private long _lngUnitPrice;

        public long ReworkUnitPrice
        {
            get { return _lngUnitPrice; }
            set { _lngUnitPrice = value; }
        }

        private Employee _objEmployee;

        public Employee ReworkReceivedBy
        {
            get { return _objEmployee; }
            set { _objEmployee = value; }
        }

        private DateTime _dtRecivedDate;

        public DateTime ReworkReceivedDate
        {
            get { return _dtRecivedDate; }
            set { _dtRecivedDate = value; }
        }

        private String _strRemarks;

        public String ReworkRemarks
        {
            get { return _strRemarks; }
            set { _strRemarks = value; }
        }

        enum ReworkStatus
        {
            InPrograss = 0,
            Finish = 1,
            Finalized = 2
        }
    }

    public class ReworkCollec : CollectionBase
    {
        public void Add(Rework objRework)
        {
            this.InnerList.Add(objRework);
        }
    }
}
