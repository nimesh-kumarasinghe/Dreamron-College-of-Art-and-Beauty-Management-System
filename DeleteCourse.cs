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
    public partial class DeleteCourse : Form
    {
        Course course = new Course();
        public DeleteCourse()
        {
            InitializeComponent();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_course_id.Text))
                error_msg("Course id cannot be empty !");
            else
            {
                String[] userdata = course.getCourseData(txt_course_id.Text);
                if (userdata[0].Equals("error"))
                {
                    error_msg("Not Found");
                }
                else
                {
                    txt_course_name.Text = userdata[0];
                    txt_course_duration.Text = userdata[1];
                    txt_course_fee.Text = userdata[2];
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_course_id.Clear();
            txt_course_name.Clear();
            txt_course_duration.Clear();
            txt_course_fee.Clear();
        }

        private void btn_delete_course_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_course_id.Text))
                MessageBox.Show("Course id cannot be empty !");
            else if (string.IsNullOrEmpty(txt_course_name.Text))
                MessageBox.Show("Course name cannot be empty !");
            else if (string.IsNullOrEmpty(txt_course_duration.Text))
                MessageBox.Show("Course duration cannot be empty !");
            else if (!txt_course_duration.Text.Any(char.IsDigit))
                MessageBox.Show("Course duration can only contain numbers !");
            else if (string.IsNullOrEmpty(txt_course_fee.Text))
                MessageBox.Show("Course fee cannot be empty !");
            else if (!txt_course_fee.Text.Any(char.IsDigit))
                MessageBox.Show("Course fee can only contain numbers !");
            else
            {
                int status = course.deleteCoursesData(
            txt_course_name.Text,
            txt_course_duration.Text,
            txt_course_fee.Text,
            txt_course_id.Text
            );
                if (status == 0)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
        }
    }
}
