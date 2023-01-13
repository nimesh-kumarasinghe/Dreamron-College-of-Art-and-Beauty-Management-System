using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Dreamron_College
{
    class StudentPaymentDetails
    {
        Database db;
        public StudentPaymentDetails()
        {
            db = new Database();
        }
        public String[] getBatchDetails()
        {
            DataTable dt = db.getDatatable("select BatchID from Batch;");
            var query = from row in dt.AsEnumerable() select row["BatchID"].ToString();
            string[] batchids = query.ToArray();
            return batchids;
        }
        public String[] getCourseDetails(String batch_id)
        {
            DataTable dt = db.getDatatable("select CID from Course,Batch where BatchID = '" + batch_id + "';");
            var query = from row in dt.AsEnumerable() select row["CID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        public String[] getStudentDetails(String course_id)
        {
            DataTable dt = db.getDatatable("select StdID from Student_Course where CID = '" + course_id + "';");
            var query = from row in dt.AsEnumerable() select row["StdID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        public String getRefID()
        {
            var max_id = db.dataScalar("select MAX(RefNo) from Payment");

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
        public int insertStundetPaymentDetails(String refno, String amount, String date, String status, String stid, String courseid)
        {
            String query = "insert into Payment (RefNo,Amount,Date,Status,StdID,CourseID) values ('" + refno + "', '" + amount + "', '" + date + "', '" + status + "', '" + stid + "', '" + courseid + "'); ";
            try
            {
                var student_email = db.dataScalar("select SEmail from Student where SID = '" + stid + "';");
                var student_i_name = db.dataScalar("select SIniName from Student where SID = '" + stid + "';");
                var course_name = db.dataScalar("select CName from Course where CID = '" + courseid + "';");
                db.command(query);
                Email em = new Email();
                em.to(student_email.ToString());
                if (status.Equals("Paid"))
                {
                    em.subject("Payment Successful");
                    em.body(
                        "Dear " + student_i_name + "\n\n" +
                        "Thank you for joining with our course.\n" +
                        "Your payment is successfull!\n\n" +
                        "Payment Reciept\n\n" +
                        "- Refference No. : " + refno + "\n" +
                        "- Student Name : " + student_i_name + " \n" +
                        "- Course Name : " + course_name + " \n" +
                        "- Payment Date : " + date + " \n\n" +
                        "Total Amount : Rs." + amount + "\n\n" +
                        "Best Regards \n" +
                        "Thank you! \n" +
                        "Dreamron College of Art & Beauty."
                        );

                }
                else if (status.Equals("UnPaid"))
                {
                    em.subject("Payment UnSuccessful");
                    em.body(
                        "Dear " + student_i_name + "\n\n" +
                        "Your payment is unsuccessfull!\n\n" +
                        "Payment Reciept\n\n" +
                        "- Refference No. : " + refno + "\n" +
                        "- Student Name : " + student_i_name + " \n" +
                        "- Course Name : " + course_name + " \n" +
                        "- Payment Date : " + date + " \n\n" +
                        "Total Amount : Rs." + amount + "\n\n" +
                        "Best Regards \n" +
                        "Thank you! \n" +
                        "Dreamron College of Art & Beauty."
                        );
                }
                em.sendEmail();
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
    }
}
