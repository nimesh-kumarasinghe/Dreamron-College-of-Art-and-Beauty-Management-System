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
    public partial class UpdateStudentAssignForCourse : Form
    {
        Course course = new Course();
        Student student = new Student();
        Batch batch = new Batch();
        Database db;
        public UpdateStudentAssignForCourse()
        {
            db = new Database();
            InitializeComponent();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_previous_stu_id.SelectedIndex == -1)
                    error_msg("Please select previous Student ID first");
                else if (cmb_prvius_c_id.SelectedIndex == -1)
                    error_msg("Please select previous Course ID first");
                else if (cmb_new_stu_id.SelectedIndex == -1)
                    error_msg("Please select New Student ID first");
                else if (cmb_new_c_id.SelectedIndex == -1)
                    error_msg("Please select New Course ID first");
                else
                {
                    string cmd = "delete from Student_Course where StdID='" + cmb_previous_stu_id.Text.ToString() + "'AND CourseID='" + cmb_prvius_c_id.Text.ToString() + "' AND RegDate='" + picker_reg_date.Value.ToString() + "';delete from Student_Batch where StdID='" + cmb_previous_stu_id.Text.ToString() + "' AND BatchID='" + cmb_batch_old.Text.ToString() + "';insert into Student_Course values('" + cmb_new_stu_id.Text.ToString() + "','" + cmb_new_c_id.Text.ToString() + "','" + picker_new_date.Value.ToString() + "');insert into Student_Batch Values('" + cmb_new_stu_id.Text.ToString() + "','" + cmb_batch_new.Text.ToString() + "')";
                    var x = db.command(cmd);
                    MessageBox.Show("Update Successfully!");
                }
            }
            catch(Exception )
            {
                error_msg("Please check again");
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            picker_new_date.ResetText();
            picker_reg_date.ResetText();
            txt_new_student_name.Clear();
            txt_Sinitial_name.Clear();
            txt_new_course_name.Clear();
            txt_course_name.Clear();
            cmb_new_c_id.Items.Clear();
            cmb_new_stu_id.Items.Clear();
            cmb_previous_stu_id.Items.Clear();
            cmb_prvius_c_id.Items.Clear();

        }

        private void UpdateStudentAssignForCourse_Load(object sender, EventArgs e)
        {
            String[] stu_ids = getStudentId();
            foreach (String id in stu_ids)
            {
                cmb_previous_stu_id.Items.Add(id);
            }

            String[] course_id = getCourseId();
            foreach (String id in course_id)
            {
                cmb_prvius_c_id.Items.Add(id);
            }
            //new
            String[] newstu_ids = getStudentNewId();
            foreach (String id in newstu_ids)
            {

                cmb_new_stu_id.Items.Add(id);
            }

            String[] newcourse_id = getCourseIds();
            foreach (String id in newcourse_id)
            {
                cmb_new_c_id.Items.Add(id);
            }
        }

        public String[] getStudentId()
        {
            DataTable dt = db.getDatatable("select StdID from Student_Course;");
            var query = from row in dt.AsEnumerable() select row["StdID"].ToString();
            string[] lecids = query.ToArray();
            return lecids;

        }
        public String[] getCourseId()
        {
            DataTable dt = db.getDatatable("select CourseID from Student_Course;");
            var query = from row in dt.AsEnumerable() select row["CourseID"].ToString();
            string[] lecids = query.ToArray();
            return lecids;

        }
        ///new
        public String[] getStudentNewId()
        {
            DataTable dt = db.getDatatable("select SID from Student;");
            var query = from row in dt.AsEnumerable() select row["SID"].ToString();
            string[] lecids = query.ToArray();
            return lecids;

        }
        public String[] getCourseIds()
        {
            DataTable dt = db.getDatatable("select CID from Course;");
            var query = from row in dt.AsEnumerable() select row["CID"].ToString();
            string[] lecids = query.ToArray();
            return lecids;

        }

        private void cmb_prvius_c_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] coursename = course.getCourseNames(cmb_prvius_c_id.SelectedItem.ToString());
            txt_course_name.Text = coursename[0];
        }

        private void cmb_previous_stu_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] stu_ininame = student.getStudentINIdata(cmb_previous_stu_id.SelectedItem.ToString());
            txt_Sinitial_name.Text = stu_ininame[0];
        }

        private void cmb_new_c_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] newcoursename = course.getCourseNames(cmb_new_c_id.SelectedItem.ToString());
            txt_new_course_name.Text = newcoursename[0];
        }

        private void cmb_new_stu_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] newstuname = student.getStudentINIdata(cmb_new_stu_id.SelectedItem.ToString());
            txt_new_student_name.Text = newstuname[0];
        }

        private void txt_Sinitial_name_TextChanged(object sender, EventArgs e)
        {
            String[] ids = batch.getOldBatchIdNumbers(cmb_previous_stu_id.SelectedItem.ToString());
            foreach (String id in ids)
            {
                cmb_batch_old.Items.Add(id);
            }

            String[] stu_regdate = student.getCoursedate(cmb_previous_stu_id.SelectedItem.ToString(), cmb_prvius_c_id.SelectedItem.ToString());
            picker_reg_date.Text = stu_regdate[0];

            String[] stu_newregdate = student.getCoursedate(cmb_previous_stu_id.SelectedItem.ToString(), cmb_prvius_c_id.SelectedItem.ToString());
            picker_new_date.Text = stu_newregdate[0];
        }

        private void txt_course_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_new_student_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_new_course_name_TextChanged(object sender, EventArgs e)
        {

            String[] ids = batch.getBatchIdNumbers(cmb_new_c_id.SelectedItem.ToString());
            foreach (String id in ids)
            {
                cmb_batch_new.Items.Add(id);
            }
        }
    }
}
