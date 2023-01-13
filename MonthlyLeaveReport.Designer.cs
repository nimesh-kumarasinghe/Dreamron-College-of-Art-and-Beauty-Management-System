
namespace Dreamron_College
{
    partial class MonthlyLeaveReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.dt_end = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_generate = new Guna.UI2.WinForms.Guna2Button();
            this.dt_start = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_types = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rv_emptot = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_lectotgrade = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_leave_id = new Guna.UI2.WinForms.Guna2Button();
            this.rv_empid = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_lecid = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rv_withoutgradeid = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EmpTotIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AllLevaes = new Dreamron_College.AllLevaes();
            this.testempleaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LecTotIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LecturerTotLeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeTotLeaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeTotLeaveTableAdapter = new Dreamron_College.AllLevaesTableAdapters.EmployeeTotLeaveTableAdapter();
            this.LecturerTotLeaveTableAdapter = new Dreamron_College.AllLevaesTableAdapters.LecturerTotLeaveTableAdapter();
            this.EmpTotIDTableAdapter = new Dreamron_College.AllLevaesTableAdapters.EmpTotIDTableAdapter();
            this.LecTotIDTableAdapter = new Dreamron_College.AllLevaesTableAdapters.LecTotIDTableAdapter();
            this.testempleaveTableAdapter = new Dreamron_College.AllLevaesTableAdapters.testempleaveTableAdapter();
            this.rv_lecwithoutgrade = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lecwithoutgradeIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecwithoutgradeIDTableAdapter = new Dreamron_College.AllLevaesTableAdapters.lecwithoutgradeIDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EmpTotIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllLevaes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testempleaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecTotIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerTotLeaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTotLeaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecwithoutgradeIDBindingSource)).BeginInit();
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
            this.btn_clear.Location = new System.Drawing.Point(712, 99);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 35);
            this.btn_clear.TabIndex = 175;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dt_end
            // 
            this.dt_end.Animated = true;
            this.dt_end.Checked = true;
            this.dt_end.FillColor = System.Drawing.Color.White;
            this.dt_end.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_end.Location = new System.Drawing.Point(280, 166);
            this.dt_end.Margin = new System.Windows.Forms.Padding(4);
            this.dt_end.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_end.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(243, 44);
            this.dt_end.TabIndex = 173;
            this.dt_end.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(280, 136);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(199, 23);
            this.guna2HtmlLabel1.TabIndex = 172;
            this.guna2HtmlLabel1.Text = "Select Last day of the Month";
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
            this.btn_generate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.ForeColor = System.Drawing.Color.White;
            this.btn_generate.Location = new System.Drawing.Point(644, 13);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(268, 35);
            this.btn_generate.TabIndex = 171;
            this.btn_generate.Text = "Generate According to Grades";
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // dt_start
            // 
            this.dt_start.Animated = true;
            this.dt_start.Checked = true;
            this.dt_start.FillColor = System.Drawing.Color.White;
            this.dt_start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_start.Location = new System.Drawing.Point(13, 166);
            this.dt_start.Margin = new System.Windows.Forms.Padding(4);
            this.dt_start.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_start.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(243, 44);
            this.dt_start.TabIndex = 170;
            this.dt_start.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(13, 136);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(201, 23);
            this.guna2HtmlLabel4.TabIndex = 169;
            this.guna2HtmlLabel4.Text = "Select First day of the Month";
            // 
            // viewheaderlabel
            // 
            this.viewheaderlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewheaderlabel.BackColor = System.Drawing.Color.Transparent;
            this.viewheaderlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewheaderlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.viewheaderlabel.Location = new System.Drawing.Point(15, 12);
            this.viewheaderlabel.Name = "viewheaderlabel";
            this.viewheaderlabel.Size = new System.Drawing.Size(214, 43);
            this.viewheaderlabel.TabIndex = 167;
            this.viewheaderlabel.Text = "LEAVE REPORT\r\n";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(13, 62);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(81, 23);
            this.guna2HtmlLabel2.TabIndex = 195;
            this.guna2HtmlLabel2.Text = "Select Type";
            // 
            // cmb_types
            // 
            this.cmb_types.BackColor = System.Drawing.Color.Transparent;
            this.cmb_types.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_types.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_types.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_types.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_types.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_types.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_types.ItemHeight = 30;
            this.cmb_types.Items.AddRange(new object[] {
            "Employee",
            "Lecturer"});
            this.cmb_types.Location = new System.Drawing.Point(12, 90);
            this.cmb_types.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_types.Name = "cmb_types";
            this.cmb_types.Size = new System.Drawing.Size(136, 36);
            this.cmb_types.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_types.TabIndex = 200;
            this.cmb_types.SelectedIndexChanged += new System.EventHandler(this.cmb_types_SelectedIndexChanged);
            // 
            // rv_emptot
            // 
            reportDataSource8.Name = "EMpTotLeave";
            reportDataSource8.Value = this.EmployeeTotLeaveBindingSource;
            this.rv_emptot.LocalReport.DataSources.Add(reportDataSource8);
            this.rv_emptot.LocalReport.ReportEmbeddedResource = "Dreamron_College.EmployeeTotLeaveReport.rdlc";
            this.rv_emptot.Location = new System.Drawing.Point(12, 233);
            this.rv_emptot.Name = "rv_emptot";
            this.rv_emptot.ServerReport.BearerToken = null;
            this.rv_emptot.Size = new System.Drawing.Size(900, 438);
            this.rv_emptot.TabIndex = 202;
            // 
            // rv_lectotgrade
            // 
            reportDataSource7.Name = "LecTot";
            reportDataSource7.Value = this.LecturerTotLeaveBindingSource;
            this.rv_lectotgrade.LocalReport.DataSources.Add(reportDataSource7);
            this.rv_lectotgrade.LocalReport.ReportEmbeddedResource = "Dreamron_College.LecTotLeavesGrades.rdlc";
            this.rv_lectotgrade.Location = new System.Drawing.Point(12, 233);
            this.rv_lectotgrade.Name = "rv_lectotgrade";
            this.rv_lectotgrade.ServerReport.BearerToken = null;
            this.rv_lectotgrade.Size = new System.Drawing.Size(900, 438);
            this.rv_lectotgrade.TabIndex = 203;
            // 
            // btn_leave_id
            // 
            this.btn_leave_id.Animated = true;
            this.btn_leave_id.AutoRoundedCorners = true;
            this.btn_leave_id.BorderRadius = 16;
            this.btn_leave_id.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_leave_id.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_leave_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_leave_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_leave_id.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_leave_id.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leave_id.ForeColor = System.Drawing.Color.White;
            this.btn_leave_id.Location = new System.Drawing.Point(644, 56);
            this.btn_leave_id.Margin = new System.Windows.Forms.Padding(4);
            this.btn_leave_id.Name = "btn_leave_id";
            this.btn_leave_id.Size = new System.Drawing.Size(268, 35);
            this.btn_leave_id.TabIndex = 204;
            this.btn_leave_id.Text = "Generate According to ID";
            this.btn_leave_id.Click += new System.EventHandler(this.btn_leave_id_Click);
            // 
            // rv_empid
            // 
            reportDataSource6.Name = "emptotID";
            reportDataSource6.Value = this.EmpTotIDBindingSource;
            this.rv_empid.LocalReport.DataSources.Add(reportDataSource6);
            this.rv_empid.LocalReport.ReportEmbeddedResource = "Dreamron_College.EmpTotLevesID.rdlc";
            this.rv_empid.Location = new System.Drawing.Point(13, 233);
            this.rv_empid.Name = "rv_empid";
            this.rv_empid.ServerReport.BearerToken = null;
            this.rv_empid.Size = new System.Drawing.Size(899, 438);
            this.rv_empid.TabIndex = 205;
            // 
            // rv_lecid
            // 
            reportDataSource5.Name = "lectotleavesID";
            reportDataSource5.Value = this.LecTotIDBindingSource;
            this.rv_lecid.LocalReport.DataSources.Add(reportDataSource5);
            this.rv_lecid.LocalReport.ReportEmbeddedResource = "Dreamron_College.lectotleavesID.rdlc";
            this.rv_lecid.Location = new System.Drawing.Point(12, 233);
            this.rv_lecid.Name = "rv_lecid";
            this.rv_lecid.ServerReport.BearerToken = null;
            this.rv_lecid.Size = new System.Drawing.Size(901, 438);
            this.rv_lecid.TabIndex = 206;
            // 
            // rv_withoutgradeid
            // 
            reportDataSource3.Name = "emptotID";
            reportDataSource3.Value = this.EmpTotIDBindingSource;
            reportDataSource4.Name = "testemp";
            reportDataSource4.Value = this.testempleaveBindingSource;
            this.rv_withoutgradeid.LocalReport.DataSources.Add(reportDataSource3);
            this.rv_withoutgradeid.LocalReport.DataSources.Add(reportDataSource4);
            this.rv_withoutgradeid.LocalReport.ReportEmbeddedResource = "Dreamron_College.EmpTotLevesID.rdlc";
            this.rv_withoutgradeid.Location = new System.Drawing.Point(12, 233);
            this.rv_withoutgradeid.Name = "rv_withoutgradeid";
            this.rv_withoutgradeid.ServerReport.BearerToken = null;
            this.rv_withoutgradeid.Size = new System.Drawing.Size(900, 438);
            this.rv_withoutgradeid.TabIndex = 207;
            // 
            // EmpTotIDBindingSource
            // 
            this.EmpTotIDBindingSource.DataMember = "EmpTotID";
            this.EmpTotIDBindingSource.DataSource = this.AllLevaes;
            // 
            // AllLevaes
            // 
            this.AllLevaes.DataSetName = "AllLevaes";
            this.AllLevaes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testempleaveBindingSource
            // 
            this.testempleaveBindingSource.DataMember = "testempleave";
            this.testempleaveBindingSource.DataSource = this.AllLevaes;
            // 
            // LecTotIDBindingSource
            // 
            this.LecTotIDBindingSource.DataMember = "LecTotID";
            this.LecTotIDBindingSource.DataSource = this.AllLevaes;
            // 
            // LecturerTotLeaveBindingSource
            // 
            this.LecturerTotLeaveBindingSource.DataMember = "LecturerTotLeave";
            this.LecturerTotLeaveBindingSource.DataSource = this.AllLevaes;
            // 
            // EmployeeTotLeaveBindingSource
            // 
            this.EmployeeTotLeaveBindingSource.DataMember = "EmployeeTotLeave";
            this.EmployeeTotLeaveBindingSource.DataSource = this.AllLevaes;
            // 
            // EmployeeTotLeaveTableAdapter
            // 
            this.EmployeeTotLeaveTableAdapter.ClearBeforeFill = true;
            // 
            // LecturerTotLeaveTableAdapter
            // 
            this.LecturerTotLeaveTableAdapter.ClearBeforeFill = true;
            // 
            // EmpTotIDTableAdapter
            // 
            this.EmpTotIDTableAdapter.ClearBeforeFill = true;
            // 
            // LecTotIDTableAdapter
            // 
            this.LecTotIDTableAdapter.ClearBeforeFill = true;
            // 
            // testempleaveTableAdapter
            // 
            this.testempleaveTableAdapter.ClearBeforeFill = true;
            // 
            // rv_lecwithoutgrade
            // 
            reportDataSource1.Name = "lectotleavesID";
            reportDataSource1.Value = this.LecTotIDBindingSource;
            reportDataSource2.Name = "lecleavewithoutgradeID";
            reportDataSource2.Value = this.lecwithoutgradeIDBindingSource;
            this.rv_lecwithoutgrade.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_lecwithoutgrade.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_lecwithoutgrade.LocalReport.ReportEmbeddedResource = "Dreamron_College.lectotleavesID.rdlc";
            this.rv_lecwithoutgrade.Location = new System.Drawing.Point(12, 233);
            this.rv_lecwithoutgrade.Name = "rv_lecwithoutgrade";
            this.rv_lecwithoutgrade.ServerReport.BearerToken = null;
            this.rv_lecwithoutgrade.Size = new System.Drawing.Size(901, 438);
            this.rv_lecwithoutgrade.TabIndex = 208;
            // 
            // lecwithoutgradeIDBindingSource
            // 
            this.lecwithoutgradeIDBindingSource.DataMember = "lecwithoutgradeID";
            this.lecwithoutgradeIDBindingSource.DataSource = this.AllLevaes;
            // 
            // lecwithoutgradeIDTableAdapter
            // 
            this.lecwithoutgradeIDTableAdapter.ClearBeforeFill = true;
            // 
            // MonthlyLeaveReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.rv_lecwithoutgrade);
            this.Controls.Add(this.rv_withoutgradeid);
            this.Controls.Add(this.rv_lecid);
            this.Controls.Add(this.rv_empid);
            this.Controls.Add(this.btn_leave_id);
            this.Controls.Add(this.rv_lectotgrade);
            this.Controls.Add(this.rv_emptot);
            this.Controls.Add(this.cmb_types);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyLeaveReport";
            this.Text = "MonthlyLeaveReport";
            this.Load += new System.EventHandler(this.MonthlyLeaveReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpTotIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllLevaes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testempleaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecTotIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LecturerTotLeaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTotLeaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecwithoutgradeIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_end;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btn_generate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_start;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_types;
        private Microsoft.Reporting.WinForms.ReportViewer rv_emptot;
        private System.Windows.Forms.BindingSource EmployeeTotLeaveBindingSource;
        private AllLevaes AllLevaes;
        private AllLevaesTableAdapters.EmployeeTotLeaveTableAdapter EmployeeTotLeaveTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_lectotgrade;
        private System.Windows.Forms.BindingSource LecturerTotLeaveBindingSource;
        private AllLevaesTableAdapters.LecturerTotLeaveTableAdapter LecturerTotLeaveTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btn_leave_id;
        private Microsoft.Reporting.WinForms.ReportViewer rv_empid;
        private System.Windows.Forms.BindingSource EmpTotIDBindingSource;
        private AllLevaesTableAdapters.EmpTotIDTableAdapter EmpTotIDTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_lecid;
        private System.Windows.Forms.BindingSource LecTotIDBindingSource;
        private AllLevaesTableAdapters.LecTotIDTableAdapter LecTotIDTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_withoutgradeid;
        private System.Windows.Forms.BindingSource testempleaveBindingSource;
        private AllLevaesTableAdapters.testempleaveTableAdapter testempleaveTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_lecwithoutgrade;
        private System.Windows.Forms.BindingSource lecwithoutgradeIDBindingSource;
        private AllLevaesTableAdapters.lecwithoutgradeIDTableAdapter lecwithoutgradeIDTableAdapter;
    }
}