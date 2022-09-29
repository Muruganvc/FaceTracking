﻿namespace FaceTracking
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
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.rBtnAll = new System.Windows.Forms.RadioButton();
            this.rbtnPresence = new System.Windows.Forms.RadioButton();
            this.rBtnAbsence = new System.Windows.Forms.RadioButton();
            this.Rollno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblPresence = new System.Windows.Forms.Label();
            this.LblAbsence = new System.Windows.Forms.Label();
            this.DtFrom = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.DtTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(486, 116);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(304, 39);
            this.BtnSearch.TabIndex = 16;
            this.BtnSearch.Text = "Search..";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtRollNo
            // 
            this.txtRollNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRollNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNo.Location = new System.Drawing.Point(101, 78);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(360, 37);
            this.txtRollNo.TabIndex = 15;
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNo.Location = new System.Drawing.Point(12, 80);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(83, 30);
            this.lblRollNo.TabIndex = 17;
            this.lblRollNo.Text = "Roll No";
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rollno,
            this.FirstName,
            this.Lastname,
            this.DepartmentCode,
            this.EntryDate,
            this.Flag});
            this.dgvAttendance.Location = new System.Drawing.Point(17, 165);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 62;
            this.dgvAttendance.RowTemplate.Height = 28;
            this.dgvAttendance.Size = new System.Drawing.Size(1159, 383);
            this.dgvAttendance.TabIndex = 18;
            this.dgvAttendance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAttendance_CellFormatting);
            // 
            // rBtnAll
            // 
            this.rBtnAll.AutoSize = true;
            this.rBtnAll.Checked = true;
            this.rBtnAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnAll.Location = new System.Drawing.Point(486, 34);
            this.rBtnAll.Name = "rBtnAll";
            this.rBtnAll.Size = new System.Drawing.Size(62, 34);
            this.rBtnAll.TabIndex = 19;
            this.rBtnAll.TabStop = true;
            this.rBtnAll.Text = "All";
            this.rBtnAll.UseVisualStyleBackColor = true;
            // 
            // rbtnPresence
            // 
            this.rbtnPresence.AutoSize = true;
            this.rbtnPresence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPresence.Location = new System.Drawing.Point(486, 73);
            this.rbtnPresence.Name = "rbtnPresence";
            this.rbtnPresence.Size = new System.Drawing.Size(125, 34);
            this.rbtnPresence.TabIndex = 20;
            this.rbtnPresence.Text = "Presence";
            this.rbtnPresence.UseVisualStyleBackColor = true;
            // 
            // rBtnAbsence
            // 
            this.rBtnAbsence.AutoSize = true;
            this.rBtnAbsence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnAbsence.Location = new System.Drawing.Point(617, 76);
            this.rBtnAbsence.Name = "rBtnAbsence";
            this.rBtnAbsence.Size = new System.Drawing.Size(120, 34);
            this.rBtnAbsence.TabIndex = 21;
            this.rBtnAbsence.Text = "Absence";
            this.rBtnAbsence.UseVisualStyleBackColor = true;
            // 
            // Rollno
            // 
            this.Rollno.DataPropertyName = "RollNumber";
            this.Rollno.HeaderText = "Rollno";
            this.Rollno.MinimumWidth = 8;
            this.Rollno.Name = "Rollno";
            this.Rollno.ReadOnly = true;
            this.Rollno.Width = 150;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.MinimumWidth = 8;
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 150;
            // 
            // Lastname
            // 
            this.Lastname.DataPropertyName = "Lastname";
            this.Lastname.HeaderText = "Last Name";
            this.Lastname.MinimumWidth = 8;
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Width = 150;
            // 
            // DepartmentCode
            // 
            this.DepartmentCode.DataPropertyName = "DepartmentCode";
            this.DepartmentCode.HeaderText = "Department Code";
            this.DepartmentCode.MinimumWidth = 8;
            this.DepartmentCode.Name = "DepartmentCode";
            this.DepartmentCode.ReadOnly = true;
            this.DepartmentCode.Width = 150;
            // 
            // EntryDate
            // 
            this.EntryDate.DataPropertyName = "EntryDate";
            this.EntryDate.HeaderText = "Entry Date";
            this.EntryDate.MinimumWidth = 8;
            this.EntryDate.Name = "EntryDate";
            this.EntryDate.ReadOnly = true;
            this.EntryDate.Width = 150;
            // 
            // Flag
            // 
            this.Flag.DataPropertyName = "Type";
            this.Flag.HeaderText = "Attendance";
            this.Flag.MinimumWidth = 8;
            this.Flag.Name = "Flag";
            this.Flag.ReadOnly = true;
            this.Flag.Width = 150;
            // 
            // LblPresence
            // 
            this.LblPresence.AutoSize = true;
            this.LblPresence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPresence.Location = new System.Drawing.Point(12, 591);
            this.LblPresence.Name = "LblPresence";
            this.LblPresence.Size = new System.Drawing.Size(0, 30);
            this.LblPresence.TabIndex = 22;
            // 
            // LblAbsence
            // 
            this.LblAbsence.AutoSize = true;
            this.LblAbsence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbsence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblAbsence.Location = new System.Drawing.Point(548, 591);
            this.LblAbsence.Name = "LblAbsence";
            this.LblAbsence.Size = new System.Drawing.Size(0, 30);
            this.LblAbsence.TabIndex = 23;
            // 
            // DtFrom
            // 
            this.DtFrom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtFrom.Location = new System.Drawing.Point(101, 31);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Size = new System.Drawing.Size(156, 37);
            this.DtFrom.TabIndex = 24;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 31);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(64, 30);
            this.lblDateOfBirth.TabIndex = 25;
            this.lblDateOfBirth.Text = "From";
            // 
            // DtTo
            // 
            this.DtTo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtTo.Location = new System.Drawing.Point(305, 31);
            this.DtTo.Name = "DtTo";
            this.DtTo.Size = new System.Drawing.Size(156, 37);
            this.DtTo.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "To";
            // 
            // FrmAttendanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 577);
            this.Controls.Add(this.DtTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtFrom);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.LblAbsence);
            this.Controls.Add(this.LblPresence);
            this.Controls.Add(this.rBtnAbsence);
            this.Controls.Add(this.rbtnPresence);
            this.Controls.Add(this.rBtnAll);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.txtRollNo);
            this.Controls.Add(this.lblRollNo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAttendanceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceView";
            this.Load += new System.EventHandler(this.FrmAttendanceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.RadioButton rBtnAll;
        private System.Windows.Forms.RadioButton rbtnPresence;
        private System.Windows.Forms.RadioButton rBtnAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rollno;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartmentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flag;
        private System.Windows.Forms.Label LblPresence;
        private System.Windows.Forms.Label LblAbsence;
        private System.Windows.Forms.DateTimePicker DtFrom;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.DateTimePicker DtTo;
        private System.Windows.Forms.Label label1;
    }
}