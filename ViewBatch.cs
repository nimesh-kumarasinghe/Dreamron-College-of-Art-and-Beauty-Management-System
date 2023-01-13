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
    public partial class ViewBatch : Form
    {
        Database db;
        public ViewBatch()
        {
            db = new Database();
            InitializeComponent();
        }

        private void ViewBatch_Load(object sender, EventArgs e)
        {
            DataTable table = db.getDatatable("select * from Batch");
            Datagrid_view_batch.DataSource = table;
            // TODO: This line of code loads data into the 'dreamronDBDataSet.Batch' table. You can move, or remove it, as needed.
            //this.batchTableAdapter.Fill(this.dreamronDBDataSet.Batch);

        }
        void error_msg(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_batch_id.Text))
                error_msg("Please type Batch ID");
            else
            {
                Datagrid_view_batch.DataSource = db.getDatatable("Select * from Batch where BatchID = '" + txt_batch_id.Text + "'");
                Datagrid_view_batch.Visible = true;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_batch_id.Clear();
            Datagrid_view_batch.DataSource = null;
        }

        private void btn_all_data_Click(object sender, EventArgs e)
        {
            Datagrid_view_batch.DataSource = db.getDatatable("Select * from Batch");
            Datagrid_view_batch.Visible = true;
        }
    }
}
