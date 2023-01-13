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
    public partial class ViewLecturer : Form
    {
        Database db;
        public ViewLecturer()
        {
            db = new Database();
            InitializeComponent();
        }

        private void ViewLecturer_Load(object sender, EventArgs e)
        {
            DataTable table = db.getDatatable("select * from Lecturer");
            Datagrid_view_lecturer.DataSource = table;
            // TODO: This line of code loads data into the 'datasetForAllRep.Lecturer' table. You can move, or remove it, as needed.
            //this.lecturerTableAdapter.Fill(this.datasetForAllRep.Lecturer);

        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_lecturer_id.Text) && String.IsNullOrEmpty(txt_nic.Text))
                error_msg("Please type Lecturer ID or Type NIC to get details");
            else if (!String.IsNullOrEmpty(txt_lecturer_id.Text) && !String.IsNullOrEmpty(txt_nic.Text))
                error_msg("Should be fill only one text box");
            else if (String.IsNullOrEmpty(txt_nic.Text))
            {
                Datagrid_view_lecturer.DataSource = db.getDatatable("Select * from Lecturer where LID = '" + txt_lecturer_id.Text + "'");
                Datagrid_view_lecturer.Visible = true;
            }
            else if (String.IsNullOrEmpty(txt_lecturer_id.Text))
            {
                Datagrid_view_lecturer.DataSource = db.getDatatable("Select * from Lecturer where LNIC = '" + txt_nic.Text + "'");
                Datagrid_view_lecturer.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Datagrid_view_lecturer.DataSource = null;
            txt_nic.Clear();
            txt_lecturer_id.Clear();
        }

        private void btn_all_data_Click(object sender, EventArgs e)
        {
            Datagrid_view_lecturer.DataSource = db.getDatatable("Select * from Lecturer");
        }
    }
}
