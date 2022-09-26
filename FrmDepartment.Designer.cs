namespace FaceTracking
{
    partial class FrmDepartment
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
            this.TxtDepartmentName = new System.Windows.Forms.TextBox();
            this.LblDepartmentName = new System.Windows.Forms.Label();
            this.TxtDepartmentCode = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.LblCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtDepartmentName
            // 
            this.TxtDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDepartmentName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepartmentName.Location = new System.Drawing.Point(226, 56);
            this.TxtDepartmentName.Name = "TxtDepartmentName";
            this.TxtDepartmentName.Size = new System.Drawing.Size(369, 37);
            this.TxtDepartmentName.TabIndex = 17;
            // 
            // LblDepartmentName
            // 
            this.LblDepartmentName.AutoSize = true;
            this.LblDepartmentName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartmentName.Location = new System.Drawing.Point(12, 54);
            this.LblDepartmentName.Name = "LblDepartmentName";
            this.LblDepartmentName.Size = new System.Drawing.Size(193, 30);
            this.LblDepartmentName.TabIndex = 19;
            this.LblDepartmentName.Text = "Department Name";
            // 
            // TxtDepartmentCode
            // 
            this.TxtDepartmentCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDepartmentCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepartmentCode.Location = new System.Drawing.Point(226, 109);
            this.TxtDepartmentCode.Name = "TxtDepartmentCode";
            this.TxtDepartmentCode.Size = new System.Drawing.Size(369, 37);
            this.TxtDepartmentCode.TabIndex = 18;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(295, 162);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 44);
            this.btnReset.TabIndex = 22;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(129, 162);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 44);
            this.btnSubmit.TabIndex = 21;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCode.Location = new System.Drawing.Point(12, 109);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(187, 30);
            this.LblCode.TabIndex = 23;
            this.LblCode.Text = "Department Code";
            // 
            // FrmDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 227);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.TxtDepartmentName);
            this.Controls.Add(this.LblDepartmentName);
            this.Controls.Add(this.TxtDepartmentCode);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDepartmentName;
        private System.Windows.Forms.Label LblDepartmentName;
        private System.Windows.Forms.TextBox TxtDepartmentCode;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label LblCode;
    }
}