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
    public partial class frmPRPDBatchCreateCAP : System.Windows.Forms.Form
    {
        public frmPRPDBatchCreateCAP()
        {
            InitializeComponent();
        }

        public frmPRPDBatchCreateCAP(User objUser)
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

        Material objMaterial;
        PRPDBatch_DL objPRPDBatch_DL = new PRPDBatch_DL(ConnectionStringClass.GetConnection());
        Material_DL objMaterial_DL = new Material_DL(ConnectionStringClass.GetConnection());
        Employee_DL objEmployee_DL = new Employee_DL(ConnectionStringClass.GetConnection());
        RPDActivityMachine_DL objRPDActivityMachine_DL = new RPDActivityMachine_DL(ConnectionStringClass.GetConnection());
        MainActivity_DL objMainActivity_DL = new MainActivity_DL(ConnectionStringClass.GetConnection());
        Machine_DL objMachine_DL = new Machine_DL(ConnectionStringClass.GetConnection());
        PRPDBatchActivityInstructions_DL objPRPDBatchActivityInstructions_DL = new PRPDBatchActivityInstructions_DL(ConnectionStringClass.GetConnection());
        MachineActivity_DL objMachineActivity_DL = new MachineActivity_DL(ConnectionStringClass.GetConnection());
        MTN_DL objMTN_DL = new MTN_DL(ConnectionStringClass.GetConnection());
        MTNMaterial_DL objMTNMaterial_DL = new MTNMaterial_DL(ConnectionStringClass.GetConnection());

        DataTable dtMaterials = new DataTable();
        DataTable dtEmployees = new DataTable();
        DataTable dtActivityMachine = new DataTable();
        DataTable bdtStores = new DataTable();
        DataTable dtMTN = new DataTable();

        RPDActivityMachineCollec objRPDActivityMachineCollec = new RPDActivityMachineCollec();
        PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec objPRPDBatchActivityInstructionsCollec = new PRPDBatchActivityInstructions.PRPDBatchActivityInstructionsCollec();

        BindingSource objSource = new BindingSource();
        Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
        private Label lblUnit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private ComboBox cmbMachine;
        private Label label11;
        private ComboBox cmbActivityID;
        private Label label7;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtInstruction;
        private Label label9;
        private DataGridView dgvActivityInstructions;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn Machine;
        private DataGridViewTextBoxColumn Instructions;
        private Label label3;
        private GroupBox groupBox2;
        private Label lblUnit3;
        private TextBox txtReworkAmount;
        private Label label12;
        private TextBox txtMaterialCode;
        private Label label10;
        private ComboBox cmbMTN;
        private Label lblUnit2;
        private TextBox txtQuantity;
        private Label label6;
        private TextBox txtMaterial;
        private Label label2;
        private Label label1;
        private BindingSource objSourceCAP;
        private IContainer components;
        private BindingSource objSourceMTN;
        private Label lblPRPDBatch;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Label label4;
        private GroupBox groupBox4;
        private GroupBox grpActivityInstructions;
        private Label label8;
        private ComboBox cmbInstructedBy;
        private Label label5;
        private TextBox txtNewBatchQuantity;
        private GroupBox groupBox1;
        private Button btnSave;
        private Button btnExit;

        Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void frmPRPDBatchCreateCAP_Load(object sender, EventArgs e)
        {

            try
            {
                dtMaterials = objMaterial_DL.GetDataView(Convert.ToInt32(SESD.MRP.REF.Material.Status.Enable));
                dtEmployees = objEmployee_DL.Get_By_RoleType("Manager", "Staff","Production", true);
                dtActivityMachine = objMachineActivity_DL.GetDataByAct(Convert.ToInt64(cmbActivityID.SelectedValue));


                cmbInstructedBy.DataSource = dtEmployees;


                //Load Activity
                Department objDep = objDepDL.GetByDepType("PRPD");

                cmbActivityID.DataSource = objMainActivity_DL.GetByDepID(objDepDL.GetByDepType("PRPD").DepID);
                cmbActivityID.DisplayMember = "MainActivity";
                cmbActivityID.ValueMember = "MainActID";

                //Load CAPRework

                dtMTN=objMTN_DL.GetDataViewByStateAndType(MTN.Status.Received, MTN.Type.PRPDCAPBatch);


                objSourceMTN.DataSource = dtMTN;
                cmbMTN.DataSource = objSourceMTN;




            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbActivityID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public long GenerateMR(PRPDBatch objPRPD)
        {
            MR objMR = new MR();
            MRMaterialCollec objMRMatCollec = new MRMaterialCollec();
            MRFinishProductCollec objMRFinishProductCollec = new MRFinishProductCollec();
            MRBasicProductCollec objMRBasicProductCollec = new MRBasicProductCollec();
            BatchMR objBatchMR = new BatchMR();
            Department_DL objDepDL = new Department_DL(ConnectionStringClass.GetConnection());
            MR_DL objMRDL = new MR_DL(ConnectionStringClass.GetConnection());
            MRMaterial_DL objMRMaterialDL = new MRMaterial_DL(ConnectionStringClass.GetConnection());
            Store_DL objStoreDL = new Store_DL(ConnectionStringClass.GetConnection());
            try
            {

                objMR.MRDate = DateTime.Now;
                objMR.MRDepartmentFrom = objDepDL.GetByDepType("PRPD");
                objMR.MREnterdBy = CurrentUser.UserEmp;
                objMR.MRStatus = MR.Status.Initial;
               // Store objStore = (Store)cmbStores.SelectedItem;
                //objMR.MRStore = objStoreDL.Get(objStore.StoreID);
                objMR.MRType = MR.Type.Material;
                objMR.MRRemarks = "Material Requition(Materials) for PRPD Batch NO " + objPRPD.PRPDBatchID.ToString();

                MRMaterial obj = new MRMaterial();
                obj.Description = "PRPD Batch Material Requition";
                obj.Material = objPRPD.PRPDBatchMaterial;
                obj.MRBINNo = "";
                obj.ReqdQty = objPRPD.PRPDBatchQty;

                long MRNO = objMRDL.Add(objMR);
                if (MRNO > 0)
                {
                    objMR.MRNO = MRNO;
                    obj.MR = objMR;
                    objMRMaterialDL.Add(obj);





                }
                return MRNO;


            }
            catch (Exception ex)
            {

                return 0;
            }

        }

        private void cmbMTN_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblUnit = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMachine = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbActivityID = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInstruction = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvActivityInstructions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblUnit3 = new System.Windows.Forms.Label();
            this.txtReworkAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaterialCode = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMTN = new System.Windows.Forms.ComboBox();
            this.lblUnit2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.objSourceCAP = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMTN = new System.Windows.Forms.BindingSource(this.components);
            this.lblPRPDBatch = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grpActivityInstructions = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbInstructedBy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewBatchQuantity = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMTN)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grpActivityInstructions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(777, 159);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(32, 13);
            this.lblUnit.TabIndex = 33;
            this.lblUnit.Text = "[Unit]";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ActivityName";
            this.dataGridViewTextBoxColumn1.FillWeight = 150F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // cmbMachine
            // 
            this.cmbMachine.DisplayMember = "MachineName";
            this.cmbMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMachine.FormattingEnabled = true;
            this.cmbMachine.Location = new System.Drawing.Point(101, 47);
            this.cmbMachine.Name = "cmbMachine";
            this.cmbMachine.Size = new System.Drawing.Size(336, 21);
            this.cmbMachine.TabIndex = 24;
            this.cmbMachine.ValueMember = "MachineID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 49);
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
            this.cmbActivityID.Location = new System.Drawing.Point(101, 20);
            this.cmbActivityID.Name = "cmbActivityID";
            this.cmbActivityID.Size = new System.Drawing.Size(336, 21);
            this.cmbActivityID.TabIndex = 22;
            this.cmbActivityID.ValueMember = "MainActID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Activity";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(866, 300);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(463, 116);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add ";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtInstruction
            // 
            this.txtInstruction.Location = new System.Drawing.Point(101, 74);
            this.txtInstruction.Multiline = true;
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInstruction.Size = new System.Drawing.Size(336, 65);
            this.txtInstruction.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Instruction";
            // 
            // dgvActivityInstructions
            // 
            this.dgvActivityInstructions.AllowUserToAddRows = false;
            this.dgvActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvActivityInstructions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivityInstructions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.Machine,
            this.Instructions});
            this.dgvActivityInstructions.Location = new System.Drawing.Point(6, 144);
            this.dgvActivityInstructions.Name = "dgvActivityInstructions";
            this.dgvActivityInstructions.RowTemplate.Height = 23;
            this.dgvActivityInstructions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActivityInstructions.Size = new System.Drawing.Size(955, 148);
            this.dgvActivityInstructions.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ActivityName";
            this.dataGridViewTextBoxColumn3.FillWeight = 150F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Activity";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Machine
            // 
            this.Machine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Machine.DataPropertyName = "MachineName";
            this.Machine.HeaderText = "Machine";
            this.Machine.Name = "Machine";
            // 
            // Instructions
            // 
            this.Instructions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Instructions.DataPropertyName = "InstructionDesc";
            this.Instructions.FillWeight = 150F;
            this.Instructions.HeaderText = "Instructions";
            this.Instructions.Name = "Instructions";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 39);
            this.label3.TabIndex = 42;
            this.label3.Text = "Rework - CAP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblUnit3);
            this.groupBox2.Controls.Add(this.txtReworkAmount);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMaterialCode);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cmbMTN);
            this.groupBox2.Controls.Add(this.lblUnit2);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMaterial);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(532, 151);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CAP Rework";
            // 
            // lblUnit3
            // 
            this.lblUnit3.AutoSize = true;
            this.lblUnit3.Location = new System.Drawing.Point(245, 122);
            this.lblUnit3.Name = "lblUnit3";
            this.lblUnit3.Size = new System.Drawing.Size(32, 13);
            this.lblUnit3.TabIndex = 12;
            this.lblUnit3.Text = "[Unit]";
            // 
            // txtReworkAmount
            // 
            this.txtReworkAmount.BackColor = System.Drawing.SystemColors.Control;
            this.txtReworkAmount.Enabled = false;
            this.txtReworkAmount.Location = new System.Drawing.Point(110, 119);
            this.txtReworkAmount.Name = "txtReworkAmount";
            this.txtReworkAmount.Size = new System.Drawing.Size(129, 20);
            this.txtReworkAmount.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Rework Amount";
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterialCode.Enabled = false;
            this.txtMaterialCode.Location = new System.Drawing.Point(110, 47);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(394, 20);
            this.txtMaterialCode.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Material Code";
            // 
            // cmbMTN
            // 
            this.cmbMTN.DisplayMember = "MTNNo";
            this.cmbMTN.FormattingEnabled = true;
            this.cmbMTN.Location = new System.Drawing.Point(110, 23);
            this.cmbMTN.Name = "cmbMTN";
            this.cmbMTN.Size = new System.Drawing.Size(201, 21);
            this.cmbMTN.TabIndex = 7;
            this.cmbMTN.ValueMember = "MTNNo";
            // 
            // lblUnit2
            // 
            this.lblUnit2.AutoSize = true;
            this.lblUnit2.Location = new System.Drawing.Point(245, 96);
            this.lblUnit2.Name = "lblUnit2";
            this.lblUnit2.Size = new System.Drawing.Size(32, 13);
            this.lblUnit2.TabIndex = 6;
            this.lblUnit2.Text = "[Unit]";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(110, 93);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(129, 20);
            this.txtQuantity.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Quantity";
            // 
            // txtMaterial
            // 
            this.txtMaterial.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaterial.Enabled = false;
            this.txtMaterial.Location = new System.Drawing.Point(110, 70);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(394, 20);
            this.txtMaterial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Material Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAP Note";
            // 
            // lblPRPDBatch
            // 
            this.lblPRPDBatch.AutoSize = true;
            this.lblPRPDBatch.Location = new System.Drawing.Point(106, 12);
            this.lblPRPDBatch.Name = "lblPRPDBatch";
            this.lblPRPDBatch.Size = new System.Drawing.Size(35, 13);
            this.lblPRPDBatch.TabIndex = 38;
            this.lblPRPDBatch.Text = "[Auto]";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MachineCode";
            this.dataGridViewTextBoxColumn2.HeaderText = "Machine";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "PRPDBatchID";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.lblPRPDBatch);
            this.groupBox4.Controls.Add(this.lblUnit);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.grpActivityInstructions);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cmbInstructedBy);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtNewBatchQuantity);
            this.groupBox4.Location = new System.Drawing.Point(12, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(982, 550);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Batch";
            // 
            // grpActivityInstructions
            // 
            this.grpActivityInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpActivityInstructions.Controls.Add(this.cmbMachine);
            this.grpActivityInstructions.Controls.Add(this.label11);
            this.grpActivityInstructions.Controls.Add(this.cmbActivityID);
            this.grpActivityInstructions.Controls.Add(this.label7);
            this.grpActivityInstructions.Controls.Add(this.btnDelete);
            this.grpActivityInstructions.Controls.Add(this.btnAdd);
            this.grpActivityInstructions.Controls.Add(this.txtInstruction);
            this.grpActivityInstructions.Controls.Add(this.label9);
            this.grpActivityInstructions.Controls.Add(this.dgvActivityInstructions);
            this.grpActivityInstructions.Location = new System.Drawing.Point(6, 201);
            this.grpActivityInstructions.Name = "grpActivityInstructions";
            this.grpActivityInstructions.Size = new System.Drawing.Size(967, 341);
            this.grpActivityInstructions.TabIndex = 8;
            this.grpActivityInstructions.TabStop = false;
            this.grpActivityInstructions.Text = "Add Instructions";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "New Batch Quantity";
            // 
            // cmbInstructedBy
            // 
            this.cmbInstructedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbInstructedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInstructedBy.DisplayMember = "EmpName";
            this.cmbInstructedBy.FormattingEnabled = true;
            this.cmbInstructedBy.Location = new System.Drawing.Point(652, 133);
            this.cmbInstructedBy.Name = "cmbInstructedBy";
            this.cmbInstructedBy.Size = new System.Drawing.Size(321, 21);
            this.cmbInstructedBy.TabIndex = 24;
            this.cmbInstructedBy.ValueMember = "EmpID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "InstructedBy";
            // 
            // txtNewBatchQuantity
            // 
            this.txtNewBatchQuantity.Location = new System.Drawing.Point(652, 156);
            this.txtNewBatchQuantity.Name = "txtNewBatchQuantity";
            this.txtNewBatchQuantity.Size = new System.Drawing.Size(119, 20);
            this.txtNewBatchQuantity.TabIndex = 27;
            this.txtNewBatchQuantity.Text = "0.00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 605);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(810, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 23);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Create Batch";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(919, 576);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmPRPDBatchCreateCAP
            // 
            this.ClientSize = new System.Drawing.Size(1006, 605);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPRPDBatchCreateCAP";
            this.Text = "PRPDBatch Create - CAP";
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityInstructions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceCAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMTN)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grpActivityInstructions.ResumeLayout(false);
            this.grpActivityInstructions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}