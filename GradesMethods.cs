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
    public partial class GradesMethods : Form
    {
        public GradesMethods()
        {
            InitializeComponent();
        }
        AddGrade addgrd = new AddGrade() { TopLevel = false, TopMost = true };
        UpdateGrade updategrd = new UpdateGrade() { TopLevel = false, TopMost = true };
        DeleteGrade del_grd = new DeleteGrade() { TopLevel = false, TopMost = true };
        ViewGrade viewgrade = new ViewGrade() { TopLevel = false, TopMost = true };
        private void clsoe_forms()
        {
            addgrd.Hide();
            updategrd.Hide();
            del_grd.Hide();
            viewgrade.Hide();

        }
        private void btn_add_grade_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            addgrd.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(addgrd);
            addgrd.Show();
        }

        private void btn_edit_grade_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            updategrd.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(updategrd);
            updategrd.Show();
        }

        private void btn_delete_grade_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            del_grd.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(del_grd);
            del_grd.Show();
        }

        private void btn_view_grade_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            viewgrade.FormBorderStyle = FormBorderStyle.None;
            this.panel4.Controls.Add(viewgrade);
            viewgrade.Show();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            clsoe_forms();
            ManagerMenu managermenu = new ManagerMenu();
            managermenu.Show();
            this.Hide();
        }
    }
}
