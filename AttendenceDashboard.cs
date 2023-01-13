using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dreamron_College
{
    public partial class AttendenceDashboard : Form
    {
        AddEmployeeAttendance empatte = new AddEmployeeAttendance() { TopLevel = false, TopMost = true };
        AddLecturerAttendance lecatt = new AddLecturerAttendance() { TopLevel = false, TopMost = true };
        AddStudentAttendance stuatt = new AddStudentAttendance() { TopLevel = false, TopMost = true };
        public AttendenceDashboard()
        {
            InitializeComponent();
        }
        private void clsoe_forms()
        {
            empatte.Hide();
            lecatt.Hide();
            stuatt.Hide();

        }
        private void btn_student_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            stuatt.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(stuatt);
            stuatt.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            lecatt.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(lecatt);
            lecatt.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            empatte.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(empatte);
            empatte.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Close();
            StaffMenu stffmenu = new StaffMenu();
            stffmenu.Show();

        }
    }
}
