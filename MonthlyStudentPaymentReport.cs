using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dreamron_College
{
    public partial class MonthlyStudentPaymentReport : Form
    {
        Database db;
        public MonthlyStudentPaymentReport()
        {
            InitializeComponent();
            db = new Database();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error");
        }
        private void MonthlyStudentPaymentReport_Load(object sender, EventArgs e)
        {


            rv_all.Visible = false;
            rv_relcourse.Visible = false;

            String[] batch_ids = getBatchId();
            foreach (String id in batch_ids)
            {
                cmb_batchid.Items.Add(id);
            }


        }
        public String[] getBatchId()
        {
            DataTable dt = db.getDatatable("select BatchID from Batch;");
            var query = from row in dt.AsEnumerable() select row["BatchID"].ToString();
            string[] batchid = query.ToArray();
            return batchid;
        }
        public String[] getCourseName()
        {
                DataTable dt = db.getDatatable("select CName from Course, Batch where Batch.CourseID = Course.CID AND BatchID ='" + cmb_batchid.SelectedItem.ToString() + "'");
                var query = from row in dt.AsEnumerable() select row["CName"].ToString();
                string[] coursename = query.ToArray();
                return coursename;

        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            dt_firstday.ResetText();
            dt_lastday.ResetText();
            cmb_batchid.Items.Clear();
            cmb_cname.Items.Clear();
            rv_all.Clear();
            rv_relcourse.Clear();
            rv_all.Visible = false;
            rv_relcourse.Visible = false;

            MonthlyStudentPaymentReport monthpay = new MonthlyStudentPaymentReport();
            monthpay.Refresh();
            String[] batch_ids = getBatchId();
            foreach (String id in batch_ids)
            {
                cmb_batchid.Items.Add(id);
            }
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            if (cmb_batchid.SelectedIndex.Equals(-1) && cmb_cname.SelectedIndex.Equals(-1))
                error_msg("Please Select Batch ID and Course Name");
            else if (cmb_cname.SelectedIndex.Equals(-1))
                error_msg("Please Select Course Name");
            else
            {
                    rv_all.Visible = false;
                    rv_relcourse.Visible = true;
                    // TODO: This line of code loads data into the 'RelavantCoursePayments.Paymentrel' table. You can move, or remove it, as needed.
                    this.PaymentrelTableAdapter.Fill(this.RelavantCoursePayments.Paymentrel, dt_firstday.Value.ToString(), dt_lastday.Value.ToString(), cmb_cname.SelectedItem.ToString());
                    this.rv_relcourse.RefreshReport();
            }
        }

        private void btn_allreports_Click(object sender, EventArgs e)
        {

            rv_relcourse.Visible = false;
            rv_all.Visible = true;
            // TODO: This line of code loads data into the 'PaymentDataset.Payment' table. You can move, or remove it, as needed.
            this.PaymentTableAdapter.Fill(this.PaymentDataset.Payment, dt_firstday.Value.ToString(), dt_lastday.Value.ToString());
            this.rv_all.RefreshReport();
        }

        private void cmb_batchid_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] course_ids = getCourseName();
            foreach (String id in course_ids)
            {
                cmb_cname.Items.Add(id);
            }
        }
    }
}
