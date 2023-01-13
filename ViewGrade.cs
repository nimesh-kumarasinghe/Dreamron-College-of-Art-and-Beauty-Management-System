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
    public partial class ViewGrade : Form
    {
        public ViewGrade()
        {
            InitializeComponent();
        }

        private void ViewGrade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newDreamronDataSet.Grade' table. You can move, or remove it, as needed.
            this.gradeTableAdapter.Fill(this.newDreamronDataSet.Grade);
        }


    }
}
