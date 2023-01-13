using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dreamron_College
{
    class Grade
    {
        Database db;

        public Grade()
        {
            db = new Database();
        }
        public String getGradeId() //get Grade id
        {
            var max_id = db.dataScalar("select MAX(GradeID) from Grade");

            if (max_id == null)
            {
                return "G1";
            }
            else
            {
                int val_length = max_id.Length - 1;
                int intval = int.Parse(max_id.Substring(1, val_length));
                intval++;
                return "G" + intval;
            }
        }
        public int addGrade(String gradeid, String gradename, String basic_salary, String epf, String etf, String leaves_per_month, String allowance, String salary_per_day)
        {
            String query = "insert into Grade (GradeID,GradeName,BasicSalary,EPF,ETF,LeavesPerMonth,Allowance,SalaryPerDay) values ('" + gradeid + "','" + gradename + "','" + basic_salary + "','" + epf + "','" + etf + "','" + leaves_per_month + "','" + allowance + "','" + salary_per_day + "');";
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

        public String[] getGradeIds() // get ids of grade for update
        {
            DataTable dt = db.getDatatable("select GradeID from Grade;");
            var query = from row in dt.AsEnumerable() select row["GradeID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }

        public String[] getGradeData(String gradeid) //get grade data for update
        {
            String[] grade_data = new string[8];
            DataTable dt = db.getDatatable("select GradeName,BasicSalary,EPF,ETF,LeavesPerMonth,Allowance,SalaryPerDay from Grade where GradeID = '" + gradeid + "';");
            if (dt.Rows.Count == 0)
            {
                grade_data[0] = "error";
                return grade_data;
            }
            else
            {
                var gname = from row in dt.AsEnumerable() select row["GradeName"].ToString();
                var gbsal = from row in dt.AsEnumerable() select row["BasicSalary"].ToString();
                var gepf = from row in dt.AsEnumerable() select row["EPF"].ToString();
                var getf = from row in dt.AsEnumerable() select row["ETF"].ToString();
                var gleaves_per_month = from row in dt.AsEnumerable() select row["LeavesPerMonth"].ToString();
                var gallow = from row in dt.AsEnumerable() select row["Allowance"].ToString();
                var gsalary_p_day = from row in dt.AsEnumerable() select row["GradeName"].ToString();

                String[] a_gname = gname.ToArray();
                String[] a_gbsal = gbsal.ToArray();
                String[] a_gepf = gepf.ToArray();
                String[] a_getf = getf.ToArray();
                String[] a_gleaves = gleaves_per_month.ToArray();
                String[] a_gallow = gallow.ToArray();
                String[] a_gsalary_p_day = gleaves_per_month.ToArray();

                grade_data[0] = a_gname[0];
                grade_data[1] = a_gbsal[0];
                grade_data[2] = a_gepf[0];
                grade_data[3] = a_getf[0];
                grade_data[4] = a_gleaves[0];
                grade_data[5] = a_gallow[0];
                grade_data[6] = a_gsalary_p_day[0];

                return grade_data;
            }
        }
        public int updateGrade(String gradeid, String gradename, String basic_salary, String epf, String etf, String leaves_per_month, String allowance, String salary_per_day)
        {
            String query = "Update Grade set GradeName='" + gradename + "',BasicSalary='" + basic_salary + "',EPF='" + epf + "',ETF='" + etf + "',LeavesPerMonth='" + leaves_per_month + "',Allowance='" + allowance + "',SalaryPerDay='" + salary_per_day + "' where GradeID = '" + gradeid + "';";
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

        public int deletGrade(String gradeid)
        {
            String query = "delete from Grade Where GradeID = '" + gradeid + "';";
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
    }
}
