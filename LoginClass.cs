using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace Dreamron_College
{
    internal class LoginClass
    {
        Database db = new Database();
        public String login(String usid , String pwd)
        {
            DataTable dt = db.getDatatable("select EType,EmpID,EPassword from Employee;");

            var empoloyee_types = from row in dt.AsEnumerable() select row["EType"].ToString();
            var empoloyee_ids = from row in dt.AsEnumerable() select row["EmpID"].ToString();
            var empoloyee_passwords = from row in dt.AsEnumerable() select row["EPassword"].ToString();

            string[] emptypes = empoloyee_types.ToArray();
            string[] empids = empoloyee_ids.ToArray();
            string[] passwords = empoloyee_passwords.ToArray();

            int counter = 0;
            String userid = usid.ToUpper();
            String userpassword = pwd;

            foreach (var empid in empids)
            {
                if (userid.Equals(empids[counter]))
                {
                    if (userpassword.Equals(passwords[counter]))
                    {
                        //TextFile - write
                        using (StreamWriter streamwriter = new StreamWriter("userType.txt"))
                        {
                            streamwriter.WriteLine(emptypes[counter]);
                        }
                        //TextFile
                        return emptypes[counter];
                        break;
                    }
                }
                counter++;
            }
            return "-1";
        }
    }
}
