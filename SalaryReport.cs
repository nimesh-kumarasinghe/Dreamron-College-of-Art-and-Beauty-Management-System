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
    public partial class SalaryReport : Form
    {
        Database db;
        public SalaryReport()
        {
            InitializeComponent();
            db = new Database();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error");
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
            DataTable dt = db.getDatatable("select EmpID from Employee where GradeID = (SELECT GradeID from Grade where GradeName = '"+grade+"')");
            var query = from row in dt.AsEnumerable() select row["EmpID"].ToString();
            string[] names = query.ToArray();
            return names;
        }
        public String[] getLecturerIds(String grade)
        {
            DataTable dt = db.getDatatable("select LID from Lecturer where GradeID = (SELECT GradeID from Grade where GradeName = '"+grade+"')");
            var query = from row in dt.AsEnumerable() select row["LID"].ToString();
            string[] names = query.ToArray();
            foreach(String name in names)
            {
                System.Console.WriteLine(name);
            }
            return names;
        }
        private void MonthlySalaryReport_Load(object sender, EventArgs e)
        {

        }


        private void btn_clear_Click(object sender, EventArgs e)
        {
            date_end.ResetText();
            date_start.ResetText();
            cmb_select_type.SelectedIndex = -1;
            rv_allgrade_salary.Clear();
            rv_employeeID.Clear();
            rv_emp_tot_salaries.Clear();
            rv_lec.Clear();
            rv_lecturerTotalSalgrades.Clear();
            rv_lec_ID.Clear();

            cmb_select_grade.Items.Clear();
            cmb_select_id.Items.Clear();

            SalaryReport salreport = new SalaryReport();
            salreport.Refresh();

            String[] grade_names = getEmployeeGrade();

            foreach (String name in grade_names)
            {
                cmb_select_grade.Items.Add(name);
            }

            String[] grade_name = getLecturerGrade();

            foreach (String name in grade_name)
            {
                cmb_select_grade.Items.Add(name);
            }


        }

        private void cmb_select_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_select_type.SelectedIndex == 0)
            {
                cmb_select_grade.Items.Clear();
                String[] grade_names = getEmployeeGrade();

                foreach (String name in grade_names)
                {
                    cmb_select_grade.Items.Add(name);
                }
            }
            else if(cmb_select_type.SelectedIndex == 1)
            {
                cmb_select_grade.Items.Clear();
                String[] grade_names = getLecturerGrade();

                foreach (String name in grade_names)
                {
                    cmb_select_grade.Items.Add(name);
                }
            }
        }

        private void cmb_select_grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_select_type.SelectedIndex == 0)
            {
                cmb_select_id.Items.Clear();
                String[] ids = getEmployeIds(cmb_select_grade.SelectedItem.ToString());

                foreach (String id in ids)
                {
                    cmb_select_id.Items.Add(id);
                }
            }
            else if(cmb_select_type.SelectedIndex == 1)
            {
                cmb_select_id.Items.Clear();
                String[] ids = getLecturerIds(cmb_select_grade.SelectedItem.ToString());

                foreach (String id in ids)
                {
                    cmb_select_id.Items.Add(id);
                }
            }
        }

        private void btn_show_generate_Click(object sender, EventArgs e)
        {
            if (cmb_select_type.SelectedIndex == -1 && cmb_select_grade.SelectedIndex == -1)
                error_msg("Please Select Type and Grade");
            else if(cmb_select_grade.SelectedIndex == -1)
                error_msg("Please Select Grade");
            else if (cmb_select_type.SelectedIndex.Equals(0))
            {
                rv_lec.Visible = false;
                rv_lec_ID.Visible = false;
                rv_employeeID.Visible = false;
                rv_emp_tot_salaries.Visible = false;
                rv_lecturerTotalSalgrades.Visible = false;
                rv_allgrade_salary.Visible = true;
                // TODO: This line of code loads data into the 'all_grades_data_set.Salary' table. You can move, or remove it, as needed.
                this.SalaryTableAdapter.Fill(this.all_grades_data_set.Salary, cmb_select_grade.SelectedItem.ToString(), date_start.Value.Year + "-" + date_start.Value.Month + "-" + date_start.Value.Day.ToString(), date_end.Value.Year + "-" + date_end.Value.Month + "-" + date_end.Value.Day.ToString());
                this.rv_allgrade_salary.RefreshReport();
            }

            else if (cmb_select_type.SelectedIndex.Equals(1))
            {
                rv_allgrade_salary.Visible = false;
                rv_lec_ID.Visible = false;
                rv_employeeID.Visible = false;
                rv_emp_tot_salaries.Visible = false;
                rv_lecturerTotalSalgrades.Visible = false;
                rv_lec.Visible = true;
                // TODO: This line of code loads data into the 'LecturerAllGradesDataset.LecSalary' table. You can move, or remove it, as needed.
                this.LecSalaryTableAdapter.Fill(this.LecturerAllGradesDataset.LecSalary, cmb_select_grade.SelectedItem.ToString(), date_start.Value.Year + "-" + date_start.Value.Month + "-" + date_start.Value.Day.ToString(), date_end.Value.Year + "-" + date_end.Value.Month + "-" + date_end.Value.Day.ToString());
                this.rv_lec.RefreshReport();
            }

        }

        private void btn_user_id_Click(object sender, EventArgs e)
        {
            if (cmb_select_type.SelectedIndex == -1 && cmb_select_grade.SelectedIndex == -1 && cmb_select_id.SelectedIndex == -1)
                error_msg("Please Select Type and Grade and ID");
            else if (cmb_select_grade.SelectedIndex == -1)
                error_msg("Please Select Grade");
            else if (cmb_select_id.SelectedIndex == -1)
                error_msg("Please Select ID");
            else if (cmb_select_type.SelectedIndex.Equals(0))
            {
                rv_allgrade_salary.Visible = false;
                rv_lec.Visible = false;
                rv_lec_ID.Visible = false;
                rv_emp_tot_salaries.Visible = false;
                rv_lecturerTotalSalgrades.Visible = false;
                rv_employeeID.Visible = true;
                // TODO: This line of code loads data into the 'all_grades_data_set.EmployeeSalaryID' table. You can move, or remove it, as needed.
                this.EmployeeSalaryIDTableAdapter.Fill(this.all_grades_data_set.EmployeeSalaryID, date_start.Value.Year + "-" + date_start.Value.Month + "-" + date_start.Value.Day.ToString(), date_end.Value.Year + "-" + date_end.Value.Month + "-" + date_end.Value.Day.ToString(), cmb_select_id.SelectedItem.ToString(), cmb_select_grade.SelectedItem.ToString());
                this.rv_employeeID.RefreshReport();
            }
            else if (cmb_select_type.SelectedIndex.Equals(1))
            {
                rv_allgrade_salary.Visible = false;
                rv_lec.Visible = false;
                rv_employeeID.Visible = false;
                rv_emp_tot_salaries.Visible = false;
                rv_lecturerTotalSalgrades.Visible = false;
                rv_lec_ID.Visible = true;
                // TODO: This line of code loads data into the 'LecturerAllGradesDataset.LecSalaryID' table. You can move, or remove it, as needed.
                this.LecSalaryIDTableAdapter.Fill(this.LecturerAllGradesDataset.LecSalaryID, date_start.Value.Year + "-" + date_start.Value.Month + "-" + date_start.Value.Day.ToString(), date_end.Value.Year + "-" + date_end.Value.Month + "-" + date_end.Value.Day.ToString(), cmb_select_id.SelectedItem.ToString(), cmb_select_grade.SelectedItem.ToString());
                this.rv_lec_ID.RefreshReport();
            }
        }

        private void btn_totsal_Click(object sender, EventArgs e)
        {
            if (cmb_select_type.SelectedIndex == -1)
                error_msg("Please Select Type to get Total Salaries Reports");
            else if (cmb_select_type.SelectedIndex == 0)
            {
                rv_allgrade_salary.Visible = false;
                rv_lec.Visible = false;
                rv_employeeID.Visible = false;
                rv_lec_ID.Visible = false;
                rv_lecturerTotalSalgrades.Visible = false;
                rv_emp_tot_salaries.Visible = true;
                // TODO: This line of code loads data into the 'all_grades_data_set.EmployeTotalSalGrade' table. You can move, or remove it, as needed.
                this.EmployeTotalSalGradeTableAdapter.Fill(this.all_grades_data_set.EmployeTotalSalGrade, date_start.Value.Year + "-" + date_start.Value.Month + "-" + date_start.Value.Day.ToString(), date_end.Value.Year + "-" + date_end.Value.Month + "-" + date_end.Value.Day.ToString());
                this.rv_emp_tot_salaries.RefreshReport();
            }
            else if (cmb_select_type.SelectedIndex == 1)
            {
                rv_allgrade_salary.Visible = false;
                rv_lec.Visible = false;
                rv_employeeID.Visible = false;
                rv_lec_ID.Visible = false;
                rv_emp_tot_salaries.Visible = false;
                rv_lecturerTotalSalgrades.Visible = true;
                // TODO: This line of code loads data into the 'LecturerAllGradesDataset.TotalLecturerSalariesGrade' table. You can move, or remove it, as needed.
                this.TotalLecturerSalariesGradeTableAdapter.Fill(this.LecturerAllGradesDataset.TotalLecturerSalariesGrade, date_start.Value.Year + "-" + date_start.Value.Month + "-" + date_start.Value.Day.ToString(), date_end.Value.Year + "-" + date_end.Value.Month + "-" + date_end.Value.Day.ToString());
                this.rv_lecturerTotalSalgrades.RefreshReport();
            }
        }

        private void txt_grade_des_Click(object sender, EventArgs e)
        {

        }

        private void d_txt_name_emp_id_Click(object sender, EventArgs e)
        {

        }

        private void cmb_select_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
