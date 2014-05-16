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
    public partial class frmViewActivityDetails : System.Windows.Forms.Form
    {
        private PRPDBatchActivity_DL objPRPDBatchActivityDL = new PRPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        private User _CurrentUser;
        private PRPDBatchActivity objPRPDBatchActivity;
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private PRPDBatch objPRPDBatch = null;
        private PRPDBatchActivityDetails objPRPDBatchActivityDetails;
        private PRPDBatchActivityDetails_DL objPRPDBatchActivityDetailsDL = new PRPDBatchActivityDetails_DL(ConnectionStringClass.GetConnection());
        private PRPDActivityDetailsLabour_DL objPRPDActivityDetailsLabour_DL = new PRPDActivityDetailsLabour_DL(ConnectionStringClass.GetConnection());
        private Button btnClose;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridView gvMachines;
        private BindingSource bindMachines;
        private IContainer components;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Column1;
        private BindingSource bindLabours;
        private TextBox txtActivity;
        private Label label1;
        private BindingSource bindDetails;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private Label label3;
        private DataGridView gvLabours;
        private DataGridView gvDetails;
        private PRPDActivityDetailsMachine_DL objPRPDActivityDetailsMachine_DL = new PRPDActivityDetailsMachine_DL(ConnectionStringClass.GetConnection());
        public frmViewActivityDetails(User objUser, PRPDBatchActivity objPRPDBatchActivity)
        {
            this.objPRPDBatchActivity = objPRPDBatchActivity;
            CurrentUser = objUser;
            InitializeComponent();
        }

        private void frmViewActivityDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (objPRPDBatchActivity != null)
                {
                    MainActivity obj = objMainActivityDL.Get(objPRPDBatchActivity.MainActID);
                    txtActivity.Text = obj.MainActivityTitle;
                    bindDetails.DataSource = objPRPDBatchActivityDetailsDL.GetView(objPRPDBatchActivity.PRPDBatchActivityID);

                    if (obj.Type == MainActivity.LayoutType.Template2)
                    {
                        gvMachines.Enabled = true;
                    }
                    else
                    {
                        gvMachines.Enabled = false;
                    }

  
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this, "Error occured while loading details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

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
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvMachines = new System.Windows.Forms.DataGridView();
            this.bindMachines = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindLabours = new System.Windows.Forms.BindingSource(this.components);
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bindDetails = new System.Windows.Forms.BindingSource(this.components);
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.gvLabours = new System.Windows.Forms.DataGridView();
            this.gvDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLabours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(828, 416);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 114;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 112;
            this.label2.Text = "Labour";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "ActivityDetailsMachineID";
            this.dataGridViewTextBoxColumn10.HeaderText = "ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "StopQty";
            this.dataGridViewTextBoxColumn9.HeaderText = "Stop Qty";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "StartQty";
            this.dataGridViewTextBoxColumn8.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "StopTime";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn7.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Format = "HH:mm";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remarks";
            this.dataGridViewTextBoxColumn5.HeaderText = "Remarks";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 200;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
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
            // gvMachines
            // 
            this.gvMachines.AllowUserToAddRows = false;
            this.gvMachines.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvMachines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.gvMachines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMachines.AutoGenerateColumns = false;
            this.gvMachines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMachines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.gvMachines.DataSource = this.bindMachines;
            this.gvMachines.Location = new System.Drawing.Point(311, 199);
            this.gvMachines.Name = "gvMachines";
            this.gvMachines.ReadOnly = true;
            this.gvMachines.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvMachines.RowTemplate.Height = 18;
            this.gvMachines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvMachines.Size = new System.Drawing.Size(592, 211);
            this.gvMachines.TabIndex = 111;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ActivityDetailsLabourID";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "OTHours";
            this.Column5.HeaderText = "OT Hours";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
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
            // Column7
            // 
            this.Column7.DataPropertyName = "StopQty";
            this.Column7.HeaderText = "Stop Qty";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartQty";
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "StopTime";
            dataGridViewCellStyle4.Format = "HH:mm";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StartTime";
            dataGridViewCellStyle5.Format = "HH:mm";
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn1.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
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
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(47, 1);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.ReadOnly = true;
            this.txtActivity.Size = new System.Drawing.Size(248, 20);
            this.txtActivity.TabIndex = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 108;
            this.label1.Text = "Activity";
            // 
            // colID
            // 
            this.colID.DataPropertyName = "PRPDBatchActDetailsID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 25;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "StopTime";
            dataGridViewCellStyle6.Format = "HH:mm";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "Stop Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "StartTime";
            dataGridViewCellStyle7.Format = "HH:mm";
            dataGridViewCellStyle7.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column3.HeaderText = "Start Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "ActivityDate";
            dataGridViewCellStyle8.Format = "d";
            this.Column6.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column6.HeaderText = "Date";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 113;
            this.label3.Text = "Machine";
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
            this.Column1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Column7,
            this.Column9,
            this.Column5,
            this.dataGridViewTextBoxColumn4});
            this.gvLabours.DataSource = this.bindLabours;
            this.gvLabours.Location = new System.Drawing.Point(311, 27);
            this.gvLabours.Name = "gvLabours";
            this.gvLabours.ReadOnly = true;
            this.gvLabours.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvLabours.RowTemplate.Height = 18;
            this.gvLabours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvLabours.Size = new System.Drawing.Size(592, 153);
            this.gvLabours.TabIndex = 110;
            // 
            // gvDetails
            // 
            this.gvDetails.AllowUserToAddRows = false;
            this.gvDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.gvDetails.AutoGenerateColumns = false;
            this.gvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column3,
            this.Column4,
            this.colID});
            this.gvDetails.DataSource = this.bindDetails;
            this.gvDetails.Location = new System.Drawing.Point(0, 27);
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.ReadOnly = true;
            this.gvDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetails.RowTemplate.Height = 24;
            this.gvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetails.Size = new System.Drawing.Size(295, 386);
            this.gvDetails.TabIndex = 107;
            // 
            // frmViewActivityDetails
            // 
            this.ClientSize = new System.Drawing.Size(906, 442);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvMachines);
            this.Controls.Add(this.txtActivity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gvLabours);
            this.Controls.Add(this.gvDetails);
            this.Name = "frmViewActivityDetails";
            this.Text = "Activity Details";
            ((System.ComponentModel.ISupportInitialize)(this.gvMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindMachines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindLabours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLabours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}