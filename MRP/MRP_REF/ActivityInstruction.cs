using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace SESD.MRP.REF
{
    public class ActivityInstruction
    {
        public ActivityInstruction()
        {
            Machine = new Machine();
            Activity = new Activity();
        }

        private String _strActInsType;

        public String ActInsType
        {
            get { return _strActInsType; }
            set { _strActInsType = value; }
        }
	

        private Activity _objActivity;

        public Activity Activity
        {
            get { return _objActivity; }
            set { _objActivity = value; }
        }

        private long _lngInstrictionID;

        public long ActInstructionID
        {
            get { return _lngInstrictionID; }
            set { _lngInstrictionID = value; }
        }

        private String _strPart;

        public String ActInstructionPart
        {
            get { return _strPart; }
            set { _strPart = value; }
        }

        private String Stage;

        public String ActStage
        {
            get { return Stage; }
            set { Stage = value; }
        }

        private Machine _objMachine;

        public Machine Machine
        {
            get { return _objMachine; }
            set { _objMachine = value; }
        }

        private String _strRemarks;

        public String Remarks
        {
            get { return _strRemarks; }
            set { _strRemarks = value; }
        }

        private Decimal _lngMesh;

        public Decimal MeshSize
        {
            get { return _lngMesh; }
            set { _lngMesh = value; }
        }

        private Decimal _BOIL_TotalWeight;

        public Decimal BOIL_TotalWeight
        {
            get { return _BOIL_TotalWeight; }
            set { _BOIL_TotalWeight = value; }
        }

        private Decimal _BOIL_TotalInitialVol;

        public Decimal BOIL_TotalInitialVol
        {
            get { return _BOIL_TotalInitialVol; }
            set { _BOIL_TotalInitialVol = value; }
        }

        private Decimal _BOIL_TotalFinalVol;

        public Decimal BOIL_TotalFinalVol
        {
            get { return _BOIL_TotalFinalVol; }
            set { _BOIL_TotalFinalVol = value; }
        }

        private Decimal _BOIL_TotalConcentratedDecoction;

        public Decimal BOIL_TotalConcentratedDecoction
        {
            get { return _BOIL_TotalConcentratedDecoction; }
            set { _BOIL_TotalConcentratedDecoction = value; }
        }

        private Decimal _BOIL_Parts;

        public Decimal BOIL_Parts
        {
            get { return _BOIL_Parts; }
            set { _BOIL_Parts = value; }
        }

        private Decimal _BOIL_PartWeight;

        public Decimal BOIL_PartWeight
        {
            get { return _BOIL_PartWeight; }
            set { _BOIL_PartWeight = value; }
        }

        private Decimal _BOIL_InitialPartVol;

        public Decimal BOIL_InitialPartVol
        {
            get { return _BOIL_InitialPartVol; }
            set { _BOIL_InitialPartVol = value; }
        }

        private Decimal _BOIL_FinalPartVol;

        public Decimal BOIL_FinalPartVol
        {
            get { return _BOIL_FinalPartVol; }
            set { _BOIL_FinalPartVol = value; }
        }

        private Decimal _BOIL_ConcPartVol;

        public Decimal BOIL_ConcPartVol
        {
            get { return _BOIL_ConcPartVol; }
            set { _BOIL_ConcPartVol = value; }
        }

        private Decimal _BOIL_SugarQty;

        public Decimal BOIL_SugarQty
        {
            get { return _BOIL_SugarQty; }
            set { _BOIL_SugarQty = value; }
        }

        private Decimal _BOIL_FinalQty;

        public Decimal BOIL_FinalQty
        {
            get { return _BOIL_FinalQty; }
            set { _BOIL_FinalQty = value; }
        }

        private Decimal _FER_WaterDecocQty;

        public Decimal FER_WaterDecocQty
        {
            get { return _FER_WaterDecocQty; }
            set { _FER_WaterDecocQty = value; }
        }

        private Decimal _FER_VolAfterSugar;

        public Decimal FER_VolAfterSugar
        {
            get { return _FER_VolAfterSugar; }
            set { _FER_VolAfterSugar = value; }
        }

        private Decimal _FER_DaysBeforeSealing;

        public Decimal FER_DaysBeforeSealing
        {
            get { return _FER_DaysBeforeSealing; }
            set { _FER_DaysBeforeSealing = value; }
        }

        private Decimal _FER_SealingDays;

        public Decimal FER_SealingDays
        {
            get { return _FER_SealingDays; }
            set { _FER_SealingDays = value; }
        }

        private Decimal _PER_TotalGroundWeight;

        public Decimal PER_TotalGroundWeight
        {
            get { return _PER_TotalGroundWeight; }
            set { _PER_TotalGroundWeight = value; }
        }

        private Decimal _PER_LaterAddedWeight;

        public Decimal PER_LaterAddedWeight
        {
            get { return _PER_LaterAddedWeight; }
            set { _PER_LaterAddedWeight = value; }
        }

        private Decimal _PER_EthanolVol;

        public Decimal PER_EthanolVol
        {
            get { return _PER_EthanolVol; }
            set { _PER_EthanolVol = value; }
        }

        private Decimal _PER_LiquidRatio;

        public Decimal PER_LiquidRatio
        {
            get { return _PER_LiquidRatio; }
            set { _PER_LiquidRatio = value; }
        }

        private Decimal _PER_96Ethanol;

        public Decimal PER_96Ethanol
        {
            get { return _PER_96Ethanol; }
            set { _PER_96Ethanol = value; }
        }

        private Decimal _DRY_FinalMostureContent;

        public Decimal DRY_FinalMostureContent
        {
            get { return _DRY_FinalMostureContent; }
            set { _DRY_FinalMostureContent = value; }
        }

        private Decimal _TAB_Weight;

        public Decimal TAB_Weight
        {
            get { return _TAB_Weight; }
            set { _TAB_Weight = value; }
        }

        private Decimal _TAB_Thickness;

        public Decimal TAB_Thickness
        {
            get { return _TAB_Thickness; }
            set { _TAB_Thickness = value; }
        }

        private Decimal _TAB_Hardness;

        public Decimal TAB_Hardness
        {
            get { return _TAB_Hardness; }
            set { _TAB_Hardness = value; }
        }

        private String _TAB_LogoWith;

        public String TAB_LogoWith
        {
            get { return _TAB_LogoWith; }
            set { _TAB_LogoWith = value; }
        }

        private String _TAB_LogoWithout;

        public String TAB_LogoWithout
        {
            get { return _TAB_LogoWithout; }
            set { _TAB_LogoWithout = value; }
        }

        private Decimal _BLEND_FinalVol;

        public Decimal BLEND_FinalVol
        {
            get { return _BLEND_FinalVol; }
            set { _BLEND_FinalVol = value; }
        }

        private String _BLEND_Item;

        public String BLEND_Item
        {
            get { return _BLEND_Item; }
            set { _BLEND_Item = value; }
        }

        private Decimal _BLEND_Qty;

        public Decimal BLEND_Qty
        {
            get { return _BLEND_Qty; }
            set { _BLEND_Qty = value; }
        }

        private String _COOKING_Item;

        public String COOKING_Item
        {
            get { return _COOKING_Item; }
            set { _COOKING_Item = value; }
        }

        private Decimal _COOKING_Qty;

        public Decimal COOKING_Qty
        {
            get { return _COOKING_Qty; }
            set { _COOKING_Qty = value; }
        }

        private String _DRY_Material;

        public String DRY_Material
        {
            get { return _DRY_Material; }
            set { _DRY_Material = value; }
        }

        private String _DRY_DryerCode;

        public String DRY_DryerCode
        {
            get { return _DRY_DryerCode; }
            set { _DRY_DryerCode = value; }
        }

        private Decimal _DRY_Time;

        public Decimal DRY_Time
        {
            get { return _DRY_Time; }
            set { _DRY_Time = value; }
        }

        private Decimal _DRY_Temperature;

        public Decimal DRY_Temperature
        {
            get { return _DRY_Temperature; }
            set { _DRY_Temperature = value; }
        }

        private String _CHOP_Material;

        public String CHOP_Material
        {
            get { return _CHOP_Material; }
            set { _CHOP_Material = value; }
        }

        private Decimal _CHOP_Size;

        public Decimal CHOP_Size
        {
            get { return _CHOP_Size; }
            set { _CHOP_Size = value; }
        }

        private String _SOLID_Material;

        public String SOLID_Material
        {
            get { return _SOLID_Material; }
            set { _SOLID_Material = value; }
        }

        private Decimal _SOLID_InitialVol;

        public Decimal SOLID_InitialVol
        {
            get { return _SOLID_InitialVol; }
            set { _SOLID_InitialVol = value; }
        }

        private Decimal _SOLID_Time;

        public Decimal SOLID_Time
        {
            get { return _SOLID_Time; }
            set { _SOLID_Time = value; }
        }

        private Decimal _SBLEND_FinalVol;

        public Decimal SBLEND_FinalVol
        {
            get { return _SBLEND_FinalVol; }
            set { _SBLEND_FinalVol = value; }
        }

        private String _SBLEND_Item;

        public String SBLEND_Item
        {
            get { return _SBLEND_Item; }
            set { _SBLEND_Item = value; }
        }

        private Decimal _SBLEND_Qty;

        public Decimal SBLEND_Qty
        {
            get { return _SBLEND_Qty; }
            set { _SBLEND_Qty = value; }
        }


        private Decimal _PREMIX_FinalVol;

        public Decimal PREMIX_FinalVol
        {
            get { return _PREMIX_FinalVol; }
            set { _PREMIX_FinalVol = value; }
        }

        private String _PREMIX_Item;

        public String PREMIX_Item
        {
            get { return _PREMIX_Item; }
            set { _PREMIX_Item = value; }
        }

        private Decimal _PREMIX_Qty;

        public Decimal PREMIX_Qty
        {
            get { return _PREMIX_Qty; }
            set { _PREMIX_Qty = value; }
        }

        private Decimal _PREHEAT_TotalWeight;

        public Decimal PREHEAT_TotalWeight
        {
            get { return _PREHEAT_TotalWeight; }
            set { _PREHEAT_TotalWeight = value; }
        }

        private Decimal _PREHEAT_TotalInitialVol;

        public Decimal PREHEAT_TotalInitialVol
        {
            get { return _PREHEAT_TotalInitialVol; }
            set { _PREHEAT_TotalInitialVol = value; }
        }

        private Decimal _PREHEAT_TotalFinalVol;

        public Decimal PREHEAT_TotalFinalVol
        {
            get { return _PREHEAT_TotalFinalVol; }
            set { _PREHEAT_TotalFinalVol = value; }
        }

        private Decimal _PREHEAT_TotalConcentratedDecoction;

        public Decimal PREHEAT_TotalConcentratedDecoction
        {
            get { return _PREHEAT_TotalConcentratedDecoction; }
            set { _PREHEAT_TotalConcentratedDecoction = value; }
        }


        private Decimal _PREHEAT_Parts;

        public Decimal PREHEAT_Parts
        {
            get { return _PREHEAT_Parts; }
            set { _PREHEAT_Parts = value; }
        }


        private Decimal _PREHEAT_PartWeight;

        public Decimal PREHEAT_PartWeight
        {
            get { return _PREHEAT_PartWeight; }
            set { _PREHEAT_PartWeight = value; }
        }


        private Decimal _PREHEAT_InitialPartVol;

        public Decimal PREHEAT_InitialPartVol
        {
            get { return _PREHEAT_InitialPartVol; }
            set { _PREHEAT_InitialPartVol = value; }
        }


        private Decimal _PREHEAT_FinalPartVol;

        public Decimal PREHEAT_FinalPartVol
        {
            get { return _PREHEAT_FinalPartVol; }
            set { _PREHEAT_FinalPartVol = value; }
        }


        private Decimal _PREHEAT_ConcPartVol;

        public Decimal PREHEAT_ConcPartVol
        {
            get { return _PREHEAT_ConcPartVol; }
            set { _PREHEAT_ConcPartVol = value; }
        }


        private Decimal _PREHEAT_SugarQty;

        public Decimal PREHEAT_SugarQty
        {
            get { return _PREHEAT_SugarQty; }
            set { _PREHEAT_SugarQty = value; }
        }

        private Decimal _PREHEAT_FinalQty;

        public Decimal PREHEAT_FinalQty
        {
            get { return _PREHEAT_FinalQty; }
            set { _PREHEAT_FinalQty = value; }
        }


        private String _GRIND_Material;

        public String GRIND_Material
        {
            get { return _GRIND_Material; }
            set { _GRIND_Material = value; }
        }

        private String _Machine;
        public String MachineCode
        {
            get { return Machine.MachineName; }
        }
	
	
    }

    public class ActivityInstructionCollec : CollectionBase
    {
        public void Add(ActivityInstruction objActIns)
        {
            this.InnerList.Add(objActIns);
        }
    }
}
