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
    public partial class ViewAttendence : Form
    {
        Database db;
        public ViewAttendence()
        {
            db = new Database();
            InitializeComponent();
        }

        private void ViewAttendence_Load(object sender, EventArgs e)
        {
            DataTable table = db.getDatatable("select * from Attendance");
            dg_attendence.DataSource = table;
            // TODO: This line of code loads data into the 'dreamronDBDataSet2.Attendance' table. You can move, or remove it, as needed.
            //this.attendanceTableAdapter1.Fill(this.dreamronDBDataSet2.Attendance);

        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmbtype.SelectedIndex.Equals(-1))
            {
                dg_attendence.Visible = false;
                error_msg("Please select a user type");
            }
            else if (cmbtype.SelectedIndex.Equals(0))
            {
                dg_attendence.DataSource = db.getDatatable("Select * from Attendance where Type = 'Employee'");
                dg_attendence.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(1))
            {
                dg_attendence.DataSource = db.getDatatable("Select * from Attendance where Type = 'Lecturer'");
                dg_attendence.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(2))
            {
                dg_attendence.DataSource = db.getDatatable("Select * from Attendance where Type = 'Student'");
                dg_attendence.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(3))
            {
                dg_attendence.DataSource = db.getDatatable("Select * from Attendance");
                dg_attendence.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(-1))
            {
                dg_attendence.DataSource = db.getDatatable("Select * from Attendance");
                dg_attendence.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmbtype.SelectedIndex = (-1);
            dg_attendence.DataSource = null;
        }
    }
}
