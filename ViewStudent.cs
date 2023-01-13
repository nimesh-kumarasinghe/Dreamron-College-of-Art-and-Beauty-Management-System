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
    public partial class ViewStudent : Form
    {
        Database db;
        public ViewStudent()
        {
            db = new Database();
            InitializeComponent();
        }
        private void ViewStudent_Load(object sender, EventArgs e)
        {
            DataTable table = db.getDatatable("select * from Student");
            Datagrid_view_student.DataSource = table;
            // TODO: This line of code loads data into the 'datasetForAllRep.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.datasetForAllRep.Student);
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_student_id.Text) && String.IsNullOrEmpty(txt_nic.Text))
                error_msg("Please type Student ID or Type NIC to get details");
            else if (!String.IsNullOrEmpty(txt_nic.Text) && !String.IsNullOrEmpty(txt_student_id.Text))
                error_msg("Should be fill only one text box");
            else if (String.IsNullOrEmpty(txt_nic.Text))
            {
                Datagrid_view_student.DataSource = db.getDatatable("Select * from Student where SID = '" + txt_student_id.Text + "'");
                Datagrid_view_student.Visible = true;
            }
            else if (String.IsNullOrEmpty(txt_student_id.Text))
            {
                Datagrid_view_student.DataSource = db.getDatatable("Select * from Student where SNIC = '" + txt_nic.Text + "'");
                Datagrid_view_student.Visible = true;
            }
        }

        private void btn_all_data_Click(object sender, EventArgs e)
        {
            Datagrid_view_student.DataSource = db.getDatatable("Select * from Student");
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Datagrid_view_student.DataSource = null;
            txt_nic.Clear();
            txt_student_id.Clear();
        }
    }
}
