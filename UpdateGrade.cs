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
    public partial class UpdateGrade : Form
    {
        Grade gd;
        public UpdateGrade()
        {
            InitializeComponent();
            gd = new Grade();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (cmb_grade_id.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a grade ! ");
            }
            else if (string.IsNullOrEmpty(txt_grade_name.Text))
            {
                MessageBox.Show("Grade name cannot be null ! ");
            }
            else if (string.IsNullOrEmpty(txt_allowance.Text))
            {
                MessageBox.Show("Allowance cannot be null ! ");
            }
            else if (string.IsNullOrEmpty(txt_bsal.Text))
            {
                MessageBox.Show("Basic Salary cannot be null ! ");
            }
            else if (string.IsNullOrEmpty(txt_epf.Text))
            {
                MessageBox.Show("EPF cannot be null ! ");
            }
            else if (string.IsNullOrEmpty(txt_etf.Text))
            {
                MessageBox.Show("ETF cannot be null ! ");
            }
            else if (string.IsNullOrEmpty(txt_leaves_per_month.Text))
            {
                MessageBox.Show("Leaves per month cannot be null ! ");
            }
            else if (string.IsNullOrEmpty(txt_salary_per_day.Text))
            {
                MessageBox.Show("Salary per day cannot be null ! ");
            }
            else if (!txt_bsal.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Baisc salary can only contain numbers !");
            }
            else if (!txt_allowance.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Allowance can only contain numbers !");
            }
            else if (!txt_epf.Text.Any(char.IsDigit))
            {
                MessageBox.Show("EPF can only contain numbers !");
            }
            else if (!txt_etf.Text.Any(char.IsDigit))
            {
                MessageBox.Show("ETF can only contain numbers !");
            }
            else if (!txt_leaves_per_month.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Leaves Per Month can only contain numbers !");
            }
            else if (!txt_salary_per_day.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Salary per day can only contain numbers !");
            }
            else
            {
                int status = gd.updateGrade(cmb_grade_id.SelectedItem.ToString(),
                    txt_grade_name.Text,
                    txt_bsal.Text,
                    txt_epf.Text,
                    txt_etf.Text,
                    txt_leaves_per_month.Text,
                    txt_allowance.Text,
                    txt_salary_per_day.Text);
                if (status == 0)
                {
                    MessageBox.Show("Updated Successfull!");
                }
                else
                {
                    MessageBox.Show("failed");
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_allowance.Clear();
            txt_bsal.Clear();
            txt_epf.Clear();
            txt_etf.Clear();
            txt_grade_name.Clear();
            txt_leaves_per_month.Clear();
            txt_salary_per_day.Clear();
        }

        private void UpdateGrade_Load(object sender, EventArgs e)
        {
            String[] ids = gd.getGradeIds();
            foreach (String id in ids)
            {
                cmb_grade_id.Items.Add(id);
            }
        }

        private void cmb_grade_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] grade_data = gd.getGradeData(cmb_grade_id.SelectedItem.ToString());

            txt_grade_name.Text = grade_data[0];
            txt_bsal.Text = grade_data[1];
            txt_epf.Text = grade_data[2];
            txt_etf.Text = grade_data[3];
            txt_leaves_per_month.Text = grade_data[4];
            txt_allowance.Text = grade_data[5];
            txt_salary_per_day.Text = grade_data[6];
        }
    }
}
