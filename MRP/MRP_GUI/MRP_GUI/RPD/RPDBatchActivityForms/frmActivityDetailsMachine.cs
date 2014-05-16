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
    public partial class frmActivityDetailsMachine : System.Windows.Forms.Form
    {
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private User _CurrentUser;
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private RPDBatchActivityDetails objRPDBatchActivityDetails = null;
        private RPDBatchActivityDetails_DL objRPDBatchActivityDetailsDL = new RPDBatchActivityDetails_DL(ConnectionStringClass.GetConnection());
        private RPDActivityDetailsMachine_DL objRPDActivityDetailsMachineDL = new RPDActivityDetailsMachine_DL(ConnectionStringClass.GetConnection());
        private RPDActivityDetailsMachine objRPDActivityDetailsMachine = null;
        private Machine_DL objMachineDL = new Machine_DL(ConnectionStringClass.GetConnection());
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn colID;
        private BindingSource bindMachines;
        private IContainer components;
        private GroupBox groupBox2;
        private TextBox txtComments;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private Button btnClose;
        private TextBox txtFinalQty;
        private Label label29;
        private Label label5;
        private TextBox txtMeshSizeGRN;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox1;
        private DateTimePicker dtStopDate;
        private Label lblStop;
        private DateTimePicker dtStartDate;
        private Label label8;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtRemarks;
        private Label label4;
        private TextBox txtDescription;
        private Label label3;
        private DateTimePicker dtpMachineStopGRN;
        private DateTimePicker dtpMachineStartGRN;
        private Label lblStopMachine;
        private Label label38;
        private TextBox txtStopQtyGRN;
        private Label lbStopQty;
        private TextBox txtStartQtyGRN;
        private Label label35;
        private ComboBox cmbMachine;
        private Label label28;
        private DataGridView gvMachines;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private RPDBatchActivity_DL objRPDBatchActivityDL = new RPDBatchActivity_DL(ConnectionStringClass.GetConnection());
       
        public frmActivityDetailsMachine()
        {
            InitializeComponent();
        }

        public frmActivityDetailsMachine(User objUser, RPDBatchActivityDetails objRPDBatchAcDetails)
        {
            CurrentUser = objUser;
            objRPDBatchActivityDetails = objRPDBatchAcDetails;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmActivityDetailsMachine_Load(object sender, EventArgs e)
        {
            try
            {
                if (objRPDBatchActivityDetails != null)
                {
                    txtID.Text = objRPDBatchActivityDetails.BatchActDetailsID.ToString();
                    txtComments.Text = objRPDBatchActivityDetails.Comments;
                    bindMachines.DataSource = objRPDActivityDetailsMachineDL.Get_By_BatchActDetails_View(objRPDBatchActivityDetails.BatchActDetailsID);
                    RPDBatchActivity obj = objRPDBatchActivityDL.Get(objRPDBatchActivityDetails.RPDBatchActID);
                    cmbMachine.DataSource = objMachineDL.GetDataView_By_Activity(obj.MainActID);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this,"Error occured while loading machine details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            txtDescription.Text = "";
            txtFinalQty.Text = "0.00";
            if (cmbMachine.Items.Count > 0)
            {
                cmbMachine.SelectedIndex = 0;
            }
            txtMeshSizeGRN.Text = "0.00";
            txtRemarks.Text = "";
            txtStartQtyGRN.Text = "0.00";
            dtpMachineStartGRN.Value = Convert.ToDateTime("7/15/2009 8:00 AM");
            txtStopQtyGRN.Text = "0.00";
            dtpMachineStopGRN.Value = Convert.ToDateTime("7/15/2009 5:00 PM");
            objRPDActivityDetailsMachine = null;
            btnDelete.Enabled = false;
            bindMachines.DataSource = objRPDActivityDetailsMachineDL.Get_By_BatchActDetails_View(objRPDBatchActivityDetails.BatchActDetailsID);
            dtStopDate.Value = DateTime.Now;
            dtStartDate.Value = DateTime.Now;


            lblStop.Visible = false;
            lblStopMachine.Visible = false;
            lbStopQty.Visible = false;

            dtpMachineStopGRN.Visible = false;
            dtStopDate.Visible = false;
            txtStopQtyGRN.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void gvMachines_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMachines = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtFinalQty = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMeshSizeGRN = new System.Windows.Forms.TextBox();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtStopDate = new System.Windows.Forms.DateTimePicker();
            this.lblStop = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpMachineStopGRN = new System.Windows.Forms.DateTimePicker();
            this.dtpMachineStartGRN = new System.Windows.Forms.DateTimePicker();
            this.lblStopMachine = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.txtStopQtyGRN = new System.Windows.Forms.TextBox();
            this.lbStopQty = new System.Windows.Forms.Label();
            this.txtStartQtyGRN = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.gvMachines = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn9.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "StartQty";
            this.Column6.HeaderText = "Start Qty";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
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
            this.colID.DataPropertyName = "ActivityDetailsMachineID";
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
            this.groupBox2.TabIndex = 109;
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
            this.btnClose.Location = new System.Drawing.Point(793, 444);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 113;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtFinalQty
            // 
            this.txtFinalQty.Location = new System.Drawing.Point(284, 438);
            this.txtFinalQty.Name = "txtFinalQty";
            this.txtFinalQty.Size = new System.Drawing.Size(93, 20);
            this.txtFinalQty.TabIndex = 111;
            this.txtFinalQty.Text = "0.00";
            this.txtFinalQty.Visible = false;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(29, 444);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(56, 13);
            this.label29.TabIndex = 112;
            this.label29.Text = "Mesh Size";
            this.label29.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 114;
            this.label5.Text = "Final Qty";
            this.label5.Visible = false;
            // 
            // txtMeshSizeGRN
            // 
            this.txtMeshSizeGRN.Location = new System.Drawing.Point(93, 441);
            this.txtMeshSizeGRN.Name = "txtMeshSizeGRN";
            this.txtMeshSizeGRN.Size = new System.Drawing.Size(93, 20);
            this.txtMeshSizeGRN.TabIndex = 110;
            this.txtMeshSizeGRN.Text = "0.00";
            this.txtMeshSizeGRN.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "StopTime";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.HeaderText = "Stop Time";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MachineCode";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Machine Code";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MeshSize";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mesh Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn4.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StopTime";
            dataGridViewCellStyle3.Format = "HH:mm";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StartQty";
            this.dataGridViewTextBoxColumn6.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StopQty";
            this.dataGridViewTextBoxColumn7.HeaderText = "Stop Qty";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FinalQty";
            this.dataGridViewTextBoxColumn8.HeaderText = "Final Qty";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ActivityDetailsMachineID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StartTime";
            dataGridViewCellStyle4.Format = "HH:mm";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Start Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtStopDate);
            this.groupBox1.Controls.Add(this.lblStop);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtRemarks);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpMachineStopGRN);
            this.groupBox1.Controls.Add(this.dtpMachineStartGRN);
            this.groupBox1.Controls.Add(this.lblStopMachine);
            this.groupBox1.Controls.Add(this.label38);
            this.groupBox1.Controls.Add(this.txtStopQtyGRN);
            this.groupBox1.Controls.Add(this.lbStopQty);
            this.groupBox1.Controls.Add(this.txtStartQtyGRN);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.cmbMachine);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.gvMachines);
            this.groupBox1.Location = new System.Drawing.Point(12, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 347);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Machine Usage";
            // 
            // dtStopDate
            // 
            this.dtStopDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStopDate.Location = new System.Drawing.Point(290, 103);
            this.dtStopDate.Name = "dtStopDate";
            this.dtStopDate.Size = new System.Drawing.Size(99, 20);
            this.dtStopDate.TabIndex = 6;
            this.dtStopDate.Visible = false;
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(229, 106);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(55, 13);
            this.lblStop.TabIndex = 115;
            this.lblStop.Text = "Stop Date";
            this.lblStop.Visible = false;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(100, 102);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(99, 20);
            this.dtStartDate.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Start Date";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(608, 147);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(686, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(764, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(521, 22);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(318, 57);
            this.txtRemarks.TabIndex = 9;
            this.txtRemarks.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "Remarks";
            this.label4.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(100, 39);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(287, 57);
            this.txtDescription.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 98;
            this.label3.Text = "Description";
            // 
            // dtpMachineStopGRN
            // 
            this.dtpMachineStopGRN.CustomFormat = "HH:mm";
            this.dtpMachineStopGRN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMachineStopGRN.Location = new System.Drawing.Point(290, 125);
            this.dtpMachineStopGRN.Name = "dtpMachineStopGRN";
            this.dtpMachineStopGRN.ShowUpDown = true;
            this.dtpMachineStopGRN.Size = new System.Drawing.Size(99, 20);
            this.dtpMachineStopGRN.TabIndex = 8;
            this.dtpMachineStopGRN.Value = new System.DateTime(2009, 7, 15, 17, 0, 0, 0);
            this.dtpMachineStopGRN.Visible = false;
            // 
            // dtpMachineStartGRN
            // 
            this.dtpMachineStartGRN.CustomFormat = "HH:mm";
            this.dtpMachineStartGRN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMachineStartGRN.Location = new System.Drawing.Point(100, 125);
            this.dtpMachineStartGRN.Name = "dtpMachineStartGRN";
            this.dtpMachineStartGRN.ShowUpDown = true;
            this.dtpMachineStartGRN.Size = new System.Drawing.Size(99, 20);
            this.dtpMachineStartGRN.TabIndex = 7;
            this.dtpMachineStartGRN.Value = new System.DateTime(2009, 7, 15, 8, 0, 0, 0);
            // 
            // lblStopMachine
            // 
            this.lblStopMachine.AutoSize = true;
            this.lblStopMachine.Location = new System.Drawing.Point(211, 127);
            this.lblStopMachine.Name = "lblStopMachine";
            this.lblStopMachine.Size = new System.Drawing.Size(73, 13);
            this.lblStopMachine.TabIndex = 93;
            this.lblStopMachine.Text = "Machine Stop";
            this.lblStopMachine.Visible = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(19, 129);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 13);
            this.label38.TabIndex = 92;
            this.label38.Text = "Machine Start";
            // 
            // txtStopQtyGRN
            // 
            this.txtStopQtyGRN.Location = new System.Drawing.Point(290, 147);
            this.txtStopQtyGRN.Name = "txtStopQtyGRN";
            this.txtStopQtyGRN.Size = new System.Drawing.Size(99, 20);
            this.txtStopQtyGRN.TabIndex = 4;
            this.txtStopQtyGRN.Text = "0.00";
            this.txtStopQtyGRN.Visible = false;
            // 
            // lbStopQty
            // 
            this.lbStopQty.AutoSize = true;
            this.lbStopQty.Location = new System.Drawing.Point(236, 150);
            this.lbStopQty.Name = "lbStopQty";
            this.lbStopQty.Size = new System.Drawing.Size(48, 13);
            this.lbStopQty.TabIndex = 90;
            this.lbStopQty.Text = "Stop Qty";
            this.lbStopQty.Visible = false;
            // 
            // txtStartQtyGRN
            // 
            this.txtStartQtyGRN.Location = new System.Drawing.Point(100, 147);
            this.txtStartQtyGRN.Name = "txtStartQtyGRN";
            this.txtStartQtyGRN.Size = new System.Drawing.Size(99, 20);
            this.txtStartQtyGRN.TabIndex = 3;
            this.txtStartQtyGRN.Text = "0.00";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(21, 150);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 13);
            this.label35.TabIndex = 88;
            this.label35.Text = "Start Quantity";
            // 
            // cmbMachine
            // 
            this.cmbMachine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMachine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(100, 16);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(287, 21);
            this.cmbMachine.TabIndex = 0;
            this.cmbMachine.ValueMember = "MachineCode";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(44, 19);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 13);
            this.label28.TabIndex = 84;
            this.label28.Text = "Machine";
            // 
            // gvMachines
            // 
            this.gvMachines.AllowUserToAddRows = false;
            this.gvMachines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMachines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvMachines.AutoGenerateColumns = false;
            this.gvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.colID});
            this.gvMachines.DataSource = this.bindMachines;
            this.gvMachines.Location = new System.Drawing.Point(6, 186);
            this.gvMachines.Name = "gvMachines";
            this.gvMachines.ReadOnly = true;
            this.gvMachines.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMachines.RowTemplate.Height = 18;
            this.gvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMachines.Size = new System.Drawing.Size(844, 155);
            this.gvMachines.TabIndex = 12;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MachineCode";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Machine Code";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Description";
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // frmActivityDetailsMachine
            // 
            this.ClientSize = new System.Drawing.Size(877, 477);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFinalQty);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMeshSizeGRN);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmActivityDetailsMachine";
            this.Text = "Machine Usage";
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}