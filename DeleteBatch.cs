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
    public partial class DeleteBatch : Form
    {
        Batch batch = new Batch();
        public DeleteBatch()
        {
            InitializeComponent();
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
                    start_date_picker.Text = userdata[0].ToString();
                    end_date_picker.Text = userdata[1].ToString();
                    txt_no_of_seats.Text = userdata[2];
                    txt_course_id.Text = userdata[3];
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_course_id.Text))
                MessageBox.Show("Batch id cannot be empty !");

            else
            {
                int status = batch.deleteBatchData(


                start_date_picker.Text,
                end_date_picker.Text,
                txt_no_of_seats.Text,
                txt_course_id.Text,
                txt_batch_id.Text


            );
                if (status == 0)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_batch_id.Clear();
            start_date_picker.ResetText();
            end_date_picker.ResetText();
            txt_no_of_seats.Clear();
            txt_course_id.Clear();
        }
    }
}
