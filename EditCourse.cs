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
    public partial class EditCourse : Form
    {
        Course course;
        public EditCourse()
        {
            InitializeComponent();
            course = new Course();
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
                    txt_cname.Text = userdata[0];
                    txt_duration.Text = userdata[1];
                    txt_fee.Text = userdata[2];
                }
            }
        }

        private void btn_updatecourse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_course_id.Text))
                MessageBox.Show("Course id cannot be empty !");
            else if (string.IsNullOrEmpty(txt_cname.Text))
                MessageBox.Show("Course name cannot be empty !");
            else if (string.IsNullOrEmpty(txt_duration.Text))
                MessageBox.Show("Course duration cannot be empty !");
            else if (!txt_duration.Text.Any(char.IsDigit))
                MessageBox.Show("Course duration can only contain numbers !");
            else if (string.IsNullOrEmpty(txt_fee.Text))
                MessageBox.Show("Course fee cannot be empty !");
            else if (!txt_fee.Text.Any(char.IsDigit))
                MessageBox.Show("Course fee can only contain numbers !");
            else
            {
                int status = course.updateCourseData(
            txt_cname.Text,
            txt_duration.Text,
            txt_fee.Text,
            txt_course_id.Text
            );
                if (status == 0)
                {
                    MessageBox.Show("Updated Successfully!");
                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_course_id.Clear();
            txt_cname.Clear();
            txt_duration.Clear();
            txt_fee.Clear();
        }
    }
}
