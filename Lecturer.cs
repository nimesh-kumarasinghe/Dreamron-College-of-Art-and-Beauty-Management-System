using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dreamron_College
{
    class Lecturer
    {
        Database db;
        public Lecturer()
        {

            db = new Database();

        }
        public int registerLecturer(String ID, String LFirstName, String LLastName, String LSurname, String IniName, String NIC, String Gender, String DOB, String No, String Street, String City, String Mobile, String Email, String Regdate, String gradeid)
        {
            try
            {
                //insert into Lecturer (LID, LFName, LIniName, LNIC,LGender, LDOB, LAddress, LMobile, LEmail, LBasicSalary, EPF, ETF) values('LEC1', '1', '1', '1', '1', '2020-10-10', '1', '1', '1', '1', '1', '1');
                String cmd = "insert into Lecturer (LID, LFName,LLName,LSname, LIniName, LNIC,LGender, LDOB, AddressNo, Street, City, LMobile, LEmail,LRegDate,GradeID) values('" + ID + "','" + LFirstName + "','" + LLastName + "','" + LSurname + "','" + IniName + "','" + NIC + "','" + Gender + "','" + DOB + "','" + No + "','" + Street + "','" + City + "','" + Mobile + "','" + Email + "','" + Regdate + "','" + gradeid + "');";
                System.Console.WriteLine(cmd);
                var x = db.command(cmd);

                //Email
                Email em = new Email();
                bool status = em.lecturerAccountCreated(ID, Email, IniName);//String ID,String Email, String IniName
                if (status == true)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }

            }
            catch (Exception ex)
            {
                return -2;
            }
        }
        public String getLecID()
        {
            var max_id = db.dataScalar("select MAX(LID) from Lecturer");

            if (max_id == null)
            {
                return "LEC1";
            }
            else
            {
                int val_length = max_id.Length - 3;
                int intval = int.Parse(max_id.Substring(3, val_length));
                intval++;
                return "LEC" + intval;
            }
        }
        public String[] getLecturerData(String lid) //get employee data for update
        {
            String[] lecata = new string[14];
            DataTable dt = db.getDatatable("select LFName,LLName,LSname,LIniName,LNIC,LGender,LDOB,AddressNo, Street, City,LMobile,LEmail,LRegDate,GradeID from Lecturer where LID = '" + lid + "'");
            if (dt.Rows.Count == 0)
            {
                lecata[0] = "error";
                return lecata;
            }
            else
            {
                var fname = from row in dt.AsEnumerable() select row["LFName"].ToString();
                var lname = from row in dt.AsEnumerable() select row["LLName"].ToString();
                var sname = from row in dt.AsEnumerable() select row["LSname"].ToString();
                var iname = from row in dt.AsEnumerable() select row["LIniName"].ToString();
                var nic = from row in dt.AsEnumerable() select row["LNIC"].ToString();
                var gender = from row in dt.AsEnumerable() select row["LGender"].ToString();
                var dob = from row in dt.AsEnumerable() select row["LDOB"].ToString();
                var no = from row in dt.AsEnumerable() select row["AddressNo"].ToString();
                var street = from row in dt.AsEnumerable() select row["Street"].ToString();
                var city = from row in dt.AsEnumerable() select row["City"].ToString();
                var lmobile = from row in dt.AsEnumerable() select row["LMobile"].ToString();
                var lemail = from row in dt.AsEnumerable() select row["LEmail"].ToString();
                var lregdate = from row in dt.AsEnumerable() select row["LRegDate"].ToString();
                var gradeid = from row in dt.AsEnumerable() select row["GradeID"].ToString();
                

                string[] f_name = fname.ToArray();
                string[] l_name = lname.ToArray();
                string[] s_name = sname.ToArray();
                string[] i_name = iname.ToArray();
                string[] l_nic = nic.ToArray();
                string[] l_gender = gender.ToArray();
                string[] l_dob = dob.ToArray();
                string[] l_no = no.ToArray();
                string[] l_street = street.ToArray();
                string[] l_city = city.ToArray();
                string[] l_mobile = lmobile.ToArray();
                string[] l_email = lemail.ToArray();
                string[] l_regdate = lregdate.ToArray();
                string[] l_gradeid = gradeid.ToArray();
                

                lecata[0] = f_name[0];
                lecata[1] = l_name[0];
                lecata[2] = s_name[0];
                lecata[3] = i_name[0];
                lecata[4] = l_nic[0];
                lecata[5] = l_gender[0];
                lecata[6] = l_dob[0];
                lecata[7] = l_no[0];
                lecata[8] = l_street[0];
                lecata[9] = l_city[0];
                lecata[10] = l_mobile[0];
                lecata[11] = l_email[0];
                lecata[12] = l_regdate[0];
                lecata[13] = l_gradeid[0];
               
                return lecata;
            }
        }
        //update employee data
        public int updateLecturerData(String LFirstName, String LLastName, String LSurname, String iname, String nic, String gender, String dob, String No, String Street, String City, String tp, String email, String LRegDate, String GradeID, String lid)
        {
            try
            {
                string cmd = "Update Lecturer set  LFName= '" + LFirstName + "',LLName= '" + LLastName + "',LSname= '" + LSurname + "', LIniName = '" + iname + "', LNIC = '" + nic + "', LGender=  '" + gender + "', LDOB= '" + dob + "', AddressNo= '" + No + "',Street= '" + Street + "',City= '" + City + "', LMobile= '" + tp + "', LEmail= '" + email + "', LBasicSalary= '" + LRegDate + "', EPF= '" + GradeID + "' where LID = '" + lid + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public String[] getLecturerAssignData(String lecturer_id)  //get LecturerfromCourse data for delete
        {
            SqlDataReader da;
            da = db.dataReader("select LecID,CourseID from Lecturer_Course where LecID = '" + lecturer_id + "'");
            String[] data = new string[2];
            while (da.Read())
            {
                data[0] = da.GetValue(0).ToString();
                data[1] = da.GetValue(1).ToString();



            }
            da.Close();
            return data;

        }
        public String[] getLecturerTableData(String lecturer_id)  //get LecturerfromCourse data for delete
        {
            SqlDataReader da;
            da = db.dataReader("select LIniName from Lecturer where LID='" + lecturer_id + "'");
            String[] data = new string[1];
            while (da.Read())
            {
                data[0] = da.GetValue(0).ToString();

            }
            da.Close();
            return data;

        }
        public int deleteLectureAssignCourse(String CourseID, String lecturer_id)// delete Course_assign lecturer
        {

            try
            {

                string cmd = "delete from Lecturer_Course where LecID='" + lecturer_id + "'AND CourseID='" + CourseID + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }


        }
        public int addlecturerforcourse(String LecID, String CourseId)
        {

            try
            {

                string cmd = "Insert into Lecturer_Course values('" + LecID + "','" + CourseId + "')";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        //updatelecturerformcourse
        public int updatelecturerformcourse(String LecID, String CourseId)
        {
            try
            {

                string cmd = "update Lecturer_Course set LecID ='" + LecID + "' where CourseID='" + CourseId + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        //privous data for update   start
        public String[] getLectureINIdata(String lecturer_id)  //get Lecturer initialname 
        {
            SqlDataReader da;
            da = db.dataReader("select LIniName from Lecturer where LID='" + lecturer_id + "'");
            String[] data = new string[1];
            while (da.Read())
            {
                data[0] = da.GetValue(0).ToString();

            }
            da.Close();
            return data;

        }

        public String[] getCoursename(String course_ids)  //get previous course name 
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
        //to get course id
        public String[] getCourseName(String lec_ids)  //get previous course name 
        {
            SqlDataReader da;
            da = db.dataReader("select CourseID from Lecturer_Course where LecID='" + lec_ids + "'");
            String[] data = new string[1];
            while (da.Read())
            {
                data[0] = da.GetValue(0).ToString();

            }
            da.Close();
            return data;

        }


        //privous data for update   End

        //update lecturer from course
        public int updateLecturerformcourse(String LecID, String CourseId, String newLecID, String newCID)
        {

            try
            {

                string cmd = "delete from Lecturer_Course where LecID='" + LecID + "';insert into Lecturer_Course values('" + newLecID + "','" + newCID + "')";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }

        }


        public int deleteLecturerData(String firstame, String lastname, String surname, String siname, String nic, String gender, String dob, String no, String street, String city, String telephone, String email, String lecturerid)
        {
            try
            {

                string cmd = "delete from Salary where LecID='" + lecturerid + "';delete from Attendance where LecID='" + lecturerid + "';delete from Leave where LecID='" + lecturerid + "'; delete from Lecturer_Course where LecID='" + lecturerid + "';delete from Lecturer where LID= '" + lecturerid + "';";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }

    }
}
