namespace MRP_GUI.Components.MaterialSelection
{
    partial class MaterialSelect
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtMaterial
            // 
            this.txtMaterial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaterial.Location = new System.Drawing.Point(0, 0);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(280, 20);
            this.txtMaterial.TabIndex = 0;
            this.txtMaterial.TextChanged += new System.EventHandler(this.txtMaterial_TextChanged);
            this.txtMaterial.Click += new System.EventHandler(this.txtMaterial_Click);
            this.txtMaterial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaterial_KeyDown);
            this.txtMaterial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMaterial_KeyUp);
            this.txtMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaterial_KeyPress);
            this.txtMaterial.Enter += new System.EventHandler(this.txtMaterial_Enter);
            // 
            // MaterialSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMaterial);
            this.Name = "MaterialSelect";
            this.Size = new System.Drawing.Size(280, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaterial;
    }
}
