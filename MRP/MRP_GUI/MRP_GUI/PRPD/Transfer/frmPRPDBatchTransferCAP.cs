using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.DL;
using SESD.MRP.REF;


namespace MRP_GUI
{
    public partial class frmPRPDBatchTransferCAP : System.Windows.Forms.Form
    {
        public frmPRPDBatchTransferCAP()
        {
            InitializeComponent();
        }

        public frmPRPDBatchTransferCAP(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }


        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }



        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        TGRN_DL objTGRN_DL = new TGRN_DL(ConnectionStringClass.GetConnection());
        PRPDBatchActivityInstructions_DL objPRPDBatchActivityInstructions_DL = new PRPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());

        PRPDBatch objPRPDBatch = new PRPDBatch();

        DataTable dtPRPDBatches = new DataTable();
        DataTable dtPRPDBatchActivity = new DataTable();
        private GroupBox groupBox6;
        private Label label2;
        private TextBox txtDescription;
        private Label label16;
        private TextBox txtAddedUnitCost;
        private Label label17;
        private TextBox txtAfterReworkQty;
        private Label label18;
        private TextBox txtStopDate;
        private TextBox txtStartDate;
        private TextBox txtInstructedBy;
        private GroupBox groupBox5;
        private DataGridView dgvActivities;
        private DataGridViewTextBoxColumn ActivityName;
        private BindingSource objSourcePRPDBatchActivity;
        private IContainer components;
        private Label lblUnit;
        private Label label12;
        private TextBox txtPRPDBatchQty;
        private Label label8;
        private TextBox txtMaterialCode;
        private TextBox txtMaterialName;
        private Label label7;
        private Button btnClose;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private TextBox txtBatchState;
        private Label label6;
        private Label label9;
        private ComboBox cmbPRPDBatch;
        private TextBox txtMRNo;
        private Label label14;
        private Label label15;
        private Button btnTransfer;
        private Label label1;
        private GroupBox groupBox4;
        private Label label10;
        private GroupBox groupBox3;

        //BindingSource objSourcePRPDBatchActivity = new BindingSource();
        BindingSource objSourcePRPDBatches = new BindingSource();


        private void frmPRPDBatchTransferCAP_Load(object sender, EventArgs e)
        {
            try
            {
                ucProcessedMaterial1.Load_Data(ConnectionStringClass.GetConnection(), txtMaterialCode.Text);

                dtPRPDBatches = objPRPDBatch_DL.GetDataByState(PRPDBatch.PRPDBatchStatus.Cost,PRPDBatch.PRPDType.PrimaryRework);
                if (dtPRPDBatches.Rows.Count != 0)
                {

                    objSourcePRPDBatches.DataSource = dtPRPDBatches;
                    cmbPRPDBatch.DataSource = objSourcePRPDBatches;
                }

                else
                {
                    objSourcePRPDBatches.DataSource = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void cmbPRPDBatch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {



            txtBatchState.Text = "";

            txtMaterialCode.Text = "";
            txtMaterialName.Text = "";

            txtPRPDBatchQty.Text = "";
            txtInstructedBy.Text = "";
            txtAddedUnitCost.Text = "";

            txtAfterReworkQty.Text = "";
            txtDescription.Text = "";
            objSourcePRPDBatchActivity.DataSource = null;
            //try
            //{
            //    ucProcessedMaterial1.Load_Data(ConnectionStringClass.GetConnection(), txtMaterialCode.Text);

            //    dtPRPDBatches = objPRPDBatch_DL.GetDataByState(PRPDBatch.PRPDBatchStatus.Finished, PRPDBatch.PRPDType.PrimaryRework);
            //    if (dtPRPDBatches.Rows.Count != 0)
            //    {

            //        objSourcePRPDBatches.DataSource = dtPRPDBatches;
            //        cmbPRPDBatch.DataSource = objSourcePRPDBatches;
            //    }

            //    else
            //    {
            //        objSourcePRPDBatches = null;
            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message.ToString());
            //}
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddedUnitCost = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAfterReworkQty = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtStopDate = new System.Windows.Forms.TextBox();
            this.txtStartDate = new System.Windows.Forms.TextBox();
            this.txtInstructedBy = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourcePRPDBatchActivity = new System.Windows.Forms.BindingSource(this.components);
            this.lblUnit = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPRPDBatchQty = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaterialCode = new System.Windows.Forms.TextBox();
            this.txtMaterialName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBatchState = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPRPDBatch = new System.Windows.Forms.ComboBox();
            this.txtMRNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePRPDBatchActivity)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.txtDescription);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.txtAddedUnitCost);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.txtAfterReworkQty);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Location = new System.Drawing.Point(12, 317);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(960, 254);
            this.groupBox6.TabIndex = 44;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Final Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "<Unit>";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Control;
            this.txtDescription.Location = new System.Drawing.Point(124, 92);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(507, 52);
            this.txtDescription.TabIndex = 39;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(58, 95);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Description";
            // 
            // txtAddedUnitCost
            // 
            this.txtAddedUnitCost.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddedUnitCost.Location = new System.Drawing.Point(124, 70);
            this.txtAddedUnitCost.Name = "txtAddedUnitCost";
            this.txtAddedUnitCost.Size = new System.Drawing.Size(192, 20);
            this.txtAddedUnitCost.TabIndex = 37;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Added Unit Cost(Rs.)";
            // 
            // txtAfterReworkQty
            // 
            this.txtAfterReworkQty.BackColor = System.Drawing.SystemColors.Control;
            this.txtAfterReworkQty.Location = new System.Drawing.Point(124, 48);
            this.txtAfterReworkQty.Name = "txtAfterReworkQty";
            this.txtAfterReworkQty.Size = new System.Drawing.Size(192, 20);
            this.txtAfterReworkQty.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 53);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "After Rework Qty.";
            // 
            // txtStopDate
            // 
            this.txtStopDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtStopDate.Enabled = false;
            this.txtStopDate.Location = new System.Drawing.Point(124, 156);
            this.txtStopDate.Name = "txtStopDate";
            this.txtStopDate.Size = new System.Drawing.Size(200, 20);
            this.txtStopDate.TabIndex = 44;
            // 
            // txtStartDate
            // 
            this.txtStartDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtStartDate.Enabled = false;
            this.txtStartDate.Location = new System.Drawing.Point(124, 131);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Size = new System.Drawing.Size(200, 20);
            this.txtStartDate.TabIndex = 43;
            // 
            // txtInstructedBy
            // 
            this.txtInstructedBy.Location = new System.Drawing.Point(124, 203);
            this.txtInstructedBy.Name = "txtInstructedBy";
            this.txtInstructedBy.ReadOnly = true;
            this.txtInstructedBy.Size = new System.Drawing.Size(264, 20);
            this.txtInstructedBy.TabIndex = 38;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.dgvActivities);
            this.groupBox5.Location = new System.Drawing.Point(559, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(395, 223);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Processed Activities";
            // 
            // dgvActivities
            // 
            this.dgvActivities.AllowUserToAddRows = false;
            this.dgvActivities.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvActivities.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivities.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivities.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ActivityName});
            this.dgvActivities.DataSource = this.objSourcePRPDBatchActivity;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivities.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActivities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActivities.Location = new System.Drawing.Point(3, 16);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivities.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvActivities.RowTemplate.Height = 20;
            this.dgvActivities.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivities.Size = new System.Drawing.Size(389, 204);
            this.dgvActivities.TabIndex = 0;
            // 
            // ActivityName
            // 
            this.ActivityName.DataPropertyName = "MainActivity";
            this.ActivityName.HeaderText = "ActivityName";
            this.ActivityName.MinimumWidth = 300;
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.ReadOnly = true;
            this.ActivityName.Width = 380;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(330, 181);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(38, 13);
            this.lblUnit.TabIndex = 36;
            this.lblUnit.Text = "<Unit>";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(45, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "Instructed By";
            // 
            // txtPRPDBatchQty
            // 
            this.txtPRPDBatchQty.BackColor = System.Drawing.SystemColors.Control;
            this.txtPRPDBatchQty.Enabled = false;
            this.txtPRPDBatchQty.Location = new System.Drawing.Point(124, 178);
            this.txtPRPDBatchQty.Name = "txtPRPDBatchQty";
            this.txtPRPDBatchQty.Size = new System.Drawing.Size(200, 20);
            this.txtPRPDBatchQty.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "PRPDBatch Qty";
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterialCode.Enabled = false;
            this.txtMaterialCode.Location = new System.Drawing.Point(124, 105);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(148, 20);
            this.txtMaterialCode.TabIndex = 31;
            // 
            // txtMaterialName
            // 
            this.txtMaterialName.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterialName.Enabled = false;
            this.txtMaterialName.Location = new System.Drawing.Point(278, 105);
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.Size = new System.Drawing.Size(275, 20);
            this.txtMaterialName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Material ";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(897, 577);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MainActivity";
            this.dataGridViewTextBoxColumn1.HeaderText = "ActivityName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // txtBatchState
            // 
            this.txtBatchState.BackColor = System.Drawing.SystemColors.Control;
            this.txtBatchState.Enabled = false;
            this.txtBatchState.Location = new System.Drawing.Point(124, 55);
            this.txtBatchState.Name = "txtBatchState";
            this.txtBatchState.Size = new System.Drawing.Size(264, 20);
            this.txtBatchState.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Batch End Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Batch Started Date";
            // 
            // cmbPRPDBatch
            // 
            this.cmbPRPDBatch.DisplayMember = "PRPDBatchID";
            this.cmbPRPDBatch.FormattingEnabled = true;
            this.cmbPRPDBatch.Location = new System.Drawing.Point(124, 29);
            this.cmbPRPDBatch.Name = "cmbPRPDBatch";
            this.cmbPRPDBatch.Size = new System.Drawing.Size(264, 21);
            this.cmbPRPDBatch.TabIndex = 24;
            this.cmbPRPDBatch.ValueMember = "PRPDBatchID";
            // 
            // txtMRNo
            // 
            this.txtMRNo.BackColor = System.Drawing.SystemColors.Control;
            this.txtMRNo.Enabled = false;
            this.txtMRNo.Location = new System.Drawing.Point(124, 80);
            this.txtMRNo.Name = "txtMRNo";
            this.txtMRNo.Size = new System.Drawing.Size(264, 20);
            this.txtMRNo.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 83);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "MR No";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(51, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Batch State";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.ForeColor = System.Drawing.Color.Maroon;
            this.btnTransfer.Location = new System.Drawing.Point(806, 577);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(85, 23);
            this.btnTransfer.TabIndex = 14;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Rework(CAP) - Transfer";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.txtStopDate);
            this.groupBox4.Controls.Add(this.txtStartDate);
            this.groupBox4.Controls.Add(this.txtInstructedBy);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.lblUnit);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtPRPDBatchQty);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtMaterialCode);
            this.groupBox4.Controls.Add(this.txtMaterialName);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtBatchState);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cmbPRPDBatch);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtMRNo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Location = new System.Drawing.Point(12, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(960, 248);
            this.groupBox4.TabIndex = 45;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRPD CAP Batch Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Batch No";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnTransfer);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(978, 606);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transfer Details";
            // 
            // frmPRPDBatchTransferCAP
            // 
            this.ClientSize = new System.Drawing.Size(978, 606);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmPRPDBatchTransferCAP";
            this.Text = "PRPDBatch ( CAP) -Transfer";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourcePRPDBatchActivity)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}