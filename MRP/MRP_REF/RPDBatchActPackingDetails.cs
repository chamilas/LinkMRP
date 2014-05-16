using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RPDBatchActPackingDetails
    {
        private long _RPDPackDetails;

        public long RPDPackDetails
        {
            get { return _RPDPackDetails; }
            set { _RPDPackDetails = value; }
        }

        private long _RPDBatchActID;

        public long RPDBatchActID
        {
            get { return _RPDBatchActID; }
            set { _RPDBatchActID = value; }
        }


        private String _MaterialCode;

        public String MaterialCode
        {
            get { return _MaterialCode; }
            set { _MaterialCode = value; }
        }

        private long _NoOfPackets;

        public long NoOfPackets
        {
            get { return _NoOfPackets; }
            set { _NoOfPackets = value; }
        }

        private Decimal _PackSize;

        public Decimal PackSize
        {
            get { return _PackSize; }
            set { _PackSize = value; }
        }
	
	
    }

    public class RPDBatchActPackingDetailsCollec : CollectionBase
    {
        public void Add(RPDBatchActPackingDetails obj)
        {
            this.InnerList.Add(obj);
        }
    }


}

