using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dreamron_College
{
    public partial class SalaryLeavesDashboard : Form
    {
        RequestLeave leave = new RequestLeave() { TopLevel = false, TopMost = true };
        CalculateSalary sal = new CalculateSalary() { TopLevel = false, TopMost = true };

        public SalaryLeavesDashboard()
        {
            InitializeComponent();
        }
        private void clsoe_forms()
        {
            leave.Hide();
            sal.Hide();


        }
        private void btn_sal_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            sal.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(sal);
            sal.Show();
        }

        private void btn_leaves_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            leave.FormBorderStyle = FormBorderStyle.None;
            this.panel2.Controls.Add(leave);
            leave.Show();
        }

        private void btn_gohome_Click(object sender, EventArgs e)
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
    }
}
