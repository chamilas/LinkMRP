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
using MRP_GUI.Sales;
using MRP_GUI.Report;


namespace MRP_GUI
{
    public partial class MRP_Main : System.Windows.Forms.Form
    {
        private int childFormNumber = 0;
        Thread checkThread;
        System.Timers.Timer objTimer = new System.Timers.Timer();
        bool IsLogOff = false;
        bool IsNotificaton = false;
        int TipType = 0;
        String TipText = "";
        private User _objCurrentUser;
        
        UserAccessRights_DL objUserAccessDL = new UserAccessRights_DL(ConnectionStringClass.GetConnection());
        User_DL objUser_DL = new User_DL(ConnectionStringClass.GetConnection());
        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }
	
        public MRP_Main()
        { 
            User_DL objUserDL = new User_DL(ConnectionStringClass.GetConnection());
            try
            {
                this.CurrentUser = objUserDL.Get(2);
            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Error in DB Connection","DB Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            InitializeComponent();
        }

        public MRP_Main(User ObjUser)
        {
            this.CurrentUser = ObjUser;
        
            InitializeComponent();
        }

        private void ShowForm(System.Windows.Forms.Form obj)
        {
            bool IsFormOpen = false;
            System.Windows.Forms.Form[] mdi = this.MdiChildren;
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
                obj.MdiParent = this;
                obj.Show();
            }
        }

        private void MenuItemSettings(ToolStripMenuItem item,UserAccessRights obj)
        {

            if (item.Name == obj.MenuID)
            {
                if (obj.Permission.Equals("Active"))
                {
                    item.Enabled = true;
                }
                else
                {
                    item.Enabled = false;
                } 
            }
            
            foreach (ToolStripItem subitem in item.DropDownItems)
            {
                if (subitem is ToolStripMenuItem)
                {
                    MenuItemSettings((ToolStripMenuItem)subitem,obj);
                }
            }
        }


        private void MenuItemSettings_DiableAll(ToolStripMenuItem item)
        {
            
                    item.Enabled = false;
              
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    CurrentUser.Online = false;
                    objUser_DL.Update_OnlineState(CurrentUser);
                    Application.Exit();
                    break;
                   
            }
        }


        private void MRP_Main_Load(object sender, EventArgs e)
        {
            frmMainScreen objFrm = new frmMainScreen(CurrentUser);
            objFrm.MdiParent = this;

            Rectangle mdiClientArea = Rectangle.Empty;
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                    mdiClientArea = c.ClientRectangle;
            }
            objFrm.Bounds = mdiClientArea;
            objFrm.Show();

            //-- Notification Thread

                checkThread = new Thread(this.CheckMRApprove);
                checkThread.Start();
                //while (!checkThread.IsAlive) ;
                Thread.Sleep(1);

                checkThread.Abort();
                checkThread.Join();
  

            toolStripStatusLabel1.Text = CurrentUser.EmpName;

            UserAccessRightsCollec objCollec = new UserAccessRightsCollec();
            objCollec = objUserAccessDL.Get(CurrentUser.UserRoleID);

            if (objCollec.Count > 0)
            {
                foreach (UserAccessRights obj in objCollec)
                {
                    foreach (ToolStripMenuItem mitem in menuStrip.Items)
                    {

                        MenuItemSettings(mitem, obj);

                    }
                }
            }
            else
            {
                foreach (ToolStripMenuItem mitem in menuStrip.Items)
                {
                    MenuItemSettings_DiableAll(mitem);
                }
            }

        }


        //-------------------------------------------------------------------------------

        public void CheckMRApprove()
        {
           
            objTimer.Elapsed += new System.Timers.ElapsedEventHandler(objTimer_Elapsed);
            objTimer.Interval = 30000;
            objTimer.Enabled = true;
            GC.KeepAlive(objTimer);

           
        }

       

        void objTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
            Stock_DL objStockDL = new Stock_DL(ConnectionStringClass.GetConnection());
            try
            {
               // int count = objMRDL.GET_Approval_Count(CurrentUser.EmployeeID, MR.Status.Initial);
               // if (count > 0)
               // {
               //     TipType = 1;
               //     TipText = TipText + "*You have received " + count + " Material Requisition(s) for approval.\n";
               //     niMain.ShowBalloonTip(15, "Manufacturing Resourse Planning Software", TipText, ToolTipIcon.Info);
               // }

               //int count1 = objMRDL.GET_Issue_Count(CurrentUser.EmployeeID, MR.Status.Approved);
               // if (count1 > 0)
               // {
               //     TipType = 2;
               //     TipText = TipText + "*You have received " + count1 + " Material Requisition(s) for Item Issue.\n";
               //     niMain.ShowBalloonTip(15, "Manufacturing Resourse Planning Software", TipText, ToolTipIcon.Info);

               // }

               // int count2 = objStockDL.Get_ReorderLevel_Below_Count(CurrentUser.EmployeeID);
               // if (count2 > 0)
               // {
               //     TipType = 3;
               //     TipText = TipText + "*Quantity of " + count2 + " item(s) in the store low than reorder level.\n";
               //     niMain.ShowBalloonTip(15, "Manufacturing Resourse Planning Software", TipText, ToolTipIcon.Info);

               // }
            }
            catch (Exception ex)
            {


            }
            finally
            {
                objMRDL = null;
            }
        }

        //-------------------------------------------------------------------------------


        private void ShowNewForm(object sender, EventArgs e)
        {
            // Create a new instance of the child form.
            System.Windows.Forms.Form childForm = new System.Windows.Forms.Form();
            // Make it a child of this MDI form before showing it.
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {

        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
                // TODO: Add code here to save the current contents of the form to a file.
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to Close the Application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                
                Application.Exit();
            }

        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard to insert the selected text or images into the clipboard
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Use System.Windows.Forms.Clipboard.GetText() or System.Windows.Forms.GetData to retrieve information from the clipboard.
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        }

        private void productCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void asfasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterialRegistration objFrm = new frmMaterialRegistration();
            this.ShowForm(objFrm);
        }



        private void materialCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 0;
            objFrm.Show();
        }

        private void productTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 1;
            objFrm.Show();
        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            ShowForm(objFrm);

        }

        private void itemStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 2;
            objFrm.Show();
        }

        private void packingTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 3;
            objFrm.Show();
        }

        private void shiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 4;
            objFrm.Show();
        }

        private void DepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemMgt objFrm = new frmSystemMgt();
            objFrm.tabControl1.SelectedIndex = 0;
            objFrm.MdiParent = this;
            objFrm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemMgt objFrm = new frmSystemMgt();
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 1;
            objFrm.Show();
        }

        private void tGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    

        private void tMTNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gRNApprovalsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materialRequisitionNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void materialRequisitionApprovelsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void materialIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRIssue objFrm = new frmMRIssue(CurrentUser);
            ShowForm(objFrm);
        }

        private void materialReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pOCertifyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pODiplayPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
 /*           frmInvoice objFrm = new frmInvoice();
            objFrm.MdiParent = this;
            objFrm.Show();*/
        }

        private void dispatchNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mTNToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMTN objFrm = new frmMTN();
            ShowForm(objFrm);
        }

        private void mTNApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNApproval objFrm = new frmMTNApproval();
            ShowForm(objFrm);
        }

        private void productReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void monthlySalesForecastToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesForecastManaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void resourseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmRequrement objFrm = new frmRequrement();
            //objFrm.MdiParent = this;
            //objFrm.Show(); 
        }




        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAbout objFrm = new frmAbout();
            
            //objFrm.Show();
        }

        private void loginAsDifferentUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin objFrm = new frmLogin();
            IsLogOff = true;
            objFrm.Show();
            this.Close();
        }

        private void MRP_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsLogOff)
            {
                Application.Exit();
            }
            

        }

        private void standardBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStandardBatch objFrm = new frmStandardBatch(CurrentUser);
            ShowForm(objFrm);
        }

        private void batchManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void frmBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmProductionPlanningToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmProductionScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void frmBatchApprovingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void batchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void approveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void amendToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productionPlanForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmProductionPlanning objFrm = new frmProductionPlanning(CurrentUser);
            //ShowForm(objFrm);
        }

        private void salesForecastToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmSalesForecast objFrm = new frmSalesForecast(CurrentUser);
            //ShowForm(objFrm);
        }

        private void plannedToolStripMenuItem_Click(object sender, EventArgs e)
        {
  
        }

        private void opeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dispatchNoteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        }

        private void mTNToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmMTN objFrm = new frmMTN();
            ShowForm(objFrm);
        }

        private void mTNApprovalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMTNApproval objFrm = new frmMTNApproval();
            ShowForm(objFrm);
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBasicProductRegistration objFrm = new frmBasicProductRegistration();
            ShowForm(objFrm);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSupplier objFrm = new frmSupplier();
            this.ShowForm(objFrm);
        }

        private void approveAmendedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAmendSalesForecast objFrm = new frmAmendSalesForecast();
            //ShowForm(objFrm);
        }

        private void formulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFormula objFrm = new frmFormula(CurrentUser);
            ShowForm(objFrm);
        }

        private void materialRequirementForSalesForecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void batchPlanninToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void machineTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMachineTransfer objFrm = new frmMachineTransfer();
            //ShowForm(objFrm); 
        }

        private void machineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMachineRegistration objFrm = new frmMachineRegistration();
            this.ShowForm(objFrm);
        }

        private void machineRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void batchEditingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void issueMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRpdMaterialIssue objFrm = new frmRpdMaterialIssue();
            //ShowForm(objFrm); 
        }

        private void monthlyMaterialRequirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ////frmRpdReq objFrm = new frmRpdReq();
            //ReportForm.RPD.frmRPDMaterialReq objFrm = new MRP_GUI.ReportForm.RPD.frmRPDMaterialReq();
            //ShowForm(objFrm);
        }

        private void requestingMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRequestMaterials objFrm = new frmRequestMaterials(CurrentUser);
            //ShowForm(objFrm);
        }

        private void viewMaterialRequitionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmViewBatchMR objFrm = new frmViewBatchMR();
            //ShowForm(objFrm);
        }

        private void viewMaterialRequistionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmViewMR objFrm = new frmViewMR(CurrentUser);
            //ShowForm(objFrm);
        }

        private void creatingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmBatchPlanning objFrm = new frmBatchPlanning(CurrentUser);
            //ShowForm(objFrm);
        }


        private void approvingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmBatchApproving objFrm = new frmBatchApproving(CurrentUser);
            //ShowForm(objFrm); 
        }

        private void tempGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmTGRNCategarization objFrm = new frmTGRNCategarization(CurrentUser);
            //ShowForm(objFrm);
        }

        private void tGRNToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void materialReceivedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmTempMaterialGRN objFrm = new frmTempMaterialGRN();
            //ShowForm(objFrm);
        }

        private void materialReceivedToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //frmPRPDRecived objFrm = new frmPRPDRecived();
            //ShowForm(objFrm);
        }

        private void materialTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmPR objFrm = new frmPR(this.CurrentUser);
            //ShowForm(objFrm);
        }

        private void sPRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPR objFrm = new frmPR(this.CurrentUser, "SPR");
            //SPR.frmSPRCreate objFrm = new MRP_GUI.SPR.frmSPRCreate(CurrentUser);
            //ShowForm(objFrm);
        }

        private void discardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPOManage objFrm = new frmPOManage();
            //ShowForm(objFrm);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPODisplay objFrm = new frmPODisplay();
            //ShowForm(objFrm);
        }

        private void approveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //frmPOManage objFrm = new frmPOManage(CurrentUser);
            //ShowForm(objFrm);
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void approveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmPRApproval objFrm = new frmPRApproval(CurrentUser);
            //ShowForm(objFrm);

        }

        private void gRNToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gRNREWORKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void priceNegotiationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPurchasingPrice objFrm = new frmPurchasingPrice();
            //ShowForm(objFrm);
        }

        private void invoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //frmInvoice objFrm = new frmInvoice(CurrentUser);
            //ShowForm(objFrm);
        }

        private void deliverNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmDeliverNote objFrm = new frmDeliverNote(CurrentUser);
            //ShowForm(objFrm);
        }

        private void reworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPRPDRework objFrm = new frmPRPDRework();
            //ShowForm(objFrm);
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmRPDBatchCreate objFrm = new frmRPDBatchCreate(CurrentUser);
            //ShowForm(objFrm);
        }

        private void productionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmRPDBatch objFrm = new frmRPDBatch();
            //ShowForm(objFrm);
        }

        private void pfToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void supplierSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPOCreate objFrm = new frmPOCreate(CurrentUser);
            //ShowForm(objFrm);
        }

        private void finalizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPOFinalize objFrm = new frmPOFinalize(CurrentUser);
            //ShowForm(objFrm);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPOEdit objFrm = new frmPOEdit(this.CurrentUser);
            //ShowForm(objFrm);
        }

        private void productReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMTN objFrm = new frmMTN(CurrentUser);
            ShowForm(objFrm);
        }

        private void approveToolStripMenuItem2_Click(object sender, EventArgs e)
        {
    
        }

        private void mTNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmFinishProductTransfer objFrm = new frmFinishProductTransfer();
            //ShowForm(objFrm);
        }

     

        private void reworkedToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productsReceivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceive objFrm = new frmMTNReceive();
            ShowForm(objFrm);
        }

        private void productReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transfersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeRegistration objFrm = new frmEmployeeRegistration();
            ShowForm(objFrm);
        }

        private void productReworkBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmCAP objFrm = new frmCAP(CurrentUser);
            //ShowForm(objFrm);
        }

        private void batchCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReworkBatch objFrm = new frmReworkBatch(CurrentUser);
            //ShowForm(objFrm);
        }

        private void createToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //frmRepackBatch objFrm = new frmRepackBatch(CurrentUser);
            //ShowForm(objFrm);
        }

        private void reworkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmReworkBatchProduction objFrm = new frmReworkBatchProduction(CurrentUser);
            //ShowForm(objFrm);
        }

        private void generalProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
                        //frmBatch objFrm = new frmBatch(CurrentUser);
                        //ShowForm(objFrm);
        }

        private void productReturnToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void materialToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void primaryPreparationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPRPDBatchCreat objFrm = new frmPRPDBatchCreat(CurrentUser);
            //ShowForm(objFrm);
        }

        private void batchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //frmPrimaryPreparationBatch objFrm = new frmPrimaryPreparationBatch(CurrentUser);
            //ShowForm(objFrm);
        }

        private void machineCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 8;
            objFrm.Show();
        }

        private void supplierCatergoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 8;
            objFrm.Show();
        }

        private void workingShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 7;
            objFrm.Show();
        }

        private void packingTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 6;
            objFrm.Show();
        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 5;
            objFrm.Show();
        }

        private void discardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockManagment objFrm = new frmStockManagment(CurrentUser);
            ShowForm(objFrm);
        }

        private void employeeRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.MdiParent = this;
            objFrm.tabControl1.SelectedIndex = 9;
            objFrm.Show();
        }

        private void storesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemMgt objFrm = new frmSystemMgt();
            objFrm.tabControl1.SelectedIndex = 2;
            objFrm.MdiParent = this;
            objFrm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMTNReceiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }


        private void approveToolStripMenuItem3_Click(object sender, EventArgs e)
        {
         
        }

        private void requestToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNote objFrm = new frmMTNote(CurrentUser);
            ShowForm(objFrm); ;
        }

        private void productReturnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmTGRNProduct objFrm = new frmTGRNProduct(CurrentUser);
            //ShowForm(objFrm);
        }

        private void materialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmTgrn objFrm = new frmTgrn(CurrentUser);
            //ShowForm(objFrm);
        }

        private void gRNApprovalsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGRNApproval objFrm = new frmGRNApproval(CurrentUser,"RPD_Main");
            ShowForm(objFrm);
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void createToolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmChangePassword objFrm = new frmChangePassword(CurrentUser,1);
            objFrm.Show();

        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPRManage objFrm = new frmPRManage(CurrentUser);
            //ShowForm(objFrm);
        }

        private void fffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainScreen objFrm = new frmMainScreen(CurrentUser);
            objFrm.MdiParent = this;

            Rectangle mdiClientArea = Rectangle.Empty;
            foreach (Control c in this.Controls)
            {
                if (c is MdiClient)
                    mdiClientArea = c.ClientRectangle;
            }
            objFrm.Bounds = mdiClientArea;
            objFrm.Show();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReworkStart objFrm = new frmReworkStart(CurrentUser);
            //ShowForm(objFrm);
        }

        private void startToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmRepackBatchStart objFrm = new frmRepackBatchStart(CurrentUser);
            //ShowForm(objFrm);
        }

        private void contextMenuExit_Click(object sender, EventArgs e)
        {
            
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmRPDBatchEditApprove objFrm = new frmRPDBatchEditApprove(CurrentUser);
            //ShowForm(objFrm);

        }

        private void activityMachineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRPDActivityMachineAssign objFrm = new frmRPDActivityMachineAssign(CurrentUser);
            //ShowForm(objFrm);
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void baToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm.frmRptBasicProductsAll objFrm = new MRP_GUI.ReportForm.frmRptBasicProductsAll();
            //ShowForm(objFrm);
        }

        private void finishGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm.frmRptFinishProductAll objFrm = new MRP_GUI.ReportForm.frmRptFinishProductAll();
            //ShowForm(objFrm);
        }

        private void MRP_Main_FormClosed(object sender, FormClosedEventArgs e)
        {



        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //frmProductionPlanning objFrm = new frmProductionPlanning(CurrentUser);
            //ShowForm(objFrm);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
 
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            //frmBatch objFrm = new frmBatch(CurrentUser);
            //ShowForm(objFrm);
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            //frmRequestMaterials objFrm = new frmRequestMaterials(CurrentUser);
            //ShowForm(objFrm);
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);

        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);

        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);

        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            //frmAbout objFrm = new frmAbout();

            //objFrm.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(this, "Are you sure you want to Close the Application?", "Close Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmAbout objFrm = new frmAbout();

            //objFrm.Show();
        }


        private void stockDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm.frmRptStock objFrm = new MRP_GUI.ReportForm.frmRptStock();
            //ShowForm(objFrm);
        }

        private void lowStoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm.frmRptStockBelow objFrm = new MRP_GUI.ReportForm.frmRptStockBelow(CurrentUser.EmployeeID);
            //ShowForm(objFrm);
        }

        private void niMain_BalloonTipClicked(object sender, EventArgs e)
        {
           /* if (TipType == 3)
            {
                ReportForm.frmRptStockBelow objFrm = new MRP_GUI.ReportForm.frmRptStockBelow(CurrentUser.EmployeeID);
                objFrm.MdiParent = this;
                objFrm.Show();
            }*/
            TipText = "";
        }

        private void salesForecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSalesForecast objFrm = new frmSalesForecast(CurrentUser);
            //ShowForm(objFrm);
        }

        private void apprToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSalesForecastApproval objFrm = new frmSalesForecastApproval(CurrentUser);
            //ShowForm(objFrm);
        }

        private void productReturnsGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmSalesReturnGRN objFrm = new frmSalesReturnGRN(CurrentUser);
            //ShowForm(objFrm);
        }

        private void userRightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRoleAssign objFrm = new frmUserRoleAssign(menuStrip);
            ShowForm(objFrm);
        }

        private void finalizedInvoiceGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPaymentGRN objFrm = new frmPaymentGRN(CurrentUser);
            //ShowForm(objFrm);
        }

        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //frmPODisplay objFrm = new frmPODisplay();
            //ShowForm(objFrm);
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            frmPRPDBatchCreatePreperation objForm = new frmPRPDBatchCreatePreperation(CurrentUser);
            ShowForm(objForm);
        }

        private void pRPDBatchEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPRPDBatchApprove objFrm = new frmPRPDBatchApprove(CurrentUser);
            //ShowForm(objFrm);
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            frmPRPDBatchFile objFrm = new frmPRPDBatchFile(CurrentUser);
            ShowForm(objFrm);
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            frmPRPDBatchTransfer_Preperation objForm = new frmPRPDBatchTransfer_Preperation(CurrentUser);
            ShowForm(objForm);

        }

        private void gRNRPDBatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRPDBatchGRN objFrm = new frmRPDBatchGRN(CurrentUser);
            //ShowForm(objFrm);
        }

        private void materialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm.frmRptMaterialList objFrm = new MRP_GUI.ReportForm.frmRptMaterialList();
            //ShowForm(objFrm);
        }

        private void costRatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCosting objFrm = new frmCosting(CurrentUser);
            ShowForm(objFrm);
        }

        private void activityManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActivityManagement objFrm = new frmActivityManagement();
            ShowForm(objFrm);
        }

        private void suppliersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ReportForm.frmRptSuppliers objFrm = new MRP_GUI.ReportForm.frmRptSuppliers();
            //ShowForm(objFrm);
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ReportForm.frmRptEmployees objFrm = new MRP_GUI.ReportForm.frmRptEmployees();
            //ShowForm(objFrm);
        }

        private void addNewStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmAddStock obj = new frmAddStock(CurrentUser);
            //ShowForm(obj);
        }

        private void stockBalancingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRemoveStock obj = new frmRemoveStock(CurrentUser);
            ShowForm(obj);
        }

        private void costingBreakdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MRP_GUI.ReportForm.frmPRPDCosting obj = new MRP_GUI.ReportForm.frmPRPDCosting();
            //ShowForm(obj);
        }

        private void costingBreakdownToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MRP_GUI.ReportForm.frmRptRPDCost obj = new MRP_GUI.ReportForm.frmRptRPDCost();
            //ShowForm(obj);
        }

        private void primaryPreparationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
          
        }

        private void reworkToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //frmPRPDBatchCreateRework objForm = new frmPRPDBatchCreateRework(CurrentUser);
            //ShowForm(objForm);
        }

        private void gRNToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
         
        }

        private void testResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPRPDQTR objFrm = new frmPRPDQTR(CurrentUser);
            //ShowForm(objFrm);
        }

        private void manageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMRManagement objFrm = new frmMRManagement(CurrentUser);
            ShowForm(objFrm);
        }

        private void manageToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemMgt objFrm = new frmSystemMgt();
            objFrm.tabControl1.SelectedIndex = 3;
            objFrm.MdiParent = this;
            objFrm.Show();
        }

        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemMgt objFrm = new frmSystemMgt();
            objFrm.tabControl1.SelectedIndex = 4;
            objFrm.MdiParent = this;
            objFrm.Show();
        }

        private void materialMainCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.tabControl1.SelectedIndex = 0;
            objFrm.MdiParent = this;
            objFrm.Show();
        }

        private void materialSubCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatTypeUnit objFrm = new frmCatTypeUnit(CurrentUser);
            objFrm.tabControl1.SelectedIndex = 2;
            objFrm.MdiParent = this;
            objFrm.Show();
        }

        private void initiateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRPDBatchInitialize objRPD = new frmRPDBatchInitialize(CurrentUser);
            ShowForm(objRPD);
        }

        private void pRPDReworkCAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPRPDBatchCreateCAP objForm = new frmPRPDBatchCreateCAP(CurrentUser);
            //ShowForm(objForm);
        }

        private void reworkToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //frmPRPDBatchTransfer_Rework objForm = new frmPRPDBatchTransfer_Rework(CurrentUser);
            //ShowForm(objForm);

        }

        private void primaryPreperationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void pRPDReowrkCAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPRPDBatchTransferCAP objForm = new frmPRPDBatchTransferCAP(CurrentUser);
            //ShowForm(objForm);
        }

        private void reworkToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //frmPRPDReworkBatchManagement objForm = new frmPRPDReworkBatchManagement(CurrentUser);
            //ShowForm(objForm);
        }

        private void pRPDReworkCAPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmPRPDCAPBatchManagement objForm = new frmPRPDCAPBatchManagement(CurrentUser);
            //ShowForm(objForm);

        }

        private void productionNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPD.frmRPDProduction objFrm = new MRP_GUI.RPD.frmRPDProduction(CurrentUser);
            ShowForm(objFrm);
        }

        private void assignCodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SPR.frmSPRAssignCode objFrm = new MRP_GUI.SPR.frmSPRAssignCode(CurrentUser);
            //ShowForm(objFrm);
        }

        private void qCViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmQCReport objFrm = new frmQCReport(CurrentUser);
            ShowForm(objFrm);
        }

        private void manageToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            RPD.frmRPDBatchManage objFrm = new MRP_GUI.RPD.frmRPDBatchManage(CurrentUser);
            ShowForm(objFrm);
        }

        private void extractionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ExtractionDetails.frmExtractionDetails objFrm = new MRP_GUI.ExtractionDetails.frmExtractionDetails(CurrentUser);
            //ShowForm(objFrm);
        }

        private void primaryPreperationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void pRPDCAPRaiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PRPDCAP.frmLABCaps objfrm = new MRP_GUI.PRPDCAP.frmLABCaps(CurrentUser);
            //ShowForm(objfrm);
        }

        private void pRPDCAPManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void pRPDCAPManageToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void disposeApproveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PRPDCAP.frmDisposeApproval objFrm = new MRP_GUI.PRPDCAP.frmDisposeApproval(CurrentUser);
            //ShowForm(objFrm);
        }

        private void approvalLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MRP_GUI.Registration.frmApporvalLimits objFrm = new MRP_GUI.Registration.frmApporvalLimits(CurrentUser);
            //ShowForm(objFrm);
        }

        private void manageToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmGRNManagement objFrm = new frmGRNManagement(CurrentUser);
            ShowForm(objFrm);
        }

        private void monthlyTemporaryPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Production.frmTemporaryBatchPlanning objFrm = new MRP_GUI.Production.frmTemporaryBatchPlanning(CurrentUser);
            //ShowForm(objFrm);

        }

        private void materialRequirementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sPRToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmSPO objFrm = new frmSPO(CurrentUser);
            //ShowForm(objFrm);
        }

        private void materialRequirementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //ReportForm.PRPD.frmPRPDReq objFrm = new MRP_GUI.ReportForm.PRPD.frmPRPDReq();
            //ShowForm(objFrm);
        }

        private void invoiceManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmManageInvoice objFrm = new frmManageInvoice(CurrentUser);
            //ShowForm(objFrm);
        }

        private void finalizePOTallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPOTally objFrm = new frmPOTally(CurrentUser);
            //ShowForm(objFrm);
        }

        private void approveChangedPurchaseOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPOChangedApprove objFrm = new frmPOChangedApprove(CurrentUser);
            //ShowForm(objFrm);
        }

        private void transferToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmTGRNTransfer objFrm = new frmTGRNTransfer(CurrentUser);
            //ShowForm(objFrm);
        }

        private void nEWSTDBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void batchFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchList objForm = new frmBatchList(CurrentUser);
            ShowForm(objForm);
        }

        private void batchFileManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Production.BatchFile.frmBatchList objFrm = new MRP_GUI.Production.BatchFile.frmBatchList(CurrentUser);
            //ShowForm(objFrm);
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SubStockManage.frmSubStockReceive objFrm = new MRP_GUI.SubStockManage.frmSubStockReceive(CurrentUser);
            //ShowForm(objFrm);
        }

        private void issueItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SubStockManage.frmSubStockIssue objFrm = new MRP_GUI.SubStockManage.frmSubStockIssue(CurrentUser);
            //ShowForm(objFrm);
        }

        private void packingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void subContractorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration.frmSubContractor objFrm = new MRP_GUI.Registration.frmSubContractor(CurrentUser);
            ShowForm(objFrm);
        }

        private void cAPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmCAP objFrm = new frmCAP(CurrentUser);
            //ShowForm(objFrm);
        }

        private void batchCreateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmReworkBatch objFrm = new frmReworkBatch(CurrentUser);
            //ShowForm(objFrm);
        }

        private void batchStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReworkStart objFrm = new frmReworkStart(CurrentUser);
            //ShowForm(objFrm);
        }

        private void newBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRepackBatch objFrm = new frmRepackBatch(CurrentUser);
            //ShowForm(objFrm);
        }

        private void startBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmRepackBatchStart objFrm = new frmRepackBatchStart(CurrentUser);
            //ShowForm(objFrm);
        }

        private void createBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void approveBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void materialRequirementToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //ReportForm.Production.frmMaterialRequirement objFrm = new MRP_GUI.ReportForm.Production.frmMaterialRequirement();
            //ShowForm(objFrm);
        }

        private void reworkRepackBatchFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmReworkBatchProduction objFrm = new frmReworkBatchProduction(CurrentUser);
            //ShowForm(objFrm);
        }

        private void packingBatchQAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQCReport_Packing objFrm = new frmQCReport_Packing(CurrentUser);
            ShowForm(objFrm);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PRPD.frmInstructedPRPDBatches objFrm = new MRP_GUI.PRPD.frmInstructedPRPDBatches(CurrentUser);
            //ShowForm(objFrm);
        }

        private void weighingToolStripMenuItem_Click(object sender, EventArgs e)
        {
          

        }

        private void weighingCheckingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void detailListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRPD.frmPRPDBatchList objFrm = new MRP_GUI.PRPD.frmPRPDBatchList(CurrentUser);
            ShowForm(objFrm);
        }

        private void costApproveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PRPD.frmPRPDCostingApprove objFrm = new MRP_GUI.PRPD.frmPRPDCostingApprove(CurrentUser);
            ShowForm(objFrm);
        }

        private void costApproveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MRP_GUI.RPD.frmRPDCostApprove objFrm = new MRP_GUI.RPD.frmRPDCostApprove(CurrentUser);
            ShowForm(objFrm);
        }

        private void viewFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RPD.frmRPDBatchList objFrm = new MRP_GUI.RPD.frmRPDBatchList(CurrentUser);
            ShowForm(objFrm);
        }

        private void bulkReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MRP_GUI.ReportForm.frmRptGRNBulkPrint objFrm = new  MRP_GUI.ReportForm.frmRptGRNBulkPrint(CurrentUser);
            //ShowForm(objFrm);
        }

        private void gRNApprovalsPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmGRNPayment_Raw_Approval objFrm = new frmGRNPayment_Raw_Approval(CurrentUser);
            //ShowForm(objFrm);
        }

        private void paymentGRNPackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frmGRNPayment_Packing objFrm = new frmGRNPayment_Packing(CurrentUser);
           // ShowForm(objFrm);
        }

        private void receiveGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void binCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void batchMRToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void receivedToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void packingToStockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void itemToStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRT_Batch objFrm = new frmMRT_Batch(CurrentUser);
            ShowForm(objFrm);
        }

        private void cDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRT_Batch_Partial objFrm = new frmMRT_Batch_Partial(CurrentUser);
            ShowForm(objFrm);
        }

        private void approveToolStripMenuItem4_Click(object sender, EventArgs e)
        {
           
        }

        private void receiveToBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void receiveToStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void directGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmGRNPayment_Raw objFrm = new frmGRNPayment_Raw(CurrentUser);
            //ShowForm(objFrm);
        }

        private void paymentGRNApprovalPackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmGRNPayment_Packing_Approval objFrm = new frmGRNPayment_Packing_Approval(CurrentUser);
            //ShowForm(objFrm);
        }

        private void paymentGRNLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  frmGRNP_RPD objFrm = new frmGRNP_RPD(CurrentUser);
          //  ShowForm(objFrm);
        }

        private void paymentGRNApprovalPackingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //frmGRNPayment_Lab_Approval objFrm = new frmGRNPayment_Lab_Approval(CurrentUser);
            //ShowForm(objFrm);
        }

   

        private void packingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBinCards_Packing objForm = new frmBinCards_Packing(CurrentUser, "Packing");
            ShowForm(objForm);
        }

        private void rawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinCards_Raw objForm = new frmBinCards_Raw(CurrentUser, "RM_Main");
            ShowForm(objForm);
        }

        private void gRNRPDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGRN_Direct objForm = new frmGRN_Direct(CurrentUser,"RPD_Main","Raw");
            ShowForm(objForm);
        }

        private void rPDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBinCards_Raw objForm = new frmBinCards_Raw(CurrentUser, "RPD_Main");
            ShowForm(objForm);
        }

        private void labToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBinCards_Raw objForm = new frmBinCards_Raw(CurrentUser, "Lab");
            ShowForm(objForm);
        }

        private void processedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinCards_Raw objForm = new frmBinCards_Raw(CurrentUser, "RM_Processed");
            ShowForm(objForm);
        }

        private void batchFinishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchFinish objForm = new frmBatchFinish(CurrentUser);
            ShowForm(objForm);
        }

        private void tGRNToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void rawToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTGRN objForm = new frmTGRN(CurrentUser,"Raw");
            ShowForm(objForm);
        }

        private void packingToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTGRN objForm = new frmTGRN(CurrentUser,"Packing");
            ShowForm(objForm);
        }

        private void labToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTGRN objForm = new frmTGRN(CurrentUser,"Lab");
            ShowForm(objForm);
        }

        private void gRNRawToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rawToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGRN objForm = new frmGRN(CurrentUser,"RM_Main","Raw");
            ShowForm(objForm);
        }

        private void packingToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmGRN objForm = new frmGRN(CurrentUser, "Packing", "Packing");
            ShowForm(objForm);
        }

        private void labToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmGRN objForm = new frmGRN(CurrentUser, "Lab", "Lab");
            ShowForm(objForm);
        }

        private void rawToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmGRNApproval objFrm = new frmGRNApproval(CurrentUser,"RM_Main");
            ShowForm(objFrm);
        }

        private void packingToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmGRNApproval objFrm = new frmGRNApproval(CurrentUser, "Packing");
            ShowForm(objFrm);
        }

        private void labToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmGRNApproval objFrm = new frmGRNApproval(CurrentUser, "Lab_01");
            ShowForm(objFrm);
        }

        private void batchSendQCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchSendQC objFrm = new frmBatchSendQC(CurrentUser);
            ShowForm(objFrm);
        }

        private void batchSendPackingQCToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void batchTransferToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rPDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGRNApproval objFrm = new frmGRNApproval(CurrentUser, "RPD_Main");
            ShowForm(objFrm);
        }

        private void rawToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmMRT_toStore objFrm = new frmMRT_toStore(CurrentUser,"RM_Main","Raw");
            ShowForm(objFrm);
        }

        private void processedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMRT_toStore objFrm = new frmMRT_toStore(CurrentUser, "RM_Processed", "Raw");
            ShowForm(objFrm);
        }

        private void packingToolStripMenuItem5_Click(object sender, EventArgs e)
        {

            frmMRT_toStore objFrm = new frmMRT_toStore(CurrentUser, "Packing", "Packing");
            ShowForm(objFrm);
        }

        private void labToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmMRT_toStore objFrm = new frmMRT_toStore(CurrentUser, "Lab_01", "Raw");
            ShowForm(objFrm);
        }

        private void rPDToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmMRT_toStore objFrm = new frmMRT_toStore(CurrentUser, "RPD_Main", "Raw");
            ShowForm(objFrm);

        }

        private void packingToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmMRT_toDep_Packing objFrm = new frmMRT_toDep_Packing(CurrentUser);
            ShowForm(objFrm);
        }

        private void receiveToDepToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void materialTransToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNApproval objFrm = new frmMTNApproval(CurrentUser);
            ShowForm(objFrm);
        }

        private void receiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mTNGRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBatchCreate objForm = new frmBatchCreate(CurrentUser);
            ShowForm(objForm);
        }

        private void approveInitiateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchApproving objFrm = new frmBatchApproving(CurrentUser);
            ShowForm(objFrm);
        }

        private void mTNCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNCosting objFrm = new frmMTNCosting(CurrentUser);
            ShowForm(objFrm);
        }

        private void hPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceiveGRN_Herbal objFrm = new frmMTNReceiveGRN_Herbal(CurrentUser);
            ShowForm(objFrm);
        }

        private void batchPackingSecondaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void fGHerbalToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void finishedGoodsHCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGRNApproval_FG objFrm = new frmGRNApproval_FG(CurrentUser, "Finished_Goods_Consumer");
            ShowForm(objFrm);
        }

        private void finishedGoodsHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGRNApproval_FG objFrm = new frmGRNApproval_FG(CurrentUser, "Finished_Goods_Ayurveda");
            ShowForm(objFrm);
        }

        private void batchPackingSecondaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void batchTransferSecondaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem26_Click_1(object sender, EventArgs e)
        {
            frmDailySales objForm = new frmDailySales(CurrentUser);
            ShowForm(objForm);
        }

        private void optionalMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRT_Batch_Optional objFrm = new frmMRT_Batch_Optional(CurrentUser);
            ShowForm(objFrm);
        }

        private void optionalSemiFinishedToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void initiateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBatchInitiate objFrm = new frmBatchInitiate(CurrentUser);
            ShowForm(objFrm);

        }

        private void hCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceiveGRN_Ayurveda objFrm = new frmMTNReceiveGRN_Ayurveda(CurrentUser);
            ShowForm(objFrm);
        }

        private void transferBasicProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchList_Transfer_Basic objFrm = new frmBatchList_Transfer_Basic(CurrentUser);
            ShowForm(objFrm);
        }

        private void primaryPackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchPacking_Priamry objForm = new frmBatchPacking_Priamry(CurrentUser);
            ShowForm(objForm);
        }

        private void sendPackingQCToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void transferToSecondaryPackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchList_Transfer objFrm = new frmBatchList_Transfer(CurrentUser);
            ShowForm(objFrm);
        }

        private void secondaryPackingInstructionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchPacking_Secondary_Instructions objFrm = new frmBatchPacking_Secondary_Instructions(CurrentUser);
            ShowForm(objFrm);
        }

        private void secondaryPackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchPacking_Secondary objFrm = new frmBatchPacking_Secondary(CurrentUser);
            ShowForm(objFrm);
        }

        private void secondaryProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchList_Transfer_Secondary objFrm = new frmBatchList_Transfer_Secondary(CurrentUser);
            ShowForm(objFrm);
        }

        private void priamryProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchList_Transfer_Primary objFrm = new frmBatchList_Transfer_Primary(CurrentUser);
            ShowForm(objFrm);
        }

        private void bulkPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void stockDepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRApproval objFrm = new frmMRApproval(CurrentUser);
            ShowForm(objFrm);
        }

        private void batchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMRApproval_Batch objFrm = new frmMRApproval_Batch(CurrentUser);
            ShowForm(objFrm);
        }

        private void rPDToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmGRN_Direct objFrm = new frmGRN_Direct(CurrentUser, "RPD_Main", "Raw");
            ShowForm(objFrm);
        }

        private void packingToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void packingToBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rejectMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceive_Rejects objForm = new frmMTNReceive_Rejects(CurrentUser);
            ShowForm(objForm);
        }

        private void finishedGoodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceive objForm = new frmMTNReceive(CurrentUser);
            ShowForm(objForm);
        }

        private void semiFinishedBasicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceive_Semi objForm = new frmMTNReceive_Semi(CurrentUser);
            ShowForm(objForm);
        }

        private void rwjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceiveGRN_Rejects objForm = new frmMTNReceiveGRN_Rejects(CurrentUser);
            ShowForm(objForm);
        }

        private void rejectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGRN_Rejects_Approval objForm = new frmGRN_Rejects_Approval(CurrentUser);
            ShowForm(objForm);
        }

        private void batchViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchRegistry objForm = new frmBatchRegistry(CurrentUser);
            ShowForm(objForm);
        }

        private void editToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmTGRNEdit objForm = new frmTGRNEdit(CurrentUser);
            ShowForm(objForm);
        }

        private void batchRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchRegister objForm = new frmBatchRegister(CurrentUser);
            ShowForm(objForm);
        }

        private void rMMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRBulkPrint objForm = new frmMRBulkPrint(CurrentUser, "RM_Main");
            ShowForm(objForm);
        }

        private void packingToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmMRBulkPrint objForm = new frmMRBulkPrint(CurrentUser, "Packing");
            ShowForm(objForm);
        }

        private void labToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmMRBulkPrint objForm = new frmMRBulkPrint(CurrentUser, "Lab");
            ShowForm(objForm);
        }

        private void rPDToolStripMenuItem5_Click(object sender, EventArgs e)
        {
          
            frmMRBulkPrint objForm = new frmMRBulkPrint(CurrentUser, "RPD_Main");
            ShowForm(objForm);
        }

        private void packing02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMRReceive_toStore objForm = new frmMRReceive_toStore(CurrentUser, "Pk-02");
            //ShowForm(objForm);
        }

        private void processedToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            //frmMRReceive_toStore objForm = new frmMRReceive_toStore(CurrentUser, "RM_Main");
            //ShowForm(objForm);
        }

        private void labToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            //frmMRReceive_toStore objForm = new frmMRReceive_toStore(CurrentUser, "RM_Main");
            //ShowForm(objForm);
        }

        private void packing01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMRReceive_toStore objForm = new frmMRReceive_toStore(CurrentUser, "Pk-01");
            //ShowForm(objForm);
        }

        private void manufacturing01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMRReceive_toStore objForm = new frmMRReceive_toStore(CurrentUser, "Mnf-01");
            //ShowForm(objForm);
        }

        private void manufacturing02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMRReceive_toStore objForm = new frmMRReceive_toStore(CurrentUser, "Mnf-02");
            //ShowForm(objForm);
        }

        private void primaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchSendQC_Packing objFrm = new frmBatchSendQC_Packing(CurrentUser);
            ShowForm(objFrm);
        }

        private void secondaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchSendQC_Packing_Secondary objFrm = new frmBatchSendQC_Packing_Secondary(CurrentUser);
            ShowForm(objFrm);
        }

        private void gRNBulkPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }

        private void rawToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmGRNBulkPrint objFrm = new frmGRNBulkPrint(CurrentUser,"RM_Main",Convert.ToInt32(GRN.Type.Material));
            ShowForm(objFrm);
        }

        private void packingToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmGRNBulkPrint objFrm = new frmGRNBulkPrint(CurrentUser, "Packing", Convert.ToInt32(GRN.Type.Material));
            ShowForm(objFrm);
        }

        private void labToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmGRNBulkPrint objFrm = new frmGRNBulkPrint(CurrentUser, "Lab", Convert.ToInt32(GRN.Type.Material));
            ShowForm(objFrm);
        }

        private void rPDToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmGRNBulkPrint objFrm = new frmGRNBulkPrint(CurrentUser, "RPD_Main", Convert.ToInt32(GRN.Type.Material));
            ShowForm(objFrm);
        }

        private void rPDSemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void batchSendToFinishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchFinish_Approve objForm = new frmBatchFinish_Approve(CurrentUser);
            ShowForm(objForm);
        }

        private void anyMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRT_Batch_AnyMaterial objForm = new frmMRT_Batch_AnyMaterial(CurrentUser);
            ShowForm(objForm);
        }

        private void rMProcessedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRBulkPrint objForm = new frmMRBulkPrint(CurrentUser, "RM_Processed");
            ShowForm(objForm);
        }

        private void rMProcessedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGRNBulkPrint objFrm = new frmGRNBulkPrint(CurrentUser, "RM_Processed", Convert.ToInt32(GRN.Type.Material));
            ShowForm(objFrm);
        }

        private void gRNManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGRNManagement objForm = new frmGRNManagement(CurrentUser);
            ShowForm(objForm);
        }

        private void mRManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRManagement objForm = new frmMRManagement(CurrentUser);
            ShowForm(objForm);
        }

        private void mTNManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNManagement objForm = new frmMTNManagement(CurrentUser);
            ShowForm(objForm);
        }

        private void packingToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmMRT_Batch_Packing objFrm = new frmMRT_Batch_Packing(CurrentUser);
            ShowForm(objFrm); 
        }

        private void anySemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rPDToolStripMenuItem8_Click(object sender, EventArgs e)
        {
       
        }

        private void semiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rPDToolStripMenuItem7_Click(object sender, EventArgs e)
        {
          
        }

        private void batchReworkRepackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchPlanExclusive objFrm = new frmBatchPlanExclusive(CurrentUser);
            ShowForm(objFrm);
        }

        private void reworkRepackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchPacking_Rework objFrm = new frmBatchPacking_Rework(CurrentUser);
            ShowForm(objFrm);
        }

        private void reworkRepackSendQCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchSendQC_Rework objFrm = new frmBatchSendQC_Rework(CurrentUser);
            ShowForm(objFrm);
        }

        private void reworkQCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQCReport_Rework objFrm = new frmQCReport_Rework(CurrentUser);
            ShowForm(objFrm);  
        }

        private void reworkToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmBatchList_Transfer_Rework objFrm = new frmBatchList_Transfer_Rework(CurrentUser);
            ShowForm(objFrm);
        }
        private void herbalReworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceiveGRN_Herbal_Rework objFrm = new frmMTNReceiveGRN_Herbal_Rework(CurrentUser);
            ShowForm(objFrm);  
        }

        private void ayurvedaReworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceiveGRN_Ayurveda_Rework objFrm = new frmMTNReceiveGRN_Ayurveda_Rework(CurrentUser);
            ShowForm(objFrm);  
        }

        private void batchQCFailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchQCFail objFrm = new frmBatchQCFail(CurrentUser);
            ShowForm(objFrm);  
        }

        private void rPDToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            //frmMRT_Batch_RPD objFrm = new frmMRT_Batch_RPD(CurrentUser);
            //ShowForm(objFrm); 
        }

        private void manageToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            frmPRPDPreperationBatchManagement objForm = new frmPRPDPreperationBatchManagement(CurrentUser);
            ShowForm(objForm);
        }

        private void qCViewRPDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQCView objForm = new frmQCView(CurrentUser);
            ShowForm(objForm);
        }

        private void processedToolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void processedToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmGRNApproval objFrm = new frmGRNApproval(CurrentUser, "RM_Processed");
            ShowForm(objFrm);
        }

        private void rawMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceive_RM objFrm = new frmMTNReceive_RM(CurrentUser);
            ShowForm(objFrm);
        }

        private void rawMaterialsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMTNReceiveGRN_RM objFrm = new frmMTNReceiveGRN_RM(CurrentUser,"RM_Processed");
            ShowForm(objFrm);
        }

        private void batchReworkRepackApprovToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatch_Rework_Approve objFrm = new frmBatch_Rework_Approve(CurrentUser);
            ShowForm(objFrm);
        }

        private void batchFileAdminModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchList_Edit objFrm = new frmBatchList_Edit(CurrentUser);
            ShowForm(objFrm);
        }

        private void basicProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMTNReceiveGRN_Basic objFrm = new frmMTNReceiveGRN_Basic(CurrentUser);
            ShowForm(objFrm);
        }

        private void batchRegisterReworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchRegister_Rework objFrm = new frmBatchRegister_Rework(CurrentUser);
            ShowForm(objFrm);
        }

        private void packingToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmMRT_toSec_Packing objFrm = new frmMRT_toSec_Packing(CurrentUser);
            ShowForm(objFrm);
        }

        private void receiveToSectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void primaryBatchAdminModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchPacking_Priamry_Edit objFrm = new frmBatchPacking_Priamry_Edit(CurrentUser);
            ShowForm(objFrm);
        }

        private void secondaryBatchAdminModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchPacking_Secondary_Edit objFrm = new frmBatchPacking_Secondary_Edit(CurrentUser);
            ShowForm(objFrm);
        }

        private void rPDSemiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmStockManagment objFrm = new frmStockManagment(CurrentUser);
            ShowForm(objFrm);
        }

        private void disposeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGRNApproval objFrm = new frmGRNApproval(CurrentUser, "Dispose_RM");
            ShowForm(objFrm);
        }

        private void labFromRPDMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMRReceive_toStore objForm = new frmMRReceive_toStore(CurrentUser, "RPD_Main");
            //ShowForm(objForm);
        }

        private void fromLabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMRReceive_toStore objForm = new frmMRReceive_toStore(CurrentUser, "Lab");
            //ShowForm(objForm);
        }

        private void fromRMProcessedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMRReceive_toStore objForm = new frmMRReceive_toStore(CurrentUser, "RM_Processed");
            //ShowForm(objForm);
        }

        private void labQAProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGRNApproval objFrm = new frmGRNApproval(CurrentUser, "Lab");
            ShowForm(objFrm);
        }

        private void semiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void materialToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void costingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchCost objFrm = new frmBatchCost(CurrentUser);
            ShowForm(objFrm);
        }

        private void dispatchFGToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rawToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmPO objFrm = new frmPO(CurrentUser, "Raw");
            ShowForm(objFrm);
        }

        private void pODeliverySheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rawToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            frmPOList objFrm = new frmPOList(CurrentUser, "Raw");
            ShowForm(objFrm);
        }

        private void rawToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            frmPOFinalize objFrm = new frmPOFinalize(CurrentUser, "Raw");
            ShowForm(objFrm);
        }

        private void packingToolStripMenuItem12_Click(object sender, EventArgs e)
        {
            frmPO objFrm = new frmPO(CurrentUser, "Packing");
            ShowForm(objFrm);
        }

        private void labToolStripMenuItem7_Click_1(object sender, EventArgs e)
        {
            frmPO objFrm = new frmPO(CurrentUser, "Lab");
            ShowForm(objFrm);
        }

        private void packingToolStripMenuItem13_Click(object sender, EventArgs e)
        {
            frmPOList objFrm = new frmPOList(CurrentUser, "Packing");
            ShowForm(objFrm);
        }

        private void labToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            frmPOList objFrm = new frmPOList(CurrentUser, "Lab");
            ShowForm(objFrm);
        }

        private void packingToolStripMenuItem11_Click(object sender, EventArgs e)
        {
            frmPOFinalize objFrm = new frmPOFinalize(CurrentUser, "Packing");
            ShowForm(objFrm);
        }

        private void labToolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmPOFinalize objFrm = new frmPOFinalize(CurrentUser, "Lab");
            ShowForm(objFrm);
        }

        private void importRawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTGRN_Import objFrm = new frmTGRN_Import(CurrentUser, "Raw");
            ShowForm(objFrm);
        }

        private void importPackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTGRN_Import objFrm = new frmTGRN_Import(CurrentUser, "Packing");
            ShowForm(objFrm);
        }

        private void wIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWIP objFrm = new frmWIP(CurrentUser);
            ShowForm(objFrm);
        }

        private void wIPPackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void finishedGoodsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }

        private void finishedGoodsHealthCareToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void basicProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void finishedProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void packTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPackType objFrm = new frmPackType(CurrentUser);
            this.ShowForm(objFrm);
        }

        private void wIPPackingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmWIP_Packing objFrm = new frmWIP_Packing(CurrentUser);
            ShowForm(objFrm);
        }

        private void editStandardBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStandardBatchManage objFrm = new frmStandardBatchManage(CurrentUser);
            ShowForm(objFrm);
        }

        private void finishedProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinishedProductRegistration objFrm = new frmFinishedProductRegistration();
            this.ShowForm(objFrm);
        }

        private void formulaWeighingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWeighing objForm = new frmWeighing(CurrentUser);
            ShowForm(objForm);
        }

        private void formulaWeighingCheckingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWeighingChecking objForm = new frmWeighingChecking(CurrentUser);
            ShowForm(objForm);
        }

        private void semiFinishedProductBinCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rPDStoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBinCards_BP objFrm = new frmBinCards_BP(CurrentUser, "RPD_Main");
            ShowForm(objFrm);
        }

        private void rPDStoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGRN_Direct_Semi objFrm = new frmGRN_Direct_Semi(CurrentUser, "RPD_Main");
            ShowForm(objFrm);
        }

        private void rPDStoresToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmGRNBulkPrint objFrm = new frmGRNBulkPrint(CurrentUser, "RPD_Main", Convert.ToInt32(GRN.Type.BasicProduct));
            ShowForm(objFrm);
        }

        private void finishedGoodsConsumerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIssueFinishedGoods objFrm = new frmIssueFinishedGoods(CurrentUser, "Finished_Goods_Consumer", "HP");
            ShowForm(objFrm);
        }

        private void rPDStoresToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmMRT_toStore_Semi objFrm = new frmMRT_toStore_Semi(CurrentUser, "RPD_Main");
            ShowForm(objFrm);
        }

        private void toStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRReceive_toStore objFrm = new frmMRReceive_toStore(CurrentUser);
            ShowForm(objFrm);
        }

        private void toBatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRReceive_toBatch objFrm = new frmMRReceive_toBatch(CurrentUser);
            ShowForm(objFrm);
        }

        private void toDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRReceive_toDep objFrm = new frmMRReceive_toDep(CurrentUser);
            ShowForm(objFrm);
        }

        private void toSectionStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRReceive_toSection objFrm = new frmMRReceive_toSection(CurrentUser);
            ShowForm(objFrm);
        }

        private void optionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRT_Batch_Optional_Semi objFrm = new frmMRT_Batch_Optional_Semi(CurrentUser);
            ShowForm(objFrm);
        }

        private void anyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRT_Batch_AnySemi objFrm = new frmMRT_Batch_AnySemi(CurrentUser, "RPD_Main");
            ShowForm(objFrm); 
        }

        private void finishedGoodsAyurvedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMRT_Batch_FG objFrm = new frmMRT_Batch_FG(CurrentUser, "AP");
            ShowForm(objFrm);
        }

        private void finishedGoodsConsumerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMRT_Batch_FG objFrm = new frmMRT_Batch_FG(CurrentUser, "HC");
            ShowForm(objFrm);
        }

        private void planningWeeksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartmentPlanningWeeks objFrm = new frmDepartmentPlanningWeeks(CurrentUser);
            ShowForm(objFrm);
        }

        private void batchPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBatchPlan objFrm = new frmBatchPlan(CurrentUser);
            ShowForm(objFrm);
        }

        private void rPDMaterialRequirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanMaterial objFrm = new frmPlanMaterial(CurrentUser,"RPD");
            ShowForm(objFrm);
        }

        private void rPDMaterialRequirementPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanMaterial_Full objFrm = new frmPlanMaterial_Full(CurrentUser, "RPD");
            ShowForm(objFrm);
        }

        private void pRPDMaterialRequirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanMaterial objFrm = new frmPlanMaterial(CurrentUser, "PRPD");
            ShowForm(objFrm);
        }

        private void pRPDMaterialRequirementPlanRPDMaterialRequirementPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanMaterial_Full objFrm = new frmPlanMaterial_Full(CurrentUser, "PRPD-temp");
            ShowForm(objFrm);
        }

        private void storesMaterialRequirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanMaterial objFrm = new frmPlanMaterial(CurrentUser, "Store");
            ShowForm(objFrm);
        }

        private void storeMaterialRequirementPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanMaterial_Full objFrm = new frmPlanMaterial_Full(CurrentUser, "Store");
            ShowForm(objFrm);
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerRegistration objFrm = new frmCustomerRegistration();
            ShowForm(objFrm);
        }

        private void forecastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesForeCast frm = new frmSalesForeCast(CurrentUser,"AP");
            ShowForm(frm);
        }

        private void createProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisterProject frm = new frmRegisterProject();
            ShowForm(frm);
        }

        private void projectMaterialConumptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProjectMaterials frm = new frmProjectMaterials(CurrentUser);
            ShowForm(frm);
        }

        private void packingMaterialRequirementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPackingMaterialsForecast frm = new frmPackingMaterialsForecast();
            //ShowForm(frm);
            frmPlanPackingMaterial_Full frm = new frmPlanPackingMaterial_Full();
            ShowForm(frm);
        }

        private void forecastApproveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApproveSalesForeCast frm = new frmApproveSalesForeCast();
            ShowForm(frm);
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            ShowForm(frm);
            
        }

        private void test2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanPackingMaterial_Full frm = new frmPlanPackingMaterial_Full();
            ShowForm(frm);
        }

        private void frmPlanPackingMaterialFullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPlanPackingMaterial_Full frm = new frmPlanPackingMaterial_Full();
            ShowForm(frm);
        }

        private void planPackingMaterialFullToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmGRN_Edit frm = new frmGRN_Edit();
            ShowForm(frm);
        }

        private void test2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void rPDStoresToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmGRN_Direct objFrm = new frmGRN_Direct(CurrentUser, "RPD_Main", "Raw");
            ShowForm(objFrm);
        }

        private void gRNEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGRN_Edit frm = new frmGRN_Edit();
            ShowForm(frm);
        }



        private void stockAdjesmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStockAdjustment frm = new frmStockAdjustment(CurrentUser, "HP", "Stock Adjustment", "Dispose_FG");
            ShowForm(frm);
        }

        private void salesReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalesReturn frm = new frmSalesReturn(CurrentUser, "HP", "Return_FG");
            ShowForm(frm);
        }

        private void testToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            frmBatchPlan_admin objFrm = new frmBatchPlan_admin(CurrentUser);
            ShowForm(objFrm);
        }

        private void fffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmQCReportHistory objFrm = new frmQCReportHistory("Production");
            ShowForm(objFrm);
        }

        private void addDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDetails frm = new AddDetails();
            ShowForm(frm);
        }

        private void approveToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Approve frm = new Approve();
            ShowForm(frm);
        }

        private void companyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyDetails frm = new CompanyDetails(1,1);
            ShowForm(frm);
        }

        private void comRegDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComRegDetails frm = new ComRegDetails(1,1);
            ShowForm(frm);
        }

        private void financeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FinanceDetails frm = new FinanceDetails(1, 1);
            ShowForm(frm);
        }

        private void frmAssignQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAssignQuantity frm = new frmAssignQuantity();
            ShowForm(frm);
        }

        private void frmHigherApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHigherApproval frm = new frmHigherApproval();
            ShowForm(frm);
        }

        private void frmInvoiceApproveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInvoiceApprove frm = new frmInvoiceApprove();
            ShowForm(frm);
        }

        private void frmNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewOrder frm = new frmNewOrder();
            ShowForm(frm);
        }

        private void frmOrderApprovalBySalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderApprovalBySales frm = new frmOrderApprovalBySales();
            ShowForm(frm);
        }

        private void frmOrderApprovalByStoreManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderApprovalByStoreManager frm = new frmOrderApprovalByStoreManager();
            ShowForm(frm);
        }

        private void frmOrderApproveByFinanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderApproveByFinance frm = new frmOrderApproveByFinance();
            ShowForm(frm);
        }

        private void frmOrderSortingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderSorting frm = new frmOrderSorting();
            ShowForm(frm);
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCustomer frm = new NewCustomer(1676);
            ShowForm(frm);
        }

        private void transactionDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransactionDetails frm = new TransactionDetails(1,1);
            ShowForm(frm);
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update frm = new Update();
            ShowForm(frm);
        }




    }
}
