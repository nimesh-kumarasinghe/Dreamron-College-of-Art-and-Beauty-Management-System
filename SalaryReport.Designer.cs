
namespace Dreamron_College
{
    partial class SalaryReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.all_grades_data_set = new Dreamron_College.all_grades_data_set();
            this.LecSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LecturerAllGradesDataset = new Dreamron_College.LecturerAllGradesDataset();
            this.LecSalaryIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeSalaryIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeTotalSalGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TotalLecturerSalariesGradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.date_end = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_start = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_select_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_select_grade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_select_id = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_grade_des = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.d_txt_name_emp_id = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_show_generate = new Guna.UI2.WinForms.Guna2Button();
            this.rv_allgrade_salary = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_lec = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_lec_ID = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_employeeID = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_user_id = new Guna.UI2.WinForms.Guna2Button();
            this.SalaryTableAdapter = new Dreamron_College.all_grades_data_setTableAdapters.SalaryTableAdapter();
            this.EmployeeSalaryIDTableAdapter = new Dreamron_College.all_grades_data_setTableAdapters.EmployeeSalaryIDTableAdapter();
            this.btn_totsal = new Guna.UI2.WinForms.Guna2Button();
            this.rv_emp_tot_salaries = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmployeTotalSalGradeTableAdapter = new Dreamron_College.all_grades_data_setTableAdapters.EmployeTotalSalGradeTableAdapter();
            this.LecSalaryTableAdapter = new Dreamron_College.LecturerAllGradesDatasetTableAdapters.LecSalaryTableAdapter();
            this.LecSalaryIDTableAdapter = new Dreamron_College.LecturerAllGradesDatasetTableAdapters.LecSalaryIDTableAdapter();
            this.rv_lecturerTotalSalgrades = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TotalLecturerSalariesGradeTableAdapter = new Dreamron_College.LecturerAllGradesDatasetTableAdapters.TotalLecturerSalariesGradeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_grades_data_set)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecSalaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerAllGradesDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecSalaryIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalaryIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeTotalSalGradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalLecturerSalariesGradeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SalaryBindingSource
            // 
            this.SalaryBindingSource.DataMember = "Salary";
            this.SalaryBindingSource.DataSource = this.all_grades_data_set;
            // 
            // all_grades_data_set
            // 
            this.all_grades_data_set.DataSetName = "all_grades_data_set";
            this.all_grades_data_set.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LecSalaryBindingSource
            // 
            this.LecSalaryBindingSource.DataMember = "LecSalary";
            this.LecSalaryBindingSource.DataSource = this.LecturerAllGradesDataset;
            // 
            // LecturerAllGradesDataset
            // 
            this.LecturerAllGradesDataset.DataSetName = "LecturerAllGradesDataset";
            this.LecturerAllGradesDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LecSalaryIDBindingSource
            // 
            this.LecSalaryIDBindingSource.DataMember = "LecSalaryID";
            this.LecSalaryIDBindingSource.DataSource = this.LecturerAllGradesDataset;
            // 
            // EmployeeSalaryIDBindingSource
            // 
            this.EmployeeSalaryIDBindingSource.DataMember = "EmployeeSalaryID";
            this.EmployeeSalaryIDBindingSource.DataSource = this.all_grades_data_set;
            // 
            // EmployeTotalSalGradeBindingSource
            // 
            this.EmployeTotalSalGradeBindingSource.DataMember = "EmployeTotalSalGrade";
            this.EmployeTotalSalGradeBindingSource.DataSource = this.all_grades_data_set;
            // 
            // TotalLecturerSalariesGradeBindingSource
            // 
            this.TotalLecturerSalariesGradeBindingSource.DataMember = "TotalLecturerSalariesGrade";
            this.TotalLecturerSalariesGradeBindingSource.DataSource = this.LecturerAllGradesDataset;
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
            this.viewheaderlabel.Location = new System.Drawing.Point(13, 12);
            this.viewheaderlabel.Name = "viewheaderlabel";
            this.viewheaderlabel.Size = new System.Drawing.Size(255, 43);
            this.viewheaderlabel.TabIndex = 122;
            this.viewheaderlabel.Text = "SALARY REPORTS";
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
            this.btn_clear.Location = new System.Drawing.Point(675, 148);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(224, 35);
            this.btn_clear.TabIndex = 182;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // date_end
            // 
            this.date_end.Animated = true;
            this.date_end.Checked = true;
            this.date_end.FillColor = System.Drawing.Color.White;
            this.date_end.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_end.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_end.Location = new System.Drawing.Point(280, 161);
            this.date_end.Margin = new System.Windows.Forms.Padding(4);
            this.date_end.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_end.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(243, 44);
            this.date_end.TabIndex = 181;
            this.date_end.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(280, 138);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(65, 23);
            this.guna2HtmlLabel1.TabIndex = 180;
            this.guna2HtmlLabel1.Text = "End Date";
            // 
            // date_start
            // 
            this.date_start.Animated = true;
            this.date_start.Checked = true;
            this.date_start.FillColor = System.Drawing.Color.White;
            this.date_start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_start.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_start.Location = new System.Drawing.Point(13, 161);
            this.date_start.Margin = new System.Windows.Forms.Padding(4);
            this.date_start.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_start.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_start.Name = "date_start";
            this.date_start.Size = new System.Drawing.Size(240, 44);
            this.date_start.TabIndex = 178;
            this.date_start.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(13, 138);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(72, 23);
            this.guna2HtmlLabel4.TabIndex = 177;
            this.guna2HtmlLabel4.Text = "Start Date";
            // 
            // cmb_select_type
            // 
            this.cmb_select_type.BackColor = System.Drawing.Color.Transparent;
            this.cmb_select_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_select_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_select_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_select_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_select_type.ItemHeight = 30;
            this.cmb_select_type.Items.AddRange(new object[] {
            "Employee",
            "Lecturer"});
            this.cmb_select_type.Location = new System.Drawing.Point(12, 88);
            this.cmb_select_type.Name = "cmb_select_type";
            this.cmb_select_type.Size = new System.Drawing.Size(162, 36);
            this.cmb_select_type.TabIndex = 186;
            this.cmb_select_type.SelectedIndexChanged += new System.EventHandler(this.cmb_select_type_SelectedIndexChanged);
            // 
            // cmb_select_grade
            // 
            this.cmb_select_grade.BackColor = System.Drawing.Color.Transparent;
            this.cmb_select_grade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_select_grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_select_grade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_grade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_grade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_select_grade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_select_grade.ItemHeight = 30;
            this.cmb_select_grade.Location = new System.Drawing.Point(181, 88);
            this.cmb_select_grade.Name = "cmb_select_grade";
            this.cmb_select_grade.Size = new System.Drawing.Size(162, 36);
            this.cmb_select_grade.TabIndex = 187;
            this.cmb_select_grade.SelectedIndexChanged += new System.EventHandler(this.cmb_select_grade_SelectedIndexChanged);
            // 
            // cmb_select_id
            // 
            this.cmb_select_id.BackColor = System.Drawing.Color.Transparent;
            this.cmb_select_id.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_select_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_select_id.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_select_id.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_select_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_select_id.ItemHeight = 30;
            this.cmb_select_id.Location = new System.Drawing.Point(349, 88);
            this.cmb_select_id.Name = "cmb_select_id";
            this.cmb_select_id.Size = new System.Drawing.Size(162, 36);
            this.cmb_select_id.TabIndex = 188;
            this.cmb_select_id.SelectedIndexChanged += new System.EventHandler(this.cmb_select_id_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 62);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(90, 23);
            this.guna2HtmlLabel2.TabIndex = 189;
            this.guna2HtmlLabel2.Text = "Select a type";
            // 
            // txt_grade_des
            // 
            this.txt_grade_des.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_grade_des.BackColor = System.Drawing.Color.Transparent;
            this.txt_grade_des.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grade_des.ForeColor = System.Drawing.Color.Gray;
            this.txt_grade_des.Location = new System.Drawing.Point(181, 62);
            this.txt_grade_des.Margin = new System.Windows.Forms.Padding(4);
            this.txt_grade_des.Name = "txt_grade_des";
            this.txt_grade_des.Size = new System.Drawing.Size(45, 23);
            this.txt_grade_des.TabIndex = 190;
            this.txt_grade_des.Text = "Grade";
            this.txt_grade_des.Click += new System.EventHandler(this.txt_grade_des_Click);
            // 
            // d_txt_name_emp_id
            // 
            this.d_txt_name_emp_id.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.d_txt_name_emp_id.BackColor = System.Drawing.Color.Transparent;
            this.d_txt_name_emp_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.d_txt_name_emp_id.ForeColor = System.Drawing.Color.Gray;
            this.d_txt_name_emp_id.Location = new System.Drawing.Point(349, 62);
            this.d_txt_name_emp_id.Margin = new System.Windows.Forms.Padding(4);
            this.d_txt_name_emp_id.Name = "d_txt_name_emp_id";
            this.d_txt_name_emp_id.Size = new System.Drawing.Size(18, 23);
            this.d_txt_name_emp_id.TabIndex = 191;
            this.d_txt_name_emp_id.Text = "ID";
            this.d_txt_name_emp_id.Click += new System.EventHandler(this.d_txt_name_emp_id_Click);
            // 
            // btn_show_generate
            // 
            this.btn_show_generate.Animated = true;
            this.btn_show_generate.AutoRoundedCorners = true;
            this.btn_show_generate.BorderRadius = 16;
            this.btn_show_generate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_show_generate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_show_generate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_show_generate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_show_generate.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_show_generate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show_generate.ForeColor = System.Drawing.Color.White;
            this.btn_show_generate.Location = new System.Drawing.Point(675, 20);
            this.btn_show_generate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_show_generate.Name = "btn_show_generate";
            this.btn_show_generate.Size = new System.Drawing.Size(224, 35);
            this.btn_show_generate.TabIndex = 192;
            this.btn_show_generate.Text = "Generate All  Data";
            this.btn_show_generate.Click += new System.EventHandler(this.btn_show_generate_Click);
            // 
            // rv_allgrade_salary
            // 
            reportDataSource6.Name = "AllGradesDataset";
            reportDataSource6.Value = this.SalaryBindingSource;
            this.rv_allgrade_salary.LocalReport.DataSources.Add(reportDataSource6);
            this.rv_allgrade_salary.LocalReport.ReportEmbeddedResource = "Dreamron_College.all_salaries_of_grades.rdlc";
            this.rv_allgrade_salary.Location = new System.Drawing.Point(13, 229);
            this.rv_allgrade_salary.Name = "rv_allgrade_salary";
            this.rv_allgrade_salary.ServerReport.BearerToken = null;
            this.rv_allgrade_salary.Size = new System.Drawing.Size(900, 442);
            this.rv_allgrade_salary.TabIndex = 193;
            // 
            // rv_lec
            // 
            reportDataSource5.Name = "lecall";
            reportDataSource5.Value = this.LecSalaryBindingSource;
            this.rv_lec.LocalReport.DataSources.Add(reportDataSource5);
            this.rv_lec.LocalReport.ReportEmbeddedResource = "Dreamron_College.LecturerAllGradeSalaryReport.rdlc";
            this.rv_lec.Location = new System.Drawing.Point(13, 229);
            this.rv_lec.Name = "rv_lec";
            this.rv_lec.ServerReport.BearerToken = null;
            this.rv_lec.Size = new System.Drawing.Size(900, 442);
            this.rv_lec.TabIndex = 194;
            // 
            // rv_lec_ID
            // 
            reportDataSource4.Name = "LectureIDSalary";
            reportDataSource4.Value = this.LecSalaryIDBindingSource;
            this.rv_lec_ID.LocalReport.DataSources.Add(reportDataSource4);
            this.rv_lec_ID.LocalReport.ReportEmbeddedResource = "Dreamron_College.LecturerID_GradeReport.rdlc";
            this.rv_lec_ID.Location = new System.Drawing.Point(13, 229);
            this.rv_lec_ID.Name = "rv_lec_ID";
            this.rv_lec_ID.ServerReport.BearerToken = null;
            this.rv_lec_ID.Size = new System.Drawing.Size(900, 442);
            this.rv_lec_ID.TabIndex = 195;
            // 
            // rv_employeeID
            // 
            reportDataSource3.Name = "EmployeeIDGrade";
            reportDataSource3.Value = this.EmployeeSalaryIDBindingSource;
            this.rv_employeeID.LocalReport.DataSources.Add(reportDataSource3);
            this.rv_employeeID.LocalReport.ReportEmbeddedResource = "Dreamron_College.EmployeeIDGradeReport.rdlc";
            this.rv_employeeID.Location = new System.Drawing.Point(13, 229);
            this.rv_employeeID.Name = "rv_employeeID";
            this.rv_employeeID.ServerReport.BearerToken = null;
            this.rv_employeeID.Size = new System.Drawing.Size(900, 442);
            this.rv_employeeID.TabIndex = 196;
            // 
            // btn_user_id
            // 
            this.btn_user_id.Animated = true;
            this.btn_user_id.AutoRoundedCorners = true;
            this.btn_user_id.BorderRadius = 16;
            this.btn_user_id.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_user_id.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_user_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_user_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_user_id.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_user_id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_id.ForeColor = System.Drawing.Color.White;
            this.btn_user_id.Location = new System.Drawing.Point(675, 62);
            this.btn_user_id.Margin = new System.Windows.Forms.Padding(4);
            this.btn_user_id.Name = "btn_user_id";
            this.btn_user_id.Size = new System.Drawing.Size(224, 35);
            this.btn_user_id.TabIndex = 197;
            this.btn_user_id.Text = "Generate For a User";
            this.btn_user_id.Click += new System.EventHandler(this.btn_user_id_Click);
            // 
            // SalaryTableAdapter
            // 
            this.SalaryTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeSalaryIDTableAdapter
            // 
            this.EmployeeSalaryIDTableAdapter.ClearBeforeFill = true;
            // 
            // btn_totsal
            // 
            this.btn_totsal.Animated = true;
            this.btn_totsal.AutoRoundedCorners = true;
            this.btn_totsal.BorderRadius = 16;
            this.btn_totsal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_totsal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_totsal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_totsal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_totsal.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_totsal.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_totsal.ForeColor = System.Drawing.Color.White;
            this.btn_totsal.Location = new System.Drawing.Point(675, 105);
            this.btn_totsal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_totsal.Name = "btn_totsal";
            this.btn_totsal.Size = new System.Drawing.Size(224, 35);
            this.btn_totsal.TabIndex = 198;
            this.btn_totsal.Text = "Generate Total Salaries";
            this.btn_totsal.Click += new System.EventHandler(this.btn_totsal_Click);
            // 
            // rv_emp_tot_salaries
            // 
            reportDataSource2.Name = "EmployeeTotSalGradesDataset";
            reportDataSource2.Value = this.EmployeTotalSalGradeBindingSource;
            this.rv_emp_tot_salaries.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_emp_tot_salaries.LocalReport.ReportEmbeddedResource = "Dreamron_College.EmployeeTotalSalaryGradesReport.rdlc";
            this.rv_emp_tot_salaries.Location = new System.Drawing.Point(13, 229);
            this.rv_emp_tot_salaries.Name = "rv_emp_tot_salaries";
            this.rv_emp_tot_salaries.ServerReport.BearerToken = null;
            this.rv_emp_tot_salaries.Size = new System.Drawing.Size(900, 442);
            this.rv_emp_tot_salaries.TabIndex = 199;
            // 
            // EmployeTotalSalGradeTableAdapter
            // 
            this.EmployeTotalSalGradeTableAdapter.ClearBeforeFill = true;
            // 
            // LecSalaryTableAdapter
            // 
            this.LecSalaryTableAdapter.ClearBeforeFill = true;
            // 
            // LecSalaryIDTableAdapter
            // 
            this.LecSalaryIDTableAdapter.ClearBeforeFill = true;
            // 
            // rv_lecturerTotalSalgrades
            // 
            reportDataSource1.Name = "LecturerTotalsalariesGrades";
            reportDataSource1.Value = this.TotalLecturerSalariesGradeBindingSource;
            this.rv_lecturerTotalSalgrades.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_lecturerTotalSalgrades.LocalReport.ReportEmbeddedResource = "Dreamron_College.LecturerTotalSalaryGrades.rdlc";
            this.rv_lecturerTotalSalgrades.Location = new System.Drawing.Point(13, 229);
            this.rv_lecturerTotalSalgrades.Name = "rv_lecturerTotalSalgrades";
            this.rv_lecturerTotalSalgrades.ServerReport.BearerToken = null;
            this.rv_lecturerTotalSalgrades.Size = new System.Drawing.Size(900, 442);
            this.rv_lecturerTotalSalgrades.TabIndex = 200;
            // 
            // TotalLecturerSalariesGradeTableAdapter
            // 
            this.TotalLecturerSalariesGradeTableAdapter.ClearBeforeFill = true;
            // 
            // SalaryReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.rv_lecturerTotalSalgrades);
            this.Controls.Add(this.rv_emp_tot_salaries);
            this.Controls.Add(this.btn_totsal);
            this.Controls.Add(this.btn_user_id);
            this.Controls.Add(this.rv_employeeID);
            this.Controls.Add(this.rv_lec_ID);
            this.Controls.Add(this.rv_lec);
            this.Controls.Add(this.rv_allgrade_salary);
            this.Controls.Add(this.btn_show_generate);
            this.Controls.Add(this.d_txt_name_emp_id);
            this.Controls.Add(this.txt_grade_des);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cmb_select_id);
            this.Controls.Add(this.cmb_select_grade);
            this.Controls.Add(this.cmb_select_type);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.date_start);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalaryReport";
            this.Text = "MonthlySalaryReport";
            this.Load += new System.EventHandler(this.MonthlySalaryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_grades_data_set)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecSalaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerAllGradesDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecSalaryIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeSalaryIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeTotalSalGradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalLecturerSalariesGradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_end;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_start;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel d_txt_name_emp_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel txt_grade_des;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_select_id;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_select_grade;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_select_type;
        private Guna.UI2.WinForms.Guna2Button btn_show_generate;
        private Microsoft.Reporting.WinForms.ReportViewer rv_allgrade_salary;
        private System.Windows.Forms.BindingSource SalaryBindingSource;
        private all_grades_data_set all_grades_data_set;
        private all_grades_data_setTableAdapters.SalaryTableAdapter SalaryTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_lec;
        private System.Windows.Forms.BindingSource LecSalaryBindingSource;
        private LecturerAllGradesDataset LecturerAllGradesDataset;
        private LecturerAllGradesDatasetTableAdapters.LecSalaryTableAdapter LecSalaryTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_lec_ID;
        private System.Windows.Forms.BindingSource LecSalaryIDBindingSource;
        private LecturerAllGradesDatasetTableAdapters.LecSalaryIDTableAdapter LecSalaryIDTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_employeeID;
        private System.Windows.Forms.BindingSource EmployeeSalaryIDBindingSource;
        private all_grades_data_setTableAdapters.EmployeeSalaryIDTableAdapter EmployeeSalaryIDTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btn_user_id;
        private Microsoft.Reporting.WinForms.ReportViewer rv_emp_tot_salaries;
        private Guna.UI2.WinForms.Guna2Button btn_totsal;
        private System.Windows.Forms.BindingSource EmployeTotalSalGradeBindingSource;
        private all_grades_data_setTableAdapters.EmployeTotalSalGradeTableAdapter EmployeTotalSalGradeTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_lecturerTotalSalgrades;
        private System.Windows.Forms.BindingSource TotalLecturerSalariesGradeBindingSource;
        private LecturerAllGradesDatasetTableAdapters.TotalLecturerSalariesGradeTableAdapter TotalLecturerSalariesGradeTableAdapter;
    }
}