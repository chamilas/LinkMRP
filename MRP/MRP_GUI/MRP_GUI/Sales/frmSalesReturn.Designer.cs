namespace MRP_GUI.Sales
{
    partial class frmSalesReturn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.ItemCodem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RacevQtym = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToStorem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalesType = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTerritory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStore = new System.Windows.Forms.TextBox();
            this.bsFinishProductList = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFinishProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.dgvProduct);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbProduct);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 267);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(709, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(790, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(871, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemCodem,
            this.ItemNane,
            this.RacevQtym,
            this.ToStorem});
            this.dgvProduct.Location = new System.Drawing.Point(6, 49);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(943, 212);
            this.dgvProduct.TabIndex = 10;
            // 
            // ItemCodem
            // 
            this.ItemCodem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemCodem.DataPropertyName = "ItemCode";
            this.ItemCodem.HeaderText = "Item Code";
            this.ItemCodem.Name = "ItemCodem";
            this.ItemCodem.ReadOnly = true;
            // 
            // ItemNane
            // 
            this.ItemNane.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemNane.DataPropertyName = "ItemCode";
            this.ItemNane.HeaderText = "Item";
            this.ItemNane.Name = "ItemNane";
            this.ItemNane.ReadOnly = true;
            // 
            // RacevQtym
            // 
            this.RacevQtym.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RacevQtym.DataPropertyName = "RacevQty";
            this.RacevQtym.HeaderText = "Quantity";
            this.RacevQtym.Name = "RacevQtym";
            this.RacevQtym.ReadOnly = true;
            // 
            // ToStorem
            // 
            this.ToStorem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ToStorem.DataPropertyName = "ToStore";
            this.ToStorem.HeaderText = "Store";
            this.ToStorem.Name = "ToStorem";
            this.ToStorem.ReadOnly = true;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(496, 22);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtQuantity.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantity :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Product Code :";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DisplayMember = "FinishProduct";
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(108, 22);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(324, 21);
            this.cmbProduct.TabIndex = 0;
            this.cmbProduct.ValueMember = "FinishProductCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Product Type :";
            // 
            // txtSalesType
            // 
            this.txtSalesType.Enabled = false;
            this.txtSalesType.Location = new System.Drawing.Point(92, 16);
            this.txtSalesType.Name = "txtSalesType";
            this.txtSalesType.Size = new System.Drawing.Size(200, 20);
            this.txtSalesType.TabIndex = 14;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(453, 16);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(209, 20);
            this.dtDate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "                                  Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Terarory :";
            // 
            // cmbTerritory
            // 
            this.cmbTerritory.DisplayMember = "Name";
            this.cmbTerritory.FormattingEnabled = true;
            this.cmbTerritory.Location = new System.Drawing.Point(92, 71);
            this.cmbTerritory.Name = "cmbTerritory";
            this.cmbTerritory.Size = new System.Drawing.Size(200, 21);
            this.cmbTerritory.TabIndex = 17;
            this.cmbTerritory.ValueMember = "TerritoryID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Store :";
            // 
            // txtStore
            // 
            this.txtStore.Enabled = false;
            this.txtStore.Location = new System.Drawing.Point(453, 42);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(209, 20);
            this.txtStore.TabIndex = 21;
            this.txtStore.Text = "Return_FG";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.Location = new System.Drawing.Point(881, 374);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 22;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Customer :";
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(92, 42);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(200, 21);
            this.cmbCustomer.TabIndex = 24;
            this.cmbCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbCustomer_SelectedIndexChanged);
            // 
            // frmSalesReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 405);
            this.Controls.Add(this.cmbCustomer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTerritory);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSalesType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSalesReturn";
            this.Text = "frmSalesReturn";
            this.Load += new System.EventHandler(this.frmSalesReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFinishProductList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalesType;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTerritory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStore;
        private System.Windows.Forms.BindingSource bsFinishProductList;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCodem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNane;
        private System.Windows.Forms.DataGridViewTextBoxColumn RacevQtym;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToStorem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCustomer;
    }
}