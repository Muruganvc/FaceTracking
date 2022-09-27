namespace FaceTracking
{
    partial class FrmAttendanceView
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
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(466, 73);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(304, 37);
            this.BtnSearch.TabIndex = 16;
            this.BtnSearch.Text = "Search..";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // txtRollNo
            // 
            this.txtRollNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRollNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNo.Location = new System.Drawing.Point(101, 73);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(345, 37);
            this.txtRollNo.TabIndex = 15;
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNo.Location = new System.Drawing.Point(12, 73);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(83, 30);
            this.lblRollNo.TabIndex = 17;
            this.lblRollNo.Text = "Roll No";
            // 
            // FrmAttendanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 670);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblRollNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAttendanceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label lblRollNo;
    }
}