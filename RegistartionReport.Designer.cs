
namespace Dreamron_College
{
    partial class RegistartionReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_generate = new Guna.UI2.WinForms.Guna2Button();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_end = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_start = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rv_emptotreg = new Microsoft.Reporting.WinForms.ReportViewer();
            this.AllRegistartion = new Dreamron_College.AllRegistartion();
            this.EmployeeTotalRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeTotalRegTableAdapter = new Dreamron_College.AllRegistartionTableAdapters.EmployeeTotalRegTableAdapter();
            this.rv_lectot = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LecturerTotRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LecturerTableAdapter = new Dreamron_College.AllRegistartionTableAdapters.LecturerTableAdapter();
            this.rv_studenttot = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentTotRegBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StudentTotRegTableAdapter = new Dreamron_College.AllRegistartionTableAdapters.StudentTotRegTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AllRegistartion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTotalRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerTotRegBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTotRegBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BorderRadius = 16;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.Gray;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(759, 106);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 35);
            this.btn_clear.TabIndex = 185;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_generate
            // 
            this.btn_generate.Animated = true;
            this.btn_generate.AutoRoundedCorners = true;
            this.btn_generate.BorderRadius = 16;
            this.btn_generate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_generate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_generate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_generate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_generate.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_generate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.ForeColor = System.Drawing.Color.White;
            this.btn_generate.Location = new System.Drawing.Point(600, 62);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(293, 35);
            this.btn_generate.TabIndex = 181;
            this.btn_generate.Text = "Generate Total Registartions";
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // viewheaderlabel
            // 
            this.viewheaderlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewheaderlabel.BackColor = System.Drawing.Color.Transparent;
            this.viewheaderlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewheaderlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.viewheaderlabel.Location = new System.Drawing.Point(24, 12);
            this.viewheaderlabel.Name = "viewheaderlabel";
            this.viewheaderlabel.Size = new System.Drawing.Size(361, 43);
            this.viewheaderlabel.TabIndex = 178;
            this.viewheaderlabel.Text = "REGISTRATION REPORTS\r\n";
            // 
            // cmb_type
            // 
            this.cmb_type.BackColor = System.Drawing.Color.Transparent;
            this.cmb_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_type.ItemHeight = 30;
            this.cmb_type.Items.AddRange(new object[] {
            "Employee",
            "Lecturer",
            "Student"});
            this.cmb_type.Location = new System.Drawing.Point(29, 93);
            this.cmb_type.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(130, 36);
            this.cmb_type.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_type.TabIndex = 187;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(31, 62);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(81, 23);
            this.guna2HtmlLabel2.TabIndex = 186;
            this.guna2HtmlLabel2.Text = "Select Type\r\n";
            // 
            // date_end
            // 
            this.date_end.Animated = true;
            this.date_end.Checked = true;
            this.date_end.FillColor = System.Drawing.Color.White;
            this.date_end.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_end.Location = new System.Drawing.Point(300, 160);
            this.date_end.Margin = new System.Windows.Forms.Padding(4);
            this.date_end.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_end.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(243, 44);
            this.date_end.TabIndex = 191;
            this.date_end.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(300, 137);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(65, 23);
            this.guna2HtmlLabel1.TabIndex = 190;
            this.guna2HtmlLabel1.Text = "End Date";
            // 
            // date_start
            // 
            this.date_start.Animated = true;
            this.date_start.Checked = true;
            this.date_start.FillColor = System.Drawing.Color.White;
            this.date_start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_start.Location = new System.Drawing.Point(29, 160);
            this.date_start.Margin = new System.Windows.Forms.Padding(4);
            this.date_start.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_start.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(240, 44);
            this.date_start.TabIndex = 189;
            this.date_start.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(29, 137);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(72, 23);
            this.guna2HtmlLabel4.TabIndex = 188;
            this.guna2HtmlLabel4.Text = "Start Date";
            // 
            // rv_emptotreg
            // 
            reportDataSource9.Name = "EmpToTReg";
            reportDataSource9.Value = this.EmployeeTotalRegBindingSource;
            this.rv_emptotreg.LocalReport.DataSources.Add(reportDataSource9);
            this.rv_emptotreg.LocalReport.ReportEmbeddedResource = "Dreamron_College.TotalEmployeeReg_Grade.rdlc";
            this.rv_emptotreg.Location = new System.Drawing.Point(12, 225);
            this.rv_emptotreg.Name = "rv_emptotreg";
            this.rv_emptotreg.ServerReport.BearerToken = null;
            this.rv_emptotreg.Size = new System.Drawing.Size(901, 446);
            this.rv_emptotreg.TabIndex = 192;
            // 
            // AllRegistartion
            // 
            this.AllRegistartion.DataSetName = "AllRegistartion";
            this.AllRegistartion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmployeeTotalRegBindingSource
            // 
            this.EmployeeTotalRegBindingSource.DataMember = "EmployeeTotalReg";
            this.EmployeeTotalRegBindingSource.DataSource = this.AllRegistartion;
            // 
            // EmployeeTotalRegTableAdapter
            // 
            this.EmployeeTotalRegTableAdapter.ClearBeforeFill = true;
            // 
            // rv_lectot
            // 
            reportDataSource8.Name = "LecToTReg";
            reportDataSource8.Value = this.LecturerTotRegBindingSource;
            this.rv_lectot.LocalReport.DataSources.Add(reportDataSource8);
            this.rv_lectot.LocalReport.ReportEmbeddedResource = "Dreamron_College.TotalLecturerReg_Grade.rdlc";
            this.rv_lectot.Location = new System.Drawing.Point(12, 225);
            this.rv_lectot.Name = "rv_lectot";
            this.rv_lectot.ServerReport.BearerToken = null;
            this.rv_lectot.Size = new System.Drawing.Size(901, 446);
            this.rv_lectot.TabIndex = 193;
            // 
            // LecturerTotRegBindingSource
            // 
            this.LecturerTotRegBindingSource.DataMember = "LecturerTotReg";
            this.LecturerTotRegBindingSource.DataSource = this.AllRegistartion;
            // 
            // LecturerTableAdapter
            // 
            this.LecturerTableAdapter.ClearBeforeFill = true;
            // 
            // rv_studenttot
            // 
            reportDataSource7.Name = "TotStudReg";
            reportDataSource7.Value = this.StudentTotRegBindingSource;
            this.rv_studenttot.LocalReport.DataSources.Add(reportDataSource7);
            this.rv_studenttot.LocalReport.ReportEmbeddedResource = "Dreamron_College.TotalStuReg_Course.rdlc";
            this.rv_studenttot.Location = new System.Drawing.Point(12, 225);
            this.rv_studenttot.Name = "rv_studenttot";
            this.rv_studenttot.ServerReport.BearerToken = null;
            this.rv_studenttot.Size = new System.Drawing.Size(901, 446);
            this.rv_studenttot.TabIndex = 194;
            // 
            // StudentTotRegBindingSource
            // 
            this.StudentTotRegBindingSource.DataMember = "StudentTotReg";
            this.StudentTotRegBindingSource.DataSource = this.AllRegistartion;
            // 
            // StudentTotRegTableAdapter
            // 
            this.StudentTotRegTableAdapter.ClearBeforeFill = true;
            // 
            // RegistartionReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.rv_studenttot);
            this.Controls.Add(this.rv_lectot);
            this.Controls.Add(this.rv_emptotreg);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.date_start);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistartionReport";
            this.Text = "RegistartionReport";
            this.Load += new System.EventHandler(this.RegistartionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AllRegistartion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTotalRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerTotRegBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTotRegBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_generate;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_type;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_end;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_start;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Microsoft.Reporting.WinForms.ReportViewer rv_emptotreg;
        private System.Windows.Forms.BindingSource EmployeeTotalRegBindingSource;
        private AllRegistartion AllRegistartion;
        private AllRegistartionTableAdapters.EmployeeTotalRegTableAdapter EmployeeTotalRegTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_lectot;
        private System.Windows.Forms.BindingSource LecturerTotRegBindingSource;
        private AllRegistartionTableAdapters.LecturerTableAdapter LecturerTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_studenttot;
        private System.Windows.Forms.BindingSource StudentTotRegBindingSource;
        private AllRegistartionTableAdapters.StudentTotRegTableAdapter StudentTotRegTableAdapter;
    }
}