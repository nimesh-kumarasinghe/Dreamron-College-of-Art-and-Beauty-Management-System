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
    public partial class EnterStudentPayment : Form
    {
        StudentPaymentDetails std_details;
        public EnterStudentPayment()
        {
            InitializeComponent();
            std_details = new StudentPaymentDetails();
        }

        private void cmb_batch_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_course_selector.Items.Clear();
            String[] course_ids = std_details.getCourseDetails(cmb_batch_selector.SelectedItem.ToString());

            foreach (String id in course_ids)
            {
                cmb_course_selector.Items.Add(id);
            }
        }

        private void cmb_course_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_student_selector.Items.Clear();
            String[] student_ids = std_details.getStudentDetails(cmb_course_selector.SelectedItem.ToString());

            foreach (String id in student_ids)
            {
                cmb_student_selector.Items.Add(id);
            }
        }

        private void EnterStudentPayment_Load(object sender, EventArgs e)
        {
            String[] batch_ids = std_details.getBatchDetails();
            foreach (String id in batch_ids)
            {
                cmb_batch_selector.Items.Add(id);
            }
            txt_ref_no.Text = std_details.getRefID();
            cmb_status.SelectedIndex = 0;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (cmb_batch_selector.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a batch.");
            }
            else if (cmb_course_selector.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.");
            }
            else if (cmb_student_selector.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student.");
            }
            else if ((string.IsNullOrEmpty(txt_amount.Text)))
            {
                MessageBox.Show("Please enter a amount");
            }
            else if (!txt_amount.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Amount can contain only numbers ");
            }
            else
            {
                int status = std_details.insertStundetPaymentDetails(txt_ref_no.Text, txt_amount.Text,
                    date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day,
                    cmb_status.SelectedItem.ToString(),
                    cmb_student_selector.SelectedItem.ToString(),
                    cmb_course_selector.SelectedItem.ToString());
                if (status == 0)
                {
                    MessageBox.Show("Inserted !! ");
                }
                else if (status == -1)
                {
                    MessageBox.Show("Inserted Failed !! ");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmb_status.SelectedIndex = 0;
            txt_amount.Clear();
        }
    }
}
