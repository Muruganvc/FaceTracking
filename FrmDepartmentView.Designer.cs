namespace FaceTracking
{
    partial class FrmDepartmentView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtDepartmentName = new System.Windows.Forms.TextBox();
            this.LblDepartmentName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(895, 289);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(654, 67);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 38);
            this.BtnSearch.TabIndex = 24;
            this.BtnSearch.Text = "Search..";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtDepartmentName
            // 
            this.TxtDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDepartmentName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDepartmentName.Location = new System.Drawing.Point(279, 67);
            this.TxtDepartmentName.Name = "TxtDepartmentName";
            this.TxtDepartmentName.Size = new System.Drawing.Size(369, 37);
            this.TxtDepartmentName.TabIndex = 22;
            // 
            // LblDepartmentName
            // 
            this.LblDepartmentName.AutoSize = true;
            this.LblDepartmentName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDepartmentName.Location = new System.Drawing.Point(7, 69);
            this.LblDepartmentName.Name = "LblDepartmentName";
            this.LblDepartmentName.Size = new System.Drawing.Size(266, 30);
            this.LblDepartmentName.TabIndex = 23;
            this.LblDepartmentName.Text = "Department Name / Code";
            // 
            // FrmDepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 480);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtDepartmentName);
            this.Controls.Add(this.LblDepartmentName);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDepartmentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department View";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtDepartmentName;
        private System.Windows.Forms.Label LblDepartmentName;
    }
}