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
    public partial class DeleteStudentFromCourse : Form
    {
        Course course = new Course();
        Student student = new Student();
        Batch batch = new Batch();
        public DeleteStudentFromCourse()
        {
            InitializeComponent();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_student_id.Text))
                error_msg("Student ID cannot be blank");
            else
            {
                String[] userdata = student.getStudent_coursedata(txt_student_id.Text);
                txt_course_id.Text = userdata[0];

                String[] userdataname = student.getStudentINIdata(txt_student_id.Text);
                txt_Sinitial_name.Text = userdataname[0];
                //
                String[] batchdataa = batch.getStudentBatchIdNumber(txt_student_id.Text);
                if (batchdataa[0].Equals("error"))
                {
                    error_msg("Not Found");
                }
                else
                {
                    txt_batch_id.Text= batchdataa[0];

                }
            }

            //


            
            







        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_student_id.Text))
                error_msg("Student ID be blank");

            else
            {
                int status = student.deleteStudentCourse(

                txt_student_id.Text

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
            txt_student_id.Clear();
            txt_Sinitial_name.Clear();
        }

        private void txt_Sinitial_name_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
