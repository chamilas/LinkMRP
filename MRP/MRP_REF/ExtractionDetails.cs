using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ExtractionDetails
    {
        private long _ExtractionDetailsID;

        public long ExtractionDetailsID
        {
            get { return _ExtractionDetailsID; }
            set { _ExtractionDetailsID = value; }
        }


        private String _ExtractionType;

        public String ExtractionType
        {
            get { return _ExtractionType; }
            set { _ExtractionType = value; }
        }


        private long _ProductionBatchActivity;

        public long ProductionBatchActivity
        {
            get { return _ProductionBatchActivity; }
            set { _ProductionBatchActivity = value; }
        }

        private long _PRPRDBatchActivity;

        public long PRPRDBatchActivity
        {
            get { return _PRPRDBatchActivity; }
            set { _PRPRDBatchActivity = value; }
        }

        private long _RPDBatchActivity;

        public long RPDBatchActivity
        {
            get { return _RPDBatchActivity; }
            set { _RPDBatchActivity = value; }
        }

        private String _BatchType;

        public String BatchType
        {
            get { return _BatchType; }
            set { _BatchType = value; }
        }

        private long _MainActID;

        public long MainActID
        {
            get { return _MainActID; }
            set { _MainActID = value; }
        }

        private String _MachineID;

        public String MachineID
        {
            get { return _MachineID; }
            set { _MachineID = value; }
        }

        private String _AssignedEmployee;

        public String AssignedEmployee
        {
            get { return _AssignedEmployee; }
            set { _AssignedEmployee = value; }
        }

        private DateTime? _StartTime;

        public DateTime? StartTime
        {
            get { return _StartTime; }
            set { _StartTime = value; }
        }

        private DateTime? _StopTime;

        public DateTime? StopTime
        {
            get { return _StopTime; }
            set { _StopTime = value; }
        }

        private DateTime? _LoadingStartTime;

        public DateTime? LoadingStartTime
        {
            get { return _LoadingStartTime; }
            set { _LoadingStartTime = value; }
        }

        private DateTime? _LoadingStopTime;

        public DateTime? LoadingStopTime
        {
            get { return _LoadingStopTime; }
            set { _LoadingStopTime = value; }
        }

        private DateTime? _UnloadingStartTime;

        public DateTime? UnloadingStartTime
        {
            get { return _UnloadingStartTime; }
            set { _UnloadingStartTime = value; }
        }

        private DateTime? _UnloadingStopTime;

        public DateTime? UnloadingStopTime
        {
            get { return _UnloadingStopTime; }
            set { _UnloadingStopTime = value; }
        }

        public enum Status : int
        {
            Initial = 1,
            Started = 2,
            Finished = 3,
            Transferd = 4
        }

        private Status _ExtractionStatus;

        public Status ExtractionStatus
        {
            get { return _ExtractionStatus; }
            set { _ExtractionStatus = value; }
        }

        private Decimal _SectionOverheadRate;

        public Decimal SectionOverheadRate
        {
            get { return _SectionOverheadRate; }
            set { _SectionOverheadRate = value; }
        }

        private Decimal _MachineHourlyRate;

        public Decimal MachineHourlyRate
        {
            get { return _MachineHourlyRate; }
            set { _MachineHourlyRate = value; }
        }

        private Decimal _EmployeeHourlyRate;

        public Decimal EmployeeHourlyRate
        {
            get { return _EmployeeHourlyRate; }
            set { _EmployeeHourlyRate = value; }
        }


        private Decimal _EmployeeOTRate;

        public Decimal EmployeeOTRate
        {
            get { return _EmployeeOTRate; }
            set { _EmployeeOTRate = value; }
        }
	

    }
    public class ExtractionDetailsCollec : CollectionBase
    {
        public void Add(ExtractionDetails obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
