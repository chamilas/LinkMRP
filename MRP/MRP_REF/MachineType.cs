using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MachineType
    {
        private long _lngTypeID;

        public long MachineTypeID
        {
            get { return _lngTypeID; }
            set { _lngTypeID = value; }
        }

        private String _strMachineType;

        public String MachineTypeTitle
        {
            get { return _strMachineType; }
            set { _strMachineType = value; }
        }
	
    }

    public class MachineTypeCollec : CollectionBase
    {
        public void Add(MachineType objMachineType)
        {
            this.InnerList.Add(objMachineType);
        }
    }
}
