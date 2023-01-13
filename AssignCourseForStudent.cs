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
    public partial class AssignCourseForStudent : Form
    {
        Course course = new Course();
        Student student = new Student();
        Batch batch = new Batch();
        public AssignCourseForStudent()
        {
            InitializeComponent();
        }
        private void AddBatch_Load(object sender, EventArgs e)
        {

            String[] ids = batch.getBatchIdNumbers(txt_course_id.Text);
            foreach (String id in ids)
            {
                cmb_batch.Items.Add(id);
            }
            
        }

        private void AssignCourseForStudent_Load(object sender, EventArgs e)
        {

        }

        private void btn_addbatch_Click(object sender, EventArgs e)
        {
            int status = student.addStudentforcourse(txt_student_id.Text, txt_course_id.Text, picker_reg_date.Value.ToString(),cmb_batch.SelectedItem.ToString());
            if (status == 0)
                MessageBox.Show("Assign Succesfully");
            else if (status == -1)
                MessageBox.Show("failed");
        }

        private void txt_course_id_TextChanged(object sender, EventArgs e)
        {
            String[] cosdatadetails = course.getCourseTableData(txt_course_id.Text);
            txt_course_name.Text = cosdatadetails[0];
        }

        private void txt_student_id_TextChanged(object sender, EventArgs e)
        {
            String[] studentdetails = student.getStudentINIdata(txt_student_id.Text);
            txt_Sinitial_name.Text = studentdetails[0];
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_course_id.Clear();
            txt_course_name.Clear();
            txt_student_id.Clear();
            txt_Sinitial_name.Clear();
            picker_reg_date.ResetText();
        }

        private void txt_course_name_TextChanged(object sender, EventArgs e)
        {
            
                String[] ids = batch.getBatchIdNumbers(txt_course_id.Text);
                foreach (String id in ids)
                {
                    cmb_batch.Items.Add(id);
                }
         
        }
    }
}
