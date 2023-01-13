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
    public partial class ViewAssignStudent_ForCourses : Form
    {
        Database db;
        public ViewAssignStudent_ForCourses()
        {
            db = new Database();
            InitializeComponent();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void ViewAssignStudent_ForCourses_Load(object sender, EventArgs e)
        {
            DataTable table = db.getDatatable("select Student_Course.StdID, Student_Course.CourseID, Student_Course.RegDate, Student_Batch.BatchID from Student_Batch, Student_Course where(Student_Course.StdID = Student_Batch.StdID)");
            Datagrid_view_student.DataSource = table;
            // TODO: This line of code loads data into the 'dreamronDBDataSet4.Student_Course' table. You can move, or remove it, as needed.
            //this.student_CourseTableAdapter.Fill(this.dreamronDBDataSet4.Student_Course);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_student_id.Text))
                error_msg("Please type Student ID");

            else
            {
                Datagrid_view_student.DataSource = db.getDatatable("Select * from Student_Course where StdID = '" + txt_student_id.Text + "'");
                Datagrid_view_student.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Datagrid_view_student.DataSource = null;
            txt_student_id.Clear();
        }

        private void btn_all_data_Click(object sender, EventArgs e)
        {
            Datagrid_view_student.DataSource = db.getDatatable("Select * from Student_Course");
            Datagrid_view_student.Visible = true;
        }
    }
}
