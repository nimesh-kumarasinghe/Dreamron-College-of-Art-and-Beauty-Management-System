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
    public partial class ViewCourse : Form
    {
        Database db;
        public ViewCourse()
        {
            db = new Database();
            InitializeComponent();
        }

        private void ViewCourse_Load(object sender, EventArgs e)
        {
            DataTable table = db.getDatatable("select * from Course");
            Datagrid_view_course.DataSource = table;
            // TODO: This line of code loads data into the 'dreamronDBDataSet1.Course' table. You can move, or remove it, as needed.
            //this.courseTableAdapter.Fill(this.dreamronDBDataSet1.Course);

        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_coursename.Text) && String.IsNullOrEmpty(txt_couse_id.Text))
                error_msg("Please type Course ID or Type Course Name to get details");
            else if (!String.IsNullOrEmpty(txt_coursename.Text) && !String.IsNullOrEmpty(txt_couse_id.Text))
                error_msg("Should be fill only one text box");
            else if (String.IsNullOrEmpty(txt_coursename.Text))
            {
                Datagrid_view_course.DataSource = db.getDatatable("Select * from Course where CID = '" + txt_couse_id.Text + "'");
                Datagrid_view_course.Visible = true;
            }
            else if (String.IsNullOrEmpty(txt_couse_id.Text))
            {
                Datagrid_view_course.DataSource = db.getDatatable("Select * from Course where CName = '" + txt_coursename.Text + "'");
                Datagrid_view_course.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Datagrid_view_course.DataSource = null;
            txt_coursename.Clear();
            txt_couse_id.Clear();
        }

        private void btn_all_data_Click(object sender, EventArgs e)
        {
            Datagrid_view_course.DataSource = db.getDatatable("Select * from Course");
        }
    }
}
