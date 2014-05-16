using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using SESD.MRP.DL;

namespace MRP_GUI.RPD.RPDBatchActivityForms
{
    public partial class frmActivityDetailsLabour : System.Windows.Forms.Form
    {
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private User _CurrentUser;
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        private RPDBatchActivityDetails objRPDBatchActivityDetails = null;
        private RPDBatchActivityDetails_DL objRPDBatchActivityDetailsDL = new RPDBatchActivityDetails_DL(ConnectionStringClass.GetConnection());
        private RPDActivityDetailsLabour objRPDActivityDetailsLabour = null;
        private RPDActivityDetailsLabour_DL objRPDActivityDetailsLabourDL = new RPDActivityDetailsLabour_DL(ConnectionStringClass.GetConnection());
        private Machine_DL objMachineDL = new Machine_DL(ConnectionStringClass.GetConnection());
        private RPDBatchActivity_DL objRPDBatchActivityDL = new RPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn colID;
        private BindingSource bindLabours;
        private IContainer components;
        private GroupBox groupBox2;
        private TextBox txtComments;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Button btnClose;
        private TextBox txtFinalQty;
        private TextBox txtNoofPackets;
        private TextBox txtPacketSize;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox1;
        private TextBox txtNoofRec;
        private Label lblNoofRec;
        private CheckBox cbMultiple;
        private Label lblOT;
        private DateTimePicker dtStopDate;
        private Label lblStopDate;
        private DateTimePicker dtStartDate;
        private TextBox txtOT;
        private Label label8;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtDescription;
        private Label label3;
        private DateTimePicker dtpStopTime;
        private DateTimePicker dtpStartTime;
        private Label lblStopTime;
        private TextBox txtStopQty;
        private Label lblStopQty;
        private Label label34;
        private TextBox txtStartQty;
        private Label label35;
        private DataGridView gvLabours;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Section_DL objSectionDL = new Section_DL(ConnectionStringClass.GetConnection());
        public frmActivityDetailsLabour()
        {
            InitializeComponent();
        }

        public frmActivityDetailsLabour(User objUser, RPDBatchActivityDetails objRPDBatchAcDetails)
        {
            objRPDBatchActivityDetails = objRPDBatchAcDetails;
            CurrentUser = objUser;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmActivityDetailsLabour_Load(object sender, EventArgs e)
        {
            try
            {
                if (objRPDBatchActivityDetails != null)
                {
                    txtID.Text = objRPDBatchActivityDetails.BatchActDetailsID.ToString();
                    txtComments.Text = objRPDBatchActivityDetails.Comments;
                   bindLabours.DataSource = objRPDActivityDetailsLabourDL.Get_By_BatchAct_View(objRPDBatchActivityDetails.BatchActDetailsID);
                   //cmbHelper.DataSource = objEmployeeDL.Get_By_RoleType(EmployeeRole.RoleType.Workforce.ToString(),
                       //"Production",
                       //true);
                   ucEmployeeSelect1.LoadForm(EmployeeRole.RoleType.Workforce.ToString(),"Production");
                   ucEmployeeSelect1.SetDefault(objMainActivityDL.Get(objRPDBatchActivityDL.Get(objRPDBatchActivityDetails.RPDBatchActID).MainActID).SectionID);
                   //cmbSection.DataSource = objSectionDL.GetDataView(
                }

            }
            catch (Exception)
            {

               MessageBox.Show(this,"Error occured while loading labor","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void gvLabours_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            objRPDActivityDetailsLabour = null;
            txtDescription.Text = "";
            txtFinalQty.Text = "0.00";
            txtNoofPackets.Text = "0";
            txtOT.Text = "0.00";
            txtPacketSize.Text = "0.00";
            txtStartQty.Text = "0.00";
            txtStopQty.Text = "0.00";
            dtpStartTime.Value = Convert.ToDateTime("7/15/2009 8:00 AM"); ;
            dtpStopTime.Value = Convert.ToDateTime("7/15/2009 5:00 PM"); ;
            btnDelete.Enabled = false;
            ucEmployeeSelect1.Clear();
            bindLabours.DataSource = objRPDActivityDetailsLabourDL.Get_By_BatchAct_View(objRPDBatchActivityDetails.BatchActDetailsID);
            dtStopDate.Value = DateTime.Now;
            dtStartDate.Value = DateTime.Now;

            lblStopDate.Visible = false;
            lblStopQty.Visible = false;
            lblStopTime.Visible = false;

            dtpStopTime.Visible = false;
            dtStopDate.Visible = false;
            txtStopQty.Visible = false;


            lblOT.Visible = false;
            txtOT.Visible = false;

            cbMultiple.Visible = false;
            lblNoofRec.Visible = false;
            txtNoofRec.Visible = false;
            txtNoofRec.Text = "0";
            ucEmployeeSelect1_EmployeeSelectedIndexChanged(this, new EventArgs());
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void ucEmployeeSelect1_EmployeeSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ucEmployeeSelect1.Employee != null && ucEmployeeSelect1.Employee.EmpType == "Outsource")
                {
                    cbMultiple.Visible = true;
                    lblNoofRec.Visible = true;
                    txtNoofRec.Visible = true;
                }
                else
                {
                    cbMultiple.Visible = false;
                    lblNoofRec.Visible = false;
                    txtNoofRec.Visible = false;
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while selecting Employe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindLabours = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFinalQty = new System.Windows.Forms.TextBox();
            this.txtNoofPackets = new System.Windows.Forms.TextBox();
            this.txtPacketSize = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNoofRec = new System.Windows.Forms.TextBox();
            this.lblNoofRec = new System.Windows.Forms.Label();
            this.cbMultiple = new System.Windows.Forms.CheckBox();
            this.lblOT = new System.Windows.Forms.Label();
            this.dtStopDate = new System.Windows.Forms.DateTimePicker();
            this.lblStopDate = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtOT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStopTime = new System.Windows.Forms.DateTimePicker();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStopTime = new System.Windows.Forms.Label();
            this.txtStopQty = new System.Windows.Forms.TextBox();
            this.lblStopQty = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtStartQty = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.gvLabours = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindLabours)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabours)).BeginInit();
            this.SuspendLayout();
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StopTime";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column4.HeaderText = "Stop Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "StopQty";
            this.Column7.HeaderText = "Stop Qty";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ActivityDetailsLabourID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComments);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(711, 73);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity Details";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(272, 17);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ReadOnly = true;
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(370, 50);
            this.txtComments.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(71, 17);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail ID";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(783, 438);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtFinalQty
            // 
            this.txtFinalQty.Location = new System.Drawing.Point(749, 17);
            this.txtFinalQty.Name = "txtFinalQty";
            this.txtFinalQty.Size = new System.Drawing.Size(93, 20);
            this.txtFinalQty.TabIndex = 14;
            this.txtFinalQty.Text = "0.00";
            this.txtFinalQty.Visible = false;
            // 
            // txtNoofPackets
            // 
            this.txtNoofPackets.Location = new System.Drawing.Point(749, 38);
            this.txtNoofPackets.Name = "txtNoofPackets";
            this.txtNoofPackets.Size = new System.Drawing.Size(93, 20);
            this.txtNoofPackets.TabIndex = 15;
            this.txtNoofPackets.Text = "0";
            this.txtNoofPackets.Visible = false;
            // 
            // txtPacketSize
            // 
            this.txtPacketSize.Location = new System.Drawing.Point(749, 59);
            this.txtPacketSize.Name = "txtPacketSize";
            this.txtPacketSize.Size = new System.Drawing.Size(93, 20);
            this.txtPacketSize.TabIndex = 16;
            this.txtPacketSize.Text = "0.00";
            this.txtPacketSize.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Helper";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Helper";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StopTime";
            dataGridViewCellStyle3.Format = "HH:mm";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StartQty";
            this.dataGridViewTextBoxColumn5.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StopQty";
            this.dataGridViewTextBoxColumn6.HeaderText = "Stop Qty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FinalQty";
            this.dataGridViewTextBoxColumn7.HeaderText = "Final Qty";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn8.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "NoOfPackets";
            this.dataGridViewTextBoxColumn9.HeaderText = "No of Packets";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PacketSize";
            this.dataGridViewTextBoxColumn10.HeaderText = "Packet Size";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OTHours";
            this.dataGridViewTextBoxColumn11.HeaderText = "OT Hours";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "StartQty";
            this.Column6.HeaderText = "Start Qty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Helper";
            this.dataGridViewTextBoxColumn13.HeaderText = "af";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "StartTime";
            dataGridViewCellStyle4.Format = "HH:mm";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column3.HeaderText = "Start Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNoofRec);
            this.groupBox1.Controls.Add(this.lblNoofRec);
            this.groupBox1.Controls.Add(this.cbMultiple);
            this.groupBox1.Controls.Add(this.lblOT);
            this.groupBox1.Controls.Add(this.dtStopDate);
            this.groupBox1.Controls.Add(this.lblStopDate);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.txtOT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpStopTime);
            this.groupBox1.Controls.Add(this.dtpStartTime);
            this.groupBox1.Controls.Add(this.lblStopTime);
            this.groupBox1.Controls.Add(this.txtStopQty);
            this.groupBox1.Controls.Add(this.lblStopQty);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.txtStartQty);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.gvLabours);
            this.groupBox1.Location = new System.Drawing.Point(13, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 345);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Labour Details";
            // 
            // txtNoofRec
            // 
            this.txtNoofRec.Location = new System.Drawing.Point(198, 158);
            this.txtNoofRec.Name = "txtNoofRec";
            this.txtNoofRec.Size = new System.Drawing.Size(99, 20);
            this.txtNoofRec.TabIndex = 121;
            this.txtNoofRec.Text = "0";
            this.txtNoofRec.Visible = false;
            // 
            // lblNoofRec
            // 
            this.lblNoofRec.AutoSize = true;
            this.lblNoofRec.Location = new System.Drawing.Point(117, 161);
            this.lblNoofRec.Name = "lblNoofRec";
            this.lblNoofRec.Size = new System.Drawing.Size(76, 13);
            this.lblNoofRec.TabIndex = 120;
            this.lblNoofRec.Text = "No of Records";
            this.lblNoofRec.Visible = false;
            // 
            // cbMultiple
            // 
            this.cbMultiple.AutoSize = true;
            this.cbMultiple.Location = new System.Drawing.Point(6, 160);
            this.cbMultiple.Name = "cbMultiple";
            this.cbMultiple.Size = new System.Drawing.Size(105, 17);
            this.cbMultiple.TabIndex = 119;
            this.cbMultiple.Text = "Multiple Records";
            this.cbMultiple.UseVisualStyleBackColor = true;
            this.cbMultiple.Visible = false;
            // 
            // lblOT
            // 
            this.lblOT.AutoSize = true;
            this.lblOT.Location = new System.Drawing.Point(205, 139);
            this.lblOT.Name = "lblOT";
            this.lblOT.Size = new System.Drawing.Size(56, 13);
            this.lblOT.TabIndex = 115;
            this.lblOT.Text = "OT(Hours)";
            this.lblOT.Visible = false;
            // 
            // dtStopDate
            // 
            this.dtStopDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStopDate.Location = new System.Drawing.Point(271, 71);
            this.dtStopDate.Name = "dtStopDate";
            this.dtStopDate.Size = new System.Drawing.Size(99, 20);
            this.dtStopDate.TabIndex = 5;
            this.dtStopDate.Visible = false;
            // 
            // lblStopDate
            // 
            this.lblStopDate.AutoSize = true;
            this.lblStopDate.Location = new System.Drawing.Point(206, 74);
            this.lblStopDate.Name = "lblStopDate";
            this.lblStopDate.Size = new System.Drawing.Size(55, 13);
            this.lblStopDate.TabIndex = 113;
            this.lblStopDate.Text = "Stop Date";
            this.lblStopDate.Visible = false;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(85, 71);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(99, 20);
            this.dtStartDate.TabIndex = 3;
            // 
            // txtOT
            // 
            this.txtOT.Location = new System.Drawing.Point(271, 136);
            this.txtOT.MaxLength = 2;
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(99, 20);
            this.txtOT.TabIndex = 7;
            this.txtOT.Text = "0.00";
            this.txtOT.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "Start Date";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(608, 153);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(686, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(764, 153);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(421, 70);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(408, 68);
            this.txtDescription.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 100;
            this.label3.Text = "Description";
            // 
            // dtpStopTime
            // 
            this.dtpStopTime.CustomFormat = "HH:mm";
            this.dtpStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStopTime.Location = new System.Drawing.Point(271, 115);
            this.dtpStopTime.Name = "dtpStopTime";
            this.dtpStopTime.ShowUpDown = true;
            this.dtpStopTime.Size = new System.Drawing.Size(99, 20);
            this.dtpStopTime.TabIndex = 6;
            this.dtpStopTime.Value = new System.DateTime(2009, 7, 15, 17, 0, 0, 0);
            this.dtpStopTime.Visible = false;
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "HH:mm";
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(85, 117);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowUpDown = true;
            this.dtpStartTime.Size = new System.Drawing.Size(99, 20);
            this.dtpStartTime.TabIndex = 4;
            this.dtpStartTime.Value = new System.DateTime(2009, 7, 15, 8, 0, 0, 0);
            // 
            // lblStopTime
            // 
            this.lblStopTime.AutoSize = true;
            this.lblStopTime.Location = new System.Drawing.Point(206, 117);
            this.lblStopTime.Name = "lblStopTime";
            this.lblStopTime.Size = new System.Drawing.Size(55, 13);
            this.lblStopTime.TabIndex = 94;
            this.lblStopTime.Text = "Stop Time";
            this.lblStopTime.Visible = false;
            // 
            // txtStopQty
            // 
            this.txtStopQty.Location = new System.Drawing.Point(271, 94);
            this.txtStopQty.Name = "txtStopQty";
            this.txtStopQty.Size = new System.Drawing.Size(99, 20);
            this.txtStopQty.TabIndex = 2;
            this.txtStopQty.Text = "0.00";
            this.txtStopQty.Visible = false;
            // 
            // lblStopQty
            // 
            this.lblStopQty.AutoSize = true;
            this.lblStopQty.Location = new System.Drawing.Point(213, 97);
            this.lblStopQty.Name = "lblStopQty";
            this.lblStopQty.Size = new System.Drawing.Size(48, 13);
            this.lblStopQty.TabIndex = 93;
            this.lblStopQty.Text = "Stop Qty";
            this.lblStopQty.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(24, 121);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(55, 13);
            this.label34.TabIndex = 92;
            this.label34.Text = "Start Time";
            // 
            // txtStartQty
            // 
            this.txtStartQty.Location = new System.Drawing.Point(85, 94);
            this.txtStartQty.Name = "txtStartQty";
            this.txtStartQty.Size = new System.Drawing.Size(99, 20);
            this.txtStartQty.TabIndex = 1;
            this.txtStartQty.Text = "0.00";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(13, 97);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 13);
            this.label35.TabIndex = 91;
            this.label35.Text = "Start Quantity";
            // 
            // gvLabours
            // 
            this.gvLabours.AllowUserToAddRows = false;
            this.gvLabours.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvLabours.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvLabours.AutoGenerateColumns = false;
            this.gvLabours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLabours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.colID});
            this.gvLabours.DataSource = this.bindLabours;
            this.gvLabours.Location = new System.Drawing.Point(5, 183);
            this.gvLabours.Name = "gvLabours";
            this.gvLabours.ReadOnly = true;
            this.gvLabours.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLabours.RowTemplate.Height = 18;
            this.gvLabours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvLabours.Size = new System.Drawing.Size(834, 156);
            this.gvLabours.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Helper";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Helper";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Description";
            this.Column2.HeaderText = "Description";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ActivityDetailsLabourID";
            this.dataGridViewTextBoxColumn12.HeaderText = "ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // frmActivityDetailsLabour
            // 
            this.ClientSize = new System.Drawing.Size(867, 467);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFinalQty);
            this.Controls.Add(this.txtNoofPackets);
            this.Controls.Add(this.txtPacketSize);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmActivityDetailsLabour";
            this.Text = "Labour Details";
            ((System.ComponentModel.ISupportInitialize)(this.bindLabours)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}