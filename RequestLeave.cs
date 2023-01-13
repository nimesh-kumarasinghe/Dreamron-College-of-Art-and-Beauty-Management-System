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
    public partial class RequestLeave : Form
    {
        Leave ls;
        public RequestLeave()
        {
            InitializeComponent();
            ls = new Leave();
        }
        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            int status = ls.requestLeave(cmb_type_selector.SelectedItem.ToString(),
                cmb_leave_type.SelectedItem.ToString(),
                date_picker.Value.Year + "-" + date_picker.Value.Month + "-" + date_picker.Value.Day,
                txt_reason.Text,
                cmb_id_selector.SelectedItem.ToString());
            if (status == 0)
            {
                MessageBox.Show("Leave requested sucessfully");
            }
            else if (status == -1)
            {
                MessageBox.Show("Leave requested failed");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_reason.Clear();
            date_picker.ResetText();
        }

        private void cmb_type_selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_type_selector.SelectedIndex == 0)
            {
                cmb_id_selector.Items.Clear();
                String[] ids = ls.getAdminId();
                foreach (String id in ids)
                {
                    cmb_id_selector.Items.Add(id);
                }
            }
            else if (cmb_type_selector.SelectedIndex == 1)
            {
                cmb_id_selector.Items.Clear();
                String[] ids = ls.getStaffId();
                foreach (String id in ids)
                {
                    cmb_id_selector.Items.Add(id);
                }
            }
            else if (cmb_type_selector.SelectedIndex == 2)
            {
                cmb_id_selector.Items.Clear();
                String[] ids = ls.getManagerID();
                foreach (String id in ids)
                {
                    cmb_id_selector.Items.Add(id);
                }
            }
            else if (cmb_type_selector.SelectedIndex == 3)
            {
                cmb_id_selector.Items.Clear();
                String[] ids = ls.getLecturerId();
                foreach (String id in ids)
                {
                    cmb_id_selector.Items.Add(id);
                }
            }
        }
    }
    }
