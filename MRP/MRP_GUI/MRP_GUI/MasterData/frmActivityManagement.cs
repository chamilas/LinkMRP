using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;

namespace MRP_GUI
{
    public partial class frmActivityManagement : System.Windows.Forms.Form
    {
        private MainActivity objMainActivity = null;
        private MainActivity_DL objManiActDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        private Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
        private Section_DL objSection_DL = new Section_DL(ConnectionStringClass.GetConnection());
        private Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        private MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        private MachineActivity objMachineActivity = null;
        public frmActivityManagement()
        {
            InitializeComponent();                
        }

        private void frmActivityManagement_Load(object sender, EventArgs e)
        {

            try
            {
                cmbTemplate.DataSource = Enum.GetValues(typeof(MainActivity.LayoutType));
                ucSectionFilter1.Load(ConnectionStringClass.GetConnection());
                bindMachine.DataSource = objMachine_DL.GetDataView();
                cmbMachineList.DataSource = bindMachine;
                bindActivity.DataSource = objManiActDL.Get_Data_View();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (objMainActivity != null)
                {
                    if (ucSectionFilter1.Section != null)
                    {
                        objMainActivity.DepID = ucSectionFilter1.Section.DepID;
                        objMainActivity.SectionID = ucSectionFilter1.Section.SectionID;
                        objMainActivity.Type = (MainActivity.LayoutType)cmbTemplate.SelectedItem;
                        int res = objManiActDL.Update(objMainActivity);
                        if (res > 0)
                        {
                            MessageBox.Show(this,"Successfully saved to database","Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Clear();

                        }

                    }
                    else
                    {
                        MessageBox.Show(this,"Please select a section","Empty Fields",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }

                
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(this,ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            txtActivity.Text = "";
            ucSectionFilter1.Load(ConnectionStringClass.GetConnection());
            bindActivity.DataSource = objManiActDL.Get_Data_View();
            grpMachine.Enabled = false;
            cmbTemplate.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvActivityList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    objMainActivity = objManiActDL.Get(Convert.ToInt64(gvActivityList.Rows[e.RowIndex].Cells["colActID"].Value));
                    if (objMainActivity != null)
                    {
                        txtActivity.Text = objMainActivity.MainActivityTitle;
                        ucSectionFilter1.Set(objSection_DL.Get(objMainActivity.SectionID));
                        bindMachineList.DataSource = objMachineActivity_DL.GetDataByAct(objMainActivity.MainActID);
                        cmbTemplate.SelectedItem = objMainActivity.Type;
                        grpMachine.Enabled = true;
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show(this,"Error occured while loading Main Activity","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void btnMachineAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (objMainActivity != null)
                {


                    if (objMachineActivity == null)
                    {
                        objMachineActivity = new MachineActivity();
                        objMachineActivity.MainActivityID = objMainActivity.MainActID;
                        objMachineActivity.MachineID = (cmbMachineList.SelectedValue.ToString());

                        int res = objMachineActivity_DL.Add(objMachineActivity);
                        if (res > 0)
                        {
                            ClearMachine();
                        }
                    }
                    else
                    {

                        int res = objMachineActivity_DL.Delete(objMachineActivity);
                        if (res > 0)
                        {
                            ClearMachine();
                        }
                    }
                }
            }
            catch (Exception )
            {

                MessageBox.Show(this,"Error occured while saving","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClearMachine_Click(object sender, EventArgs e)
        {
            ClearMachine();
        }

        private void ClearMachine()
        {
            objMachineActivity = null;
            cmbMachineList.SelectedIndex = 0;
            btnMachineAdd.Text = "Add";
            bindMachineList.DataSource = objMachineActivity_DL.GetDataByAct(objMainActivity.MainActID);
        }

        private void gvMachine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    String MachineID = gvMachine.Rows[e.RowIndex].Cells["ColMachineID"].Value.ToString();
                    objMachineActivity = new MachineActivity();
                    objMachineActivity.MachineID = MachineID;
                    objMachineActivity.MainActivityID = objMainActivity.MainActID;
                    cmbMachineList.SelectedValue = MachineID;
                    btnMachineAdd.Text = "Remove";
                }
                catch (Exception)
                {

                    MessageBox.Show(this,"Error occured while loading Machine","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning); ;
                }
            }
        }
    }
}