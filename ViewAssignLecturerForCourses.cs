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
    public partial class ViewAssignLecturerForCourses : Form
    {
        Database db;
        public ViewAssignLecturerForCourses()
        {
            db = new Database();
            InitializeComponent();
        }

        private void ViewAssignLecturerForCourses_Load(object sender, EventArgs e)
        {
            DataTable table = db.getDatatable("select *  from Lecturer_Course");
            Datagrid_view_lecturer.DataSource = table;
            // TODO: This line of code loads data into the 'dreamronDBDataSet5.Course_Lecturer' table. You can move, or remove it, as needed.
            //this.course_LecturerTableAdapter.Fill(this.dreamronDBDataSet5.Course_Lecturer);

        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_lecturer_id.Text))
                error_msg("Please type Lecturer ID");

            else
            {
                Datagrid_view_lecturer.DataSource = db.getDatatable("Select * from Lecturer_Course where LecID = '" + txt_lecturer_id.Text + "'");
                Datagrid_view_lecturer.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Datagrid_view_lecturer.DataSource = null;
            txt_lecturer_id.Clear();
        }

        private void btn_all_data_Click(object sender, EventArgs e)
        {
            Datagrid_view_lecturer.DataSource = db.getDatatable("Select * from Lecturer_Course");
            Datagrid_view_lecturer.Visible = true;
        }
    }
}
