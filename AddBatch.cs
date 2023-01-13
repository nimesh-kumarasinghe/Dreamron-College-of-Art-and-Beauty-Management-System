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
    public partial class AddBatch : Form
    {
        Batch batch;
        public AddBatch()
        {
            InitializeComponent();
            batch = new Batch();
        }

        private void AddBatch_Load(object sender, EventArgs e)
        {
            String[] ids = batch.getCourseDetails();
            foreach (String id in ids)
            {
                cmb_course_selector.Items.Add(id);
            }
            txt_batch_id.Text = batch.getBatchID();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error);
        }

        private void btn_addbatch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_batch_id.Text))
                error_msg("Batch id cannot be empty ! ");
            else if (string.IsNullOrEmpty(txt_no_of_seats.Text))
                error_msg("Please enter no of seats ! ");
            else if (!txt_no_of_seats.Text.Any(char.IsDigit))
                error_msg("No of seats cannot contain letters !");
            else if (cmb_course_selector.SelectedIndex == -1)
                error_msg("Please select a course ! ");
            else
            {
                int status = batch.addNewBatch(
                txt_batch_id.Text,
                start_date_picker.Value.Year + "-" + start_date_picker.Value.Month + "-" + start_date_picker.Value.Day,
                end_date_picker.Value.Year + "-" + end_date_picker.Value.Month + "-" + end_date_picker.Value.Day,
                txt_no_of_seats.Text,
                cmb_course_selector.SelectedItem.ToString()
                );
                if (status == 0)
                {
                    MessageBox.Show("Batch created sucessfully");
                }
                else if (status == -1)
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            start_date_picker.ResetText();
            end_date_picker.ResetText();
            txt_no_of_seats.Clear();
            cmb_course_selector.SelectedIndex = -1;
        }
    }
}
