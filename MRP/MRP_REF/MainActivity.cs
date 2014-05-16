using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class MainActivity
    {
        private long _lngMainActID;

        public long MainActID
        {
            get { return _lngMainActID; }
            set { _lngMainActID = value; }
        }

        private String _strMainActivity;

        public String MainActivityTitle
        {
            get { return _strMainActivity; }
            set { _strMainActivity = value; }
        }

        private long _DepID;

        public long DepID
        {
            get { return _DepID; }
            set { _DepID = value; }
        }
	

        public enum Title : int
        {
            Grinding = 1,
            Sieving = 2,
            Pre_Mixing = 3,
            Pre_Heating = 4,
            Filteration = 5,
            Blending = 6,
            Boiling = 7,
            Decoction = 8,
            Cooking = 9,
            Sugar_Blending = 10,
            Fermentation = 11,
            Filtering = 12,
            Other_Activities = 13,
            Percolation = 14,
            Drying = 15,
            Chopping_Cutting = 16,
            Solidification = 17,
            Tabletting = 18,
            Packing = 19
        }

        private long _SectionID;

        public long SectionID
        {
            get { return _SectionID; }
            set { _SectionID = value; }
        }

        public enum LayoutType : int
        {
            Template1 = 1,
            Template2 = 2,
            Template3 = 3,
            Template4 = 4
        }

        private LayoutType _Type;

        public LayoutType Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
	
	
	
    }

    public class MainActivityCollec : CollectionBase
    {
        public void Add(MainActivity objMainAct)
        {
            this.InnerList.Add(objMainAct);
        }
    }
}
