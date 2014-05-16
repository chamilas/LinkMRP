using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class Activity
    {
        private long _lngActID;

        public long ActivityID
        {
            get { return _lngActID; }
            set { _lngActID = value; }
        }

        private MainActivity _objMainAct;

        public MainActivity ActMainActivity
        {
            get { return _objMainAct; }
            set { _objMainAct = value; }
        }

        private STDBatch _objSTDBatch;

        public STDBatch ActSTDBatch
        {
            get { return _objSTDBatch; }
            set { _objSTDBatch = value; }
        }


        private Decimal _lngDuration;

        public Decimal ActDuration
        {
            get { return _lngDuration; }
            set { _lngDuration = value; }
        }


        private Decimal _lngManHours;

        public Decimal ActManHours
        {
            get { return _lngManHours; }
            set { _lngManHours = value; }
        }

        private Decimal _lngCost;

        public Decimal ActCost
        {
            get { return _lngCost; }
            set { _lngCost = value; }
        }


        private String _MainActivity;
        public String MainActivity
        {
            get 
            {
                _MainActivity = ActMainActivity.MainActivityTitle;
                return _MainActivity; 
            
            }
        }



        private String _MainActivityID;
        public String MainActivityID
        {
            get
            {
                _MainActivityID = ActMainActivity.MainActivityTitle + " - " + ActivityID.ToString();
                return _MainActivityID;

            }
        }

        private int _SequenceNo;

        public int SequenceNo
        {
            get { return _SequenceNo; }
            set { _SequenceNo = value; }
        }

        private String _Part;

        public String Part
        {
            get { return _Part; }
            set { _Part = value; }
        }


        private String _InstructedBy;

        public String InstructedBy
        {
            get { return _InstructedBy; }
            set { _InstructedBy = value; }
        }


        private DateTime _LastEdited;

        public DateTime LastEdited
        {
            get { return _LastEdited; }
            set { _LastEdited = value; }
        }


        private bool _BlockNextActivity;

        public bool BlockNextActivity
        {
            get { return _BlockNextActivity; }
            set { _BlockNextActivity = value; }
        }
	


    }

    public class ActivityCollec : CollectionBase
    {
        public void Add(Activity objActivity)
        {
            this.InnerList.Add(objActivity);

        }

        public void Delete(Activity objActivity)
        {
            this.InnerList.Remove(objActivity);
        }
    }
}
