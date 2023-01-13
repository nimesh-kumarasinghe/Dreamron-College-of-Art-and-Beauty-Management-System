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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        AdminMenu admin_menu = new AdminMenu();
        StaffMenu StaffMenu = new StaffMenu();
        ManagerMenu Manager = new ManagerMenu();



        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            admin_menu.FormBorderStyle = FormBorderStyle.None;
            //EditBatch cx = new EditBatch();
            admin_menu.Show();
            this.Hide();
            //Login login = new Login();
            //login.Close();
            //cx.Show();

        }

        private void lbl_forgotpassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you have clicked a link label");
        }

        private void btn_staff_Click(object sender, EventArgs e)
        {
            StaffMenu.Show();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Manager.FormBorderStyle = FormBorderStyle.None;
            //EditBatch cx = new EditBatch();
            Manager.Show();
            this.Hide();
            
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            LoginClass logclass = new LoginClass();
            String status = logclass.login(txt_ID.Text, txt_password.Text);
            if (status.Equals("-1"))
            {
                MessageBox.Show("Wrong Login Details !! ");
            }
            else if (status.Equals("Admin"))
            {
                admin_menu.Show();
                this.Hide();
            }
            else if (status.Equals("Staff"))
            {
                StaffMenu.Show();
                this.Hide();
            }
            else if (status.Equals("Manager"))
            {
                Manager.Show();
                this.Hide();
            }
        }
    }
}
