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
    public partial class StudentMethods : Form
    {
        public StudentMethods()
        {
            InitializeComponent();
        }
        SendEmail email = new SendEmail() { TopLevel = false, TopMost = true };
        AddStudent add_stu = new AddStudent() { TopLevel = false, TopMost = true };
        EditStudent editstu = new EditStudent() { TopLevel = false, TopMost = true };
        DeleteStudent delete_stu = new DeleteStudent() { TopLevel = false, TopMost = true };
        ViewStudent view_std = new ViewStudent() { TopLevel = false, TopMost = true };

        private void btn_add_student_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            add_stu.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(add_stu);
            add_stu.Show();
        }
        private void clsoe_forms()
        {
            email.Hide();
            add_stu.Hide();
            editstu.Hide();
            delete_stu.Hide();
            view_std.Hide();
        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            editstu.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(editstu);
            editstu.Show();
        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            delete_stu.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(delete_stu);
            delete_stu.Show();
        }

        private void btn_view_student_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            view_std.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(view_std);
            view_std.Show();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            email.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(email);
            email.Show();
        }

        private void btn_go_home_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            StaffMenu staffmenu = new StaffMenu();
            staffmenu.Show();
            this.Hide();
        }

        private void btn_assign_course_Click(object sender, EventArgs e)
        {
            this.Close();
            AssignStudentForCoursesDashboard assigndash = new AssignStudentForCoursesDashboard();
            assigndash.Show();
        }
    }
}
