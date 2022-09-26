using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceTracking
{
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDepartmentName.Text))
            {
                MessageBox.Show("Please Enter Department Name.", "Tracking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDepartmentName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(TxtDepartmentCode.Text))
            {
                MessageBox.Show("Please Enter Department Code.", "Tracking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtDepartmentCode.Focus();
                return;
            }
            int iResult = new DbConcept().NewDepartment(TxtDepartmentName.Text, TxtDepartmentCode.Text);
            if (iResult > 0)
            {
                MessageBox.Show("Department details Successfully Saved.", "Tracking", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                btnReset.PerformClick();
            }
            else
            {
                MessageBox.Show("Department details Not Saved.", "Tracking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
