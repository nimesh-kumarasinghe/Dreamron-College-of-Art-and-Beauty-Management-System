using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dreamron_College
{
    public partial class LecturerMethods : Form
    {
        public LecturerMethods()
        {
            InitializeComponent();
        }
        SendEmail email = new SendEmail() { TopLevel = false, TopMost = true };
        AddLecturer add_lec = new AddLecturer() { TopLevel = false, TopMost = true };
        EditLecturer editlec = new EditLecturer() { TopLevel = false, TopMost = true };
        DeleteLecturer delete_emp = new DeleteLecturer() { TopLevel = false, TopMost = true };
        ViewLecturer view_lec = new ViewLecturer() { TopLevel = false, TopMost = true };

        private void clsoe_forms()
        {
            email.Hide();
            add_lec.Hide();
            editlec.Hide();
            delete_emp.Hide();
            view_lec.Hide();

        }
        private void btn_gohome_Click(object sender, EventArgs e)
        {
            clsoe_forms();

            String usertype;
            //TextFile - read
            using (StreamReader streamreader = new StreamReader("userType.txt"))
            {
                usertype = streamreader.ReadLine();
                if(usertype.Equals("Admin"))
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                }
                else if(usertype.Equals("Staff"))
                {
                    StaffMenu staffMenu = new StaffMenu();
                    staffMenu.Show();
                }
            }
            //TextFile - read

            this.Hide();
        }


        private void btn_addlec_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            add_lec.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(add_lec);
            add_lec.Show();
        }

        private void btn_editlec_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            editlec.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(editlec);
            editlec.Show();
        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            email.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(email);
            email.Show();
        }

        private void brn_delete_lec_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            delete_emp.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(delete_emp);
            delete_emp.Show();
        }

        private void btn_assign_course_Click(object sender, EventArgs e)
        {
            this.Hide();
            AssignLecturerForCoursesDashboard assignlec = new AssignLecturerForCoursesDashboard();
            assignlec.Show();
        }

        private void btn_view_lec_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            view_lec.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(view_lec);
            view_lec.Show();
        }
    }
}
