using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.DL;
using SESD.MRP.REF;

namespace MRP_GUI.PRPD.PRPDBatchActivityForms
{
    public partial class frmPRPDMachine : System.Windows.Forms.Form
    {
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private User _CurrentUser;
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private PRPDBatchActivityDetails objPRPDBatchActivityDetails = null;
        private PRPDBatchActivityDetails_DL objPRPDBatchActivityDetailsDL = new PRPDBatchActivityDetails_DL(ConnectionStringClass.GetConnection());
        private PRPDActivityDetailsMachine_DL objPRPDActivityDetailsMachineDL = new PRPDActivityDetailsMachine_DL(ConnectionStringClass.GetConnection());
        private PRPDActivityDetailsMachine objPRPDActivityDetailsMachine = null;
        private Machine_DL objMachineDL = new Machine_DL(ConnectionStringClass.GetConnection());
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Label label3;
        private Label lblActivity;
        private Label label6;
        private DataGridView gvMachines;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn colID;
        private BindingSource bindMachines;
        private IContainer components;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private GroupBox groupBox2;
        private TextBox txtComments;
        private Label label2;
        private TextBox txtID;
        private Label label1;
        private DateTimePicker dtStopDate;
        private Label lblStopDate;
        private DateTimePicker dtStartDate;
        private TextBox txtRemarks;
        private Label label8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DateTimePicker dtpMachineStopGRN;
        private Label lblMachineStop;
        private TextBox txtStopQtyGRN;
        private Label label38;
        private Label lblStopQty;
        private ComboBox cmbMachine;
        private TextBox txtStartQtyGRN;
        private Label label35;
        private Label label28;
        private Button btnClose;
        private DateTimePicker dtpMachineStartGRN;
        private PRPDBatchActivity_DL objPRPDBatchActivityDL = new PRPDBatchActivity_DL(ConnectionStringClass.GetConnection());

        public frmPRPDMachine(User objUser, PRPDBatchActivityDetails objPRPDBatchAcDetails)
        {
            CurrentUser = objUser;
            objPRPDBatchActivityDetails = objPRPDBatchAcDetails;
            InitializeComponent();
        }

        private void frmPRPDMachine_Load(object sender, EventArgs e)
        {
            try
            {
                if (objPRPDBatchActivityDetails != null)
                {
                    MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
                    MainActivity obj = objMainActivityDL.Get(objPRPDBatchActivityDetails.PRPDBatchActivity.MainActID);
                    lblActivity.Text = obj.MainActivityTitle;
                    txtID.Text = objPRPDBatchActivityDetails.PRPDBatchActDetailsID.ToString();
                    txtComments.Text = objPRPDBatchActivityDetails.Remarks;
                    bindMachines.DataSource = objPRPDActivityDetailsMachineDL.GetDataView(objPRPDBatchActivityDetails.PRPDBatchActDetailsID);
                    
                    cmbMachine.DataSource = objMachineDL.GetDataView_By_Activity(objPRPDBatchActivityDetails.PRPDBatchActivity.MainActID);


                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(this, "Error occured while loading machine details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
            
            //txtFinalQty.Text = "0.00";
            if (cmbMachine.Items.Count > 0)
            {
                cmbMachine.SelectedIndex = 0;
            }
            //txtMeshSizeGRN.Text = "0.00";
            txtRemarks.Text = "";
            txtStartQtyGRN.Text = "0.00";
            dtpMachineStartGRN.Value = Convert.ToDateTime("7/15/2009 8:00 AM");
            txtStopQtyGRN.Text = "0.00";
            dtpMachineStopGRN.Value = Convert.ToDateTime("7/15/2009 5:00 PM");
            objPRPDActivityDetailsMachine = null;
            btnDelete.Enabled = false;
            bindMachines.DataSource = objPRPDActivityDetailsMachineDL.GetDataView(objPRPDBatchActivityDetails.PRPDBatchActDetailsID);
            dtStopDate.Value = DateTime.Now;
            dtStartDate.Value = DateTime.Now;

            lblMachineStop.Visible = false;
            lblStopDate.Visible = false;
            lblStopQty.Visible = false;

            dtpMachineStopGRN.Visible = false;
            dtStopDate.Visible = false;
            txtStopQtyGRN.Visible = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gvMachines = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMachines = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStopDate = new System.Windows.Forms.DateTimePicker();
            this.lblStopDate = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpMachineStopGRN = new System.Windows.Forms.DateTimePicker();
            this.lblMachineStop = new System.Windows.Forms.Label();
            this.txtStopQtyGRN = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.lblStopQty = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.txtStartQtyGRN = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dtpMachineStartGRN = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(776, 157);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 133;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.Location = new System.Drawing.Point(695, 157);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 132;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(569, 157);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 131;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartTime";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StopTime";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
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
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn9.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ActivityDetailsMachineID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(736, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 145;
            this.label3.Text = "Machine Usage";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivity.Location = new System.Drawing.Point(12, 9);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(74, 16);
            this.lblActivity.TabIndex = 144;
            this.lblActivity.Text = "<Activity>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3099, -32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(7088, 73);
            this.label6.TabIndex = 146;
            this.label6.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "___________________________________";
            // 
            // gvMachines
            // 
            this.gvMachines.AllowUserToAddRows = false;
            this.gvMachines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMachines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMachines.AutoGenerateColumns = false;
            this.gvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.colID});
            this.gvMachines.DataSource = this.bindMachines;
            this.gvMachines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMachines.Location = new System.Drawing.Point(3, 16);
            this.gvMachines.Name = "gvMachines";
            this.gvMachines.ReadOnly = true;
            this.gvMachines.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMachines.RowTemplate.Height = 18;
            this.gvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMachines.Size = new System.Drawing.Size(833, 230);
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
            // Column4
            // 
            this.Column4.DataPropertyName = "StartTime";
            dataGridViewCellStyle4.Format = "HH:mm";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Start Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "StopTime";
            dataGridViewCellStyle5.Format = "HH:mm";
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Stop Time";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "Remarks";
            this.Column9.HeaderText = "Remarks";
            this.Column9.MinimumWidth = 200;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "ActivityDetailsMachineID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MeshSize";
            this.dataGridViewTextBoxColumn3.HeaderText = "Mesh Size";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gvMachines);
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(839, 249);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Activity Machine Usage";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtComments);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtID);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(84, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(58, 31);
            this.groupBox2.TabIndex = 140;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Activity Details";
            this.groupBox2.Visible = false;
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
            // dtStopDate
            // 
            this.dtStopDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStopDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStopDate.Location = new System.Drawing.Point(350, 44);
            this.dtStopDate.Name = "dtStopDate";
            this.dtStopDate.Size = new System.Drawing.Size(99, 21);
            this.dtStopDate.TabIndex = 127;
            this.dtStopDate.Visible = false;
            // 
            // lblStopDate
            // 
            this.lblStopDate.AutoSize = true;
            this.lblStopDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopDate.Location = new System.Drawing.Point(274, 48);
            this.lblStopDate.Name = "lblStopDate";
            this.lblStopDate.Size = new System.Drawing.Size(70, 15);
            this.lblStopDate.TabIndex = 143;
            this.lblStopDate.Text = "Stop Date";
            this.lblStopDate.Visible = false;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStartDate.Location = new System.Drawing.Point(112, 44);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(99, 21);
            this.dtStartDate.TabIndex = 126;
            this.dtStartDate.Visible = false;
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(455, 43);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(396, 108);
            this.txtRemarks.TabIndex = 130;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 15);
            this.label8.TabIndex = 142;
            this.label8.Text = "Start Date";
            this.label8.Visible = false;
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
            // dtpMachineStopGRN
            // 
            this.dtpMachineStopGRN.CustomFormat = "HH:mm";
            this.dtpMachineStopGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMachineStopGRN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMachineStopGRN.Location = new System.Drawing.Point(350, 114);
            this.dtpMachineStopGRN.Name = "dtpMachineStopGRN";
            this.dtpMachineStopGRN.ShowUpDown = true;
            this.dtpMachineStopGRN.Size = new System.Drawing.Size(99, 21);
            this.dtpMachineStopGRN.TabIndex = 129;
            this.dtpMachineStopGRN.Value = new System.DateTime(2009, 7, 15, 17, 0, 0, 0);
            this.dtpMachineStopGRN.Visible = false;
            // 
            // lblMachineStop
            // 
            this.lblMachineStop.AutoSize = true;
            this.lblMachineStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineStop.Location = new System.Drawing.Point(249, 116);
            this.lblMachineStop.Name = "lblMachineStop";
            this.lblMachineStop.Size = new System.Drawing.Size(95, 15);
            this.lblMachineStop.TabIndex = 138;
            this.lblMachineStop.Text = "Machine Stop";
            this.lblMachineStop.Visible = false;
            // 
            // txtStopQtyGRN
            // 
            this.txtStopQtyGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStopQtyGRN.Location = new System.Drawing.Point(350, 91);
            this.txtStopQtyGRN.Name = "txtStopQtyGRN";
            this.txtStopQtyGRN.Size = new System.Drawing.Size(99, 21);
            this.txtStopQtyGRN.TabIndex = 125;
            this.txtStopQtyGRN.Text = "0.00";
            this.txtStopQtyGRN.Visible = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(12, 118);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(96, 15);
            this.label38.TabIndex = 137;
            this.label38.Text = "Machine Start";
            // 
            // lblStopQty
            // 
            this.lblStopQty.AutoSize = true;
            this.lblStopQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStopQty.Location = new System.Drawing.Point(274, 92);
            this.lblStopQty.Name = "lblStopQty";
            this.lblStopQty.Size = new System.Drawing.Size(60, 15);
            this.lblStopQty.TabIndex = 136;
            this.lblStopQty.Text = "Stop Qty";
            this.lblStopQty.Visible = false;
            // 
            // cmbMachine
            // 
            this.cmbMachine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMachine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(112, 67);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(337, 23);
            this.cmbMachine.TabIndex = 123;
            this.cmbMachine.ValueMember = "MachineCode";
            // 
            // txtStartQtyGRN
            // 
            this.txtStartQtyGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartQtyGRN.Location = new System.Drawing.Point(112, 91);
            this.txtStartQtyGRN.Name = "txtStartQtyGRN";
            this.txtStartQtyGRN.Size = new System.Drawing.Size(99, 21);
            this.txtStartQtyGRN.TabIndex = 124;
            this.txtStartQtyGRN.Text = "0.00";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(15, 94);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(93, 15);
            this.label35.TabIndex = 135;
            this.label35.Text = "Start Quantity";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(46, 70);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(62, 15);
            this.label28.TabIndex = 134;
            this.label28.Text = "Machine";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(793, 441);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 141;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dtpMachineStartGRN
            // 
            this.dtpMachineStartGRN.CustomFormat = "HH:mm";
            this.dtpMachineStartGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMachineStartGRN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMachineStartGRN.Location = new System.Drawing.Point(112, 114);
            this.dtpMachineStartGRN.Name = "dtpMachineStartGRN";
            this.dtpMachineStartGRN.ShowUpDown = true;
            this.dtpMachineStartGRN.Size = new System.Drawing.Size(99, 21);
            this.dtpMachineStartGRN.TabIndex = 128;
            this.dtpMachineStartGRN.Value = new System.DateTime(2009, 7, 15, 8, 0, 0, 0);
            // 
            // frmPRPDMachine
            // 
            this.ClientSize = new System.Drawing.Size(864, 609);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtStopDate);
            this.Controls.Add(this.lblStopDate);
            this.Controls.Add(this.dtStartDate);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpMachineStopGRN);
            this.Controls.Add(this.lblMachineStop);
            this.Controls.Add(this.txtStopQtyGRN);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.lblStopQty);
            this.Controls.Add(this.cmbMachine);
            this.Controls.Add(this.txtStartQtyGRN);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dtpMachineStartGRN);
            this.Name = "frmPRPDMachine";
            this.Text = "PRPD Machine";
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}