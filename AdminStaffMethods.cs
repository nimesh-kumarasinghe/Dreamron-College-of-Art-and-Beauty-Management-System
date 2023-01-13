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
    public partial class AdminStaffMethods : Form
    {
        public AdminStaffMethods()
        {
            InitializeComponent();
        }
        SendEmail email = new SendEmail() { TopLevel = false, TopMost = true };
        AddEmployee add_emp = new AddEmployee() { TopLevel = false, TopMost = true };
        EditEmployee editemp = new EditEmployee() { TopLevel = false, TopMost = true };
        DeleteEmployee delete_emp = new DeleteEmployee() { TopLevel = false, TopMost = true };
        ViewEmployee view_emp =  new ViewEmployee() { TopLevel = false, TopMost = true };

    private void btn_email_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            email.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(email);
            email.Show();
        }

        private void btn_add_admin_staff_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            add_emp.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(add_emp);
            add_emp.Show();
        }

        private void btn_edit_admin_staff_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            editemp.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(editemp);
            editemp.Show();
        }

        private void btn_delete_admin_staff_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            delete_emp.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(delete_emp);
            delete_emp.Show();

        }
        private void btn_view_staff_admin_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            view_emp.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(view_emp);
            view_emp.Show();
        }

        private void clsoe_forms()
        {
            email.Hide();
            add_emp.Hide();
            editemp.Hide();
            delete_emp.Hide();
            view_emp.Hide();

        }

        private void btn_go_home_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            this.Hide();
        }
    }
}
