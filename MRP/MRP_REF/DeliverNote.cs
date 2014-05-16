using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class DeliverNote
    {
        private String _strDelNo;

        public String DeleveryNoteID
        {
            get { return _strDelNo; }
            set { _strDelNo = value; }
        }

        private string _objPO;

        public string DeleveryNotePO
        {
            get { return _objPO; }
            set { _objPO = value; }
        }

        private DateTime _dtDate;

        public DateTime DeleveryNoteDate
        {
            get { return _dtDate; }
            set { _dtDate = value; }
        }


        private Employee _objEnterd;

        public Employee DeleveryNoteEnterdBy
        {
            get { return _objEnterd; }
            set { _objEnterd = value; }
        }

        private DateTime _dtEnterdDate;

        public DateTime DeleveryNoteEnterdDate
        {
            get { return _dtEnterdDate; }
            set { _dtEnterdDate = value; }
        }

        public enum Status : int
        {
            Initial =0,
            GRN = 1,
            Cancel = 2
        }

        private Status _enumStatus;

        public Status DeleveryNoteStatus
        {
            get { return _enumStatus; }
            set { _enumStatus = value; }
        }

        private long _Supplier;

        public long Supplier
        {
            get { return _Supplier; }
            set { _Supplier = value; }
        }

        private String _Remarks;

        public String Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }
	
    }

    public class DeleveryNoteCollec : CollectionBase
    {
        public void Add(DeliverNote objDelNote)
        {
            this.InnerList.Add(objDelNote);
        }
    }
}
