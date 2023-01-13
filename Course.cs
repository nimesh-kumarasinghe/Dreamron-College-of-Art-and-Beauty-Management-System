using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Dreamron_College
{
    class Course
    {
        Database db;
        public Course()
        {
            db = new Database();
        }
        public int addCourse(String course_id, String course_name, String course_duration, String course_fee)
        {
            try
            {
                String cmd = "insert into Course (CID,CName,CDuratin,CFee) values ('" + course_id + "','" + course_name + "','" + course_duration + "','" + course_fee + "');";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public String getCourseID()
        {
            var max_id = db.dataScalar("select MAX(CID) from Course");

            if (max_id == null)
            {
                return "C1";
            }
            else
            {
                int val_length = max_id.Length - 1;
                System.Console.WriteLine(val_length + max_id);
                int intval = int.Parse(max_id.Substring(1, val_length));
                intval++;
                return "C" + intval;
            }
        }
        public String[] getCourseData(String courseid) //get course data for update
        {
            String[] coursedata = new string[3];
            DataTable dt = db.getDatatable("select CName, CDuratin, CFee from Course where CID = '" + courseid + "'");
            if (dt.Rows.Count == 0)
            {

                coursedata[0] = "error";
                return coursedata;
            }
            else
            {
                var c_name = from row in dt.AsEnumerable() select row["CName"].ToString();
                var c_duration = from row in dt.AsEnumerable() select row["CDuratin"].ToString();
                var c_fee = from row in dt.AsEnumerable() select row["CFee"].ToString();

                string[] cname = c_name.ToArray();
                string[] cduration = c_duration.ToArray();
                string[] cfee = c_fee.ToArray();



                coursedata[0] = cname[0];
                coursedata[1] = cduration[0];
                coursedata[2] = cfee[0];
                return coursedata;
            }

        }

        public int updateCourseData(String coursename, String duration, String fee, String courseid) // update course data
        {
            try
            {
                string cmd = "Update Course set CName = '" + coursename + "', CDuratin = '" + duration + "', CFee = '" + fee + "' where CID = '" + courseid + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int deleteCoursesData(String coursename, String duration, String fee, String courseid)
        {
            try
            {

                string cmd = "delete from Lecturer_Course where CID='" + courseid + "';delete from Student_Course where CID='" + courseid + "';update Batch set CourseID=null where CourseID='" + courseid + "';update Payment set CourseID=null where CourseID='" + courseid + "' ; delete from Course where CID='" + courseid + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public int deleteCourseData(String coursename, String duration, String fee, String courseid)
        {
            try
            {
                string cmd = "delete from Lecturer_Course where CID='" + courseid + "';delete from Student_Course where CID='" + courseid + "' ; delete from Course where CID='" + courseid + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public String[] getCourseTableData(String course_id)  //get CoursefromCourse data for delete
        {
            SqlDataReader da;
            da = db.dataReader("select CName from Course where CID='" + course_id + "'");
            String[] data = new string[1];
            while (da.Read())
            {
                data[0] = da.GetValue(0).ToString();
            }
            da.Close();
            return data;
        }
        public String[] getCourseNames(String course_ids)  //get previous course name 
        {
            SqlDataReader da;
            da = db.dataReader("select CName from Course where CID='" + course_ids + "'");
            String[] data = new string[1];
            while (da.Read())
            {
                data[0] = da.GetValue(0).ToString();

            }
            da.Close();
            return data;

        }
    }
}
