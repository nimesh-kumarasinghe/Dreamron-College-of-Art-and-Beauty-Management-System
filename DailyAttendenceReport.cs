using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Dreamron_College
{
    public partial class DailyAttendenceReport : Form
    {
        Database db;
        public DailyAttendenceReport()
        {
            InitializeComponent();
            db = new Database();
        }
        private void DailyAttendenceReport_Load(object sender, EventArgs e)
        {
            rv_emp.Visible = false;
            rv_lecturer.Visible = false;
            rv_student.Visible = false;
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error");
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txt_type.Text))
                error_msg("Please Type Employee or Lecturer or Student");
            else if (txt_type.Text=="employee" || txt_type.Text == "Employee")
            {
                rv_emp.Visible = true;
                // TODO: This line of code loads data into the 'AttendenceDataset.Attendance' table. You can move, or remove it, as needed.
                this.AttendanceTableAdapter.Fill(this.AttendenceDataset.Attendance, txt_type.Text, dt_picker.Value.ToString());
                this.rv_emp.RefreshReport();
            }
            else if (txt_type.Text == "lecturer" || txt_type.Text == "Lecturer")
            {
                rv_lecturer.Visible = true;
                // TODO: This line of code loads data into the 'AttendenceDataset.Attendance' table. You can move, or remove it, as needed.
                this.AttendanceTableAdapter.Fill(this.AttendenceDataset.Attendance, txt_type.Text, dt_picker.Value.ToString());
                this.rv_lecturer.RefreshReport();

            }
            else if (txt_type.Text == "student" || txt_type.Text == "Student")
            {
                rv_student.Visible = true;
                // TODO: This line of code loads data into the 'AttendenceDataset.Attendance' table. You can move, or remove it, as needed.
                this.AttendanceTableAdapter.Fill(this.AttendenceDataset.Attendance, txt_type.Text, dt_picker.Value.ToString());
                this.rv_student.RefreshReport();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            rv_emp.Clear();
            txt_type.Clear();
            dt_picker.ResetText();
            rv_lecturer.Clear();
            rv_student.Clear();
        }


    }
}
