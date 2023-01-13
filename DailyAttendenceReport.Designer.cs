
namespace Dreamron_College
{
    partial class DailyAttendenceReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dt_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_generate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.AttendenceDataset = new Dreamron_College.AttendenceDataset();
            this.AttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AttendanceTableAdapter = new Dreamron_College.AttendenceDatasetTableAdapters.AttendanceTableAdapter();
            this.txt_type = new Guna.UI2.WinForms.Guna2TextBox();
            this.rv_emp = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_student = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_lecturer = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.AttendenceDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // viewheaderlabel
            // 
            this.viewheaderlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewheaderlabel.BackColor = System.Drawing.Color.Transparent;
            this.viewheaderlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewheaderlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.viewheaderlabel.Location = new System.Drawing.Point(38, 15);
            this.viewheaderlabel.Name = "viewheaderlabel";
            this.viewheaderlabel.Size = new System.Drawing.Size(414, 43);
            this.viewheaderlabel.TabIndex = 78;
            this.viewheaderlabel.Text = "DAILY ATTENDENCE REPORT";
            // 
            // dt_picker
            // 
            this.dt_picker.Animated = true;
            this.dt_picker.Checked = true;
            this.dt_picker.FillColor = System.Drawing.Color.White;
            this.dt_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_picker.Location = new System.Drawing.Point(12, 96);
            this.dt_picker.Margin = new System.Windows.Forms.Padding(4);
            this.dt_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_picker.Name = "dt_picker";
            this.dt_picker.Size = new System.Drawing.Size(245, 44);
            this.dt_picker.TabIndex = 119;
            this.dt_picker.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 65);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(106, 23);
            this.guna2HtmlLabel4.TabIndex = 118;
            this.guna2HtmlLabel4.Text = "Select the Date";
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
            this.btn_generate.Location = new System.Drawing.Point(621, 40);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(134, 35);
            this.btn_generate.TabIndex = 147;
            this.btn_generate.Text = "Generate";
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
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
            this.btn_clear.Location = new System.Drawing.Point(778, 40);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 35);
            this.btn_clear.TabIndex = 177;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // AttendenceDataset
            // 
            this.AttendenceDataset.DataSetName = "AttendenceDataset";
            this.AttendenceDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AttendanceBindingSource
            // 
            this.AttendanceBindingSource.DataMember = "Attendance";
            this.AttendanceBindingSource.DataSource = this.AttendenceDataset;
            // 
            // AttendanceTableAdapter
            // 
            this.AttendanceTableAdapter.ClearBeforeFill = true;
            // 
            // txt_type
            // 
            this.txt_type.Animated = true;
            this.txt_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_type.DefaultText = "";
            this.txt_type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_type.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_type.ForeColor = System.Drawing.Color.DimGray;
            this.txt_type.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_type.Location = new System.Drawing.Point(279, 96);
            this.txt_type.Margin = new System.Windows.Forms.Padding(7);
            this.txt_type.Name = "txt_type";
            this.txt_type.PasswordChar = '\0';
            this.txt_type.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_type.PlaceholderText = "Enter User Type (Ex: Employee or Lecturer or Student)";
            this.txt_type.SelectedText = "";
            this.txt_type.Size = new System.Drawing.Size(489, 44);
            this.txt_type.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_type.TabIndex = 178;
            // 
            // rv_emp
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.AttendanceBindingSource;
            this.rv_emp.LocalReport.DataSources.Add(reportDataSource3);
            this.rv_emp.LocalReport.ReportEmbeddedResource = "Dreamron_College.EmployeeAttendenceReportLayout.rdlc";
            this.rv_emp.Location = new System.Drawing.Point(12, 163);
            this.rv_emp.Name = "rv_emp";
            this.rv_emp.ServerReport.BearerToken = null;
            this.rv_emp.Size = new System.Drawing.Size(901, 508);
            this.rv_emp.TabIndex = 179;
            // 
            // rv_student
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.AttendanceBindingSource;
            this.rv_student.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_student.LocalReport.ReportEmbeddedResource = "Dreamron_College.StudentAttendenceReportLayout.rdlc";
            this.rv_student.Location = new System.Drawing.Point(12, 163);
            this.rv_student.Name = "rv_student";
            this.rv_student.ServerReport.BearerToken = null;
            this.rv_student.Size = new System.Drawing.Size(901, 508);
            this.rv_student.TabIndex = 181;
            // 
            // rv_lecturer
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AttendanceBindingSource;
            this.rv_lecturer.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_lecturer.LocalReport.ReportEmbeddedResource = "Dreamron_College.LecturerAttendenceReportlayout.rdlc";
            this.rv_lecturer.Location = new System.Drawing.Point(12, 163);
            this.rv_lecturer.Name = "rv_lecturer";
            this.rv_lecturer.ServerReport.BearerToken = null;
            this.rv_lecturer.Size = new System.Drawing.Size(900, 508);
            this.rv_lecturer.TabIndex = 182;
            // 
            // DailyAttendenceReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.rv_lecturer);
            this.Controls.Add(this.rv_student);
            this.Controls.Add(this.rv_emp);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.dt_picker);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyAttendenceReport";
            this.Text = "DailyAttendenceReport";
            this.Load += new System.EventHandler(this.DailyAttendenceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttendenceDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_picker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btn_generate;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private System.Windows.Forms.BindingSource AttendanceBindingSource;
        private AttendenceDataset AttendenceDataset;
        private AttendenceDatasetTableAdapters.AttendanceTableAdapter AttendanceTableAdapter;
        private Guna.UI2.WinForms.Guna2TextBox txt_type;
        private Microsoft.Reporting.WinForms.ReportViewer rv_emp;
        private Microsoft.Reporting.WinForms.ReportViewer rv_student;
        private Microsoft.Reporting.WinForms.ReportViewer rv_lecturer;
    }
}