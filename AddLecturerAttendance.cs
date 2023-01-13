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
    public partial class AddLecturerAttendance : Form
    {
        Database db;
        public AddLecturerAttendance()
        {
            InitializeComponent();
            db = new Database();
            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_add.Enabled = false;
        }
        public void getLecturerData()
        {
            DataTable dtable = db.getDatatable("select DISTINCT Attendance.ADate,Attendance.RoleType,Attendance.AStatus,Attendance.ATimeIn,Attendance.ATimeOut,Attendance.LecID,Lecturer.LIniName from Attendance,Lecturer where ADate = '" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "' AND Attendance.LecID IN (select LecID from Lecturer);");

            var status = from row in dtable.AsEnumerable() select row["AStatus"].ToString();
            var timein = from row in dtable.AsEnumerable() select row["ATimeIn"].ToString();
            var tinmeout = from row in dtable.AsEnumerable() select row["ATimeOut"].ToString();
            var empid = from row in dtable.AsEnumerable() select row["LecID"].ToString();
            var name = from row in dtable.AsEnumerable() select row["LIniName"].ToString();

            string[] statuss = status.ToArray();
            string[] timeins = timein.ToArray();
            string[] tinmeouts = tinmeout.ToArray();
            string[] empids = empid.ToArray();
            string[] names = name.ToArray();

            int x = 0;

            foreach (string id in empids)
            {
                addLecturerAttendanceClassBindingSource.Add(new AddLecturerAttendanceClass() { id = id, i_name = names[x] });
                table_view.Rows[x].Cells[2].Value = timeins[x];
                table_view.Rows[x].Cells[3].Value = tinmeouts[x];
                table_view.Rows[x].Cells[4].Value = statuss[x];
                x++;
            }
        }
        private void date_picker_ValueChanged(object sender, EventArgs e)
        {

            btn_update.Enabled = false;
            btn_delete.Enabled = false;
            btn_add.Enabled = false;

            table_view.Rows.Clear();
            DataTable dtable = db.getDatatable("select DISTINCT Attendance.ADate,Attendance.RoleType,Attendance.AStatus,Attendance.ATimeIn,Attendance.ATimeOut,Attendance.LecID,Lecturer.LIniName from Attendance,Lecturer where ADate = '" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "' AND Attendance.LecID IN (select LecID from Lecturer);");
            if (dtable.Rows.Count == 0)
            {
                btn_add.Enabled = true;
                DataTable dt = db.getDatatable("select LID,LIniName from Lecturer;");
                var user_ids = from row in dt.AsEnumerable() select row["LID"].ToString();
                var users_names = from row in dt.AsEnumerable() select row["LIniName"].ToString();

                string[] ids = user_ids.ToArray();
                string[] names = users_names.ToArray();

                int x = 0;
                foreach (string id in ids)
                {
                    addLecturerAttendanceClassBindingSource.Add(new AddLecturerAttendanceClass() { id = id, i_name = names[x] });
                    x++;
                }
                int counter = 0;
                int row_count = table_view.RowCount;
                while (counter < row_count)
                {
                    table_view.Rows[counter].Cells[2].Value = "8:30 AM";
                    table_view.Rows[counter].Cells[3].Value = "4:30 PM";
                    table_view.Rows[counter].Cells[4].Value = "Full Day";
                    counter++;
                }
            }
            else
            {
                btn_add.Enabled = false;
                btn_update.Enabled = true;
                btn_delete.Enabled = true;

                table_view.Rows.Clear();
                getLecturerData();
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            int counter = 0;
            int row_count = table_view.RowCount;
            String query = "insert into Attendance(ADate,RoleType,AStatus,ATimeIn,ATimeOut,LecID)values ";
            String values = "";
            while (counter < row_count)
            {
                values += "('" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "','Lecturer','" +
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
                    table_view.Rows[counter].Cells[4].Value.ToString() + "' where Attendance.LecID = '" +
                    table_view.Rows[counter].Cells[0].Value.ToString() + "' AND Attendance.Date = '" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "';";
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

            getLecturerData();

            btn_add.Enabled = false;
            btn_update.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int index = table_view.CurrentCell.RowIndex;
            String query = "delete from Attendance where Attendance.LecID = '" + table_view.Rows[index].Cells[0].Value.ToString() + "' AND Attendance.ADate = '" + date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day + "';";
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
