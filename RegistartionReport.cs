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
    public partial class RegistartionReport : Form
    {
        Database db;
        public RegistartionReport()
        {
            InitializeComponent();
            db = new Database();
        }

        private void RegistartionReport_Load(object sender, EventArgs e)
        {

        }
        public String[] getBatchId()
        {
            DataTable dt = db.getDatatable("select BatchID from Batch");
            var query = from row in dt.AsEnumerable() select row["BatchID"].ToString();
            string[] batchid = query.ToArray();
            return batchid;
        }
        public String[] getCoureNames(String batch_id)
        {
            DataTable dt = db.getDatatable("select Course.CName from Course where Course.CID = (select Batch.CourseID from Batch where BatchID = '"+batch_id+"')");
            var query = from row in dt.AsEnumerable() select row["CName"].ToString();
            string[] cname = query.ToArray();
            return cname;
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error");
        }
        private void btn_generate_Click(object sender, EventArgs e)
        {
            if(cmb_type.SelectedIndex == 0)
            {
                rv_lectot.Visible = false;
                rv_studenttot.Visible = false;
                rv_emptotreg.Visible = true;
                // TODO: This line of code loads data into the 'AllRegistartion.EmployeeTotalReg' table. You can move, or remove it, as needed.
                this.EmployeeTotalRegTableAdapter.Fill(this.AllRegistartion.EmployeeTotalReg, date_start.Value.Year + "-" + date_start.Value.Month + "-" + date_start.Value.Day.ToString(), date_end.Value.Year + "-" + date_end.Value.Month + "-" + date_end.Value.Day.ToString());
                this.rv_emptotreg.RefreshReport();
            }
            else if (cmb_type.SelectedIndex == 1)
            {
                rv_emptotreg.Visible = false;
                rv_studenttot.Visible = false;
                rv_lectot.Visible = true;
                // TODO: This line of code loads data into the 'AllRegistartion.LecturerTotReg' table. You can move, or remove it, as needed.
                this.LecturerTableAdapter.Fill(this.AllRegistartion.LecturerTotReg, date_start.Value.Year + "-" + date_start.Value.Month + "-" + date_start.Value.Day.ToString(), date_end.Value.Year + "-" + date_end.Value.Month + "-" + date_end.Value.Day.ToString());
                this.rv_lectot.RefreshReport();
            }
            else if (cmb_type.SelectedIndex == 2)
            {
                rv_emptotreg.Visible = false;
                rv_lectot.Visible = false;
                rv_studenttot.Visible = true;
                // TODO: This line of code loads data into the 'AllRegistartion.StudentTotReg' table. You can move, or remove it, as needed.
                this.StudentTotRegTableAdapter.Fill(this.AllRegistartion.StudentTotReg, date_start.Value.Year + "-" + date_start.Value.Month + "-" + date_start.Value.Day.ToString(), date_end.Value.Year + "-" + date_end.Value.Month + "-" + date_end.Value.Day.ToString());
                this.rv_studenttot.RefreshReport();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_type.SelectedIndex = -1;
            date_end.ResetText();
            date_start.ResetText();
            rv_emptotreg.Clear();
            rv_lectot.Clear();
            rv_studenttot.Clear();
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
