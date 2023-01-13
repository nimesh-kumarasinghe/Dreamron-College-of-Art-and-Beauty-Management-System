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
    public partial class AcceptRejectLeaves : Form
    {
        Database db;
        public AcceptRejectLeaves()
        {
            InitializeComponent();
            db = new Database();
        }

        private void AcceptRejectLeaves_Load(object sender, EventArgs e)
        {

        }

        public void getEmployeeData()
        {
            table_view.Rows.Clear();
            DataTable dt = db.getDatatable("select DISTINCT Employee.EmpID,Employee.EIniName,Leave.LDate,Leave.Reason,Leave.LStatus from Employee,Leave where Employee.EmpID = Leave.EmpID AND Leave.Checks = '0';");

            var emp_id = from row in dt.AsEnumerable() select row["EmpID"].ToString();
            var emp_i_name = from row in dt.AsEnumerable() select row["EIniName"].ToString();
            var emp_lv_date = from row in dt.AsEnumerable() select row["LDate"].ToString();
            var emp_lv_reason = from row in dt.AsEnumerable() select row["Reason"].ToString();
            var emp_lv_status = from row in dt.AsEnumerable() select row["LStatus"].ToString();

            string[] ids = emp_id.ToArray();
            string[] names = emp_i_name.ToArray();
            string[] dates = emp_lv_date.ToArray();
            string[] reasons = emp_lv_reason.ToArray();
            string[] status = emp_lv_status.ToArray();

            int x = 0;
            foreach (string id in ids)
            {
                acceptOrRejectLeavesClassBindingSource5.Add(new AcceptOrRejectLeavesClass() { empid = id, i_name = names[x], date = dates[x], reason = reasons[x] });
                x++;
            }
        }
        public void getLecturerData()
        {
            table_view.Rows.Clear();

            DataTable dt = db.getDatatable("select DISTINCT Lecturer.LID,Lecturer.LIniName,Leave.LDate,Leave.Reason,Leave.LStatus from Lecturer,Leave where Lecturer.LID = Leave.LecID AND Leave.Checks = '0';");

            var emp_id = from row in dt.AsEnumerable() select row["LID"].ToString();
            var emp_i_name = from row in dt.AsEnumerable() select row["LIniName"].ToString();
            var emp_lv_date = from row in dt.AsEnumerable() select row["LDate"].ToString();
            var emp_lv_reason = from row in dt.AsEnumerable() select row["Reason"].ToString();
            var emp_lv_status = from row in dt.AsEnumerable() select row["LStatus"].ToString();

            string[] ids = emp_id.ToArray();
            string[] names = emp_i_name.ToArray();
            string[] dates = emp_lv_date.ToArray();
            string[] reasons = emp_lv_reason.ToArray();
            string[] status = emp_lv_status.ToArray();

            int x = 0;
            foreach (string id in ids)
            {
                acceptOrRejectLeavesClassBindingSource5.Add(new AcceptOrRejectLeavesClass() { empid = id, i_name = names[x], date = dates[x], reason = reasons[x] });
                x++;
            }
        }
        private void cmb_user_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_user_type.SelectedIndex == 0)
            {
                getEmployeeData();
            }
            else if (cmb_user_type.SelectedIndex == 1)
            {
                getLecturerData();
            }
        }
        public void sendMail(String email, String message)
        {
            Email em = new Email();
            em.to(email);
            em.subject("About leave request");
            em.body(message);
            em.sendEmail();
        }
        private void table_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_view.Columns[e.ColumnIndex].Name == "btn_accept")
            {
                String update_query = "";
                if (cmb_user_type.SelectedIndex == 0)
                {
                    update_query = "update Leave set LStatus = 'ACCEPTED',Checks='1' where EmpID = '" + table_view.Rows[e.RowIndex].Cells[0].Value + "' AND LDate = '" + table_view.Rows[e.RowIndex].Cells[2].Value + "';";
                    db.command(update_query);

                    var user_email = db.dataScalar("select Email from Employee where EmpID = '" + table_view.Rows[e.RowIndex].Cells[0].Value + "';");
                    sendMail(user_email.ToString(),
                        "Hi, \n\n" +
                        "Your Leave has been accepted \n\n" +
                        "Thank You.");
                    MessageBox.Show("Accepted ");
                    getEmployeeData();
                }
                else if (cmb_user_type.SelectedIndex == 1)
                {
                    update_query = "update Leave set LStatus = 'ACCEPTED',Checks='1' where LECID = '" + table_view.Rows[e.RowIndex].Cells[0].Value + "' AND LDate = '" + table_view.Rows[e.RowIndex].Cells[2].Value + "';";
                    db.command(update_query);
                    var user_email = db.dataScalar("select LEmail from Lecturer where LID = '" + table_view.Rows[e.RowIndex].Cells[0].Value + "';");

                    sendMail(user_email.ToString(),
                        "Hi, \n\n" +
                        "Your Leave has been accepted \n\n" +
                        "Thank You.");
                    MessageBox.Show("Accepted ");
                    getLecturerData();
                }
            }
            else if (table_view.Columns[e.ColumnIndex].Name == "btn_reject")
            {
                String update_query = "";
                if (cmb_user_type.SelectedIndex == 0)
                {
                    update_query = "update Leave set LStatus = 'REJECTED',Checks='1' where EmpID = '" + table_view.Rows[e.RowIndex].Cells[0].Value + "' AND LDate = '" + table_view.Rows[e.RowIndex].Cells[2].Value + "';";
                    db.command(update_query);

                    var user_email = db.dataScalar("select Email from Employee where EmpID = '" + table_view.Rows[e.RowIndex].Cells[0].Value + "';");
                    sendMail(user_email.ToString(),
                        "Hi, \n\n" +
                        "Your Leave has been REJECTED \n\n" +
                        "Thank You.");
                    MessageBox.Show("REJECTED ");
                    getEmployeeData();
                }
                else if (cmb_user_type.SelectedIndex == 1)
                {
                    update_query = "update Leave set LStatus = 'REJECTED',Checks='1' where LECID = '" + table_view.Rows[e.RowIndex].Cells[0].Value + "' AND LDate = '" + table_view.Rows[e.RowIndex].Cells[2].Value + "';";
                    db.command(update_query);
                    var user_email = db.dataScalar("select LEmail from Lecturer where LID = '" + table_view.Rows[e.RowIndex].Cells[0].Value + "';");

                    sendMail(user_email.ToString(),
                        "Hi, \n\n" +
                        "Your Leave has been REJECTED \n\n" +
                        "Thank You.");
                    MessageBox.Show("REJECTED ");
                    getLecturerData();
                }
            }
        }
    }
}
