using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class SubActivity
    {
        private Activity _objActivity;

        public Activity Activity
        {
            get { return _objActivity; }
            set { _objActivity = value; }
        }

        private long _lngSubActID;

        public long SubActID
        {
            get { return _lngSubActID; }
            set { _lngSubActID = value; }
        }

        private String _strSubActDescription;

        public String SubActDescription
        {
            get { return _strSubActDescription; }
            set { _strSubActDescription = value; }
        }
	
	
	
    }

    public class SubActivityCollec : CollectionBase
    {
        public void Add(SubActivity objSubAct)
        {
            this.InnerList.Add(objSubAct);
        }
    }
}
