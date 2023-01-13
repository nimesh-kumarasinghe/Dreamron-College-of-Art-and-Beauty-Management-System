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
    public partial class UpdateAssignLecturerForCourse : Form
    {
        Lecturer lecturer = new Lecturer();
        Course course = new Course();
        Database db=new Database();
        public UpdateAssignLecturerForCourse()
        {

            InitializeComponent();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error);
        }
        

        
        private void btn_update_Click(object sender, EventArgs e)
        {
            int status = lecturer.updateLecturerformcourse(cmb_previous_l_id.Text.ToString(), cmb_prvius_c_id.Text.ToString(), cmb_new_l_id.Text.ToString(), cmb_new_c_id.Text.ToString());
            if (status == 0)
                MessageBox.Show("Updated Succesfully");
            else if (status == -1)
                MessageBox.Show("failed");
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_new_c_id.Items.Clear();
            cmb_new_l_id.Items.Clear();
            txt_new_course_name.Clear();
            txt_new_lname.Clear();

            cmb_previous_l_id.Items.Clear();
            cmb_prvius_c_id.Items.Clear();
            txt_previous_course_name.Clear();
            txt_previous_Linitial_name.Clear();
        }

        private void UpateAssignLecturerForCourse_Load(object sender, EventArgs e)
        {
            String[] lec_ids = getLectureid();
            foreach (String id in lec_ids)
            {
                cmb_previous_l_id.Items.Add(id);
            }

            String[] course_id = getCourseid();
            foreach (String id in course_id)
            {
                cmb_prvius_c_id.Items.Add(id);
            }
            //new
            String[] newlec_ids = getLectureids();
            foreach (String id in newlec_ids)
            {
                
                cmb_new_l_id.Items.Add(id);
            }

            String[] newcourse_id = getCourseids();
            foreach (String id in newcourse_id)
            {
                cmb_new_c_id.Items.Add(id);
            }
        }
        public String[] getLectureid()
        {
            DataTable dt = db.getDatatable("select LecID from Lecturer_Course;");
            var query = from row in dt.AsEnumerable() select row["LecID"].ToString();
            string[] lecids = query.ToArray();
            return lecids;

        }
        public String[] getCourseid()
        {
            DataTable dt = db.getDatatable("select CourseID from Lecturer_Course;");
            var query = from row in dt.AsEnumerable() select row["CourseID"].ToString();
            string[] lecids = query.ToArray();
            return lecids;

        }
        ///new
        public String[] getLectureids()
        {
            DataTable dt = db.getDatatable("select LID from Lecturer;");
            var query = from row in dt.AsEnumerable() select row["LID"].ToString();
            string[] lecids = query.ToArray();
            return lecids;

        }
        public String[] getCourseids()
        {
            DataTable dt = db.getDatatable("select CID from Course;");
            var query = from row in dt.AsEnumerable() select row["CID"].ToString();
            string[] lecids = query.ToArray();
            return lecids;

        }


        private void cmb_l_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] lecininame = lecturer.getLectureINIdata(cmb_previous_l_id.SelectedItem.ToString());
            txt_previous_Linitial_name.Text = lecininame[0];
        }

        private void cmb_prvius_c_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] coursename = lecturer.getCoursename(cmb_prvius_c_id.SelectedItem.ToString());
            txt_previous_course_name.Text = coursename[0];
        }


        private void cmb_new_c_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] newcoursename = lecturer.getCoursename(cmb_new_c_id.SelectedItem.ToString());
            txt_new_course_name.Text = newcoursename[0];

        }

        private void txt_new_Linitial_name_TextChanged(object sender, EventArgs e)
        {
            String[] newlecname = lecturer.getLectureINIdata(cmb_new_l_id.SelectedItem.ToString());
            txt_new_lname.Text = newlecname[0];
        }

        private void cmb_new_l_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] newlecname = lecturer.getLectureINIdata(cmb_new_l_id.SelectedItem.ToString());
            txt_new_lname.Text = newlecname[0];
        }
    }
}
