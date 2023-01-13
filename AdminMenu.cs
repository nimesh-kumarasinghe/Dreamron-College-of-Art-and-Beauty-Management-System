using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dreamron_College
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }
        AdminStaffMethods admin_staff = new AdminStaffMethods();
        LecturerMethods lecturermethods = new LecturerMethods();
        CourseMethods coursemethods = new CourseMethods();
        RequestLeave requestleave = new RequestLeave();

        private void btn_adminstaff_Click(object sender, EventArgs e)
        {
            admin_staff.FormBorderStyle = FormBorderStyle.None;
            admin_staff.Show();
            this.Hide();
        }

        private void btn_lec_Click(object sender, EventArgs e)
        {
            lecturermethods.FormBorderStyle = FormBorderStyle.None;
            lecturermethods.Show();
            this.Hide();
        }

        private void btn_course_Click(object sender, EventArgs e)
        {
            coursemethods.FormBorderStyle = FormBorderStyle.None;
            coursemethods.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            //TextFile - Delete
            using (StreamWriter streamwriter = new StreamWriter("userType.txt"))
            {
                streamwriter.Flush();
            }
            //TextFile
            Login login = new Login();
            this.Close();
            login.Show();

        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            requestleave.Show();

        }
    }
}
