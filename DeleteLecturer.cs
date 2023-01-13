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
    public partial class DeleteLecturer : Form
    {
        Lecturer lecturer;

        public DeleteLecturer()
        {
            lecturer = new Lecturer();
            InitializeComponent();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lec_id.Text))
                error_msg("Lecturer ID cannot be blank");
            else
            {
                String[] userdata = lecturer.getLecturerData(txt_lec_id.Text);
                if (userdata[0].Equals("error"))
                {
                    error_msg("Not Found");
                }
                else
                {
                    txt_firstname.Text = userdata[0];
                    txt_lastname.Text = userdata[1];
                    txt_surname.Text = userdata[2];
                    txt_name_with_i.Text = userdata[3];
                    txt_nic.Text = userdata[4];
                    cmb_gender.Text = userdata[5];
                    dob_picker.Text = userdata[6].ToString();
                    txt_addressno.Text = userdata[7];
                    txt_street.Text = userdata[8];
                    txt_city.Text = userdata[9];
                    txt_phone_number.Text = userdata[10];
                    txt_email.Text = userdata[11];
                }
            }
        }

        private void btn_delete_lecturer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_firstname.Text))
                error_msg("Full Name cannot be blank");
            else if (txt_firstname.Text.Any(char.IsDigit))
                error_msg("Full Name cannot have numbers");
            else if (string.IsNullOrEmpty(txt_name_with_i.Text))
                error_msg("Name With Initials cannot be blank");
            else if (txt_name_with_i.Text.Any(char.IsDigit))
                error_msg("Name With Initials cannot have numbers");
            else if (string.IsNullOrEmpty(txt_nic.Text))
                error_msg("NIC cannot be blank");

            else if (string.IsNullOrEmpty(txt_addressno.Text))
                error_msg("Address cannot be blank");

            else
            {
                int status = lecturer.deleteLecturerData(
            txt_firstname.Text, txt_lastname.Text, txt_surname.Text,
            txt_name_with_i.Text,
            txt_nic.Text,
            cmb_gender.Text,
            dob_picker.Text,
            txt_addressno.Text,
            txt_street.Text,
            txt_city.Text,
            txt_phone_number.Text,
            txt_email.Text,
            
            
            
            txt_lec_id.Text


            );
                if (status == 0)
                {
                    MessageBox.Show("Delete Successful!");
                }
                else
                {
                    MessageBox.Show("failed");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_surname.Clear();
            txt_name_with_i.Clear();
            txt_nic.Clear();
            cmb_gender.Text = "";

            txt_addressno.Clear();
            txt_street.Clear();
            txt_city.Clear();
            txt_phone_number.Clear();
            txt_email.Clear();

            
            txt_lec_id.Clear();
        }
    }
}
