
namespace Dreamron_College
{
    partial class MonthlyCoursePaymentReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PaymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursepaymentdataset = new Dreamron_College.coursepaymentdataset();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_generate = new Guna.UI2.WinForms.Guna2Button();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.dt_lastday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dt_firstday = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rv_coursepayment = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PaymentTableAdapter = new Dreamron_College.coursepaymentdatasetTableAdapters.PaymentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursepaymentdataset)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentBindingSource
            // 
            this.PaymentBindingSource.DataMember = "Payment";
            this.PaymentBindingSource.DataSource = this.coursepaymentdataset;
            // 
            // coursepaymentdataset
            // 
            this.coursepaymentdataset.DataSetName = "coursepaymentdataset";
            this.coursepaymentdataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.btn_generate.Location = new System.Drawing.Point(551, 103);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(134, 35);
            this.btn_generate.TabIndex = 204;
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
            this.btn_clear.Location = new System.Drawing.Point(708, 103);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(134, 35);
            this.btn_clear.TabIndex = 203;
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
            this.dt_lastday.Location = new System.Drawing.Point(280, 94);
            this.dt_lastday.Margin = new System.Windows.Forms.Padding(4);
            this.dt_lastday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_lastday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_lastday.Name = "dt_lastday";
            this.dt_lastday.Size = new System.Drawing.Size(243, 44);
            this.dt_lastday.TabIndex = 202;
            this.dt_lastday.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(280, 64);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(199, 23);
            this.guna2HtmlLabel1.TabIndex = 201;
            this.guna2HtmlLabel1.Text = "Select Last day of the Month";
            // 
            // dt_firstday
            // 
            this.dt_firstday.Animated = true;
            this.dt_firstday.Checked = true;
            this.dt_firstday.FillColor = System.Drawing.Color.White;
            this.dt_firstday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dt_firstday.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dt_firstday.Location = new System.Drawing.Point(13, 94);
            this.dt_firstday.Margin = new System.Windows.Forms.Padding(4);
            this.dt_firstday.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dt_firstday.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dt_firstday.Name = "dt_firstday";
            this.dt_firstday.Size = new System.Drawing.Size(243, 44);
            this.dt_firstday.TabIndex = 200;
            this.dt_firstday.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(13, 64);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(201, 23);
            this.guna2HtmlLabel4.TabIndex = 199;
            this.guna2HtmlLabel4.Text = "Select First day of the Month";
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
            this.viewheaderlabel.Size = new System.Drawing.Size(395, 43);
            this.viewheaderlabel.TabIndex = 198;
            this.viewheaderlabel.Text = "COURSE PAYMENT REPORT\r\n\r\n";
            // 
            // rv_coursepayment
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.PaymentBindingSource;
            this.rv_coursepayment.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_coursepayment.LocalReport.ReportEmbeddedResource = "Dreamron_College.CoursePaymentReportLayout.rdlc";
            this.rv_coursepayment.Location = new System.Drawing.Point(13, 159);
            this.rv_coursepayment.Name = "rv_coursepayment";
            this.rv_coursepayment.ServerReport.BearerToken = null;
            this.rv_coursepayment.Size = new System.Drawing.Size(889, 512);
            this.rv_coursepayment.TabIndex = 210;
            // 
            // PaymentTableAdapter
            // 
            this.PaymentTableAdapter.ClearBeforeFill = true;
            // 
            // MonthlyCoursePaymentReport
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.rv_coursepayment);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.dt_lastday);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dt_firstday);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyCoursePaymentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MonthlyCoursePaymentReport";
            this.Load += new System.EventHandler(this.MonthlyCoursePaymentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PaymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursepaymentdataset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_generate;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_lastday;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dt_firstday;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private Microsoft.Reporting.WinForms.ReportViewer rv_coursepayment;
        private System.Windows.Forms.BindingSource PaymentBindingSource;
        private coursepaymentdataset coursepaymentdataset;
        private coursepaymentdatasetTableAdapters.PaymentTableAdapter PaymentTableAdapter;
    }
}