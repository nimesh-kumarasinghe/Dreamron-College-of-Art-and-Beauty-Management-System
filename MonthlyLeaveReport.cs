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
    public partial class MonthlyLeaveReport : Form
    {
        Database db;
        public MonthlyLeaveReport()
        {
            InitializeComponent();
            db = new Database();
        }

        private void MonthlyLeaveReport_Load(object sender, EventArgs e)
        {


        }
        public String[] getEmployeeGrade()
        {
            DataTable dt = db.getDatatable("select GradeName from Grade where GradeName like '%Staff' OR GradeName like '%Manager'");
            var query = from row in dt.AsEnumerable() select row["GradeName"].ToString();
            string[] names = query.ToArray();
            return names;
        }
        public String[] getLecturerGrade()
        {
            DataTable dt = db.getDatatable("select GradeName from Grade where GradeName like '%Lecturer'");
            var query = from row in dt.AsEnumerable() select row["GradeName"].ToString();
            string[] names = query.ToArray();
            return names;
        }
        public String[] getEmployeIds(String grade)
        {
            DataTable dt = db.getDatatable("select EmpID from Employee where GradeID = (SELECT GradeID from Grade where GradeName = '" + grade + "')");
            var query = from row in dt.AsEnumerable() select row["EmpID"].ToString();
            string[] names = query.ToArray();
            return names;
        }
        public String[] getLecturerIds(String grade)
        {
            DataTable dt = db.getDatatable("select LID from Lecturer where GradeID = (SELECT GradeID from Grade where GradeName = '" + grade + "')");
            var query = from row in dt.AsEnumerable() select row["LID"].ToString();
            string[] names = query.ToArray();
            foreach (String name in names)
            {
                System.Console.WriteLine(name);
            }
            return names;
        }
        void error_msg(string error)
        {
            MessageBox.Show(error,"Error");
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (cmb_types.SelectedIndex == -1)
                error_msg("Please Select User Type");
            else if(cmb_types.SelectedIndex==0)
            {
                rv_lectotgrade.Visible = false;
                rv_emptot.Visible = true;
                rv_empid.Visible = false;
                rv_lecid.Visible = false;
                rv_lecwithoutgrade.Visible = false;
                rv_withoutgradeid.Visible = false;
                // TODO: This line of code loads data into the 'AllLevaes.EmployeeTotLeave' table. You can move, or remove it, as needed.
                this.EmployeeTotLeaveTableAdapter.Fill(this.AllLevaes.EmployeeTotLeave, dt_start.Value.Year + "-" + dt_start.Value.Month + "-" + dt_start.Value.Day.ToString(), dt_end.Value.Year + "-" + dt_end.Value.Month + "-" + dt_end.Value.Day.ToString());
                this.rv_emptot.RefreshReport();
            }
            else if (cmb_types.SelectedIndex == 1)
            {
                rv_emptot.Visible = false;
                rv_lectotgrade.Visible = true;
                rv_empid.Visible = false;
                rv_lecid.Visible = false;
                rv_lecwithoutgrade.Visible = false;
                rv_withoutgradeid.Visible = false;
                // TODO: This line of code loads data into the 'AllLevaes.LecturerTotLeave' table. You can move, or remove it, as needed.
                this.LecturerTotLeaveTableAdapter.Fill(this.AllLevaes.LecturerTotLeave, dt_start.Value.Year + "-" + dt_start.Value.Month + "-" + dt_start.Value.Day.ToString(), dt_end.Value.Year + "-" + dt_end.Value.Month + "-" + dt_end.Value.Day.ToString());
                this.rv_lectotgrade.RefreshReport();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_types.SelectedIndex = -1;
            rv_empid.Clear();
            rv_emptot.Clear();
            rv_lecid.Clear();
            rv_lectotgrade.Clear();
            dt_end.ResetText();
            dt_start.ResetText();
            rv_lecwithoutgrade.Clear();
            rv_withoutgradeid.Clear();
        }

        private void cmb_types_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btn_leave_id_Click(object sender, EventArgs e)
        {
            if (cmb_types.SelectedIndex == -1)
                error_msg("Please Select User Type");
            else if (cmb_types.SelectedIndex == 0)
            {
                rv_empid.Visible = false;
                rv_emptot.Visible = false;
                rv_lectotgrade.Visible = false;
                rv_lecid.Visible = false;
                rv_withoutgradeid.Visible = true;
                rv_lecwithoutgrade.Visible = false;
                // TODO: This line of code loads data into the 'AllLevaes.testempleave' table. You can move, or remove it, as needed.
                this.testempleaveTableAdapter.Fill(this.AllLevaes.testempleave, dt_start.Value.Year + "-" + dt_start.Value.Month + "-" + dt_start.Value.Day.ToString(), dt_end.Value.Year + "-" + dt_end.Value.Month + "-" + dt_end.Value.Day.ToString());
                this.rv_withoutgradeid.RefreshReport();



            }
            else if (cmb_types.SelectedIndex == 1)
            {
                rv_empid.Visible = false;
                rv_emptot.Visible = false;
                rv_lectotgrade.Visible = false;
                rv_lecid.Visible = false;
                rv_lecwithoutgrade.Visible = true;
                rv_withoutgradeid.Visible = false;
                // TODO: This line of code loads data into the 'AllLevaes.lecwithoutgradeID' table. You can move, or remove it, as needed.
                this.lecwithoutgradeIDTableAdapter.Fill(this.AllLevaes.lecwithoutgradeID, dt_start.Value.Year + "-" + dt_start.Value.Month + "-" + dt_start.Value.Day.ToString(), dt_end.Value.Year + "-" + dt_end.Value.Month + "-" + dt_end.Value.Day.ToString());
                this.rv_lecwithoutgrade.RefreshReport();
            }
        }
    }
}
