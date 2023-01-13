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
    public partial class AssignLecturerForCoursesDashboard : Form
    {
        AssignLecturerForCourses assignlec = new AssignLecturerForCourses() { TopLevel = false, TopMost = true };
        UpdateAssignLecturerForCourse updatelec = new UpdateAssignLecturerForCourse() { TopLevel = false, TopMost = true };
        DeleteLecturerFromCourse dellec = new DeleteLecturerFromCourse() { TopLevel = false, TopMost = true };
        ViewAssignLecturerForCourses view_lec = new ViewAssignLecturerForCourses() { TopLevel = false, TopMost = true };
        public AssignLecturerForCoursesDashboard()
        {
            InitializeComponent();
        }
        private void clsoe_forms()
        {
            assignlec.Hide();
            updatelec.Hide();
            dellec.Hide();
            view_lec.Hide();
        }

        private void btn_assign_course_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            assignlec.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(assignlec);
            assignlec.Show();
        }

        private void btn_update_assign_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            updatelec.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(updatelec);
            updatelec.Show();
        }

        private void btn_delete_assign_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            dellec.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(dellec);
            dellec.Show();
        }

        private void btn_view_assign_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            view_lec.FormBorderStyle = FormBorderStyle.None;
            this.panel1.Controls.Add(view_lec);
            view_lec.Show();
        }

        private void btn_go_home_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            LecturerMethods lecmenu = new LecturerMethods();
            lecmenu.Show();
            this.Hide();
        }
    }
}
