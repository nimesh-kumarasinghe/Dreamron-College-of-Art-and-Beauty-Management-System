using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dreamron_College
{
    class Batch
    {
        Database db;
        public Batch()
        {
            db = new Database();
        }
        public int addNewBatch(String batchid, String startdate, String end_date, String seats, String courseid)
        {
            try
            {
                String cmd = "insert into Batch (BatchID,StartDate,EndDate,Seats,CourseID) values ('" + batchid + "','" + startdate + "','" + end_date + "','" + seats + "','" + courseid + "');";
                System.Console.WriteLine(cmd);
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public String[] getCourseDetails() // get ids of courses
        {
            DataTable dt = db.getDatatable("select CID from Course;");
            var query = from row in dt.AsEnumerable() select row["CID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        public String[] getBatchIdNumbers(string course_id) // get ids of batch
        {
            
            DataTable dt = db.getDatatable("select BatchID from Batch, Course where Batch.CourseID = Course.CID AND CourseID ='"+ course_id + "';");
            var query = from row in dt.AsEnumerable() select row["BatchID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        public String[] getOldBatchIdNumbers(string std_id) // get ids of batch
        {

            DataTable dt = db.getDatatable("select BatchID from Student_Batch where StdID ='" + std_id + "';");
            var query = from row in dt.AsEnumerable() select row["BatchID"].ToString();
            string[] ids = query.ToArray();
            return ids;
        }
        public String getBatchID()
        {
            var max_id = db.dataScalar("select MAX(BatchID) from Batch");

            if (max_id == null)
            {
                return "B1";
            }
            else
            {
                int val_length = max_id.Length - 1;
                int intval = int.Parse(max_id.Substring(1, val_length));
                intval++;
                return "B" + intval;
            }
        }
        public String[] getBatchData(String batchid) //get data for update
        {
            String[] batchdata = new string[4];
            DataTable dt = db.getDatatable("select StartDate,EndDate, Seats, CourseID from Batch where BatchID = '" + batchid + "'");
            if (dt.Rows.Count == 0)
            {

                batchdata[0] = "error";
                return batchdata;
            }
            else
            {
                var start_dates = from row in dt.AsEnumerable() select row["StartDate"].ToString();
                var end_dates = from row in dt.AsEnumerable() select row["EndDate"].ToString();
                var no_seats = from row in dt.AsEnumerable() select row["Seats"].ToString();
                var course_ids = from row in dt.AsEnumerable() select row["CourseID"].ToString();
                string[] str_date = start_dates.ToArray();
                string[] ending_date = end_dates.ToArray();
                string[] num_seats = no_seats.ToArray();
                string[] c_id = course_ids.ToArray();


                batchdata[0] = str_date[0];
                batchdata[1] = ending_date[0];
                batchdata[2] = num_seats[0];
                batchdata[3] = c_id[0];
                return batchdata;
            }
        }
        public int updateBatchData(String startdate, String enddate, String seats, String courseid, String batchid) //update details
        {
            try
            {
                string cmd = "Update Batch set  StartDate= '" + startdate + "',EndDate= '" + enddate + "', Seats = '" + seats + "', CourseID=  '" + courseid + "' where BatchID = '" + batchid + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }
        public String[] getBatchDataDelete(String batchid) //get data for delete
        {

            String[] batchdatadelete = new string[4];
            DataTable dt = db.getDatatable("select StartDate,EndDate, Seats, CourseID from Batch where BatchID = '" + batchid + "'");
            if (dt.Rows.Count == 0)
            {

                batchdatadelete[0] = "error";
                return batchdatadelete;
            }
            else
            {
                var start_dates = from row in dt.AsEnumerable() select row["StartDate"].ToString();
                var end_dates = from row in dt.AsEnumerable() select row["EndDate"].ToString();
                var no_seats = from row in dt.AsEnumerable() select row["Seats"].ToString();
                var course_ids = from row in dt.AsEnumerable() select row["CourseID"].ToString();
                string[] str_date = start_dates.ToArray();
                string[] ending_date = end_dates.ToArray();
                string[] num_seats = no_seats.ToArray();
                string[] c_id = course_ids.ToArray();


                batchdatadelete[0] = str_date[0];
                batchdatadelete[1] = ending_date[0];
                batchdatadelete[2] = num_seats[0];
                batchdatadelete[3] = c_id[0];
                return batchdatadelete;
            }


        }
        public int deleteBatchData(String StartDate, String EndDate, String Seats, String CourseID, String batchid)
        {
            try
            {

                string cmd = "update Student  set BatchId = null where BatchID ='" + batchid + "';delete from Batch where BatchID = '" + batchid + "'";
                var x = db.command(cmd);
                return 0;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        //student get batch id
        public String[] getStudentBatchIdNumber(String studentid) //get course data for delete
        {
            String[] batchdata = new string[1];
            DataTable dt = db.getDatatable("select BatchID from Student_Batch where StdID = '" + studentid + "'");
            if (dt.Rows.Count == 0)
            {

                batchdata[0] = "error";
                return batchdata;
            }
            else
            {
                var b_id = from row in dt.AsEnumerable() select row["BatchID"].ToString();
                

                string[] batid = b_id.ToArray();



                batchdata[0] = batid[0];
                
                return batchdata;
            }

        }
    }
}
