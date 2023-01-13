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
    public partial class DeleteEmployee : Form
    {
        Employee employee;
        public DeleteEmployee()
        {
            employee = new Employee();
            InitializeComponent();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_emp_id.Text))
                error_msg("Please type Employee ID");
            else
            {
                String[] userdata = employee.getEmployeeData(txt_emp_id.Text);
                if (userdata[0].Equals("error"))
                {
                    error_msg("Not Found");
                }
                else
                {
                    cmb_type.SelectedIndex = cmb_type.Items.IndexOf(userdata[0]);
                    txt_firstname.Text = userdata[1];
                    txt_lastname.Text = userdata[2];
                    txt_surname.Text = userdata[3];
                    txt_name_with_i.Text = userdata[4];
                    txt_nic.Text = userdata[5];
                    cmb_gender.Text = userdata[6];
                    dob_picker.Text = userdata[7].ToString();
                    txt_addressno.Text = userdata[8];
                    txt_street.Text = userdata[9];
                    txt_city.Text = userdata[10];
                    txt_phone_number.Text = userdata[11];
                    txt_email.Text = userdata[12];
                    
                   
                }
            }
        }

        private void btn_delete_emp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lastname.Text))
                error_msg("Full Name cannot be blank");
            else if (txt_lastname.Text.Any(char.IsDigit))
                error_msg("Full Name cannot have numbers");
            else if (string.IsNullOrEmpty(txt_name_with_i.Text))
                error_msg("Name With Initials cannot be blank");
            else if (txt_name_with_i.Text.Any(char.IsDigit))
                error_msg("Name With Initials cannot have numbers");
            else if (string.IsNullOrEmpty(txt_nic.Text))
                error_msg("NIC cannot be blank");

            else if (string.IsNullOrEmpty(txt_addressno.Text))
                error_msg("Address cannot be blank");
            else if (txt_phone_number.Text.Length != 9 || !Regex.IsMatch(txt_phone_number.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
                error_msg("Please Enter Phone Number Correctly");
            else if (txt_email.Text.Length == 0)
                error_msg("Please Enter Email Address");
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
                error_msg("Enter a valid email. Ex:name@gmail.com");
            else
            {
                int status = employee.deleteEmployeeData(
            cmb_type.Text,
            txt_firstname.Text,
            txt_lastname.Text,
            txt_surname.Text,
            txt_name_with_i.Text,
            txt_nic.Text,
            cmb_gender.Text,
            dob_picker.Text,
            txt_addressno.Text,
            txt_street.Text,
            txt_city.Text,
            txt_phone_number.Text,
            txt_email.Text,
            
            
            txt_emp_id.Text
            );
                if (status == 0)
                {
                    MessageBox.Show("Deleted");
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
            cmb_type.Text = "";
            txt_addressno.Clear();
            txt_street.Clear();
            txt_city.Clear();
            txt_phone_number.Clear();
            txt_email.Clear();
            
            
        }
    }
}
