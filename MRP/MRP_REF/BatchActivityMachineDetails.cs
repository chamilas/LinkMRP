using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class BatchActivityMachineDetails
    {
        private String _BatchID;

        public String BatchID
        {
            get { return _BatchID; }
            set { _BatchID = value; }
        }
        private String _MachineID;

        public String MachineID
        {
            get { return _MachineID; }
            set { _MachineID = value; }
        }
        private Decimal _InputQty;

        public Decimal InputQty
        {
            get { return _InputQty; }
            set { _InputQty = value; }
        }
        private Decimal _OutputQty;

        public Decimal OutputQty
        {
            get { return _OutputQty; }
            set { _OutputQty = value; }
        }
        private Decimal _RejectedQty;

        public Decimal RejectedQty
        {
            get { return _RejectedQty; }
            set { _RejectedQty = value; }
        } 
	
    }

    public class BatchActivityMachineDetailsCollec : CollectionBase
    {
        public void Add(BatchActivityMachineDetails obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
