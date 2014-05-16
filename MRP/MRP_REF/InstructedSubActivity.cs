using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
     public class InstructedSubActivity
    {

        private long _InstructedSubActID;

        public long InstructedSubActID
        {
            get { return _InstructedSubActID; }
            set { _InstructedSubActID = value; }
        }

        private long _BatchActID;

        public long BatchActID
        {
            get { return _BatchActID; }
            set { _BatchActID = value; }
        }


        private String _SubActDescription;

        public String SubActDescription
        {
            get { return _SubActDescription; }
            set { _SubActDescription = value; }
        }
	
    }

    public class InstructedSubActivityCollec : CollectionBase
    {
        public void Add(InstructedSubActivity obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
