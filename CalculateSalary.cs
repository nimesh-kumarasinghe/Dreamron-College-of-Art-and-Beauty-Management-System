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
    public partial class CalculateSalary : Form
    {
        Salary sl;
        public CalculateSalary()
        {
            InitializeComponent();
            sl = new Salary();
        }
        //double etf, epf,basic_sal,allowance;
        
        

        private void CalculateSalary_Load(object sender, EventArgs e)
        {
            txt_ref_id.Text = sl.getRefId();
        }

        

       

        private void cmb_type_selector_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmb_type_selector.SelectedIndex == 0)
            {
                cmb_id_selector.Items.Clear();
                String[] ids = sl.getAdminId();
                foreach (String id in ids)
                {
                    cmb_id_selector.Items.Add(id);
                }
            }
            else if (cmb_type_selector.SelectedIndex == 1)
            {
                cmb_id_selector.Items.Clear();
                String[] ids = sl.getStaffId();
                foreach (String id in ids)
                {
                    cmb_id_selector.Items.Add(id);
                }
            }
            else if (cmb_type_selector.SelectedIndex == 2)
            {
                cmb_id_selector.Items.Clear();
                String[] ids = sl.getManagerID();
                foreach (String id in ids)
                {
                    cmb_id_selector.Items.Add(id);
                }
            }
            else if (cmb_type_selector.SelectedIndex == 3)
            {
                cmb_id_selector.Items.Clear();
                String[] ids = sl.getLecturerId();
                foreach (String id in ids)
                {
                    cmb_id_selector.Items.Add(id);
                }
            }

        }

        private void cmb_id_selector_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String[] userdata = new String[6];
            if (cmb_type_selector.SelectedIndex == 0 || cmb_type_selector.SelectedIndex == 1 || cmb_type_selector.SelectedIndex == 2)
            {
                userdata = sl.getEmployeeData(cmb_id_selector.SelectedItem.ToString());
            }
            else if (cmb_type_selector.SelectedIndex == 3)
            {
                userdata = sl.getLecturerData(cmb_id_selector.SelectedItem.ToString());
            }
            txt_basic_sal.Text = userdata[0].ToString();
            txt_allowance.Text = userdata[1].ToString();
        }

        private void btn_clear_Click_1(object sender, EventArgs e)
        {
            cmb_id_selector.Items.Clear();
            cmb_type_selector.Items.Clear();
            txt_allowance.Clear();
            txt_basic_sal.Clear();
            txt_epf.Clear();
            txt_etf.Clear();
            txt_net_sal.Clear();
            txt_ref_id.Clear();
            month_start_date.ResetText();
            month_end_date.ResetText();
        }

        private void btn_cal_Click_1(object sender, EventArgs e)
        {
            txt_epf.Text = sl.calEPF().ToString();
            txt_etf.Text = sl.calETF().ToString();

            int status = -1;
            if (cmb_type_selector.SelectedIndex == 3)
            {
                sl.getUserAttDetails("LEC",
                    cmb_id_selector.SelectedItem.ToString(),
                    month_start_date.Value.Year + "-" + month_start_date.Value.Month + "-" + month_start_date.Value.Day,
                    month_end_date.Value.Year + "-" + month_end_date.Value.Month + "-" + month_end_date.Value.Day);

                //String refno, String netsal, String b_sal, String allowance, String etf, String epf, String user_id
                txt_net_sal.Text = sl.calNetSal().ToString();
                status = sl.saveDataLec(txt_ref_id.Text,
                    txt_net_sal.Text,
                    txt_basic_sal.Text,
                    txt_allowance.Text,
                    txt_etf.Text,
                    txt_epf.Text,
                    cmb_id_selector.SelectedItem.ToString());
                try
                {
                    sl.createDoc(
                        DateTime.Now.ToString("yyyy-MM-dd"),
                        sl.getLecName(cmb_id_selector.SelectedItem.ToString()),
                        txt_ref_id.Text,
                        cmb_type_selector.SelectedItem.ToString(),
                        txt_basic_sal.Text,
                        txt_etf.Text,
                        txt_allowance.Text,
                        txt_net_sal.Text,
                        txt_etf.Text
                        );
                    sl.sendPaysheet(sl.getLecEmail(cmb_id_selector.SelectedItem.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (status == 0)
                    MessageBox.Show("Sucessfully Calculated !!");
                else
                    MessageBox.Show("Error");
            }
            else
            {
                sl.getUserAttDetails("EMP",
                    cmb_id_selector.SelectedItem.ToString(),
                    month_start_date.Value.Year + "-" + month_start_date.Value.Month + "-" + month_start_date.Value.Day,
                    month_end_date.Value.Year + "-" + month_end_date.Value.Month + "-" + month_end_date.Value.Day);

                txt_net_sal.Text = sl.calNetSal().ToString();
                status = sl.saveDataEmp(txt_ref_id.Text,
                    txt_net_sal.Text,
                    txt_basic_sal.Text,
                    txt_allowance.Text,
                    txt_etf.Text,
                    txt_epf.Text,
                    cmb_id_selector.SelectedItem.ToString());

                try
                {
                    sl.createDoc(
                        DateTime.Now.ToString("yyyy-MM-dd"),
                        sl.getEmpName(cmb_id_selector.SelectedItem.ToString()),
                        txt_ref_id.Text,
                        cmb_type_selector.SelectedItem.ToString(),
                        txt_basic_sal.Text,
                        txt_etf.Text,
                        txt_allowance.Text,
                        txt_net_sal.Text,
                        txt_etf.Text
                        );
                    sl.sendPaysheet(sl.getEmpEmail(cmb_id_selector.SelectedItem.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                if (status == 0)
                    MessageBox.Show("Sucessfully Calculated !!");
                else
                    MessageBox.Show("Error");
            }

        }
    }
}
