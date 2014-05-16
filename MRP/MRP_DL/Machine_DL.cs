using SESD.MRP.REF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DL
{
    public class Machine_DL
    {
        SqlConnection Connection = new SqlConnection();

        Unit_DL objUnit_DL = new Unit_DL(ConnectionStringClass.GetConnection());
        MachineType_DL objMachineType_DL = new MachineType_DL(ConnectionStringClass.GetConnection());


        public Machine_DL(SqlConnection Conn)
        {
            Connection = Conn;
        }
        public int Add(Machine obj)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MachineCode", obj.MachineCode),
                new SqlParameter("@MachineName", obj.MachineName),
                new SqlParameter("@MachineSupplierID", obj.MachineSupplier),
                new SqlParameter("@MachineTypeID", obj.MachineType.MachineTypeID),
                new SqlParameter("@MachineDescription", obj.MachineDescription),
                new SqlParameter("@MachinHourCost", obj.MachineHourCost),
                new SqlParameter("@MachineCapacity",  obj.MachineCapacity),
                new SqlParameter("@MachineCapacityUnitID", obj.MachineCapacityUnit.UnitID),
                new SqlParameter("@MachineValue", obj.MachineValue),
                new SqlParameter("@MachinePurchaseDate", obj.MachinePurchaseDate),
                new SqlParameter("@MachineTransferDetails", obj.MachineTransferDetails),
                new SqlParameter("@MachinePropertyTag", obj.MachinePropertyTag),
                new SqlParameter("@MachineBranch", obj.MachineBranch),
                new SqlParameter("@MachineWastage", obj.MachineWastage)};

                return Execute.RunSP_RowsEffected(Connection, "SPADD_Machine", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public int Delete(String MachineCode)
        {
            try
            {


                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@Original_MachineCode", MachineCode)};

                return Execute.RunSP_RowsEffected(Connection, "SPDELETE_Machine", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public MachineCollec Get()
        {
            try
            {


                DataTable dt= Execute.RunSP_DataTable(Connection, "SPGET_Machine");

                MachineCollec objMachineCollec = new MachineCollec();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Machine objMachine = new Machine();

                    objMachine.MachineBranch = Convert.ToString(dt.Rows[i]["MachineBranch"]);
                    objMachine.MachineCapacity = Convert.ToDecimal(dt.Rows[i]["MachineCapacity"]);
                    objMachine.MachineCapacityUnit =objUnit_DL.Get(Convert.ToInt64(dt.Rows[i]["MachineCapacityUnitID"]));
                    objMachine.MachineCode = Convert.ToString(dt.Rows[i]["MachineCode"]);
                    objMachine.MachineDescription = Convert.ToString(dt.Rows[i]["MachineDescription"]);
                    objMachine.MachineHourCost = Convert.ToDecimal(dt.Rows[i]["MachinHourCost"]);
                    objMachine.MachineName = Convert.ToString(dt.Rows[i]["MachineName"]);
                    objMachine.MachinePropertyTag = Convert.ToString(dt.Rows[i]["MachinePropertyTag"]);
                    objMachine.MachinePurchaseDate = Convert.ToDateTime(dt.Rows[i]["MachinePurchaseDate"]);
                    objMachine.MachineSupplier = "LNP";
                    objMachine.MachineTransferDetails = Convert.ToString(dt.Rows[i]["MachineTransferDetails"]);
                    objMachine.MachineType = objMachineType_DL.Get(Convert.ToInt64(dt.Rows[i]["MachineTypeID"]));
                    objMachine.MachineValue = Convert.ToDecimal(dt.Rows[i]["MachineValue"]);
                    objMachine.MachineWastage = Convert.ToDecimal(dt.Rows[i]["MachineWastage"]);

                    objMachineCollec.Add(objMachine);
                }
                return objMachineCollec;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }

          

        }

        public Machine Get(String MachineCode)
        {
            try
            {

                SqlParameter[] paramList = new SqlParameter[] {
                
                new SqlParameter("@MachineCode", MachineCode)};

                DataTable dt = Execute.RunSP_DataTable(Connection, "SPGET_MachineByID", paramList);

                    Machine objMachine = new Machine();
                    if (dt.Rows.Count > 0)
                    {

                        objMachine.MachineBranch = Convert.ToString(dt.Rows[0]["MachineBranch"]);
                        objMachine.MachineCapacity = Convert.ToDecimal(dt.Rows[0]["MachineCapacity"]);
                        objMachine.MachineCapacityUnit = objUnit_DL.Get(Convert.ToInt64(dt.Rows[0]["MachineCapacityUnitID"]));
                        objMachine.MachineCode = Convert.ToString(dt.Rows[0]["MachineCode"]);
                        objMachine.MachineDescription = Convert.ToString(dt.Rows[0]["MachineDescription"]);
                        objMachine.MachineHourCost = Convert.ToDecimal(dt.Rows[0]["MachinHourCost"]);
                        objMachine.MachineName = Convert.ToString(dt.Rows[0]["MachineName"]);
                        objMachine.MachinePropertyTag = Convert.ToString(dt.Rows[0]["MachinePropertyTag"]);
                        objMachine.MachinePurchaseDate = Convert.ToDateTime(dt.Rows[0]["MachinePurchaseDate"]);
                        objMachine.MachineSupplier = "LNP";
                        objMachine.MachineTransferDetails = Convert.ToString(dt.Rows[0]["MachineTransferDetails"]);
                        objMachine.MachineType = objMachineType_DL.Get(Convert.ToInt64(dt.Rows[0]["MachineTypeID"]));
                        objMachine.MachineValue = Convert.ToDecimal(dt.Rows[0]["MachineValue"]);
                        objMachine.MachineWastage = Convert.ToDecimal(dt.Rows[0]["MachineWastage"]);

                    }
                    return objMachine;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public System.Data.DataTable GetDataView()
        {
            try
            {

                return Execute.RunSP_DataTable(Connection, "SPGET_Machine");

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }


        public System.Data.DataTable GetDataView_By_Activity(long MainActivityID)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@ActID", MainActivityID)};

                return Execute.RunSP_DataTable(Connection, "SPGET_MachineByActID",paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }

        public string GetNameForCode(String MachineCode)
        {

            try
            {
                SqlParameter[] paramList = new SqlParameter[] {

                new SqlParameter("@MachineCode", MachineCode)};

                return Execute.RunSP_String(Connection, "SPGET_Machine_NameForCode", paramList);

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message, ex);
            }
        }



      


    }
}
