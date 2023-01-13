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
    public partial class BatchMethods : Form
    {
        public BatchMethods()
        {
            InitializeComponent();
        }
        EditBatch editbatch = new EditBatch() { TopLevel = false, TopMost = true };
        AddBatch addbatch  = new AddBatch() { TopLevel = false, TopMost = true };
        DeleteBatch deletebatch =  new DeleteBatch() { TopLevel = false, TopMost = true };
        ViewBatch vwbatch = new ViewBatch() { TopLevel = false, TopMost = true };

        private void btn_home_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            StaffMenu staffmenu = new StaffMenu();
            staffmenu.Show();
            this.Hide();
        }
        private void clsoe_forms()
        {
            editbatch.Hide();
            addbatch.Hide();
            vwbatch.Hide();
            deletebatch.Hide();

        }

        private void btn_edit_batch_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            editbatch.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(editbatch);
            editbatch.Show();
        }

        private void btn_add_batch_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            addbatch.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(addbatch);
            addbatch.Show();
        }

        private void btn_delete_batch_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            deletebatch.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(deletebatch);
            deletebatch.Show();
        }

        private void btn_view_batch_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            vwbatch.FormBorderStyle = FormBorderStyle.None;
            this.panel5.Controls.Add(vwbatch);
            vwbatch.Show();
        }
    }
}
