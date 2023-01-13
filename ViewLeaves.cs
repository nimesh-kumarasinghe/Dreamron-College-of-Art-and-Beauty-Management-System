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
    public partial class ViewLeaves : Form
    {
        Database db;
        public ViewLeaves()
        {
            db = new Database();
            InitializeComponent();
        }

        private void ViewLeaves_Load(object sender, EventArgs e)
        {
            DataTable table = db.getDatatable("select * from Leave");
            dg_leaves.DataSource = table;
            // TODO: This line of code loads data into the 'dreamronDBDataSet3.Leave' table. You can move, or remove it, as needed.
            //this.leaveTableAdapter1.Fill(this.dreamronDBDataSet3.Leave);

        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmbtype.SelectedIndex.Equals(-1) && String.IsNullOrEmpty(txt_userID.Text))
            {
                dg_leaves.Visible = false;
                error_msg("Please select a user type OR enter Employee or Lecturer ID");
            }
            else if (cmbtype.SelectedIndex.Equals(0))
            {
                dg_leaves.DataSource = db.getDatatable("Select * from Leave where Type = 'Employee'");
                dg_leaves.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(1))
            {
                dg_leaves.DataSource = db.getDatatable("Select * from Leave where Type = 'Lecturer'");
                dg_leaves.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(2))
            {
                dg_leaves.DataSource = db.getDatatable("Select * from Leave");
                dg_leaves.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(-1))
            {
                dg_leaves.DataSource = db.getDatatable("Select * from Leave where EmpID='" + txt_userID.Text+"'");
                dg_leaves.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(-1))
            {
                dg_leaves.DataSource = db.getDatatable("Select * from Leave where LecID ='"+txt_userID.Text+"'");
                dg_leaves.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(-1))
            {
                dg_leaves.DataSource = db.getDatatable("Select * from Leave");
                dg_leaves.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            cmbtype.SelectedIndex = (-1);
            dg_leaves.DataSource = null;
            txt_userID.Clear();

        }
    }
}
