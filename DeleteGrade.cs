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
    public partial class DeleteGrade : Form
    {
        Grade gd;
        public DeleteGrade()
        {
            InitializeComponent();
            gd = new Grade();
        }
        public void getIds()
        {
            cmb_grade_id.Items.Clear();
            String[] ids = gd.getGradeIds();
            foreach (String id in ids)
            {
                cmb_grade_id.Items.Add(id);
            }
        }
        private void DeleteGrade_Load(object sender, EventArgs e)
        {
            getIds();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (cmb_grade_id.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a grade ! ");
            }
            else
            {
                int status = gd.deletGrade(cmb_grade_id.SelectedItem.ToString());
                if (status == 0)
                {
                    MessageBox.Show("Deleted");
                }
                else
                {
                    MessageBox.Show("Failed!");
                }
                getIds();
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
