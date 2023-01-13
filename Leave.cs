using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamron_College
{
    class Leave
    {
        Database db;
        public Leave()
        {
            db = new Database();
        }
        public String[] getAdminId()
        {
            DataTable dt = db.getDatatable("select EmpID from Employee where EType = 'Admin';");
            var query = from row in dt.AsEnumerable() select row["EmpID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        public String[] getStaffId()
        {
            DataTable dt = db.getDatatable("select EmpID from Employee where EType = 'Staff';");
            var query = from row in dt.AsEnumerable() select row["EmpID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        public String[] getManagerID()
        {
            DataTable dt = db.getDatatable("select EmpID from Employee where EType = 'Manager';");
            var query = from row in dt.AsEnumerable() select row["EmpID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        public String[] getLecturerId()
        {
            DataTable dt = db.getDatatable("select LID from Lecturer;");
            var query = from row in dt.AsEnumerable() select row["LID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        public int requestLeave(String user_type_cmb, String ltype, String ldate, String reason, String user_id)
        {
            String usertype = "";
            if (user_type_cmb.Equals("LECTURER"))
            {
                usertype = "LecID";
            }
            else
            {
                usertype = "EmpID";
            }

            String query = "insert into Leave (LType,LDate,Reason,Checks," + usertype + ",LStatus) values ('" + ltype + "','" + ldate + "','" + reason + "','0','" + user_id + "','Pending');";
            try
            {
                db.command(query);
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

    }
}
