using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.DL;
using SESD.MRP.REF;

namespace MRP_GUI.RPD.RPDBatchActivityForms
{
    public partial class frmViewActivityDetails : System.Windows.Forms.Form
    {
        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        RPDBatchActivity objRPDBatchActivity;
        RPDBatchActivity_DL objRPDBatchActivity_DL = new RPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        RPDBatchActivityDetails_DL objRPDBatchActivityDetails_DL = new RPDBatchActivityDetails_DL(ConnectionStringClass.GetConnection());
        RPDBatchActivityInstructions_DL objRPDBatchActivityInstructionsDL = new RPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        RPDBatchActivity_DL objRPDBatchActivityDL = new RPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        RPDBatchPackingMaterialUsage_DL objRPDBatchPackingMaterialUsageDL = new RPDBatchPackingMaterialUsage_DL(ConnectionStringClass.GetConnection());
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column5;
        private DataGridView gvMachines;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private BindingSource bindMachines;
        private IContainer components;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView gvLabours;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private BindingSource bindLabours;
        private BindingSource bindDetails;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn colID;
        private TextBox txtStopDate;
        private Label label5;
        private TextBox txtStartDate;
        private Label label4;
        private TextBox txtActivity;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView gvDetails;
        private Button btnClose;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
       
	
        public frmViewActivityDetails(RPDBatchActivity objRPDBatchActivity)
        {
            this.objRPDBatchActivity = objRPDBatchActivity;
            InitializeComponent();
        }

        private void frmViewActivityDetails_Load(object sender, EventArgs e)
        {
            try
            {
                bindDetails.DataSource = objRPDBatchActivityDetails_DL.GetData(objRPDBatchActivity.RPDBatchActID);
                MainActivity obj = objMainActivity_DL.Get(objRPDBatchActivity.MainActID);
                txtActivity.Text = obj.MainActivityTitle;
                if (objRPDBatchActivity.StartDate.HasValue)
                {
                    txtStartDate.Text = objRPDBatchActivity.StartDate.Value.ToShortDateString();
                }
                if (objRPDBatchActivity.StopDate.HasValue)
                {
                    txtStopDate.Text = objRPDBatchActivity.StopDate.Value.ToShortDateString();
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading Activity Details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMachines = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindMachines = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvLabours = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindLabours = new System.Windows.Forms.BindingSource(this.components);
            this.bindDetails = new System.Windows.Forms.BindingSource(this.components);
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStopDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gvDetails = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLabours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ActivityDetailsLabourID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 25;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StartTime";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn6.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StopTime";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn7.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StartQty";
            this.dataGridViewTextBoxColumn8.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StopQty";
            this.dataGridViewTextBoxColumn9.HeaderText = "Stop Qty";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ActivityDetailsMachineID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OTHours";
            this.dataGridViewTextBoxColumn11.HeaderText = "OT Hours";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ActivityDetailsLabourID";
            this.dataGridViewTextBoxColumn12.HeaderText = "ID";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Visible = false;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "MachineCode";
            this.dataGridViewTextBoxColumn13.Frozen = true;
            this.dataGridViewTextBoxColumn13.HeaderText = "Machine Code";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 150;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn14.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "StartTime";
            dataGridViewCellStyle3.Format = "HH:mm";
            this.dataGridViewTextBoxColumn15.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn15.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "StopTime";
            dataGridViewCellStyle4.Format = "HH:mm";
            this.dataGridViewTextBoxColumn16.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn16.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "StartQty";
            this.dataGridViewTextBoxColumn17.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "StopQty";
            this.dataGridViewTextBoxColumn18.HeaderText = "Stop Qty";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ActivityDetailsMachineID";
            this.dataGridViewTextBoxColumn19.HeaderText = "ID";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
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
            this.Column1.DataPropertyName = "Employee";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Helper";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
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
            this.Column9.MinimumWidth = 250;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OTHours";
            this.Column5.HeaderText = "OT Hours";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // gvMachines
            // 
            this.gvMachines.AllowUserToAddRows = false;
            this.gvMachines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMachines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMachines.AutoGenerateColumns = false;
            this.gvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34});
            this.gvMachines.DataSource = this.bindMachines;
            this.gvMachines.Location = new System.Drawing.Point(463, 240);
            this.gvMachines.Name = "gvMachines";
            this.gvMachines.ReadOnly = true;
            this.gvMachines.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMachines.RowTemplate.Height = 18;
            this.gvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMachines.Size = new System.Drawing.Size(524, 225);
            this.gvMachines.TabIndex = 132;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "MachineCode";
            this.dataGridViewTextBoxColumn28.Frozen = true;
            this.dataGridViewTextBoxColumn28.HeaderText = "Machine Code";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 150;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn29.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "StartTime";
            dataGridViewCellStyle6.Format = "HH:mm";
            this.dataGridViewTextBoxColumn30.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn30.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "StopTime";
            dataGridViewCellStyle7.Format = "HH:mm";
            this.dataGridViewTextBoxColumn31.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn31.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "StartQty";
            this.dataGridViewTextBoxColumn32.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.DataPropertyName = "StopQty";
            this.dataGridViewTextBoxColumn33.HeaderText = "Stop Qty";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.DataPropertyName = "ActivityDetailsMachineID";
            this.dataGridViewTextBoxColumn34.HeaderText = "ID";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartQty";
            dataGridViewCellStyle8.Format = "HH:mm";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn3.FillWeight = 284.7716F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // gvLabours
            // 
            this.gvLabours.AllowUserToAddRows = false;
            this.gvLabours.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvLabours.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.gvLabours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvLabours.AutoGenerateColumns = false;
            this.gvLabours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvLabours.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27});
            this.gvLabours.DataSource = this.bindLabours;
            this.gvLabours.Location = new System.Drawing.Point(463, 32);
            this.gvLabours.Name = "gvLabours";
            this.gvLabours.ReadOnly = true;
            this.gvLabours.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLabours.RowTemplate.Height = 18;
            this.gvLabours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvLabours.Size = new System.Drawing.Size(524, 189);
            this.gvLabours.TabIndex = 131;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "Helper";
            this.dataGridViewTextBoxColumn20.Frozen = true;
            this.dataGridViewTextBoxColumn20.HeaderText = "Helper";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 150;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "StartTime";
            dataGridViewCellStyle10.Format = "HH:mm";
            this.dataGridViewTextBoxColumn21.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn21.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "StopTime";
            dataGridViewCellStyle11.Format = "HH:mm";
            this.dataGridViewTextBoxColumn22.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn22.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "StartQty";
            this.dataGridViewTextBoxColumn23.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "StopQty";
            this.dataGridViewTextBoxColumn24.HeaderText = "Stop Qty";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn25.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn25.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 250;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "OTHours";
            this.dataGridViewTextBoxColumn26.HeaderText = "OT Hours";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "ActivityDetailsLabourID";
            this.dataGridViewTextBoxColumn27.HeaderText = "ID";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "StartTime";
            dataGridViewCellStyle12.Format = "HH:mm";
            dataGridViewCellStyle12.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle12;
            this.Column3.FillWeight = 7.614212F;
            this.Column3.HeaderText = "Start Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 75;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StopTime";
            dataGridViewCellStyle13.Format = "HH:mm";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle13;
            this.Column4.FillWeight = 7.614212F;
            this.Column4.HeaderText = "Stop Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 75;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "Comments";
            dataGridViewCellStyle14.Format = "d";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle14;
            this.Column6.FillWeight = 284.7716F;
            this.Column6.HeaderText = "Comments";
            this.Column6.MinimumWidth = 200;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "BatchActDetailsID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 25;
            // 
            // txtStopDate
            // 
            this.txtStopDate.Location = new System.Drawing.Point(103, 69);
            this.txtStopDate.Name = "txtStopDate";
            this.txtStopDate.ReadOnly = true;
            this.txtStopDate.Size = new System.Drawing.Size(147, 20);
            this.txtStopDate.TabIndex = 130;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 129;
            this.label5.Text = "Stop Date";
            // 
            // txtStartDate
            // 
            this.txtStartDate.Location = new System.Drawing.Point(103, 43);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.ReadOnly = true;
            this.txtStartDate.Size = new System.Drawing.Size(147, 20);
            this.txtStartDate.TabIndex = 128;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 127;
            this.label4.Text = "Start Date";
            // 
            // txtActivity
            // 
            this.txtActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtActivity.Location = new System.Drawing.Point(103, 17);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.ReadOnly = true;
            this.txtActivity.Size = new System.Drawing.Size(351, 22);
            this.txtActivity.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 125;
            this.label2.Text = "Activity";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 124;
            this.label1.Text = "Labour";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "Machine";
            // 
            // gvDetails
            // 
            this.gvDetails.AllowUserToAddRows = false;
            this.gvDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gvDetails.AutoGenerateColumns = false;
            this.gvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column6,
            this.colID});
            this.gvDetails.DataSource = this.bindDetails;
            this.gvDetails.Location = new System.Drawing.Point(24, 110);
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.ReadOnly = true;
            this.gvDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetails.RowTemplate.Height = 24;
            this.gvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetails.Size = new System.Drawing.Size(430, 362);
            this.gvDetails.TabIndex = 121;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(912, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 123;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StartTime";
            dataGridViewCellStyle16.Format = "HH:mm";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewTextBoxColumn1.FillWeight = 7.614212F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StopTime";
            dataGridViewCellStyle17.Format = "HH:mm";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewTextBoxColumn2.FillWeight = 7.614212F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // frmViewActivityDetails
            // 
            this.ClientSize = new System.Drawing.Size(1011, 519);
            this.Controls.Add(this.gvMachines);
            this.Controls.Add(this.gvLabours);
            this.Controls.Add(this.txtStopDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStartDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gvDetails);
            this.Controls.Add(this.btnClose);
            this.Name = "frmViewActivityDetails";
            this.Text = "View Activity Details";
            this.Load += new System.EventHandler(this.frmViewActivityDetails_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLabours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmViewActivityDetails_Load_1(object sender, EventArgs e)
        {

        }
    }
}