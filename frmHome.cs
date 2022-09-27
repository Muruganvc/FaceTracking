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
    public partial class frmHome : Form
    {
        
        public frmHome( )
        {
            InitializeComponent(); 
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void newEnrollementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            FrmAttendanceEntry attend = new FrmAttendanceEntry();
            attend.MdiParent = this;
            attend.Show();
        }

        private void sampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmSample attend = new frmSample();
            attend.MdiParent = this;
            attend.Show();
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            FrmDepartment depart = new FrmDepartment();
            depart.MdiParent = this;
            depart.Show();
        }

        private void newEnrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            frmEnrollment enroll = new frmEnrollment();
            enroll.MdiParent = this;
            enroll.Show();
        }

        private void viewEnrollmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
                ActiveMdiChild.Close();

            EnrollmentView enroll = new EnrollmentView();
            enroll.MdiParent = this;
            enroll.Show();
        }
    }
}
