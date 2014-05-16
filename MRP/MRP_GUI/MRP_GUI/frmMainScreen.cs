using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using DL;
using System.Threading;

namespace MRP_GUI
{
    public partial class frmMainScreen : System.Windows.Forms.Form
    {
        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
        public frmMainScreen(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //this.button1.Image = global::MRP_GUI.Properties.Resources._1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this,"Are you sure you want to Close the Application?","Close Application",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }



        private void button6_Click_2(object sender, EventArgs e)
        {
            //frmRPDBatch objFrm = new frmRPDBatch();
            //objFrm.MdiParent = this.MdiParent;
            //objFrm.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
        int TipType = 0;
        Thread checkThread;
        System.Timers.Timer objTimer = new System.Timers.Timer();
        private void frmMainScreen_Load(object sender, EventArgs e)
        {
            LoadControls(this.Controls);
            lblUserName.Text = CurrentUser.UserEmp.EmployeeName;
            lblEmpName.Text = CurrentUser.UserEmp.EmployeeID;
            lblRole.Text = CurrentUser.UserEmp.EmployeeRole.RoleTitle;



            //-- Notification Thread
            //checkThread = new Thread(this.CheckMRApprove);
            //checkThread.Start();
            ////while (!checkThread.IsAlive) ;
            //Thread.Sleep(1);

            //checkThread.Abort();
            //checkThread.Join();
            
            backgroundWorker1.RunWorkerAsync();

        }

        public void CheckMRApprove()
        {
            try
            {

                objTimer.Elapsed += new System.Timers.ElapsedEventHandler(objTimer_Elapsed);
                objTimer.Interval = 30000;
                objTimer.Enabled = true;
                GC.KeepAlive(objTimer);
            }
            catch (Exception ex)
            {


            }


        }

        void objTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

        }



        String TipText = "";
        void Work()
        {
            
           
            MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
            Stock_DL objStockDL = new Stock_DL(ConnectionStringClass.GetConnection());
            try
            {
                int count = objMRDL.GET_Approval_Count(CurrentUser.EmployeeID, MR.Status.Initial);
                if (count > 0)
                {
                    TipType = 1;
                    TipText = TipText + "-- " + count + " Material Requisition(s) for approval.\n";
                    
                }

                int count1 = objMRDL.GET_Issue_Count(CurrentUser.EmployeeID, MR.Status.Approved);
                if (count1 > 0)
                {
                    TipType = 2;
                    TipText = TipText + "-- "+count1 + " Material Requisition(s) for Item Issue.\n";
                   

                }

                int count2 = objStockDL.Get_ReorderLevel_Below_Count(CurrentUser.EmployeeID);
                if (count2 > 0)
                {
                    TipType = 3;
                    TipText = TipText + "-- Quantity of " + count2 + " item(s) in the store low than reorder level.\n";
                   

                }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                objMRDL = null;
            }
        }


        private void LoadControls(Control.ControlCollection Items)
        {
            UserAccessRights_DL objUserAccessRightsDL = new UserAccessRights_DL(ConnectionStringClass.GetConnection());

            try
            {


                foreach (Control var in Items)
                {
                    if (var.GetType().Equals(typeof(Button)))
                    {
                        if ((!var.Name.Equals("btnExit")) && (!var.Name.Equals("btnClose")))
                        {
                            UserAccessRights obj = objUserAccessRightsDL.Get(var.Name, CurrentUser.UserRoleID);
                            if (obj != null)
                            {
                                if (obj.Permission == "Active")
                                {
                                    var.Visible = true;
                                }
                                else
                                {
                                    var.Visible = false;
                                }
                            }
                        }
                    }
                    if (var != null)
                    {
                        LoadControls(var.Controls);
                    }
                
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmMaterialRegistration objFrm = new frmMaterialRegistration();
            ShowForm(objFrm);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmFinishedProductRegistration objFrm = new frmFinishedProductRegistration();
            this.ShowForm(objFrm);
        }

        

        private void button18_Click(object sender, EventArgs e)
        {
            frmMachineRegistration objFrm = new frmMachineRegistration();
            this.ShowForm(objFrm);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            frmFormula objFrm = new frmFormula(CurrentUser);
            this.ShowForm(objFrm);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //frmGRNApproval objFrm = new frmGRNApproval(CurrentUser);
           // this.ShowForm(objFrm);
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            frmMTNote objFrm = new frmMTNote(CurrentUser);
            this.ShowForm(objFrm);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmMTNApproval objFrm = new frmMTNApproval(CurrentUser);
            this.ShowForm(objFrm);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmMRApproval objFrm = new frmMRApproval(CurrentUser);
            this.ShowForm(objFrm);
        }

       
        private void button23_Click(object sender, EventArgs e)
        {
            frmMRReceive_toBatch objFrm = new frmMRReceive_toBatch(CurrentUser);
            this.ShowForm(objFrm);
        }

        

        private void button28_Click(object sender, EventArgs e)
        {
            frmLogin objFrm = new frmLogin();
            objFrm.Show();
            this.MdiParent.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmChangePassword objFrm = new frmChangePassword(CurrentUser,1);
            this.ShowForm(objFrm);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Work();

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            richTextBox1.Text = TipText;
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            richTextBox1.Text = TipText;
        }

        private void ShowForm(System.Windows.Forms.Form obj)
        {
            bool IsFormOpen = false;
            System.Windows.Forms.Form[] mdi = this.MdiParent.MdiChildren;
            foreach (System.Windows.Forms.Form var in mdi)
            {
                if (var.Name.Equals(obj.Name))
                {
                    IsFormOpen = true;
                    var.Activate();
                }
            }
            if (!IsFormOpen)
            {
                obj.MdiParent = this.MdiParent;
                obj.Show();
            }
        }


    }
}