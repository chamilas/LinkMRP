namespace MRP_GUI.Components.EmployeeSelection
{
    partial class frmEmpList
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
            this.txtEmp = new System.Windows.Forms.TextBox();
            this.gvEmp = new System.Windows.Forms.DataGridView();
            this.bindEmp = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmp
            // 
            this.txtEmp.Location = new System.Drawing.Point(0, 0);
            this.txtEmp.Name = "txtEmp";
            this.txtEmp.Size = new System.Drawing.Size(325, 20);
            this.txtEmp.TabIndex = 0;
            // 
            // gvEmp
            // 
            this.gvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmp.Location = new System.Drawing.Point(0, 22);
            this.gvEmp.Name = "gvEmp";
            this.gvEmp.Size = new System.Drawing.Size(350, 188);
            this.gvEmp.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(325, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEmpList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvEmp);
            this.Controls.Add(this.txtEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmpList";
            this.Text = "frmEmpList";
            ((System.ComponentModel.ISupportInitialize)(this.gvEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmp;
        private System.Windows.Forms.DataGridView gvEmp;
        private System.Windows.Forms.BindingSource bindEmp;
        private System.Windows.Forms.Button button1;
    }
}