
namespace Dreamron_College
{
    partial class MonthlyStudentPaymentReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PaymentDataset = new Dreamron_College.PaymentDataset();
            this.PaymentrelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RelavantCoursePayments = new Dreamron_College.RelavantCoursePayments();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.dt_lastday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dt_firstday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_generate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_allreports = new Guna.UI2.WinForms.Guna2Button();
            this.cmb_batchid = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_cname = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rv_all = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaymentTableAdapter = new Dreamron_College.PaymentDatasetTableAdapters.PaymentTableAdapter();
            this.rv_relcourse = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaymentrelTableAdapter = new Dreamron_College.RelavantCoursePaymentsTableAdapters.PaymentrelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentrelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelavantCoursePayments)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentBindingSource
            // 
            this.PaymentBindingSource.DataMember = "Payment";
            this.PaymentBindingSource.DataSource = this.PaymentDataset;
            // 
            // PaymentDataset
            // 
            this.PaymentDataset.DataSetName = "PaymentDataset";
            this.PaymentDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PaymentrelBindingSource
            // 
            this.PaymentrelBindingSource.DataMember = "Paymentrel";
            this.PaymentrelBindingSource.DataSource = this.RelavantCoursePayments;
            // 
            // RelavantCoursePayments
            // 
            this.RelavantCoursePayments.DataSetName = "RelavantCoursePayments";
            this.RelavantCoursePayments.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.viewheaderlabel.Location = new System.Drawing.Point(13, 13);
            this.viewheaderlabel.Name = "viewheaderlabel";
            this.viewheaderlabel.Size = new System.Drawing.Size(415, 43);
            this.viewheaderlabel.TabIndex = 170;
            this.viewheaderlabel.Text = "STUDENT PAYMENT REPORT\r\n";
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
            this.btn_clear.Location = new System.Drawing.Point(708, 104);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 35);
            this.btn_clear.TabIndex = 188;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // dt_lastday
            // 
            this.dt_lastday.Animated = true;
            this.dt_lastday.Checked = true;
            this.dt_lastday.FillColor = System.Drawing.Color.White;
            this.dt_lastday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_lastday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_lastday.Location = new System.Drawing.Point(280, 95);
            this.dt_lastday.Margin = new System.Windows.Forms.Padding(4);
            this.dt_lastday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_lastday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_lastday.Name = "dt_lastday";
            this.dt_lastday.Size = new System.Drawing.Size(243, 44);
            this.dt_lastday.TabIndex = 187;
            this.dt_lastday.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(280, 65);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(199, 23);
            this.guna2HtmlLabel1.TabIndex = 186;
            this.guna2HtmlLabel1.Text = "Select Last day of the Month";
            // 
            // dt_firstday
            // 
            this.dt_firstday.Animated = true;
            this.dt_firstday.Checked = true;
            this.dt_firstday.FillColor = System.Drawing.Color.White;
            this.dt_firstday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_firstday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_firstday.Location = new System.Drawing.Point(13, 95);
            this.dt_firstday.Margin = new System.Windows.Forms.Padding(4);
            this.dt_firstday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_firstday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_firstday.Name = "dt_firstday";
            this.dt_firstday.Size = new System.Drawing.Size(243, 44);
            this.dt_firstday.TabIndex = 184;
            this.dt_firstday.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(13, 65);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(201, 23);
            this.guna2HtmlLabel4.TabIndex = 183;
            this.guna2HtmlLabel4.Text = "Select First day of the Month";
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
            this.btn_generate.Location = new System.Drawing.Point(551, 104);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(134, 35);
            this.btn_generate.TabIndex = 190;
            this.btn_generate.Text = "Generate";
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_allreports
            // 
            this.btn_allreports.Animated = true;
            this.btn_allreports.AutoRoundedCorners = true;
            this.btn_allreports.BorderRadius = 16;
            this.btn_allreports.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_allreports.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_allreports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_allreports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_allreports.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_allreports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_allreports.ForeColor = System.Drawing.Color.White;
            this.btn_allreports.Location = new System.Drawing.Point(622, 13);
            this.btn_allreports.Margin = new System.Windows.Forms.Padding(4);
            this.btn_allreports.Name = "btn_allreports";
            this.btn_allreports.Size = new System.Drawing.Size(291, 35);
            this.btn_allreports.TabIndex = 192;
            this.btn_allreports.Text = "Get All Payments";
            this.btn_allreports.Click += new System.EventHandler(this.btn_allreports_Click);
            // 
            // cmb_batchid
            // 
            this.cmb_batchid.BackColor = System.Drawing.Color.Transparent;
            this.cmb_batchid.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_batchid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_batchid.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_batchid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_batchid.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_batchid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_batchid.ItemHeight = 30;
            this.cmb_batchid.Location = new System.Drawing.Point(13, 162);
            this.cmb_batchid.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_batchid.Name = "cmb_batchid";
            this.cmb_batchid.Size = new System.Drawing.Size(136, 36);
            this.cmb_batchid.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_batchid.TabIndex = 193;
            this.cmb_batchid.SelectedIndexChanged += new System.EventHandler(this.cmb_batchid_SelectedIndexChanged);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(13, 147);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(60, 23);
            this.guna2HtmlLabel2.TabIndex = 194;
            this.guna2HtmlLabel2.Text = "Batch ID\r\n";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmb_cname
            // 
            this.cmb_cname.BackColor = System.Drawing.Color.Transparent;
            this.cmb_cname.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_cname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_cname.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_cname.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_cname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_cname.ItemHeight = 30;
            this.cmb_cname.Location = new System.Drawing.Point(168, 162);
            this.cmb_cname.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_cname.Name = "cmb_cname";
            this.cmb_cname.Size = new System.Drawing.Size(517, 36);
            this.cmb_cname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_cname.TabIndex = 195;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(168, 147);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(98, 23);
            this.guna2HtmlLabel3.TabIndex = 194;
            this.guna2HtmlLabel3.Text = "Course Name\r\n\r\n";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rv_all
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.PaymentBindingSource;
            this.rv_all.LocalReport.DataSources.Add(reportDataSource2);
            this.rv_all.LocalReport.ReportEmbeddedResource = "Dreamron_College.StudentPayentReportLayout.rdlc";
            this.rv_all.Location = new System.Drawing.Point(13, 219);
            this.rv_all.Name = "rv_all";
            this.rv_all.ServerReport.BearerToken = null;
            this.rv_all.Size = new System.Drawing.Size(900, 452);
            this.rv_all.TabIndex = 196;
            // 
            // PaymentTableAdapter
            // 
            this.PaymentTableAdapter.ClearBeforeFill = true;
            // 
            // rv_relcourse
            // 
            reportDataSource1.Name = "relcourse";
            reportDataSource1.Value = this.PaymentrelBindingSource;
            this.rv_relcourse.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_relcourse.LocalReport.ReportEmbeddedResource = "Dreamron_College.RelavantCoursePaymentReportLayout.rdlc";
            this.rv_relcourse.Location = new System.Drawing.Point(12, 219);
            this.rv_relcourse.Name = "rv_relcourse";
            this.rv_relcourse.ServerReport.BearerToken = null;
            this.rv_relcourse.Size = new System.Drawing.Size(901, 452);
            this.rv_relcourse.TabIndex = 197;
            // 
            // PaymentrelTableAdapter
            // 
            this.PaymentrelTableAdapter.ClearBeforeFill = true;
            // 
            // MonthlyStudentPaymentReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.rv_relcourse);
            this.Controls.Add(this.rv_all);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cmb_cname);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cmb_batchid);
            this.Controls.Add(this.btn_allreports);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dt_lastday);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dt_firstday);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyStudentPaymentReport";
            this.Text = "MonthlyStudentPaymentReport";
            this.Load += new System.EventHandler(this.MonthlyStudentPaymentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentrelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RelavantCoursePayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_lastday;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_firstday;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btn_generate;
        private Guna.UI2.WinForms.Guna2Button btn_allreports;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_cname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_batchid;
        private Microsoft.Reporting.WinForms.ReportViewer rv_all;
        private System.Windows.Forms.BindingSource PaymentBindingSource;
        private PaymentDataset PaymentDataset;
        private PaymentDatasetTableAdapters.PaymentTableAdapter PaymentTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer rv_relcourse;
        private System.Windows.Forms.BindingSource PaymentrelBindingSource;
        private RelavantCoursePayments RelavantCoursePayments;
        private RelavantCoursePaymentsTableAdapters.PaymentrelTableAdapter PaymentrelTableAdapter;
    }
}