using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SubContractor
    {

        private bool _SubStatus;

        public bool SubStatus
        {
            get { return _SubStatus; }
            set { _SubStatus = value; }
        }
	

        private String _SubContactPerson;

        public String SubContactPerson
        {
            get { return _SubContactPerson; }
            set { _SubContactPerson = value; }
        }
	

        private String _SubFax;

        public String SubFax
        {
            get { return _SubFax; }
            set { _SubFax = value; }
        }
	

        private String _SubEmail;

        public String SubEmail
        {
            get { return _SubEmail; }
            set { _SubEmail = value; }
        }
	
        private String _SubMobile;

        public String SubMobile
        {
            get { return _SubMobile; }
            set { _SubMobile = value; }
        }
	

        private String _SubPhone;

        public String SubPhone
        {
            get { return _SubPhone; }
            set { _SubPhone = value; }
        }
	


        private String _SubAddress;

        public String SubAddress
        {
            get { return _SubAddress; }
            set { _SubAddress = value; }
        }
	

        private long _SubContractorID;

        public long SubContractorID
        {
            get { return _SubContractorID; }
            set { _SubContractorID = value; }
        }


        private String _SubCode;

        public String SubCode
        {
            get { return _SubCode; }
            set { _SubCode = value; }
        }


        private String _SubName;

        public String SubName
        {
            get { return _SubName; }
            set { _SubName = value; }
        }
	


    }

    public class SubContractorCollec : CollectionBase
    {
        public void Add(SubContractor obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
