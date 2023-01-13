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
    public partial class AddStudentAttendance : Form
    {
        Database db;

        public AddStudentAttendance()
        {
            InitializeComponent();
            db = new Database();
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_add.Enabled = false;
        }
        public void getEmployeeData()
        {
            DataTable dtable = db.getDatatable("select DISTINCT Attendance.ADate,Attendance.RoleType,Attendance.AStatus,Attendance.ATimeIn,Attendance.ATimeOut,Attendance.StdID,Student.SIniName from Attendance,Student where ADate = '" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "' AND Attendance.StdID IN (select SID from Student);");

            var date = from row in dtable.AsEnumerable() select row["ADate"].ToString();
            var type = from row in dtable.AsEnumerable() select row["RoleType"].ToString();
            var status = from row in dtable.AsEnumerable() select row["AStatus"].ToString();
            var timein = from row in dtable.AsEnumerable() select row["ATimeIn"].ToString();
            var tinmeout = from row in dtable.AsEnumerable() select row["ATimeOut"].ToString();
            var empid = from row in dtable.AsEnumerable() select row["StdID"].ToString();
            var name = from row in dtable.AsEnumerable() select row["SIniName"].ToString();

            string[] dates = date.ToArray();
            string[] types = type.ToArray();
            string[] statuss = status.ToArray();
            string[] timeins = timein.ToArray();
            string[] tinmeouts = tinmeout.ToArray();
            string[] empids = empid.ToArray();
            string[] names = name.ToArray();

            int x = 0;

            foreach (string id in empids)
            {
                addStudentAttendanceClassBindingSource.Add(new AddStudentAttendanceClass() { id = id, i_name = names[x] });
                table_view.Rows[x].Cells[2].Value = timeins[x];
                table_view.Rows[x].Cells[3].Value = tinmeouts[x];
                table_view.Rows[x].Cells[4].Value = statuss[x];
                x++;
            }
        }
        public String[] getBatchDetails() // get ids of courses
        {
            DataTable dt = db.getDatatable("select BatchID from Batch;");
            var query = from row in dt.AsEnumerable() select row["BatchID"].ToString();
            string[] batchids = query.ToArray();
            return batchids;
        }
        public String[] getCourseDetails(String batch_id) // get ids of courses
        {
            DataTable dt = db.getDatatable("select CID from Course,Batch where BatchID = '" + batch_id + "';");
            var query = from row in dt.AsEnumerable() select row["CID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        private void AddStudentAttendance_Load(object sender, EventArgs e)
        {
            String[] batch_ids = getBatchDetails();
            foreach (String id in batch_ids)
            {
                cmb_batch_selector.Items.Add(id);
            }
        }

        private void cmb_batch_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_course_selector.Items.Clear();
            String[] course_ids = getCourseDetails(cmb_batch_selector.SelectedItem.ToString());

            foreach (String id in course_ids)
            {
                cmb_course_selector.Items.Add(id);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int row_count = table_view.RowCount;
            String query = "insert into Attendance(ADate,RoleType,AStatus,ATimeIn,ATimeOut,StdID)values ";
            String values = "";
            while (counter < row_count)
            {
                values += "('" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "','Student','" +
                    table_view.Rows[counter].Cells[4].Value.ToString() + "','" +
                    table_view.Rows[counter].Cells[2].Value.ToString() + "','" +
                    table_view.Rows[counter].Cells[3].Value.ToString() + "','" +
                    table_view.Rows[counter].Cells[0].Value.ToString() + "'),";
                counter++;
            }
            String rvalues = values.Substring(0, values.Length - 1);
            String full_sql_query = query + rvalues;

            try
            {
                var cmd_status = db.command(full_sql_query);
                MessageBox.Show("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void date_picker_ValueChanged(object sender, EventArgs e)
        {
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_add.Enabled = false;

            table_view.Rows.Clear();
            DataTable dtable = db.getDatatable("select DISTINCT Attendance.ADate,Attendance.RoleType,Attendance.AStatus,Attendance.ATimeIn,Attendance.ATimeOut,Attendance.StdID,Student.SIniName from Attendance,Student where ADate = '" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "' AND Attendance.StdID IN (select SID from Student);");
            if (dtable.Rows.Count == 0)
            {
                btn_add.Enabled = true;
                table_view.Rows.Clear();
                String qry = "select DISTINCT SID,SIniName from Student where SID IN (select DISTINCT StdID from Student_Course where CourseID = '" + cmb_course_selector.SelectedItem.ToString() + "');";
                System.Console.WriteLine(qry);
                DataTable dt = db.getDatatable(qry);
                var user_ids = from row in dt.AsEnumerable() select row["SID"].ToString();
                var users_names = from row in dt.AsEnumerable() select row["SIniName"].ToString();

                string[] ids = user_ids.ToArray();
                string[] names = users_names.ToArray();

                int x = 0;
                foreach (string id in ids)
                {
                    addStudentAttendanceClassBindingSource.Add(new AddStudentAttendanceClass() { id = id, i_name = names[x] });
                    x++;
                }
                int counter = 0;
                int row_count = table_view.RowCount;
                while (counter < row_count)
                {
                    table_view.Rows[counter].Cells[2].Value = "8:30 AM";
                    table_view.Rows[counter].Cells[3].Value = "4:30 PM";
                    table_view.Rows[counter].Cells[4].Value = "Present";
                    counter++;
                }
            }
            else
            {
                btn_add.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;

                table_view.Rows.Clear();

                getEmployeeData();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int row_count = table_view.RowCount;
            String query = "";

            while (counter < row_count)
            {
                query += "update Attendance set Attendance.ATimeIn = '" +
                    table_view.Rows[counter].Cells[2].Value.ToString() + "',Attendance.ATimeOut = '" +
                    table_view.Rows[counter].Cells[3].Value.ToString() + "',Attendance.AStatus = '" +
                    table_view.Rows[counter].Cells[4].Value.ToString() + "' where Attendance.StdID = '" +
                    table_view.Rows[counter].Cells[0].Value.ToString() + "' AND Attendance.ADate = '" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "';";
                counter++;
            }

            System.Console.WriteLine(query);
            try
            {
                var cmd_status = db.command(query);
                MessageBox.Show("UPDATED !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            table_view.Rows.Clear();

            getEmployeeData();

            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = table_view.CurrentCell.RowIndex;
            String query = "delete from Attendance where Attendance.StdID = '" + table_view.Rows[index].Cells[0].Value.ToString() + "' AND Attendance.ADate = '" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "';";
            table_view.Rows.RemoveAt(index);
            try
            {
                db.command(query);
                MessageBox.Show("DELETED !! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
