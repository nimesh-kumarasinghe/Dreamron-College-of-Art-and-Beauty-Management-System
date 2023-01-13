using IronPdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamron_College
{
    internal class Salary
    {
        Database db;
        public Salary()
        {
            db = new Database();
        }
        String[] userdata = new string[6];
        int full_day_att_count, half_day_att_count, casual_leaves_count, medical_leaves_count, maternity_leaves_count = 0;
        //userdata[4] -> leaves per month
        //userdata[5] -> salary per day

        //
        public void getUserAttDetails(String c_user_type, String user_id, String start_date, String end_date)
        {
            String user_type = "";
            if (c_user_type.Equals("EMP"))
            {
                user_type = "EmpID";
            }
            else if (c_user_type.Equals("LEC"))
            {
                user_type = "LecID";
            }
            // Attendence

            var full_day = db.dataScalar("select COUNT(AttendanceID) from Attendance where AStatus = 'Full Day' AND " + user_type + " = '" + user_id + "' AND ADate BETWEEN '" + start_date + "' AND '" + end_date + "'");
            if (full_day == null)
            {
                full_day_att_count = 0;
            }
            else
            {
                full_day_att_count = int.Parse(full_day.ToString());
            }
            var half_day = db.dataScalar("select COUNT(AttendanceID) from Attendance where AStatus = 'Half Day' AND " + user_type + " = '" + user_id + "' AND ADate BETWEEN '" + start_date + "' AND '" + end_date + "'");

            if (half_day == null)
            {
                half_day_att_count = 0;
            }
            else
            {
                half_day_att_count = int.Parse(full_day.ToString());
            }

            // Leaves
            var casual_leave = db.dataScalar("select COUNT(LeaveId) from Leave where (LType = 'Casual') AND (" + user_type + " = '" + user_id + "') AND (LDate BETWEEN '" + start_date + "' AND '" + end_date + "') AND (LStatus = 'ACCEPTED')");
            if (half_day == null)
            {
                casual_leaves_count = 0;
            }
            else
            {
                casual_leaves_count = int.Parse(casual_leave.ToString());
            }

            var medical_leave = db.dataScalar("select COUNT(LeaveId) from Leave where (LType = 'Medical') AND (" + user_type + " = '" + user_id + "') AND (LDate BETWEEN '" + start_date + "' AND '" + end_date + "') AND (LStatus = 'ACCEPTED')");
            if (medical_leave == null)
            {
                medical_leaves_count = 0;
            }
            else
            {
                medical_leaves_count = int.Parse(medical_leave.ToString());
            }

            var maternity_leave = db.dataScalar("select COUNT(LeaveId) from Leave where (LType = 'Maternity') AND (" + user_type + " = '" + user_id + "') AND (LDate BETWEEN '" + start_date + "' AND '" + end_date + "') AND (LStatus = 'ACCEPTED')");
            if (maternity_leave == null)
            {
                maternity_leaves_count = 0;
            }
            else
            {
                maternity_leaves_count = int.Parse(maternity_leave.ToString());
            }

            //
        }


        //
        public String getRefId()
        {
            var max_id = db.dataScalar("select MAX(RefNo) from Salary");

            if (max_id == null)
            {
                return "REF1";
            }
            else
            {
                int val_length = max_id.Length - 3;
                int intval = int.Parse(max_id.Substring(3, val_length));
                intval++;
                return "REF" + intval;
            }
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
        public String[] getEmployeeData(String userid)
        {

            DataTable dt = db.getDatatable("select BasicSalary,EPF,ETF,LeavesPerMonth,Allowance,SalaryPerDay from Grade where GradeID = (select GradeID from Employee where EmpID = '" + userid + "')");
            var basicsal = from row in dt.AsEnumerable() select row["BasicSalary"].ToString();
            var allo = from row in dt.AsEnumerable() select row["Allowance"].ToString();
            var etf = from row in dt.AsEnumerable() select row["ETF"].ToString();
            var epf = from row in dt.AsEnumerable() select row["EPF"].ToString();
            var leaves_per_month = from row in dt.AsEnumerable() select row["LeavesPerMonth"].ToString();
            var salary_per_day = from row in dt.AsEnumerable() select row["SalaryPerDay"].ToString();

            string[] bsal = basicsal.ToArray();
            string[] allowance = allo.ToArray();
            string[] etfs = etf.ToArray();
            string[] epfs = epf.ToArray();
            string[] leaves_per_months = leaves_per_month.ToArray();
            string[] salary_per_days = salary_per_day.ToArray();

            userdata[0] = bsal[0];
            userdata[1] = allowance[0];
            userdata[2] = etfs[0];
            userdata[3] = epfs[0];
            userdata[4] = leaves_per_months[0];
            userdata[5] = salary_per_days[0];

            return userdata;
        }
        public String[] getLecturerData(String userid)
        {
            DataTable dt = db.getDatatable("select BasicSalary,EPF,ETF,LeavesPerMonth,Allowance,SalaryPerDay from Grade where GradeID = (select GradeID from Lecturer where LID = '" + userid + "')");
            var basicsal = from row in dt.AsEnumerable() select row["BasicSalary"].ToString();
            var allo = from row in dt.AsEnumerable() select row["Allowance"].ToString();
            var etf = from row in dt.AsEnumerable() select row["ETF"].ToString();
            var epf = from row in dt.AsEnumerable() select row["EPF"].ToString();
            var leaves_per_month = from row in dt.AsEnumerable() select row["LeavesPerMonth"].ToString();
            var salary_per_day = from row in dt.AsEnumerable() select row["SalaryPerDay"].ToString();

            string[] bsal = basicsal.ToArray();
            string[] allowance = allo.ToArray();
            string[] etfs = etf.ToArray();
            string[] epfs = epf.ToArray();
            string[] leaves_per_months = leaves_per_month.ToArray();
            string[] salary_per_days = salary_per_day.ToArray();

            userdata[0] = bsal[0];
            userdata[1] = allowance[0];
            userdata[2] = etfs[0];
            userdata[3] = epfs[0];
            userdata[4] = leaves_per_months[0];
            userdata[5] = salary_per_days[0];

            return userdata;
        }
        public String getEmpName(String empid)
        {
            var name = db.dataScalar("select EIniName from Employee where EmpID = '" + empid + "';");
            return name.ToString();
        }
        public String getLecName(String lecid)
        {
            var name = db.dataScalar("select LIniName from Lecturer where LID = '" + lecid + "';");
            return name.ToString();

        }
        public String getEmpEmail(String empid)
        {
            var name = db.dataScalar("select Email from Employee where EmpID = '" + empid + "';");
            return name.ToString();
        }
        public String getLecEmail(String lecid)
        {
            var name = db.dataScalar("select LEmail from Lecturer where LID = '" + lecid + "';");
            return name.ToString();
        }

        // calculations

        /*
        userdata[0] = bsal[0];
        userdata[1] = allowance[0];
        userdata[2] = etfs[0];
        userdata[3] = epfs[0];
        userdata[4] = leaves_per_months[0];
        userdata[5] = salary_per_days[0];
         */
        public Double calETF()
        {
            double cal_etf = 0;
            //cal_etf = (basic_sal * pres) / 100;
            cal_etf = (double.Parse(userdata[0]) * double.Parse(userdata[2])) / 100;
            return cal_etf;
        }
        public Double calEPF()
        {
            double cal_epf = 0;
            //cal_epf =  (basic_sal * pres) / 100;
            cal_epf = (double.Parse(userdata[0]) * double.Parse(userdata[3])) / 100;
            return cal_epf;
        }
        /*public Double calNetSal()
        {
            //double netsal = basic_sal - epf;
            double netsal = double.Parse(userdata[0]) - calEPF();
            netsal = netsal + double.Parse(userdata[1]);
            return netsal;
        }*/
        public double calNetSal()
        {
            /*
             no_of_leaves_taken=(casual_leaves + medical_leaves)
            if (no_of_leaves_taken>leaves_per_month)
                noPay=(casual_leaves-leaves_per_month)*salary per day
            else
                noPay=0
             */
            //userdata[4] -> leaves per month
            //userdata[5] -> salary per day
            double no_pay = 0;
            int leaves_per_month = int.Parse(userdata[4]);
            double salary_per_day = double.Parse(userdata[5]);
            int number_of_leaves_taken = (casual_leaves_count + medical_leaves_count);
            if (number_of_leaves_taken > leaves_per_month)
            {
                no_pay = (casual_leaves_count - leaves_per_month) * salary_per_day;
            }

            double netsal = double.Parse(userdata[0]) - calEPF();
            netsal = netsal + double.Parse(userdata[1]);

            netsal = netsal - no_pay;

            return netsal;
        }
        //
        public int saveDataLec(String refno, String netsal, String b_sal, String allowance, String etf, String epf, String user_id)
        {
            String query = "insert into Salary (RefNo,NetSal,Date_of_cal,Epf_amount,Etf_amount,LecID) values ('" + refno + "','" + netsal + "', GETDATE(), '" + epf + "', '" + etf + "', '" + user_id + "')";
            System.Console.WriteLine(query);
            try
            {
                db.command(query);
                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public int saveDataEmp(String refno, String netsal, String b_sal, String allowance, String etf, String epf, String user_id)
        {
            String query = "insert into Salary (RefNo,NetSal,Date_of_cal,Epf_amount,Etf_amount,EmpID) values ('" + refno + "','" + netsal + "', GETDATE(), '" + epf + "', '" + etf + "', '" + user_id + "')";
            System.Console.WriteLine(query);
            try
            {
                db.command(query);
                return 0;
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public void sendPaysheet(String email)
        {
            Email em = new Email();
            em.to(email);
            em.subject("Monthly Payslip");
            em.addAttachment("Payslip.pdf");
            em.sendEmail();
        }
        public void createDoc(String date, String emp_name, String ref_no, String emp_type, String basic_sal, String etf, String allowance, String tot_netsal, String etf_amount)
        {
            String tot_earnings = (double.Parse(basic_sal) + double.Parse(allowance)).ToString();
            String tot_deducation = etf;
            var Renderer = new IronPdf.ChromePdfRenderer();
            var pdf = Renderer.RenderHtmlAsPdf("<head>\n" +
                "<style>\ntable{\nwidth: 100%;\nborder-collapse:collapse;\nborder: 1px solid black;\n}\ntable td{line-height:25px;padding-left:15px;}\ntable th{background-color:#fbc403; color:#363636;}\n</style>\n\n</head>\n<body>\n<table border=\"1\">\n<tr height=\"100px\" style=\"background-color:#363636;color:#ffffff;text-align:center;font-size:24px; font-weight:600;\">\n<td colspan='4'>DREAMRON COLLEGE OF ART AND BEAUTY</td>\n</tr>\n<tr>\n<th>PRINTED DATE:\t</th>\n<td>" + date + "</td>\n\n<th>EMPLOYEE NAME:</th>\n<td>" + emp_name + "</td>\n</tr>\n<!-----2 row--->\n<tr>\n<th>REF NO:</th>\n<td>" + ref_no + "</td>\n\n<th>DESIGNATION:</th>\n<td>" + emp_type + "</td>\n</tr>\n\n</table>\n<tr></tr>\n<br/>\n<table border=\"1\">\n<tr>\n<th>Earnings</th>\n<th>Amount</th>\n<th>Deductions</th>\n<th>Amount</th>\n</tr>\n\n<tr>\n<td>BASIC SALARY:</td>\n<td>" + basic_sal + "</td>\n<td>EPF:</td>\n<td>" + etf + "</td>\n</tr>\n\n<tr>\n    <td>ALLOWANCE:</td>\n    <td> " + allowance + "</td>\n\n    <td></td>\n    <td> </td>\n    </tr>\n</tr>\n\n\n<tr>\n    <td>TOTAL EARNINGS:</td>\n    <td>" + tot_earnings + " </td>\n    \n    <td>TOTAL DEDUCTIONS:</td>\n    <td> " + tot_deducation + "</td>\n    </tr>\n</tr>\n\n<td><strong>TOTAL NET SALARY: </strong></td>\n<td>" + tot_netsal + "</td>\n\n<td></td>\n</tr>\n\n<tr>\n    <td>\n        ETF AMOUNT:\n    </td>\n    <td>\n        " + etf_amount + "\n    </td>\n    <td>\n    </td>\n    <td>\n\n    </td>\n</tr>\n</table>\n\n<center><p>THIS IS SYSTEM GENERATED PAYSLIP</p></center>");
            pdf.SaveAs("Payslip.pdf");
        }
    }
}
