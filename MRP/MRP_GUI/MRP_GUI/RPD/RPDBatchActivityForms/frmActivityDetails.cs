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
    public partial class frmActivityDetails : System.Windows.Forms.Form
    {
        private RPDBatchActivity_DL objRPDBatchActivityDL = new RPDBatchActivity_DL(ConnectionStringClass.GetConnection());
        private Employee_DL objEmployeeDL = new Employee_DL(ConnectionStringClass.GetConnection());
        private MainActivity_DL objMainActivityDL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        private User _CurrentUser;
        private SESD.MRP.REF.RPDBatchActivity objRPDBatchActivity = new SESD.MRP.REF.RPDBatchActivity();
        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }
        private RPDBatch objRPDBatch = null;
        private RPDBatchActivityDetails objRPDBatchActivityDetails; 
        private RPDBatchActivityDetails_DL objRPDBatchActivityDetailsDL = new RPDBatchActivityDetails_DL(ConnectionStringClass.GetConnection());
        RPDActivityDetailsLabour_DL objRPDActivityDetailsLabour_DL = new RPDActivityDetailsLabour_DL(ConnectionStringClass.GetConnection());
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button btnClear;
        private Button btnDelete;
        private Button btnSave;
        private TextBox txtNoOfTrays;
        private Label label10;
        private TextBox txtSieveSize;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label9;
        private TextBox txtLossQty;
        private TextBox txtFinalQty;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label label8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private Label label7;
        private TextBox txtinitialVol;
        private Label label6;
        private TextBox txtFrequency;
        private Label label5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private BindingSource bindDetails;
        private IContainer components;
        private DateTimePicker dtStopTime;
        private DataGridViewTextBoxColumn Column2;
        private DateTimePicker dtStartTime;
        private Label lblStop;
        private Label label34;
        private TextBox txtComment;
        private Label label4;
        private TextBox txtStopQty;
        private Label lblStopQty;
        private TextBox txtStartQty;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Label label35;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewButtonColumn colMachine;
        private DataGridViewButtonColumn colLabour;
        private DataGridView gvDetails;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtActComments;
        private Label label2;
        private Button btnClose;
        private Label label1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private GroupBox groupBox1;
        private TextBox txtActivity;
        RPDActivityDetailsMachine_DL objRPDActivityDetailsMachine_DL = new RPDActivityDetailsMachine_DL(ConnectionStringClass.GetConnection());

        public frmActivityDetails()
        {
            InitializeComponent();
        }


        public frmActivityDetails(User objUser, RPDBatchActivity objRPDBatchAct)
        {
            objRPDBatchActivity = objRPDBatchAct;
            CurrentUser = objUser;
            InitializeComponent();


        }

        private void frmActivityDetails_Load(object sender, EventArgs e)
        {
            try
            {
                if (objRPDBatchActivity != null)
                {
                    MainActivity obj = objMainActivityDL.Get(objRPDBatchActivity.MainActID);
                    if (obj.Type == MainActivity.LayoutType.Template2)
                    {
                        colMachine.Visible = true;
                    }
                    else
                    {
                        colMachine.Visible = false;
                    }
                    txtActComments.Text = objRPDBatchActivity.Comments;
                    txtActivity.Text = objMainActivityDL.Get(objRPDBatchActivity.MainActID).MainActivityTitle;
                    bindDetails.DataSource = objRPDBatchActivityDetailsDL.GetData(objRPDBatchActivity.RPDBatchActID);
                }
            }
            catch (Exception)
            {

                MessageBox.Show(this,"Error occured while loading details","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void txtStartQty_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void gvDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void Clear()
        {
            txtComment.Text = "";
            txtFinalQty.Text = "0.00";
            txtFrequency.Text = "0.00";
            txtinitialVol.Text = "0.00";
            txtLossQty.Text = "0.00";
            txtNoOfTrays.Text = "0.00";
            txtSieveSize.Text = "";
            txtStartQty.Text = "0.00";
            txtStopQty.Text = "0.00";
            dtStartTime.Value = Convert.ToDateTime("7/15/2009 8:00 AM");
            dtStopTime.Value = Convert.ToDateTime("7/15/2009 5:00 PM");
            objRPDBatchActivityDetails = null;

            lblStop.Visible = false;
            dtStopTime.Visible = false;
            btnDelete.Visible = false;

            lblStopQty.Visible = false;
            txtStopQty.Visible = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNoOfTrays = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSieveSize = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLossQty = new System.Windows.Forms.TextBox();
            this.txtFinalQty = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtinitialVol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindDetails = new System.Windows.Forms.BindingSource(this.components);
            this.dtStopTime = new System.Windows.Forms.DateTimePicker();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblStop = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStopQty = new System.Windows.Forms.TextBox();
            this.lblStopQty = new System.Windows.Forms.Label();
            this.txtStartQty = new System.Windows.Forms.TextBox();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label35 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMachine = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colLabour = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gvDetails = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtActComments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BatchActDetailsID";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 25;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "StartQty";
            dataGridViewCellStyle1.Format = "HH:mm";
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Qty";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(615, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(693, 162);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // txtNoOfTrays
            // 
            this.txtNoOfTrays.Location = new System.Drawing.Point(492, 132);
            this.txtNoOfTrays.Name = "txtNoOfTrays";
            this.txtNoOfTrays.Size = new System.Drawing.Size(93, 20);
            this.txtNoOfTrays.TabIndex = 10;
            this.txtNoOfTrays.Text = "0.00";
            this.txtNoOfTrays.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(424, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 95;
            this.label10.Text = "No of Trays";
            this.label10.Visible = false;
            // 
            // txtSieveSize
            // 
            this.txtSieveSize.Location = new System.Drawing.Point(492, 106);
            this.txtSieveSize.Name = "txtSieveSize";
            this.txtSieveSize.Size = new System.Drawing.Size(93, 20);
            this.txtSieveSize.TabIndex = 9;
            this.txtSieveSize.Text = "N/A";
            this.txtSieveSize.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StopQty";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Stop Qty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StartTime";
            dataGridViewCellStyle2.Format = "HH:mm";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(429, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 93;
            this.label9.Text = "Sieve Size";
            this.label9.Visible = false;
            // 
            // txtLossQty
            // 
            this.txtLossQty.Location = new System.Drawing.Point(492, 84);
            this.txtLossQty.Name = "txtLossQty";
            this.txtLossQty.Size = new System.Drawing.Size(93, 20);
            this.txtLossQty.TabIndex = 8;
            this.txtLossQty.Text = "0.00";
            this.txtLossQty.Visible = false;
            // 
            // txtFinalQty
            // 
            this.txtFinalQty.Location = new System.Drawing.Point(492, 63);
            this.txtFinalQty.Name = "txtFinalQty";
            this.txtFinalQty.Size = new System.Drawing.Size(93, 20);
            this.txtFinalQty.TabIndex = 7;
            this.txtFinalQty.Text = "0.00";
            this.txtFinalQty.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Comments";
            dataGridViewCellStyle3.Format = "HH:mm";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StopTime";
            dataGridViewCellStyle4.Format = "HH:mm";
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "Stop Time";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(415, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Loss Quantity";
            this.label8.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Frequency";
            this.dataGridViewTextBoxColumn8.Frozen = true;
            this.dataGridViewTextBoxColumn8.HeaderText = "Frequency";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(415, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 89;
            this.label7.Text = "Final Quantity";
            this.label7.Visible = false;
            // 
            // txtinitialVol
            // 
            this.txtinitialVol.Location = new System.Drawing.Point(492, 42);
            this.txtinitialVol.Name = "txtinitialVol";
            this.txtinitialVol.Size = new System.Drawing.Size(93, 20);
            this.txtinitialVol.TabIndex = 6;
            this.txtinitialVol.Text = "0.00";
            this.txtinitialVol.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(417, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 87;
            this.label6.Text = "Initial Volume";
            this.label6.Visible = false;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(492, 21);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.Size = new System.Drawing.Size(93, 20);
            this.txtFrequency.TabIndex = 5;
            this.txtFrequency.Text = "0.00";
            this.txtFrequency.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(429, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 85;
            this.label5.Text = "Frequency";
            this.label5.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "InitialVolume";
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Initial Volume";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dtStopTime
            // 
            this.dtStopTime.CustomFormat = "HH:mm";
            this.dtStopTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStopTime.Location = new System.Drawing.Point(80, 115);
            this.dtStopTime.Name = "dtStopTime";
            this.dtStopTime.ShowUpDown = true;
            this.dtStopTime.Size = new System.Drawing.Size(71, 20);
            this.dtStopTime.TabIndex = 2;
            this.dtStopTime.Value = new System.DateTime(2009, 7, 15, 17, 0, 0, 0);
            this.dtStopTime.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StopQty";
            this.Column2.HeaderText = "Stop Qty";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dtStartTime
            // 
            this.dtStartTime.CustomFormat = "HH:mm";
            this.dtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtStartTime.Location = new System.Drawing.Point(80, 89);
            this.dtStartTime.Name = "dtStartTime";
            this.dtStartTime.ShowUpDown = true;
            this.dtStartTime.Size = new System.Drawing.Size(71, 20);
            this.dtStartTime.TabIndex = 1;
            this.dtStartTime.Value = new System.DateTime(2009, 7, 15, 8, 0, 0, 0);
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.Location = new System.Drawing.Point(15, 117);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(55, 13);
            this.lblStop.TabIndex = 81;
            this.lblStop.Text = "Stop Time";
            this.lblStop.Visible = false;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(15, 93);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(55, 13);
            this.label34.TabIndex = 80;
            this.label34.Text = "Start Time";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(80, 20);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(305, 63);
            this.txtComment.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Comment";
            // 
            // txtStopQty
            // 
            this.txtStopQty.Location = new System.Drawing.Point(248, 116);
            this.txtStopQty.Name = "txtStopQty";
            this.txtStopQty.Size = new System.Drawing.Size(93, 20);
            this.txtStopQty.TabIndex = 4;
            this.txtStopQty.Text = "0.00";
            this.txtStopQty.Visible = false;
            // 
            // lblStopQty
            // 
            this.lblStopQty.AutoSize = true;
            this.lblStopQty.Location = new System.Drawing.Point(190, 119);
            this.lblStopQty.Name = "lblStopQty";
            this.lblStopQty.Size = new System.Drawing.Size(48, 13);
            this.lblStopQty.TabIndex = 58;
            this.lblStopQty.Text = "Stop Qty";
            this.lblStopQty.Visible = false;
            // 
            // txtStartQty
            // 
            this.txtStartQty.Location = new System.Drawing.Point(248, 90);
            this.txtStartQty.Name = "txtStartQty";
            this.txtStartQty.Size = new System.Drawing.Size(93, 20);
            this.txtStartQty.TabIndex = 3;
            this.txtStartQty.Text = "0.00";
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "Comments";
            this.Column10.HeaderText = "Comments";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "LossQty";
            this.dataGridViewTextBoxColumn10.Frozen = true;
            this.dataGridViewTextBoxColumn10.HeaderText = "Loss Qty";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.Frozen = true;
            this.dataGridViewTextBoxColumn9.HeaderText = "Final Qty";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "NoOfTrays";
            this.dataGridViewTextBoxColumn12.Frozen = true;
            this.dataGridViewTextBoxColumn12.HeaderText = "No of Trays";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(167, 93);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(71, 13);
            this.label35.TabIndex = 57;
            this.label35.Text = "Start Quantity";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "StartQty";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Start Qty";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "StartTime";
            dataGridViewCellStyle5.Format = "HH:mm";
            dataGridViewCellStyle5.NullValue = null;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Start Time";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "BatchActDetailsID";
            this.colID.Frozen = true;
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            this.colID.Width = 25;
            // 
            // colMachine
            // 
            this.colMachine.Frozen = true;
            this.colMachine.HeaderText = "Machine";
            this.colMachine.Name = "colMachine";
            this.colMachine.ReadOnly = true;
            this.colMachine.Text = "Machine";
            this.colMachine.UseColumnTextForButtonValue = true;
            this.colMachine.Width = 75;
            // 
            // colLabour
            // 
            this.colLabour.Frozen = true;
            this.colLabour.HeaderText = "Labour";
            this.colLabour.Name = "colLabour";
            this.colLabour.ReadOnly = true;
            this.colLabour.Text = "Labour";
            this.colLabour.UseColumnTextForButtonValue = true;
            this.colLabour.Width = 75;
            // 
            // gvDetails
            // 
            this.gvDetails.AllowUserToAddRows = false;
            this.gvDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvDetails.AutoGenerateColumns = false;
            this.gvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLabour,
            this.colMachine,
            this.colID,
            this.Column3,
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column10});
            this.gvDetails.DataSource = this.bindDetails;
            this.gvDetails.Location = new System.Drawing.Point(12, 256);
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.ReadOnly = true;
            this.gvDetails.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvDetails.RowTemplate.Height = 20;
            this.gvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvDetails.Size = new System.Drawing.Size(771, 159);
            this.gvDetails.TabIndex = 20;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StopTime";
            dataGridViewCellStyle7.Format = "HH:mm";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "Stop Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtActComments
            // 
            this.txtActComments.Location = new System.Drawing.Point(354, 6);
            this.txtActComments.Multiline = true;
            this.txtActComments.Name = "txtActComments";
            this.txtActComments.ReadOnly = true;
            this.txtActComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtActComments.Size = new System.Drawing.Size(279, 48);
            this.txtActComments.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Comments";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(708, 421);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Activity";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SieveSize";
            this.dataGridViewTextBoxColumn11.Frozen = true;
            this.dataGridViewTextBoxColumn11.HeaderText = "Sieve Size";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtNoOfTrays);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSieveSize);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtLossQty);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFinalQty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtinitialVol);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFrequency);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtStopTime);
            this.groupBox1.Controls.Add(this.dtStartTime);
            this.groupBox1.Controls.Add(this.lblStop);
            this.groupBox1.Controls.Add(this.label34);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStopQty);
            this.groupBox1.Controls.Add(this.lblStopQty);
            this.groupBox1.Controls.Add(this.txtStartQty);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Location = new System.Drawing.Point(9, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 191);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add/Edit Activity Details";
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(90, 6);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.ReadOnly = true;
            this.txtActivity.Size = new System.Drawing.Size(175, 20);
            this.txtActivity.TabIndex = 17;
            // 
            // frmActivityDetails
            // 
            this.ClientSize = new System.Drawing.Size(793, 451);
            this.Controls.Add(this.gvDetails);
            this.Controls.Add(this.txtActComments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtActivity);
            this.Name = "frmActivityDetails";
            this.Text = "Activity Details";
            ((System.ComponentModel.ISupportInitialize)(this.bindDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}