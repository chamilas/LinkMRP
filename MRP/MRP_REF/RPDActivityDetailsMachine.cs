using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class RPDActivityDetailsMachine
    {
        private long _ActivityDetailsMachineID;

        public long ActivityDetailsMachineID
        {
            get { return _ActivityDetailsMachineID; }
            set { _ActivityDetailsMachineID = value; }
        }

        private long _BatchActID;

        public long BatchActID
        {
            get { return _BatchActID; }
            set { _BatchActID = value; }
        }

        private String _Description;

        public String Description
        {
            get { return _Description; }
            set { _Description = value; }
        }


        private String _MachineCode;

        public String MachineCode
        {
            get { return _MachineCode; }
            set { _MachineCode = value; }
        }

        private String _MeshSize;

        public String MeshSize
        {
            get { return _MeshSize; }
            set { _MeshSize = value; }
        }


        private string _StartTime;

        public string StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        private string _StopTime;

        public string StopTime
        {
            get { return _StopTime; }
            set { _StopTime = value; }
        }

        private DateTime _StartTime_D;

        public DateTime StartTime_D
        {
            get { return _StartTime_D; }
            set { _StartTime_D = value; }
        }

        private DateTime _StopTime_D;

        public DateTime StopTime_D
        {
            get { return _StopTime_D; }
            set { _StopTime_D = value; }
        }



        private Decimal _HourlyRate;

        public Decimal HourlyRate
        {
            get { return _HourlyRate; }
            set { _HourlyRate = value; }
        }
	
	
    }

    public class RPDActivityDetailsMachineCollec : CollectionBase
    {
        public void Add(RPDActivityDetailsMachine obj)
        {
            this.InnerList.Add(obj);
        }
    }


}

