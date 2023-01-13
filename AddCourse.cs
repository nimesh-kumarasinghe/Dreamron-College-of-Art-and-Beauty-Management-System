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
    public partial class AddCourse : Form
    {
        Course course;
        public AddCourse()
        {
            InitializeComponent();
            course = new Course();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error);
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            txt_course_id.Text = course.getCourseID();
        }

        private void btn_add_course_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_course_id.Text))
            {
                MessageBox.Show("Course id cannot be empty !");
            }
            else if (string.IsNullOrEmpty(txt_course_name.Text))
            {
                MessageBox.Show("Course name cannot be empty !");
            }
            else if (string.IsNullOrEmpty(txt_course_duration.Text))
            {
                MessageBox.Show("Course duration cannot be empty !");
            }
            else if (!txt_course_duration.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Course duration can only contain numbers !");
            }
            else if (string.IsNullOrEmpty(txt_course_fee.Text))
            {
                MessageBox.Show("Course fee cannot be empty !");
            }
            else if (!txt_course_fee.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Course fee can only contain numbers !");
            }
            else
            {
                int status = course.addCourse(
                    txt_course_id.Text,
                    txt_course_name.Text,
                    txt_course_duration.Text,
                    txt_course_fee.Text
                    );
                if (status == 0)
                {
                    MessageBox.Show("Course created sucessfully");
                }
                else if (status == -1)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_course_name.Clear();
            txt_course_duration.Clear();
            txt_course_fee.Clear();
        }
    }
}
