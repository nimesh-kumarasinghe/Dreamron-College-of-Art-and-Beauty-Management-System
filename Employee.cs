using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Dreamron_College
{
    class Employee
    {
        Database db;
        public Employee()
        {
            db = new Database();
        }
        public int registerEmployee(String EmpID, String EType, String EFirstName, String ELastName, String ESurname, String EIniName, String ENIC, String EGender, String EDOB, String No, String Street, String City, String EMobile, String Email, String Password, String regdate, String gradeid)
        {
            try
            {
                String cmd = "insert into Employee (EmpID, EType, EFName,ELName,ESName, EIniName, ENIC, EGender, EDOB, AddressNo, Street, City, EMobile, Email, EPassword, ERegDate, GradeID) values('" + EmpID + "', '" + EType + "', '" + EFirstName + "','" + ELastName + "','" + ESurname + "', '" + EIniName + "', '" + ENIC + "', '" + EGender + "', '" + EDOB + "', '" + No + "','" + Street + "','" + City + "','" + EMobile + "', '" + Email + "', '" + Password + "',GETDATE(),'"+ gradeid + "'); ";
                var x = db.command(cmd);

                //Email
                Email em = new Email();
                bool status = em.employeeAccountCreated(EmpID, EIniName, Email, Password); // String EmpID, String EIniName, String Email, String Password
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
        public String getEmpID()
        {
            var max_id = db.dataScalar("select MAX(EmpID) from Employee");

            if (max_id == null)
            {
                return "EMP1";
            }
            else
            {
                int val_length = max_id.Length - 3;
                int intval = int.Parse(max_id.Substring(3, val_length));
                intval++;
                return "EMP" + intval;
            }
        }
        public String[] getEmployeeData(String empid) //get employee data for update
        {
            String[] empdata = new string[16];
            DataTable dt = db.getDatatable("select EType,EFName,ELName,ESName,EIniName,ENIC,EGender,EDOB,AddressNo, Street, City,EMobile,Email,EPassword,ERegDate,GradeID from Employee where EmpID = '" + empid + "';");
            if (dt.Rows.Count == 0)
            {
                empdata[0] = "error";
                return empdata;
            }
            else
            {
                var etype = from row in dt.AsEnumerable() select row["EType"].ToString();
                var fname = from row in dt.AsEnumerable() select row["EFName"].ToString();
                var lname = from row in dt.AsEnumerable() select row["ELName"].ToString();
                var sname = from row in dt.AsEnumerable() select row["ESName"].ToString();
                var ininame = from row in dt.AsEnumerable() select row["EIniName"].ToString();
                var nic = from row in dt.AsEnumerable() select row["ENIC"].ToString();
                var gender = from row in dt.AsEnumerable() select row["EGender"].ToString();
                var dob = from row in dt.AsEnumerable() select row["EDOB"].ToString();
                var no = from row in dt.AsEnumerable() select row["AddressNo"].ToString();
                var street = from row in dt.AsEnumerable() select row["Street"].ToString();
                var city = from row in dt.AsEnumerable() select row["City"].ToString();
                var mobile = from row in dt.AsEnumerable() select row["EMobile"].ToString();
                var email = from row in dt.AsEnumerable() select row["Email"].ToString();
                var password = from row in dt.AsEnumerable() select row["EPassword"].ToString();
                var regdate = from row in dt.AsEnumerable() select row["ERegDate"].ToString();
                var gradeid = from row in dt.AsEnumerable() select row["GradeID"].ToString();

                string[] e_type = etype.ToArray();
                string[] f_name = fname.ToArray();
                string[] I_name = lname.ToArray();
                string[] s_name = sname.ToArray();
                string[] ini_name = ininame.ToArray();
                string[] e_nic = nic.ToArray();
                string[] e_gender = gender.ToArray();
                string[] e_dob = dob.ToArray();
                string[] e_no = no.ToArray();
                string[] e_street = street.ToArray();
                string[] e_city = city.ToArray();
                string[] e_mobile = mobile.ToArray();
                string[] e_email = email.ToArray();
                string[] e_password = password.ToArray();
                string[] e_regdate = regdate.ToArray();
                string[] e_gradeid = gradeid.ToArray();


                empdata[0] = e_type[0];
                empdata[1] = f_name[0];
                empdata[2] = I_name[0];
                empdata[3] = s_name[0];
                empdata[4] = ini_name[0];
                empdata[5] = e_nic[0];
                empdata[6] = e_gender[0];
                empdata[7] = e_dob[0];
                empdata[8] = e_no[0];
                empdata[9] = e_street[0];
                empdata[10] = e_city[0];
                empdata[11] = e_mobile[0];
                empdata[12] = e_email[0];
                empdata[13] = e_password[0];
                empdata[14] = e_regdate[0];
                empdata[15] = e_gradeid[0];

                return empdata;
            }
        }
        //update employee data
        public int updateCourseData(String emptype, String EFirstName, String ELastName, String ESurname, String iname, String nic, String gender, String dob, String No, String Street, String City, String tp, String email, String password, String regdate, String gradeid, String empid)
        {
            try
            {
                string cmd = "Update Employee set  Etype= '" + emptype + "', EFName = '" + EFirstName + "',ELName = '" + ELastName + "',ESName = '" + ESurname + "', EIniName = '" + iname+ "', ENIC=  '" +nic+ "', EGender= '" + gender + "', EDOB= '" + dob + "', AddressNo= '" + No + "',Street= '" + Street + "',City= '" + City + "', EMobile= '" + tp+ "', Email= '" +email+ "', EPassword= '" +password+ "', ERegDate= '" + regdate + "', GradeID= '" + gradeid + "' where EmpID = '" + empid + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public int deleteEmployeeData(String type, String firstname, String lastname, String surename, String siname, String nic, String gender, String dob, String no, String street, String city, String mobile, String email, String employeeid)
        {
            try
            {

                string cmd = "  delete from Salary where EmpID='" + employeeid + "';delete from Leave where EmpID ='" + employeeid + "'; delete From Attendance where EmpID='" + employeeid + "';delete from Employee where EmpID='" + employeeid + "'";
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
