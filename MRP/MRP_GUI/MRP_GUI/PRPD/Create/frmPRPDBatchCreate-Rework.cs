using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SESD.MRP.REF;
using SESD.MRP.DL;
using SESD.MRP.DL.MRPDataSet1TableAdapters;

namespace MRP_GUI
{
    public partial class frmPRPDBatchCreateRework :System.Windows.Forms.Form
    {
        public frmPRPDBatchCreateRework()
        {
            InitializeComponent();
        }
        private Label label33;
        private Button btnClose;
        private DataGridViewTextBoxColumn Instructions;
        private DataGridViewTextBoxColumn Machine;
        private DataGridViewTextBoxColumn PRPDBatchActivityInstructionsID;
        private DataGridViewTextBoxColumn Activity;
        private TextBox txtPRPDBatchInst;
        private Label label12;
        private ComboBox cmbMachine;
        private Label label11;
        private ComboBox cmbActivityID;
        private Label label7;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtInstruction;
        private Label label9;
        private DataGridView dgvActivityInstructions;
        private GroupBox grpActivityInstructions;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btnNew;
        private TextBox txtQuantity;
        private Label label32;
        private Label lblPRPDID;
        private Label label2;
        private Label label1;
        private TextBox txtReworkedAmount;
        private DataGridView dgvMTNDetails;
        private DataGridViewTextBoxColumn MaterialCode;
        private DataGridViewTextBoxColumn MaterialName;
        private DataGridViewTextBoxColumn QuantityReceived;
        private DataGridViewTextBoxColumn Column2;
        private GroupBox groupBox4;
        private Label label10;
        private Button btnCreateBatch;
        private Label label8;
        private TextBox txtNewBatchQuantity;
        private TextBox txtBatchMaterial;
        private Label label6;
        private ComboBox cmbInstructedBy;
        private Label label5;
        private Label label4;
        private TextBox txtMTNNo;
        private Label label3;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Label label17;
        private TextBox textBox4;
        private Label label16;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn Quantity;
        private Label label13;
        private DataGridViewTextBoxColumn BatchCreatedDate;
        private DataGridViewTextBoxColumn PRPDBatchID;
        private DataGridView dgvPRPDBatches;
        private ComboBox cmbMTNList;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private BindingSource objSourceMachine;
        private IContainer components;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

        private User _objCurrentUser;

        public User CurrentUser
        {
            get { return _objCurrentUser; }
            set { _objCurrentUser = value; }
        }

        public frmPRPDBatchCreateRework(User objUser)
        {
            InitializeComponent();
            CurrentUser = objUser;
        }

        //--------------------

        BindingSource objBindingSourceAct = new BindingSource();
        BindingSource objBindingSourcePRPDBatches = new BindingSource();
        BindingSource objBindingSourceMTN = new BindingSource();
      
        
        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());
        MTNMaterial_DL objMTNMaterial_DL = new MTNMaterial_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        Department_DL objDepartment_DL = new Department_DL(ConnectionStringClass.GetConnection());
        TGRN_DL objTGRN_DL = new TGRN_DL(ConnectionStringClass.GetConnection());
        PRPDBatchActivityInstructions_DL objPRPDBatchActivityInstructions_DL = new PRPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());

        DataTable dtWorkEmployees = new DataTable();
        DataTable dtOfficers = new DataTable();
        DataTable dtMTNForRework = new DataTable();
        DataTable dtMTNDetails = new DataTable();
        DataTable dtActivities = new DataTable();
        DataTable dtMachines = new DataTable();
        DataTable dtPRPDBatchActivityInstructions = new DataTable();
        DataTable dtPRPDBatchesOfMTN = new DataTable();

        PRPDBatch objPRPDBatch = new PRPDBatch();
        MTN objMTN = new MTN();
        MTNMaterial objMTNMaterial = new MTNMaterial();

 




        private void frmPRPDReworkBatchCreate_Load(object sender, EventArgs e)
        {
            try
            {
                dtMTNForRework = objMTN_DL.GetDataView(objDepartment_DL.GetByDepType("Store").DepID,  MTN.Status.Received);
            
                cmbMTNList.DataSource = dtMTNForRework;
                if (cmbMTNList.SelectedValue != null)
                {    
                    
                    //TGRN objTGRN = objTGRN_DL.Get( objMTN_DL.Get(Convert.ToInt64(cmbMTNList.SelectedValue)).MTNTGRN.TGRNNO);

                    //txtPONo.Text = objTGRN.TGRNDeleveryNote.DeleveryNotePO.PONO.ToString();
                    //txtSupplierName.Text = objTGRN.TGRNDeleveryNote.DeleveryNotePO.POSupplier.SupplieName;

                   
                    dtMTNDetails= objMTNMaterial_DL.GetDataViewByMTNNO(Convert.ToInt64(cmbMTNList.SelectedValue));

                    dgvActivityInstructions.AutoGenerateColumns = false;
                    dgvActivityInstructions.DataSource = objBindingSourceAct;
                    //objBindingSourceAct.DataSource = dtMTNDetails;
                    //objBindingSourceAct.ResetBindings(true);
                    objBindingSourceAct.DataSource = dtPRPDBatchActivityInstructions;
                    objBindingSourceAct.ResetBindings(true);

                    dtOfficers = objEmployee_DL.Get_By_RoleType("Manager", "Staff", "Production", true);
                    cmbInstructedBy.DataSource = dtOfficers;
                }
                


              

            }
            catch (Exception ex)
            {

                MessageBox.Show(this,ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
            this.label33 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.Instructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchActivityInstructionsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPRPDBatchInst = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbActivityID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvActivityInstructions = new System.Windows.Forms.DataGridView();
            this.grpActivityInstructions = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lblPRPDID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtReworkedAmount = new System.Windows.Forms.TextBox();
            this.dgvMTNDetails = new System.Windows.Forms.DataGridView();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReceived = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCreateBatch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewBatchQuantity = new System.Windows.Forms.TextBox();
            this.txtBatchMaterial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbInstructedBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMTNNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.BatchCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRPDBatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPRPDBatches = new System.Windows.Forms.DataGridView();
            this.cmbMTNList = new System.Windows.Forms.ComboBox();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objSourceMachine = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).BeginInit();
            this.grpActivityInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTNDetails)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDBatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachine)).BeginInit();
            this.SuspendLayout();
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(966, 19);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(139, 39);
            this.label33.TabIndex = 64;
            this.label33.Text = "Rework";
            this.label33.Click += new System.EventHandler(this.label33_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(1052, 584);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 21);
            this.btnClose.TabIndex = 63;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // Instructions
            // 
            this.Instructions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Instructions.DataPropertyName = "InstructionDesc";
            this.Instructions.HeaderText = "Instructions";
            this.Instructions.Name = "Instructions";
            // 
            // Machine
            // 
            this.Machine.DataPropertyName = "MachineName";
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            // 
            // PRPDBatchActivityInstructionsID
            // 
            this.PRPDBatchActivityInstructionsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchActivityInstructionsID.DataPropertyName = "PRPDBatchActivityInstructionsID";
            this.PRPDBatchActivityInstructionsID.HeaderText = "PRPDBatchActivityInstructionsID";
            this.PRPDBatchActivityInstructionsID.Name = "PRPDBatchActivityInstructionsID";
            this.PRPDBatchActivityInstructionsID.Visible = false;
            // 
            // Activity
            // 
            this.Activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Activity.DataPropertyName = "MainActivity";
            this.Activity.HeaderText = "Activity";
            this.Activity.Name = "Activity";
            // 
            // txtPRPDBatchInst
            // 
            this.txtPRPDBatchInst.Enabled = false;
            this.txtPRPDBatchInst.Location = new System.Drawing.Point(90, 26);
            this.txtPRPDBatchInst.Name = "txtPRPDBatchInst";
            this.txtPRPDBatchInst.ReadOnly = true;
            this.txtPRPDBatchInst.Size = new System.Drawing.Size(170, 20);
            this.txtPRPDBatchInst.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Batch No";
            // 
            // cmbMachine
            // 
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(90, 69);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(305, 21);
            this.cmbMachine.Sorted = true;
            this.cmbMachine.TabIndex = 24;
            this.cmbMachine.ValueMember = "MachineID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Machine";
            // 
            // cmbActivityID
            // 
            this.cmbActivityID.DisplayMember = "MainActivity";
            this.cmbActivityID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActivityID.FormattingEnabled = true;
            this.cmbActivityID.Location = new System.Drawing.Point(90, 47);
            this.cmbActivityID.Name = "cmbActivityID";
            this.cmbActivityID.Size = new System.Drawing.Size(305, 21);
            this.cmbActivityID.TabIndex = 22;
            this.cmbActivityID.ValueMember = "MainActID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Activity";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(300, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(90, 91);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstruction.Size = new System.Drawing.Size(305, 73);
            this.txtInstruction.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Instruction";
            // 
            // dgvActivityInstructions
            // 
            this.dgvActivityInstructions.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvActivityInstructions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityInstructions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvActivityInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Activity,
            this.PRPDBatchActivityInstructionsID,
            this.Machine,
            this.Instructions});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivityInstructions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActivityInstructions.Location = new System.Drawing.Point(413, 11);
            this.dgvActivityInstructions.Name = "dgvActivityInstructions";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvActivityInstructions.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvActivityInstructions.RowTemplate.Height = 20;
            this.dgvActivityInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivityInstructions.Size = new System.Drawing.Size(707, 183);
            this.dgvActivityInstructions.TabIndex = 7;
            // 
            // grpActivityInstructions
            // 
            this.grpActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActivityInstructions.Controls.Add(this.txtPRPDBatchInst);
            this.grpActivityInstructions.Controls.Add(this.label12);
            this.grpActivityInstructions.Controls.Add(this.cmbMachine);
            this.grpActivityInstructions.Controls.Add(this.label11);
            this.grpActivityInstructions.Controls.Add(this.cmbActivityID);
            this.grpActivityInstructions.Controls.Add(this.label7);
            this.grpActivityInstructions.Controls.Add(this.btnDelete);
            this.grpActivityInstructions.Controls.Add(this.btnAdd);
            this.grpActivityInstructions.Controls.Add(this.txtInstruction);
            this.grpActivityInstructions.Controls.Add(this.label9);
            this.grpActivityInstructions.Controls.Add(this.dgvActivityInstructions);
            this.grpActivityInstructions.Enabled = false;
            this.grpActivityInstructions.Location = new System.Drawing.Point(11, 378);
            this.grpActivityInstructions.Name = "grpActivityInstructions";
            this.grpActivityInstructions.Size = new System.Drawing.Size(1126, 200);
            this.grpActivityInstructions.TabIndex = 62;
            this.grpActivityInstructions.TabStop = false;
            this.grpActivityInstructions.Text = "Add Instructions";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MTNFromDepID";
            this.dataGridViewTextBoxColumn2.HeaderText = "FromDepartment";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MTNO";
            this.dataGridViewTextBoxColumn1.HeaderText = "MTNNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Location = new System.Drawing.Point(335, 113);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(59, 23);
            this.btnNew.TabIndex = 38;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(286, 42);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(109, 20);
            this.txtQuantity.TabIndex = 37;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(234, 45);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(54, 13);
            this.label32.TabIndex = 36;
            this.label32.Text = "Quantity";
            // 
            // lblPRPDID
            // 
            this.lblPRPDID.AutoSize = true;
            this.lblPRPDID.Location = new System.Drawing.Point(105, 22);
            this.lblPRPDID.Name = "lblPRPDID";
            this.lblPRPDID.Size = new System.Drawing.Size(35, 13);
            this.lblPRPDID.TabIndex = 35;
            this.lblPRPDID.Text = "[Auto]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "<Unit>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "<Unit>";
            // 
            // txtReworkedAmount
            // 
            this.txtReworkedAmount.Enabled = false;
            this.txtReworkedAmount.Location = new System.Drawing.Point(108, 109);
            this.txtReworkedAmount.Name = "txtReworkedAmount";
            this.txtReworkedAmount.Size = new System.Drawing.Size(119, 20);
            this.txtReworkedAmount.TabIndex = 31;
            this.txtReworkedAmount.Text = "0.00";
            // 
            // dgvMTNDetails
            // 
            this.dgvMTNDetails.AllowUserToAddRows = false;
            this.dgvMTNDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMTNDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvMTNDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMTNDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvMTNDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMTNDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialCode,
            this.MaterialName,
            this.QuantityReceived,
            this.Column2});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMTNDetails.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvMTNDetails.Location = new System.Drawing.Point(6, 19);
            this.dgvMTNDetails.Name = "dgvMTNDetails";
            this.dgvMTNDetails.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMTNDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvMTNDetails.RowTemplate.Height = 20;
            this.dgvMTNDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMTNDetails.Size = new System.Drawing.Size(1114, 89);
            this.dgvMTNDetails.TabIndex = 3;
            // 
            // MaterialCode
            // 
            this.MaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialCode.DataPropertyName = "MTNMaterialCode";
            this.MaterialCode.HeaderText = "Material Code";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            // 
            // MaterialName
            // 
            this.MaterialName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialName.DataPropertyName = "MaterialDescription";
            this.MaterialName.FillWeight = 250F;
            this.MaterialName.HeaderText = "MaterialName";
            this.MaterialName.Name = "MaterialName";
            this.MaterialName.ReadOnly = true;
            // 
            // QuantityReceived
            // 
            this.QuantityReceived.DataPropertyName = "MTNRceivedQty";
            this.QuantityReceived.HeaderText = "Quantity";
            this.QuantityReceived.Name = "QuantityReceived";
            this.QuantityReceived.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "MTNDescription";
            this.Column2.FillWeight = 400F;
            this.Column2.HeaderText = "Rework Remarks";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btnNew);
            this.groupBox4.Controls.Add(this.txtQuantity);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.lblPRPDID);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtReworkedAmount);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.btnCreateBatch);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtNewBatchQuantity);
            this.groupBox4.Controls.Add(this.txtBatchMaterial);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cmbInstructedBy);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtMTNNo);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(11, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(400, 171);
            this.groupBox4.TabIndex = 44;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PRPD Batch Details";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Reworked Amount";
            // 
            // btnCreateBatch
            // 
            this.btnCreateBatch.Location = new System.Drawing.Point(335, 137);
            this.btnCreateBatch.Name = "btnCreateBatch";
            this.btnCreateBatch.Size = new System.Drawing.Size(59, 23);
            this.btnCreateBatch.TabIndex = 29;
            this.btnCreateBatch.Text = "Create Batch";
            this.btnCreateBatch.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Batch Quantity";
            // 
            // txtNewBatchQuantity
            // 
            this.txtNewBatchQuantity.Location = new System.Drawing.Point(108, 131);
            this.txtNewBatchQuantity.Name = "txtNewBatchQuantity";
            this.txtNewBatchQuantity.Size = new System.Drawing.Size(119, 20);
            this.txtNewBatchQuantity.TabIndex = 27;
            this.txtNewBatchQuantity.Text = "0.00";
            // 
            // txtBatchMaterial
            // 
            this.txtBatchMaterial.Enabled = false;
            this.txtBatchMaterial.Location = new System.Drawing.Point(108, 64);
            this.txtBatchMaterial.Name = "txtBatchMaterial";
            this.txtBatchMaterial.Size = new System.Drawing.Size(287, 20);
            this.txtBatchMaterial.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "BatchMaterial";
            // 
            // cmbInstructedBy
            // 
            this.cmbInstructedBy.DisplayMember = "EmpName";
            this.cmbInstructedBy.FormattingEnabled = true;
            this.cmbInstructedBy.Location = new System.Drawing.Point(108, 86);
            this.cmbInstructedBy.Name = "cmbInstructedBy";
            this.cmbInstructedBy.Size = new System.Drawing.Size(287, 21);
            this.cmbInstructedBy.TabIndex = 24;
            this.cmbInstructedBy.ValueMember = "EmpID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "InstructedBy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Batch NO";
            // 
            // txtMTNNo
            // 
            this.txtMTNNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMTNNo.Location = new System.Drawing.Point(108, 41);
            this.txtMTNNo.Name = "txtMTNNo";
            this.txtMTNNo.ReadOnly = true;
            this.txtMTNNo.Size = new System.Drawing.Size(111, 20);
            this.txtMTNNo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "MTN NO";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvMTNDetails);
            this.groupBox2.Location = new System.Drawing.Point(10, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1126, 120);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received Items For Rework";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ActivityName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 43);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "Purchase Order No";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(164, 36);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(155, 20);
            this.textBox4.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(381, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Supplier";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(438, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(366, 20);
            this.textBox3.TabIndex = 59;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.DataPropertyName = "PRPDBatchQty";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 17);
            this.label13.TabIndex = 49;
            this.label13.Text = "TMTN For Reworks";
            // 
            // BatchCreatedDate
            // 
            this.BatchCreatedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BatchCreatedDate.DataPropertyName = "PRPDBatchInstructedDate";
            this.BatchCreatedDate.FillWeight = 150F;
            this.BatchCreatedDate.HeaderText = "Batch Created Date";
            this.BatchCreatedDate.Name = "BatchCreatedDate";
            this.BatchCreatedDate.ReadOnly = true;
            // 
            // PRPDBatchID
            // 
            this.PRPDBatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PRPDBatchID.DataPropertyName = "PRPDBatchID";
            this.PRPDBatchID.FillWeight = 200F;
            this.PRPDBatchID.HeaderText = "PRPDBatchID";
            this.PRPDBatchID.Name = "PRPDBatchID";
            this.PRPDBatchID.ReadOnly = true;
            // 
            // dgvPRPDBatches
            // 
            this.dgvPRPDBatches.AllowUserToAddRows = false;
            this.dgvPRPDBatches.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPRPDBatches.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPRPDBatches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPRPDBatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPRPDBatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPRPDBatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PRPDBatchID,
            this.BatchCreatedDate,
            this.Quantity});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPRPDBatches.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPRPDBatches.Location = new System.Drawing.Point(425, 201);
            this.dgvPRPDBatches.Name = "dgvPRPDBatches";
            this.dgvPRPDBatches.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPRPDBatches.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvPRPDBatches.RowTemplate.Height = 20;
            this.dgvPRPDBatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPRPDBatches.Size = new System.Drawing.Size(707, 162);
            this.dgvPRPDBatches.TabIndex = 61;
            // 
            // cmbMTNList
            // 
            this.cmbMTNList.DisplayMember = "MTNNO";
            this.cmbMTNList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMTNList.FormattingEnabled = true;
            this.cmbMTNList.Location = new System.Drawing.Point(164, 6);
            this.cmbMTNList.Name = "cmbMTNList";
            this.cmbMTNList.Size = new System.Drawing.Size(211, 24);
            this.cmbMTNList.TabIndex = 51;
            this.cmbMTNList.ValueMember = "MTNNO";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Instruction";
            this.dataGridViewTextBoxColumn13.HeaderText = "Instructions";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "MachineName";
            this.dataGridViewTextBoxColumn12.HeaderText = "Machine";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ActivityName";
            this.dataGridViewTextBoxColumn11.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MTNDescription";
            this.dataGridViewTextBoxColumn10.HeaderText = "Rework Remarks";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "MTNDescription";
            this.dataGridViewTextBoxColumn9.HeaderText = "Rework Remarks";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn8.HeaderText = "Rework Remarks";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TransferQty";
            this.dataGridViewTextBoxColumn7.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MaterialName";
            this.dataGridViewTextBoxColumn6.HeaderText = "Item";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Instruction";
            this.dataGridViewTextBoxColumn5.HeaderText = "Instructions";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmPRPDBatchCreateRework
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1144, 610);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpActivityInstructions);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgvPRPDBatches);
            this.Controls.Add(this.cmbMTNList);
            this.Name = "frmPRPDBatchCreateRework";
            this.Text = "Rework Batch Create";
            this.Load += new System.EventHandler(this.frmPRPDBatchCreateRework_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).EndInit();
            this.grpActivityInstructions.ResumeLayout(false);
            this.grpActivityInstructions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTNDetails)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPRPDBatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMachine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void frmPRPDBatchCreateRework_Load(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }


    }
}