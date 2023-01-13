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
    public partial class AssignStudentForCoursesDashboard : Form
    {

        AssignCourseForStudent assignstd = new AssignCourseForStudent() { TopLevel = false, TopMost = true };
        UpdateStudentAssignForCourse updatestd = new UpdateStudentAssignForCourse() { TopLevel = false, TopMost = true };
        DeleteStudentFromCourse delstd = new DeleteStudentFromCourse() { TopLevel = false, TopMost = true };
        ViewAssignStudent_ForCourses view_std = new ViewAssignStudent_ForCourses() { TopLevel = false, TopMost = true };

        public AssignStudentForCoursesDashboard()
        {
            InitializeComponent();
        }

        private void btn_assign_course_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            assignstd.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(assignstd);
            assignstd.Show();
        }
        private void clsoe_forms()
        {
            assignstd.Hide();
            updatestd.Hide();
            delstd.Hide();
            view_std.Hide();
        }

        private void btn_update_assign_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            updatestd.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(updatestd);
            updatestd.Show();
        }

        private void btn_delete_assign_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            delstd.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(delstd);
            delstd.Show();
        }

        private void btn_view_assign_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            view_std.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(view_std);
            view_std.Show();
        }

        private void btn_go_home_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            StudentMethods stdmenu = new StudentMethods();
            stdmenu.Show();
            this.Hide();
        }
    }
}
