using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
  public  class RPDActivityMachine
    {
         private MainActivity _activity;

        public MainActivity Activity
        {
            get { return _activity; }
            set { _activity = value; }
        }
      

        private string _activityID;

        public string ActivityID
        {
            get 
            {
                _activityID = Activity.MainActID.ToString();
                return _activityID; 
            }
            set { _activityID = value; }
        }

        private string _activityName;

        public string ActivityName
        {
            get {
                _activityName = Activity.MainActivityTitle;
                return _activityName; 
            }
            set { _activityName = value; }
        }
        private Machine _machine;

        public Machine Machine
        {
            get { return _machine; }
            set { _machine = value; }
        }
      
      private string _machineCode;

      public string MachineCode
      {
          get
          {
              _machineCode = Machine.MachineCode;
              return _machineCode;
          }
          set { _machineCode = value; }
      }

      private string _machineName;

      public string MachineName
      {
          get 
          {
              _machineName = Machine.MachineName;
              
              return _machineName;
          }
          set { _machineName = value; }


      }
        private decimal _costPerMachineHour;

      public decimal CostPerMachineHour
        {
            get { return _costPerMachineHour; }
            set { _costPerMachineHour = value; }
        }

      private decimal _costPerManHour;

      public decimal CostPerManHour
        {
            get { return _costPerManHour; }
            set { _costPerManHour = value; }
        }

 
    }

    public class RPDActivityMachineCollec : CollectionBase
    {
        public void Add(RPDActivityMachine objRPDActivityMachine)
        {
            this.InnerList.Add(objRPDActivityMachine);
        }

        public void Delete(RPDActivityMachine objRPDActivityMachine)
        {
            this.InnerList.Remove(objRPDActivityMachine);
        }
    }
    }


