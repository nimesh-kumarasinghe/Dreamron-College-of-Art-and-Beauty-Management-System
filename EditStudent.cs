using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Dreamron_College
{
    public partial class EditStudent : Form
    {
        Student student;
        public EditStudent()
        {
            student = new Student();
            InitializeComponent();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_student_id.Text))
                error_msg("Student ID cannot be blank");
            else
            {
                String[] userdata = student.getStudentData(txt_student_id.Text);
                if (userdata[0].Equals("error"))
                {
                    error_msg("Not Found");
                }
                else
                {
                    txt_firstname.Text = userdata[0];
                    txt_lastname.Text = userdata[1];
                    txt_surname.Text = userdata[2];
                    txt_iname.Text = userdata[3];
                    txt_nic.Text = userdata[4];
                    cmb_gender.Text = userdata[5];
                    dob_picker.Text = userdata[6].ToString();
                    txt_addressno.Text = userdata[7];
                    txt_street.Text = userdata[8];
                    txt_city.Text = userdata[9];
                    txt_tp.Text = userdata[10];
                    txt_email.Text = userdata[11];
                }
            }
        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_firstname.Text))
                error_msg("First Name cannot be blank");
            else if (string.IsNullOrEmpty(txt_lastname.Text))
                error_msg("Last Name cannot be blank");
            else if (string.IsNullOrEmpty(txt_surname.Text))
                error_msg("Surname cannot be blank");
            else if (txt_firstname.Text.Any(char.IsDigit))
                error_msg("First Name cannot have numbers");
            else if (txt_lastname.Text.Any(char.IsDigit))
                error_msg("Last Name cannot have numbers");
            else if (txt_surname.Text.Any(char.IsDigit))
                error_msg("Surname cannot have numbers");
            else if (string.IsNullOrEmpty(txt_iname.Text))
                error_msg("Name With Initials cannot be blank");
            else if (txt_iname.Text.Any(char.IsDigit))
                error_msg("Name With Initials cannot have numbers");
            else if (string.IsNullOrEmpty(txt_nic.Text))
                error_msg("NIC cannot be blank");
            else if (cmb_gender.SelectedIndex == -1)
                error_msg("Please Select A Gender");
            else if (string.IsNullOrEmpty(txt_addressno.Text))
                error_msg("Address No. cannot be blank");
            else if (string.IsNullOrEmpty(txt_street.Text))
                error_msg("Street cannot be blank");
            else if (string.IsNullOrEmpty(txt_city.Text))
                error_msg("City cannot be blank");
            else if (txt_tp.Text.Length != 10 || !Regex.IsMatch(txt_tp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                error_msg("Please Enter Phone Number Correctly");
            else if (txt_email.Text.Length == 0)
                error_msg("Please Enter Email Address");
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                error_msg("Enter a valid email. Ex:name@gmail.com");
            else
            {
                int status = student.updateStudentData(
            txt_firstname.Text,
            txt_lastname.Text,
            txt_surname.Text,
            txt_iname.Text,
            txt_nic.Text,
            cmb_gender.Text,
            dob_picker.Value.Year + "-" + dob_picker.Value.Month + "-" + dob_picker.Value.Day,
            txt_addressno.Text,
            txt_street.Text,
            txt_city.Text,
            txt_tp.Text,
            txt_email.Text,
            txt_student_id.Text
            );
                if (status == 0)
                {
                    MessageBox.Show("Updated Successfull!");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_student_id.Clear();
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_surname.Clear();
            txt_email.Clear();
            txt_addressno.Clear();
            txt_street.Clear();
            txt_city.Clear();
            txt_iname.Clear();
            txt_nic.Clear();
            txt_tp.Clear();
        }
    }
}
