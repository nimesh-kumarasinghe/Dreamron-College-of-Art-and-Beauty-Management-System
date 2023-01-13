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
    public partial class CourseMethods : Form
    {
        public CourseMethods()
        {
            InitializeComponent();
        }
        EditCourse editcourse = new EditCourse() { TopLevel = false, TopMost = true };
        AddCourse addcourse = new AddCourse() { TopLevel = false, TopMost = true };
        DeleteCourse deletecourse = new DeleteCourse() { TopLevel = false, TopMost = true };
        ViewCourse viewcourse = new ViewCourse() { TopLevel = false, TopMost = true };

        private void clsoe_forms()
        {
            editcourse.Hide();
            addcourse.Hide();
            deletecourse.Hide();
            viewcourse.Hide();

        }
        private void btn_add_course_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            addcourse.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(addcourse);
            addcourse.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            clsoe_forms();

            String usertype;
            //TextFile - read
            using (StreamReader streamreader = new StreamReader("userType.txt"))
            {
                usertype = streamreader.ReadLine();
                if (usertype.Equals("Admin"))
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                }
                else if (usertype.Equals("Staff"))
                {
                    StaffMenu staffMenu = new StaffMenu();
                    staffMenu.Show();
                }
            }
            //TextFile - read

            this.Hide();
        }

        private void btn_edit_course_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            editcourse.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(editcourse);
            editcourse.Show();
        }

        private void btn_delete_course_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            deletecourse.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(deletecourse);
            deletecourse.Show();
        }

        private void btn_view_course_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            viewcourse.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(viewcourse);
            viewcourse.Show();
        }
    }
}
