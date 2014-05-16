using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class QCReport
    {
        private long _QCReportID;

        public long QCReportID
        {
            get { return _QCReportID; }
            set { _QCReportID = value; }
        }

        private String _ReportType;

        public String ReportType
        {
            get { return _ReportType; }
            set { _ReportType = value; }
        }

        private String _RPDBatchID;

        public String RPDBatchID
        {
            get { return _RPDBatchID; }
            set { _RPDBatchID = value; }
        }

        private String _PRPDBatchID;

        public String PRPDBatchID
        {
            get { return _PRPDBatchID; }
            set { _PRPDBatchID = value; }
        }

        private String _ProductionBatchID;

        public String ProductionBatchID
        {
            get { return _ProductionBatchID; }
            set { _ProductionBatchID = value; }
        }


        private DateTime? _FinishDate;

        public DateTime? FinishDate
        {
            get { return _FinishDate; }
            set { _FinishDate = value; }
        }

        private String _AnalyzedBy;

        public String AnalyzedBy
        {
            get { return _AnalyzedBy; }
            set { _AnalyzedBy = value; }
        }
        private string _RDQAOfficer;

        public string RDQAOfficer
        {
            get { return _RDQAOfficer; }
            set { _RDQAOfficer = value; }
        }

        private String _TestBy;

        public String TestBy
        {
            get { return _TestBy; }
            set { _TestBy = value; }
        }
        private String _SendBy;

        public String SendBy
        {
            get { return _SendBy; }
            set { _SendBy = value; }
        }
        private DateTime? _SendDate;

        public DateTime? SendDate
        {
            get { return _SendDate; }
            set { _SendDate = value; }
        }
        private String _SampleSize;

        public String SampleSize
        {
            get { return _SampleSize; }
            set { _SampleSize = value; }
        }
        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
        private int _Status;

        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private decimal _SpecificGravity;

        public decimal SpecificGravity
        {
            get { return _SpecificGravity; }
            set { _SpecificGravity = value; }
        }

        private string _PackingBatchID;

        public string PackingBatchID
        {
            get { return _PackingBatchID; }
            set { _PackingBatchID = value; }
        }



        public enum ReportStatus : int
        {
            Initial = 1,
            Accept = 2,
            Reject = 3
        }


        public enum Type
        {
            RPD,
            PRPD,
            Production
        }
	
    }


    public class QCReportCollec : CollectionBase
    {
        public void Add(QCReport obj)
        {
            this.InnerList.Add(obj);
        }
    }
}
