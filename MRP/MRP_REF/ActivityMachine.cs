using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ActivityMachine
    {
        private Activity _objActivity;

        public Activity Activity
        {
            get { return _objActivity; }
            set { _objActivity = value; }
        }

        private Machine _objMachine;

        public Machine Machine
        {
            get { return _objMachine; }
            set { _objMachine = value; }
        }

        private Decimal _lngHour;

        public Decimal EstimatedHour
        {
            get { return _lngHour; }
            set { _lngHour = value; }
        }

        private String _strMachine_Title;
        public String Machine_Title
        {
            get 
            {
                _strMachine_Title = Machine.MachineName;
                return _strMachine_Title; 
            }
        }
	

    }

    public class ActivityMachineCollec : CollectionBase
    {
        public void Add(ActivityMachine objActMachine)
        {
            this.InnerList.Add(objActMachine);
        }

    }
}
