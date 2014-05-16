namespace MRP_GUI
{
    partial class frmPOFinalize
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
            this.btnDeliveryShedules = new System.Windows.Forms.Button();
            this.gvMaterialList = new System.Windows.Forms.DataGridView();
            this.objSource = new System.Windows.Forms.BindingSource(this.components);
            this.objSourceMaterialList = new System.Windows.Forms.BindingSource(this.components);
            this.gvPOList = new System.Windows.Forms.DataGridView();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.PONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PODate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReqDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaterialCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveredQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeliveryShedules
            // 
            this.btnDeliveryShedules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveryShedules.Location = new System.Drawing.Point(17, 247);
            this.btnDeliveryShedules.Name = "btnDeliveryShedules";
            this.btnDeliveryShedules.Size = new System.Drawing.Size(132, 27);
            this.btnDeliveryShedules.TabIndex = 19;
            this.btnDeliveryShedules.Text = "Delivery Shedules";
            this.btnDeliveryShedules.UseVisualStyleBackColor = true;
            // 
            // gvMaterialList
            // 
            this.gvMaterialList.AllowUserToAddRows = false;
            this.gvMaterialList.AllowUserToDeleteRows = false;
            this.gvMaterialList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMaterialList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMaterialList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialCode,
            this.Description,
            this.POQty,
            this.UnitPrice,
            this.DeliveredQty});
            this.gvMaterialList.Location = new System.Drawing.Point(17, 280);
            this.gvMaterialList.Name = "gvMaterialList";
            this.gvMaterialList.ReadOnly = true;
            this.gvMaterialList.Size = new System.Drawing.Size(843, 207);
            this.gvMaterialList.TabIndex = 13;
            this.gvMaterialList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gvPOList
            // 
            this.gvPOList.AllowUserToAddRows = false;
            this.gvPOList.AllowUserToDeleteRows = false;
            this.gvPOList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPOList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPOList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PONO,
            this.Supplier,
            this.PODate,
            this.ReqDate});
            this.gvPOList.Location = new System.Drawing.Point(17, 12);
            this.gvPOList.Name = "gvPOList";
            this.gvPOList.ReadOnly = true;
            this.gvPOList.Size = new System.Drawing.Size(844, 229);
            this.gvPOList.TabIndex = 21;
            this.gvPOList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPOList_CellClick);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalize.Location = new System.Drawing.Point(730, 247);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(131, 27);
            this.btnFinalize.TabIndex = 22;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // PONO
            // 
            this.PONO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PONO.DataPropertyName = "PONO";
            this.PONO.HeaderText = "PONO";
            this.PONO.Name = "PONO";
            this.PONO.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier.DataPropertyName = "SupName";
            this.Supplier.FillWeight = 200F;
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // PODate
            // 
            this.PODate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PODate.DataPropertyName = "POEnterdDate";
            this.PODate.HeaderText = "PODate";
            this.PODate.Name = "PODate";
            this.PODate.ReadOnly = true;
            // 
            // ReqDate
            // 
            this.ReqDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ReqDate.DataPropertyName = "PORequiredDate";
            this.ReqDate.HeaderText = "Req Date";
            this.ReqDate.Name = "ReqDate";
            this.ReqDate.ReadOnly = true;
            // 
            // MaterialCode
            // 
            this.MaterialCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialCode.DataPropertyName = "MaterialCode";
            this.MaterialCode.HeaderText = "Material Code";
            this.MaterialCode.Name = "MaterialCode";
            this.MaterialCode.ReadOnly = true;
            this.MaterialCode.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Description.DataPropertyName = "Material";
            this.Description.FillWeight = 200F;
            this.Description.HeaderText = "Material";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // POQty
            // 
            this.POQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.POQty.DataPropertyName = "POQty";
            this.POQty.HeaderText = "Req Qty";
            this.POQty.Name = "POQty";
            this.POQty.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // DeliveredQty
            // 
            this.DeliveredQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DeliveredQty.DataPropertyName = "Quantity";
            this.DeliveredQty.HeaderText = "Delivered Qty";
            this.DeliveredQty.Name = "DeliveredQty";
            this.DeliveredQty.ReadOnly = true;
            // 
            // frmPOFinalize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 499);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.gvPOList);
            this.Controls.Add(this.gvMaterialList);
            this.Controls.Add(this.btnDeliveryShedules);
            this.Name = "frmPOFinalize";
            this.Text = "PO- Finalize";
            this.Load += new System.EventHandler(this.POEntering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objSourceMaterialList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPOList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvMaterialList;
        private System.Windows.Forms.BindingSource objSource;
        private System.Windows.Forms.BindingSource objSourceMaterialList;
        private System.Windows.Forms.Button btnDeliveryShedules;
        private System.Windows.Forms.DataGridView gvPOList;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.DataGridViewTextBoxColumn PONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn PODate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReqDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaterialCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn POQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveredQty;
    }
}