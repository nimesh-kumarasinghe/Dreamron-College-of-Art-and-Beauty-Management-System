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
    public partial class ManageLeavesMethods : Form
    {
        public ManageLeavesMethods()
        {
            InitializeComponent();
        }
        ViewLeaves viewleaves = new ViewLeaves() { TopLevel = false, TopMost = true };
        AcceptRejectLeaves acc_re_leaves = new AcceptRejectLeaves () { TopLevel = false, TopMost = true };
        private void btn_leave_accept_reject_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            acc_re_leaves.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(acc_re_leaves);
            acc_re_leaves.Show();
        }
        private void clsoe_forms()
        {
            viewleaves.Hide();
            acc_re_leaves.Hide();

        }

        private void btn_view_leaves_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            viewleaves.FormBorderStyle = FormBorderStyle.None;
            this.panel.Controls.Add(viewleaves);
            viewleaves.Show();
        }

        private void btn_go_home_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            ManagerMenu managermenu = new ManagerMenu();
            managermenu.Show();
            this.Hide();
        }
    }
}
