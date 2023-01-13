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
    public partial class AssignLecturerForCourses : Form
    {
        Lecturer lecturer = new Lecturer();
        Course course = new Course();
        public AssignLecturerForCourses()
        {
            InitializeComponent();
        }

        private void txt_course_id_TextChanged(object sender, EventArgs e)
        {
            String[] cosdatadetails = course.getCourseTableData(txt_course_id.Text);
            txt_course_name.Text = cosdatadetails[0];
        }

        private void txt_lecturer_id_TextChanged(object sender, EventArgs e)
        {
            String[] lecturerdetails = lecturer.getLecturerTableData(txt_lecturer_id.Text);
            txt_Initial_name.Text = lecturerdetails[0];
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int status = lecturer.addlecturerforcourse(txt_lecturer_id.Text, txt_course_id.Text);
            if (status == 0)
                MessageBox.Show("Assign Succesfully");
            else if (status == -1)
                MessageBox.Show("failed");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_lecturer_id.Clear();
            txt_course_id.Clear();
            txt_course_name.Clear();
            txt_Initial_name.Clear();
        }
    }
}
