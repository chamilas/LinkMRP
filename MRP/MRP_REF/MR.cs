using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MR
    {
        private long _lngMRNo;

        public long MRNO
        {
            get { return _lngMRNo; }
            set { _lngMRNo = value; }
        }

        private Store _objStore;

        public Store MRStore
        {
            get { return _objStore; }
            set { _objStore = value; }
        }

        private DateTime dtDate;

        public DateTime MRDate
        {
            get { return dtDate; }
            set { dtDate = value; }
        }

        private string _objApprovedBy;

        public string MRApprovedBy
        {
            get { return _objApprovedBy; }
            set { _objApprovedBy = value; }
        }

        private DateTime _dtApprovedDate;

        public DateTime MRApprovedDate
        {
            get { return _dtApprovedDate; }
            set { _dtApprovedDate = value; }
        }

        private string _objEnterBy;

        public string MREnterdBy
        {
            get { return _objEnterBy; }
            set { _objEnterBy = value; }
        }

        private Department _objDepartmetn;

        public Department MRDepartmentFrom
        {
            get { return _objDepartmetn; }
            set { _objDepartmetn = value; }
        }

        private string _objIssuedBy;

        public string MRIssuedBy
        {
            get { return _objIssuedBy; }
            set { _objIssuedBy = value; }
        }

        private DateTime _dtIssuedDate;

        public DateTime MRIssuedDate
        {
            get { return _dtIssuedDate; }
            set { _dtIssuedDate = value; }
        }

        private string _objReceivedBy;

        public string MRReceivedBy
        {
            get { return _objReceivedBy; }
            set { _objReceivedBy = value; }
        }

        private DateTime _dtReceivedDate;

        public DateTime MRReceivedDate
        {
            get { return _dtReceivedDate; }
            set { _dtReceivedDate = value; }
        }

        private String _strRemarks;

        public String MRRemarks
        {
            get { return _strRemarks; }
            set { _strRemarks = value; }
        }

        public enum Status : int
        {
            Initial = 0,
            Approved = 1,
            Issued = 2,
            Recevied = 3,
            Reject = 4,
            ReceviedGRN = 5,
            ReceviedSubStock = 6
        }

        private Status _boolStatus;

        public Status MRStatus
        {
            get { return _boolStatus; }
            set { _boolStatus = value; }
        }

        public enum Type : int
        {
            Material = 1,
            BasicProduct = 2,
            FinishProduct = 3
        }

        private Type _intMRType;

        public Type MRType
        {
            get { return _intMRType; }
            set { _intMRType = value; }
        }

        private Decimal _decUnitRate;

        public Decimal MRUnitRate
        {
            get { return _decUnitRate; }
            set { _decUnitRate = value; }
        }

        private long? _SectionID;

        public long? SectionID
        {
            get { return _SectionID; }
            set { _SectionID = value; }
        }



        public enum Origin: int
        {
            ToDepartment = 1,
            ToSection = 2,
            ToStore = 3,
            ToBatch=4
        }

        private Origin _intOriginType;

        public Origin OriginType
        {
            get { return _intOriginType; }
            set { _intOriginType = value; }
        }


        private bool _Print;

        public bool Print
        {
            get { return _Print; }
            set { _Print = value; }
        }

        private bool _BulkPrint;

        public bool BulkPrint
        {
            get { return _BulkPrint; }
            set { _BulkPrint = value; }
        }




    }

    public class MRCollec : CollectionBase
    {
        public void Add(MR objMR)
        {
            this.InnerList.Add(objMR);
        }
    }
}
