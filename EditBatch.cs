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
    public partial class EditBatch : Form
    {
        Batch batch;
        public EditBatch()
        {
            InitializeComponent();
            batch = new Batch();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_batch_id.Text))
                error_msg("Batch id cannot be empty ! ");
            else
            {
                String[] userdata = batch.getBatchData(txt_batch_id.Text);
                if (userdata[0].Equals("error"))
                {
                    error_msg("Not Found");
                }
                else
                {
                    startdate_picker.Text = userdata[0].ToString();
                    endtdate_picker.Text = userdata[1].ToString();
                    txt_seat.Text = userdata[2];
                    txt_course_id.Text = userdata[3];
                }
            }
        }
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_batch_id.Clear();
            txt_course_id.Clear();
            txt_seat.Clear();
            startdate_picker.ResetText();
            endtdate_picker.ResetText();
        }

        private void btn_update_batch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_batch_id.Text))
                error_msg("Batch id cannot be empty ! ");
            else if (string.IsNullOrEmpty(txt_seat.Text))
                error_msg("Please enter no of seats ! ");
            else if (string.IsNullOrEmpty(txt_course_id.Text))
                error_msg("Course id cannot be empty !");
            else if (!txt_seat.Text.Any(char.IsDigit))
                error_msg("No of seats cannot contain letters !");
            else
            {
                int status = batch.updateBatchData(
            startdate_picker.Value.Year + "-" + startdate_picker.Value.Month + "-" + startdate_picker.Value.Day,
            endtdate_picker.Value.Year + "-" + endtdate_picker.Value.Month + "-" + endtdate_picker.Value.Day,
            txt_seat.Text,
            txt_course_id.Text,
            txt_batch_id.Text
            );
                if (status == 0)
                {
                    MessageBox.Show("Successfully Updated!");
                }
                else
                {
                    MessageBox.Show("Update Failed!");
                }
            }
        }
    }
}
