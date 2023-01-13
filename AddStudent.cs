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
    public partial class AddStudent : Form
    {
        Student student;
        public AddStudent()
        {
            InitializeComponent();
            student = new Student();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            txt_stu_id.Text = student.getStudentId();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }

        private void btn_add_staff_Click(object sender, EventArgs e)
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
            else if (string.IsNullOrEmpty(txt_name_with_i.Text))
                error_msg("Name With Initials cannot be blank");
            else if (txt_name_with_i.Text.Any(char.IsDigit))
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
            else if (txt_phone_number.Text.Length != 10 || !Regex.IsMatch(txt_phone_number.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                error_msg("Please Enter Phone Number Correctly");
            else if (txt_email.Text.Length == 0)
                error_msg("Please Enter Email Address");
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                error_msg("Enter a valid email. Ex:name@gmail.com");
            else
            {
                int status = student.addNewStudent(
                        txt_stu_id.Text,
                        txt_firstname.Text,
                        txt_lastname.Text,
                        txt_surname.Text,
                        txt_name_with_i.Text,
                        txt_nic.Text,
                        cmb_gender.SelectedItem.ToString(),
                        dob_picker.Value.Year + "-" + dob_picker.Value.Month + "-" + dob_picker.Value.Day,
                        txt_addressno.Text,
                        txt_street.Text,
                        txt_city.Text,
                        txt_phone_number.Text.ToString(),
                        txt_email.Text
                        );
                if (status == 0)
                {
                    MessageBox.Show("Account created sucessfully");
                }
                else if (status == -1)
                {
                    MessageBox.Show("Email send failed");
                }
                else if (status == -2)
                {
                    MessageBox.Show("Error");
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
            cmb_gender.SelectedIndex = -1;
            dob_picker.ResetText();
            txt_addressno.Clear();
            txt_street.Clear();
            txt_city.Clear();
            txt_phone_number.Clear();
            txt_email.Clear();
        }
    }
}
