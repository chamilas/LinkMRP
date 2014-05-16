using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MachineTransfer
    {
        private long _lngTransferID;

        public long TransferID
        {
            get { return _lngTransferID; }
            set { _lngTransferID = value; }
        }

        private Machine _objMachine;

        public Machine TransferMachine
        {
            get { return _objMachine; }
            set { _objMachine = value; }
        }

        private String _strLocation;

        public String TransferLocation
        {
            get { return _strLocation; }
            set { _strLocation = value; }
        }


        private DateTime _dtDate;

        public DateTime TransferDate
        {
            get { return _dtDate; }
            set { _dtDate = value; }
        }

        private Employee _objApprovedBy;

        public Employee TransferApprovedBy
        {
            get { return _objApprovedBy; }
            set { _objApprovedBy = value; }
        }

        private String _strBranch;

        public String TransferBranch
        {
            get { return _strBranch; }
            set { _strBranch = value; }
        }
	
    }

    public class MachineTransferCollec : CollectionBase
    {
        public void Add(MachineTransfer objMachineTransfer)
        {
            this.InnerList.Add(objMachineTransfer);
        }
    }
}
