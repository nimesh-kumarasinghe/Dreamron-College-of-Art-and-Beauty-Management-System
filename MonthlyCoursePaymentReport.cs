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
    public partial class MonthlyCoursePaymentReport : Form
    {
        Database db;
        public MonthlyCoursePaymentReport()
        {
            InitializeComponent();
            db = new Database();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error");
        }

        private void MonthlyCoursePaymentReport_Load(object sender, EventArgs e)
        {

        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coursepaymentdataset.Payment' table. You can move, or remove it, as needed.
            this.PaymentTableAdapter.Fill(this.coursepaymentdataset.Payment, dt_firstday.Value.ToString(), dt_lastday.Value.ToString());
            this.rv_coursepayment.RefreshReport();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dt_lastday.ResetText();
            dt_firstday.ResetText();
            rv_coursepayment.Clear();
        }
    }
}
