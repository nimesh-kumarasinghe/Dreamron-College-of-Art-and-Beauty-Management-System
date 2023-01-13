using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dreamron_College
{
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }
        ReportMethods reportmenu = new ReportMethods();
        ManageLeavesMethods leavesmethods = new ManageLeavesMethods();
        GradesMethods grd = new GradesMethods();
        SalaryLeavesDashboard sal_leave = new SalaryLeavesDashboard();
        private void btn_reports_Click(object sender, EventArgs e)
        {
            reportmenu.FormBorderStyle = FormBorderStyle.None;
            reportmenu.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            using (StreamWriter streamwriter = new StreamWriter("userType.txt"))
            {
                streamwriter.Flush();
            }
            //TextFile
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void btn_manage_leaves_Click(object sender, EventArgs e)
        {
            leavesmethods.FormBorderStyle = FormBorderStyle.None;
            leavesmethods.Show();
            this.Hide();
        }

        private void btn_grades_Click(object sender, EventArgs e)
        {
            grd.FormBorderStyle = FormBorderStyle.None;
            grd.Show();
            this.Hide();
        }

        private void btn_cal_sal_Click(object sender, EventArgs e)
        {
            sal_leave.FormBorderStyle = FormBorderStyle.None;
            sal_leave.Show();
            this.Hide();
        }
    }
}
