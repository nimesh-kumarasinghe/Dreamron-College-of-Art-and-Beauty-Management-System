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
    public partial class ViewEmployee : Form
    {
        Database db;
        public ViewEmployee()
        {
            db = new Database();
            InitializeComponent();
        }

        private void ViewAdminStaff_Load(object sender, EventArgs e)
        {
            DataTable table = db.getDatatable("select * from Employee");
            Datagrid_view_emp.DataSource = table;
            // TODO: This line of code loads data into the 'datasetForAllRep.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.datasetForAllRep.Employee);
            //this.reportViewer1.RefreshReport();
        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cmbtype.SelectedIndex.Equals(-1) && String.IsNullOrEmpty(txt_userID.Text))
            {
                Datagrid_view_emp.Visible = false;
                error_msg("Please select a user type or Type Employee ID to get details");
            }
            else if (cmbtype.SelectedIndex.Equals(0))
            {
                Datagrid_view_emp.DataSource = db.getDatatable("Select * from Employee where EType = 'Admin'");
                Datagrid_view_emp.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(1))
            {
                Datagrid_view_emp.DataSource = db.getDatatable("Select * from Employee where EType = 'Staff'");
                Datagrid_view_emp.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(2))
            {
                Datagrid_view_emp.DataSource = db.getDatatable("Select * from Employee where EType = 'Manager'");
                Datagrid_view_emp.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(3))
            {
                Datagrid_view_emp.DataSource = db.getDatatable("Select * from Employee");
                Datagrid_view_emp.Visible = true;
            }
            else if (cmbtype.SelectedIndex.Equals(-1))
            {
                Datagrid_view_emp.DataSource = db.getDatatable("Select * from Employee where EmpID = '" + txt_userID.Text + "'");
                Datagrid_view_emp.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Datagrid_view_emp.DataSource = null;
            cmbtype.SelectedIndex = -1;
            txt_userID.Clear();
        }
    }
}
