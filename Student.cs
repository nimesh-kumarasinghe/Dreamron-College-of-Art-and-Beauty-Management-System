using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dreamron_College
{
    class Student
    {
        Database db;
        public Student()
        {
            db = new Database();
        }
        public int addNewStudent(String student_id, String student_FirstName, String student_LastName, String student_Surname, String student_name_with_i, String student_nic, String student_gender, String student_dob, String No, String Street, String City, String student_mobile, String student_email)
        {
            try
            {
                String cmd = "insert into Student(SID,SFirstName,SLastName,SSurename,SIniName,SNIC,SGender,SDOB, No, Street, City,SMobile,SEmail) values ('" + student_id + "','" + student_FirstName + "','" + student_LastName + "','" + student_Surname + "','" + student_name_with_i + "','" + student_nic + "','" + student_gender + "','" + student_dob + "','" + No + "','" + Street + "','" + City + "','" + student_mobile + "','" + student_email + "');";
                System.Console.WriteLine(cmd);
                var x = db.command(cmd);
                //Email
                Email em = new Email();
                bool status = em.studentAccountCreated(student_email, student_id, student_name_with_i); //String student_email,String student_id,String student_name_with_i
                if (status == true)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
                //email
            }
            catch (Exception ex)
            {
                return -2;
            }

        }
        public String getStudentId()
        {
            var max_id = db.dataScalar("select MAX(SID) from Student");

            if (max_id == null)
            {
                return "STU1";
            }
            else
            {
                int val_length = max_id.Length - 3;
                int intval = int.Parse(max_id.Substring(3, val_length));
                intval++;
                return "STU" + intval;
            }
        }

        public String[] getStudentData(String studnetid)
        {
            String[] studata = new string[15];
            DataTable dt = db.getDatatable("select SFName,SLName,SSName,SIniName,SNIC,SGender,SDOB, AddressNo, Street, City,SMobile,SEmail from Student where SID = '" + studnetid + "'");
            if (dt.Rows.Count == 0)
            {
                studata[0] = "error";
                return studata;
            }
            else
            {
                var fname = from row in dt.AsEnumerable() select row["SFName"].ToString();
                var lname = from row in dt.AsEnumerable() select row["SLName"].ToString();
                var sname = from row in dt.AsEnumerable() select row["SSName"].ToString();
                var iname = from row in dt.AsEnumerable() select row["SIniName"].ToString();
                var nic = from row in dt.AsEnumerable() select row["SNIC"].ToString();
                var gender = from row in dt.AsEnumerable() select row["SGender"].ToString();
                var dob = from row in dt.AsEnumerable() select row["SDOB"].ToString();
                var no = from row in dt.AsEnumerable() select row["AddressNo"].ToString();
                var street = from row in dt.AsEnumerable() select row["Street"].ToString();
                var city = from row in dt.AsEnumerable() select row["City"].ToString();
                var lmobile = from row in dt.AsEnumerable() select row["SMobile"].ToString();
                var lemail = from row in dt.AsEnumerable() select row["SEmail"].ToString();

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

                studata[0] = f_name[0];
                studata[1] = l_name[0];
                studata[2] = s_name[0];
                studata[3] = i_name[0];
                studata[4] = l_nic[0];
                studata[5] = l_gender[0];
                studata[6] = l_dob[0];
                studata[7] = l_no[0];
                studata[8] = l_street[0];
                studata[9] = l_city[0];
                studata[10] = l_mobile[0];
                studata[11] = l_email[0];

                return studata;
            }
        }


        public int updateStudentData(String SFirstName, String SLastName, String SSurname, String siname, String nic, String gender, String dob, String No, String Street, String City, String mobile, String email, String studnetid)
        {
            try
            {
                string cmd = "Update Student set  SFName= '" + SFirstName + "', SLName= '" + SLastName + "', SSName= '" + SSurname + "', SIniName = '" + siname + "', SNIC=  '" + nic + "', SGender= '" + gender + "', SDOB= '" + dob + "', AddressNo = '" + No + "',Street= '" + Street + "',City = '" + City + "', SMobile= '" + mobile + "', SEmail= '" + email + "' where SID = '" + studnetid + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public String[] getStudentINIdata(String student_id)  //get Student initialname data 
        {
            SqlDataReader da;
            da = db.dataReader("select SIniName from Student where SID='" + student_id + "'");
            String[] data = new string[1];
            while (da.Read())
            {
                data[0] = da.GetValue(0).ToString();

            }
            da.Close();
            return data;

        }
        public int addStudentforcourse(String stdID, String CourseId, String regdate,string batchid)
        {

            try
            {

                string cmd = "Insert into Student_Course (StdID,CourseID,RegDate)values('" + stdID + "','" + CourseId + "','" + regdate + "');Insert into Student_Batch values('"+ stdID + "','"+ batchid + "')";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public String[] getStudent_coursedata(String student_id)  //get Student fromCourse data 
        {
            SqlDataReader da;
            da = db.dataReader("select CourseID from Student_Course where StdID='" + student_id + "'");
            String[] data = new string[1];
            while (da.Read())
            {
                data[0] = da.GetValue(0).ToString();

            }
            da.Close();
            return data;

        }
        public int deleteStudentCourse(String student_id)// delete Course_assign Student
        {

            try
            {

                string cmd = "delete from Student_Course where StdID='" + student_id + "';delete from Student_Batch where StdID='"+ student_id + "' ";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }


        }
        public String[] getCoursedate(String student_id, String c_id)  //get Student initialname data 
        {
            SqlDataReader da;
            da = db.dataReader("select RegDate from Student_Course where StdID='" + student_id + "' AND CourseID = '" + c_id + "'");
            String[] data = new string[1];
            while (da.Read())
            {
                data[0] = da.GetValue(0).ToString();

            }
            da.Close();
            return data;

        }
        public int updatestudentformcourse(String regdate, String stuId, String c_id, String newStdID, String newCID, String newdate)
        {

            try
            {
                string cmd = "delete from Student_Course where StdID='" + stuId + "'AND CourseID='" + c_id + "' AND RegDate='" + regdate + "'"; //;insert into Student_Course values('" + newStdID + "','" + newCID + "','" + newdate + "')";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }

        }
        public int deleteStudentData(String firstname, String lastname, String surname, String siname, String nic, String no, String street, String city, String mobile, String email, String studentid)
        {
            try
            {
                string cmd = " delete from Payment where StdID='" + studentid + "';delete from Student_Course where StdID='" + studentid + "'; delete from Attendance where StdID ='" + studentid + "';delete from Student where SID ='" + studentid + "'";

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
