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
    public partial class frmPRPDReworkBatchManagement : System.Windows.Forms.Form
    {
        public frmPRPDReworkBatchManagement()
        {
            InitializeComponent();
        }

        public frmPRPDReworkBatchManagement(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }



        private User _CurrentUser;

        public User CurrentUser
        {
            get { return _CurrentUser; }
            set { _CurrentUser = value; }
        }


        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        PRPDBatchActivityInstructions_DL objPRPDBatchActivityInstructions_DL = new PRPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());


        DataTable dtStaff = new DataTable();
        DataTable dtPRPDBatches = new DataTable();
        DataTable dtPRPDBatchInstructions = new DataTable();

        BindingSource objSourcePRPDBatches = new BindingSource();
        private Button btnUpdate;
        private TextBox txtPRPDBatch;
        private Label label12;
        private ComboBox cmbMachine;
        private ComboBox cmbActivity;
        private DataGridViewTextBoxColumn PRPDBatchActivityInstructionsID;
        private DataGridViewTextBoxColumn ActivityName;
        private DataGridViewTextBoxColumn MachineName;
        private DataGridViewTextBoxColumn Instructions;
        private BindingSource objSourceInstructions;
        private Button btnExit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Label label11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Label label7;
        private GroupBox groupBox1;
        private Label label3;
        private Button btnBatchDelete;
        private Button btnApprove;
        private DataGridView dgvPRPDbatchByState;
        private DataGridViewTextBoxColumn PRPDBatchID;
        private DataGridViewTextBoxColumn BatchQty;
        private DataGridViewTextBoxColumn PRPDBatchMaterialCode;
        private DataGridViewTextBoxColumn MTNIN;
        private DataGridViewTextBoxColumn PRPDBatchInstructedBy;
        private ComboBox cmbPRPDBatchStatus;
        private Button btnEditMode;
        private Label label1;
        private GroupBox grpBatchInstructions;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtInstruction;
        private Label label9;
        private DataGridView dgvActivityInstructions;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private IContainer components;
        //BindingSource objSourceInstructions = new BindingSource();
        BindingSource objSourceStaff = new BindingSource();

        private void frmPRPDReworkBatchManagement_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPRPDBatchStatus.DataSource = Enum.GetNames(typeof(PRPDBatch.PRPDBatchStatus));

                dtStaff = objEmployee_DL.Get_By_RoleType("Manager", "Staff", "Production", true);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            
        }


        private void ManageButtons()
        {

            if (cmbPRPDBatchStatus.SelectedValue.ToString() == "Created")
            {
                btnEditMode.Enabled = true;
                btnApprove.Enabled = true;

            }
            else if (cmbPRPDBatchStatus.SelectedValue.ToString() == "Approved")
            {
                btnEditMode.Enabled = true;
                btnApprove.Enabled = false;

            }
            else if (cmbPRPDBatchStatus.SelectedValue.ToString() == "Started")
            {
                btnEditMode.Enabled = true;
                btnApprove.Enabled = false;

            }
            else if (cmbPRPDBatchStatus.SelectedValue.ToString() == "Finished")
            {
                btnEditMode.Enabled = false;
                btnApprove.Enabled = false;

            }
            else
            {
                btnEditMode.Enabled = false;
                btnApprove.Enabled = false;
            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtPRPDBatch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.cmbActivity = new System.Windows.Forms.ComboBox();
            this.PRPDBatchActivityInstructionsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceInstructions = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBatchDelete = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.dgvPRPDbatchByState = new System.Windows.Forms.DataGridView();
            this.PRPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatchQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchMaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MTNIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchInstructedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbPRPDBatchStatus = new System.Windows.Forms.ComboBox();
            this.btnEditMode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBatchInstructions = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvActivityInstructions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceInstructions)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).BeginInit();
            this.grpBatchInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(781, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // txtPRPDBatch
            // 
            this.txtPRPDBatch.Location = new System.Drawing.Point(97, 23);
            this.txtPRPDBatch.Name = "txtPRPDBatch";
            this.txtPRPDBatch.ReadOnly = true;
            this.txtPRPDBatch.Size = new System.Drawing.Size(253, 20);
            this.txtPRPDBatch.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "PRPDBatch ID";
            // 
            // cmbMachine
            // 
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(97, 70);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(253, 21);
            this.cmbMachine.TabIndex = 34;
            this.cmbMachine.ValueMember = "MachineCode";
            // 
            // cmbActivity
            // 
            this.cmbActivity.DisplayMember = "MainActivity";
            this.cmbActivity.FormattingEnabled = true;
            this.cmbActivity.Location = new System.Drawing.Point(97, 47);
            this.cmbActivity.Name = "cmbActivity";
            this.cmbActivity.Size = new System.Drawing.Size(253, 21);
            this.cmbActivity.TabIndex = 32;
            this.cmbActivity.ValueMember = "MainActID";
            // 
            // PRPDBatchActivityInstructionsID
            // 
            this.PRPDBatchActivityInstructionsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchActivityInstructionsID.DataPropertyName = "PRPDBatchActivityInstructionsID";
            this.PRPDBatchActivityInstructionsID.HeaderText = "PRPDBatchActivityInstructionsID";
            this.PRPDBatchActivityInstructionsID.Name = "PRPDBatchActivityInstructionsID";
            this.PRPDBatchActivityInstructionsID.ReadOnly = true;
            this.PRPDBatchActivityInstructionsID.Visible = false;
            // 
            // ActivityName
            // 
            this.ActivityName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ActivityName.DataPropertyName = "MainActivity";
            this.ActivityName.HeaderText = "Activity";
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.ReadOnly = true;
            // 
            // MachineName
            // 
            this.MachineName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MachineName.DataPropertyName = "MachineName";
            this.MachineName.HeaderText = "Machine";
            this.MachineName.Name = "MachineName";
            this.MachineName.ReadOnly = true;
            // 
            // Instructions
            // 
            this.Instructions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Instructions.DataPropertyName = "InstructionDesc";
            this.Instructions.FillWeight = 150F;
            this.Instructions.HeaderText = "Instructions";
            this.Instructions.Name = "Instructions";
            this.Instructions.ReadOnly = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(958, 571);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 29);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PRPDBatchID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PRPDBatchID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PRPDBatchQty";
            this.dataGridViewTextBoxColumn2.HeaderText = "BatchQty";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRPDBatchMaterialCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRPDBatchMaterialCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "MTNIN";
            this.dataGridViewTextBoxColumn4.HeaderText = "TMTN No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PRPDBatchInstructedBy";
            this.dataGridViewTextBoxColumn5.HeaderText = "PRPDBatchInstructedBy";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PRPDBatchActivityInstructionsID";
            this.dataGridViewTextBoxColumn6.HeaderText = "PRPDBatchActivityInstructionsID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MainActivity";
            this.dataGridViewTextBoxColumn7.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Machine";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "InstructionDesc";
            this.dataGridViewTextBoxColumn9.FillWeight = 150F;
            this.dataGridViewTextBoxColumn9.HeaderText = "Instructions";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Activity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBatchDelete);
            this.groupBox1.Controls.Add(this.btnApprove);
            this.groupBox1.Controls.Add(this.dgvPRPDbatchByState);
            this.groupBox1.Controls.Add(this.cmbPRPDBatchStatus);
            this.groupBox1.Controls.Add(this.btnEditMode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.grpBatchInstructions);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 606);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 48;
            this.label3.Text = "Rework";
            // 
            // btnBatchDelete
            // 
            this.btnBatchDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBatchDelete.BackColor = System.Drawing.Color.Gray;
            this.btnBatchDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnBatchDelete.Location = new System.Drawing.Point(6, 571);
            this.btnBatchDelete.Name = "btnBatchDelete";
            this.btnBatchDelete.Size = new System.Drawing.Size(128, 29);
            this.btnBatchDelete.TabIndex = 46;
            this.btnBatchDelete.Text = "Delete Batch";
            this.btnBatchDelete.UseVisualStyleBackColor = false;
            // 
            // btnApprove
            // 
            this.btnApprove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApprove.Enabled = false;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.Maroon;
            this.btnApprove.Location = new System.Drawing.Point(852, 571);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(103, 29);
            this.btnApprove.TabIndex = 31;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // dgvPRPDbatchByState
            // 
            this.dgvPRPDbatchByState.AllowUserToAddRows = false;
            this.dgvPRPDbatchByState.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPRPDbatchByState.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPRPDbatchByState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPRPDbatchByState.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPRPDbatchByState.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRPDbatchByState.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRPDBatchID,
            this.BatchQty,
            this.PRPDBatchMaterialCode,
            this.MTNIN,
            this.PRPDBatchInstructedBy});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPRPDbatchByState.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPRPDbatchByState.Location = new System.Drawing.Point(12, 84);
            this.dgvPRPDbatchByState.Name = "dgvPRPDbatchByState";
            this.dgvPRPDbatchByState.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPRPDbatchByState.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPRPDbatchByState.RowTemplate.Height = 20;
            this.dgvPRPDbatchByState.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRPDbatchByState.Size = new System.Drawing.Size(1020, 147);
            this.dgvPRPDbatchByState.TabIndex = 30;
            // 
            // PRPDBatchID
            // 
            this.PRPDBatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchID.DataPropertyName = "PRPDBatchID";
            this.PRPDBatchID.HeaderText = "PRPDBatchID";
            this.PRPDBatchID.Name = "PRPDBatchID";
            this.PRPDBatchID.ReadOnly = true;
            // 
            // BatchQty
            // 
            this.BatchQty.DataPropertyName = "PRPDBatchQty";
            this.BatchQty.HeaderText = "BatchQty";
            this.BatchQty.Name = "BatchQty";
            this.BatchQty.ReadOnly = true;
            // 
            // PRPDBatchMaterialCode
            // 
            this.PRPDBatchMaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchMaterialCode.DataPropertyName = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.HeaderText = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.Name = "PRPDBatchMaterialCode";
            this.PRPDBatchMaterialCode.ReadOnly = true;
            // 
            // MTNIN
            // 
            this.MTNIN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MTNIN.DataPropertyName = "MTNIN";
            this.MTNIN.HeaderText = "TMTN No";
            this.MTNIN.Name = "MTNIN";
            this.MTNIN.ReadOnly = true;
            // 
            // PRPDBatchInstructedBy
            // 
            this.PRPDBatchInstructedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchInstructedBy.DataPropertyName = "PRPDBatchInstructedBy";
            this.PRPDBatchInstructedBy.HeaderText = "PRPDBatchInstructedBy";
            this.PRPDBatchInstructedBy.Name = "PRPDBatchInstructedBy";
            this.PRPDBatchInstructedBy.ReadOnly = true;
            // 
            // cmbPRPDBatchStatus
            // 
            this.cmbPRPDBatchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPRPDBatchStatus.FormattingEnabled = true;
            this.cmbPRPDBatchStatus.Location = new System.Drawing.Point(138, 57);
            this.cmbPRPDBatchStatus.Name = "cmbPRPDBatchStatus";
            this.cmbPRPDBatchStatus.Size = new System.Drawing.Size(224, 21);
            this.cmbPRPDBatchStatus.TabIndex = 28;
            // 
            // btnEditMode
            // 
            this.btnEditMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditMode.Location = new System.Drawing.Point(952, 237);
            this.btnEditMode.Name = "btnEditMode";
            this.btnEditMode.Size = new System.Drawing.Size(80, 23);
            this.btnEditMode.TabIndex = 29;
            this.btnEditMode.Text = "Edit Mode";
            this.btnEditMode.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "PRPDBatch Status";
            // 
            // grpBatchInstructions
            // 
            this.grpBatchInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBatchInstructions.Controls.Add(this.btnUpdate);
            this.grpBatchInstructions.Controls.Add(this.txtPRPDBatch);
            this.grpBatchInstructions.Controls.Add(this.label12);
            this.grpBatchInstructions.Controls.Add(this.cmbMachine);
            this.grpBatchInstructions.Controls.Add(this.label11);
            this.grpBatchInstructions.Controls.Add(this.cmbActivity);
            this.grpBatchInstructions.Controls.Add(this.label7);
            this.grpBatchInstructions.Controls.Add(this.btnDelete);
            this.grpBatchInstructions.Controls.Add(this.btnAdd);
            this.grpBatchInstructions.Controls.Add(this.txtInstruction);
            this.grpBatchInstructions.Controls.Add(this.label9);
            this.grpBatchInstructions.Controls.Add(this.dgvActivityInstructions);
            this.grpBatchInstructions.Enabled = false;
            this.grpBatchInstructions.Location = new System.Drawing.Point(12, 266);
            this.grpBatchInstructions.Name = "grpBatchInstructions";
            this.grpBatchInstructions.Size = new System.Drawing.Size(1026, 305);
            this.grpBatchInstructions.TabIndex = 23;
            this.grpBatchInstructions.TabStop = false;
            this.grpBatchInstructions.Text = "Batch Instructions";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(781, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(781, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(427, 20);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstruction.Size = new System.Drawing.Size(348, 68);
            this.txtInstruction.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(365, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Instruction";
            // 
            // dgvActivityInstructions
            // 
            this.dgvActivityInstructions.AllowUserToAddRows = false;
            this.dgvActivityInstructions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvActivityInstructions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivityInstructions.AutoGenerateColumns = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityInstructions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvActivityInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRPDBatchActivityInstructionsID,
            this.ActivityName,
            this.MachineName,
            this.Instructions});
            this.dgvActivityInstructions.DataSource = this.objSourceInstructions;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivityInstructions.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvActivityInstructions.Location = new System.Drawing.Point(6, 97);
            this.dgvActivityInstructions.Name = "dgvActivityInstructions";
            this.dgvActivityInstructions.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityInstructions.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvActivityInstructions.RowTemplate.Height = 20;
            this.dgvActivityInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivityInstructions.Size = new System.Drawing.Size(1014, 202);
            this.dgvActivityInstructions.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn8.HeaderText = "Machine";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // frmPRPDReworkBatchManagement
            // 
            this.ClientSize = new System.Drawing.Size(1044, 606);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPRPDReworkBatchManagement";
            this.Text = "Rework Batch Management";
            ((System.ComponentModel.ISupportInitialize)(this.objSourceInstructions)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDbatchByState)).EndInit();
            this.grpBatchInstructions.ResumeLayout(false);
            this.grpBatchInstructions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).EndInit();
            this.ResumeLayout(false);

        }


            
       
    }
}