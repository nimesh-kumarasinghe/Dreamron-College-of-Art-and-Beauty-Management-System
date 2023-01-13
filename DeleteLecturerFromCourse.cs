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
    public partial class DeleteLecturerFromCourse : Form
    {
        Lecturer lecturer = new Lecturer();
        Course course = new Course();
        public DeleteLecturerFromCourse()
        {
            InitializeComponent();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lecture_id.Text))
                error_msg("Lecturer ID cannot be blank");
            else
            {
                String[] userdata = lecturer.getLecturerAssignData(txt_lecture_id.Text);

                txt_lecture_id.Text = userdata[0];



                String[] lecdatadetails = lecturer.getLecturerTableData(txt_lecture_id.Text);
                txt_Initial_name.Text = lecdatadetails[0];
               
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lecture_id.Text))
                error_msg("Full Name cannot be blank");

            else
            {
                int status = lecturer.deleteLectureAssignCourse(

                txt_course_id.Text,
                txt_lecture_id.Text
            );
                if (status == 0)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("failed");
                }
            }
        }

        private void txt_course_id_TextChanged(object sender, EventArgs e)
        {
            String[] cosdatadetails = course.getCourseTableData(txt_course_id.Text);
            txt_course_name.Text = cosdatadetails[0];
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_course_id.Clear();
            txt_course_name.Clear();
            txt_Initial_name.Clear();
            txt_Initial_name.Clear();
        }

        private void txt_lecture_id_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
