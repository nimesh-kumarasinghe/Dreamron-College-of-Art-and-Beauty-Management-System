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
    public partial class StaffMenu : Form
    {
        public StaffMenu()
        {
            InitializeComponent();
        }
        StudentMethods studentmethods = new StudentMethods();
        CourseMethods coursemethods = new CourseMethods();
        BatchMethods batchmethods = new BatchMethods();
        LecturerMethods lecturermethods = new LecturerMethods();
        //SalaryLeavesDashboard sal_leave = new SalaryLeavesDashboard();
        AttendenceDashboard att = new AttendenceDashboard();
        RequestLeave req = new RequestLeave();
        private void btn_course_Click(object sender, EventArgs e)
        {
            coursemethods.FormBorderStyle = FormBorderStyle.None;
            coursemethods.Show();
            this.Hide();
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            studentmethods.FormBorderStyle = FormBorderStyle.None;
            studentmethods.Show();
            this.Hide();
        }

        private void btn_batch_Click(object sender, EventArgs e)
        {
            batchmethods.FormBorderStyle = FormBorderStyle.None;
            batchmethods.Show();
            this.Hide();
        }

        private void btn_lecturer_Click(object sender, EventArgs e)
        {
            lecturermethods.FormBorderStyle = FormBorderStyle.None;
            lecturermethods.Show();
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

        private void btn_salary_leavs_Click(object sender, EventArgs e)
        {
            req.FormBorderStyle = FormBorderStyle.Fixed3D;
            req.Show();
            
        }


        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StaffMenu_Load(object sender, EventArgs e)
        {
        }

        private void btn_att_Click(object sender, EventArgs e)
        {
            att.FormBorderStyle = FormBorderStyle.None;
            att.Show();
            this.Hide();
        }
    }
}
