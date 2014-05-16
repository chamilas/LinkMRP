using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SalesRef
    {
        private long _lngRefID;

        public long SalesRefID
        {
            get { return _lngRefID; }
            set { _lngRefID = value; }
        }

        private String _strName;

        public String SalesRefName
        {
            get { return _strName; }
            set { _strName = value; }
        }

        private String _strAddress;

        public String SalesRefAddress
        {
            get { return _strAddress; }
            set { _strAddress = value; }
        }

        private String _strPhone;

        public String SalesRefPhone
        {
            get { return _strPhone; }
            set { _strPhone = value; }
        }

        private String _strEmail;

        public String SalesRefEmail
        {
            get { return _strEmail; }
            set { _strEmail = value; }
        }

        private String _strFax;

        public String SalesRefFax
        {
            get { return _strFax; }
            set { _strFax = value; }
        }

        private bool _boolStatus;

        public bool SalesRefStatus
        {
            get { return _boolStatus; }
            set { _boolStatus = value; }
        }
	
	
    }

    public class SalesRefCollec : CollectionBase
    {
        public void Add(SalesRef objSalesRef)
        {
            this.InnerList.Add(objSalesRef);
        }
    }

}
