
namespace Dreamron_College
{
    partial class CalculateSalary
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.month_end_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_id_selector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_epf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_allowance = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_etf = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_basic_sal = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_type_selector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_cal = new Guna.UI2.WinForms.Guna2Button();
            this.txt_ref_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.month_start_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_net_sal = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // month_end_date
            // 
            this.month_end_date.Animated = true;
            this.month_end_date.Checked = true;
            this.month_end_date.FillColor = System.Drawing.Color.White;
            this.month_end_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.month_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.month_end_date.Location = new System.Drawing.Point(33, 301);
            this.month_end_date.Margin = new System.Windows.Forms.Padding(4);
            this.month_end_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.month_end_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.month_end_date.Name = "month_end_date";
            this.month_end_date.Size = new System.Drawing.Size(288, 44);
            this.month_end_date.TabIndex = 177;
            this.month_end_date.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(33, 270);
            this.guna2HtmlLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(98, 19);
            this.guna2HtmlLabel5.TabIndex = 176;
            this.guna2HtmlLabel5.Text = "Month End Date";
            // 
            // cmb_id_selector
            // 
            this.cmb_id_selector.BackColor = System.Drawing.Color.Transparent;
            this.cmb_id_selector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_id_selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_id_selector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_id_selector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_id_selector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_id_selector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_id_selector.ItemHeight = 30;
            this.cmb_id_selector.Location = new System.Drawing.Point(469, 209);
            this.cmb_id_selector.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_id_selector.Name = "cmb_id_selector";
            this.cmb_id_selector.Size = new System.Drawing.Size(325, 36);
            this.cmb_id_selector.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_id_selector.TabIndex = 175;
            this.cmb_id_selector.SelectedIndexChanged += new System.EventHandler(this.cmb_id_selector_SelectedIndexChanged_1);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(469, 170);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(53, 19);
            this.guna2HtmlLabel3.TabIndex = 174;
            this.guna2HtmlLabel3.Text = "Select ID";
            // 
            // txt_epf
            // 
            this.txt_epf.Animated = true;
            this.txt_epf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_epf.DefaultText = "";
            this.txt_epf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_epf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_epf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_epf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_epf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_epf.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_epf.ForeColor = System.Drawing.Color.DimGray;
            this.txt_epf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_epf.Location = new System.Drawing.Point(33, 473);
            this.txt_epf.Margin = new System.Windows.Forms.Padding(7);
            this.txt_epf.Name = "txt_epf";
            this.txt_epf.PasswordChar = '\0';
            this.txt_epf.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_epf.PlaceholderText = "EPF";
            this.txt_epf.ReadOnly = true;
            this.txt_epf.SelectedText = "";
            this.txt_epf.Size = new System.Drawing.Size(288, 44);
            this.txt_epf.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_epf.TabIndex = 173;
            // 
            // txt_allowance
            // 
            this.txt_allowance.Animated = true;
            this.txt_allowance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_allowance.DefaultText = "";
            this.txt_allowance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_allowance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_allowance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_allowance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_allowance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_allowance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_allowance.ForeColor = System.Drawing.Color.DimGray;
            this.txt_allowance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_allowance.Location = new System.Drawing.Point(469, 378);
            this.txt_allowance.Margin = new System.Windows.Forms.Padding(7);
            this.txt_allowance.Name = "txt_allowance";
            this.txt_allowance.PasswordChar = '\0';
            this.txt_allowance.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_allowance.PlaceholderText = "Allowance";
            this.txt_allowance.ReadOnly = true;
            this.txt_allowance.SelectedText = "";
            this.txt_allowance.Size = new System.Drawing.Size(325, 44);
            this.txt_allowance.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_allowance.TabIndex = 172;
            // 
            // txt_etf
            // 
            this.txt_etf.Animated = true;
            this.txt_etf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_etf.DefaultText = "";
            this.txt_etf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_etf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_etf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_etf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_etf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_etf.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_etf.ForeColor = System.Drawing.Color.DimGray;
            this.txt_etf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_etf.Location = new System.Drawing.Point(469, 473);
            this.txt_etf.Margin = new System.Windows.Forms.Padding(7);
            this.txt_etf.Name = "txt_etf";
            this.txt_etf.PasswordChar = '\0';
            this.txt_etf.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_etf.PlaceholderText = "ETF";
            this.txt_etf.ReadOnly = true;
            this.txt_etf.SelectedText = "";
            this.txt_etf.Size = new System.Drawing.Size(288, 44);
            this.txt_etf.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_etf.TabIndex = 171;
            // 
            // txt_basic_sal
            // 
            this.txt_basic_sal.Animated = true;
            this.txt_basic_sal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_basic_sal.DefaultText = "";
            this.txt_basic_sal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_basic_sal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_basic_sal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_basic_sal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_basic_sal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_basic_sal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_basic_sal.ForeColor = System.Drawing.Color.DimGray;
            this.txt_basic_sal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_basic_sal.Location = new System.Drawing.Point(469, 301);
            this.txt_basic_sal.Margin = new System.Windows.Forms.Padding(7);
            this.txt_basic_sal.Name = "txt_basic_sal";
            this.txt_basic_sal.PasswordChar = '\0';
            this.txt_basic_sal.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_basic_sal.PlaceholderText = "Basic Salary";
            this.txt_basic_sal.ReadOnly = true;
            this.txt_basic_sal.SelectedText = "";
            this.txt_basic_sal.Size = new System.Drawing.Size(325, 44);
            this.txt_basic_sal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_basic_sal.TabIndex = 170;
            // 
            // cmb_type_selector
            // 
            this.cmb_type_selector.BackColor = System.Drawing.Color.Transparent;
            this.cmb_type_selector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_type_selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type_selector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_type_selector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_type_selector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_type_selector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_type_selector.ItemHeight = 30;
            this.cmb_type_selector.Items.AddRange(new object[] {
            "ADMIN",
            "STAFF",
            "MANAGER",
            "LECTURER"});
            this.cmb_type_selector.Location = new System.Drawing.Point(469, 106);
            this.cmb_type_selector.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_type_selector.Name = "cmb_type_selector";
            this.cmb_type_selector.Size = new System.Drawing.Size(325, 36);
            this.cmb_type_selector.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_type_selector.TabIndex = 169;
            this.cmb_type_selector.SelectedIndexChanged += new System.EventHandler(this.cmb_type_selector_SelectedIndexChanged_1);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(469, 81);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(80, 19);
            this.guna2HtmlLabel2.TabIndex = 168;
            this.guna2HtmlLabel2.Text = "Select a Type";
            // 
            // btn_cal
            // 
            this.btn_cal.Animated = true;
            this.btn_cal.AutoRoundedCorners = true;
            this.btn_cal.BorderRadius = 19;
            this.btn_cal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cal.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_cal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cal.ForeColor = System.Drawing.Color.White;
            this.btn_cal.Location = new System.Drawing.Point(716, 628);
            this.btn_cal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(176, 41);
            this.btn_cal.TabIndex = 167;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click_1);
            // 
            // txt_ref_id
            // 
            this.txt_ref_id.Animated = true;
            this.txt_ref_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ref_id.DefaultText = "";
            this.txt_ref_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ref_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ref_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ref_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ref_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ref_id.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_ref_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ref_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ref_id.Location = new System.Drawing.Point(33, 96);
            this.txt_ref_id.Margin = new System.Windows.Forms.Padding(7);
            this.txt_ref_id.Name = "txt_ref_id";
            this.txt_ref_id.PasswordChar = '\0';
            this.txt_ref_id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_ref_id.PlaceholderText = "Refference No";
            this.txt_ref_id.SelectedText = "";
            this.txt_ref_id.Size = new System.Drawing.Size(288, 44);
            this.txt_ref_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_ref_id.TabIndex = 166;
            // 
            // month_start_date
            // 
            this.month_start_date.Animated = true;
            this.month_start_date.Checked = true;
            this.month_start_date.FillColor = System.Drawing.Color.White;
            this.month_start_date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.month_start_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.month_start_date.Location = new System.Drawing.Point(33, 201);
            this.month_start_date.Margin = new System.Windows.Forms.Padding(4);
            this.month_start_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.month_start_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.month_start_date.Name = "month_start_date";
            this.month_start_date.Size = new System.Drawing.Size(288, 44);
            this.month_start_date.TabIndex = 165;
            this.month_start_date.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(33, 170);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(103, 19);
            this.guna2HtmlLabel4.TabIndex = 164;
            this.guna2HtmlLabel4.Text = "Month Start Date";
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BorderRadius = 19;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.Gray;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(492, 628);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(176, 41);
            this.btn_clear.TabIndex = 163;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click_1);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(33, 14);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(232, 34);
            this.guna2HtmlLabel1.TabIndex = 162;
            this.guna2HtmlLabel1.Text = "CALCULATE SALARY";
            // 
            // txt_net_sal
            // 
            this.txt_net_sal.Animated = true;
            this.txt_net_sal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_net_sal.DefaultText = "";
            this.txt_net_sal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_net_sal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_net_sal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_net_sal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_net_sal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_net_sal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_net_sal.ForeColor = System.Drawing.Color.DimGray;
            this.txt_net_sal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_net_sal.Location = new System.Drawing.Point(33, 378);
            this.txt_net_sal.Margin = new System.Windows.Forms.Padding(7);
            this.txt_net_sal.Name = "txt_net_sal";
            this.txt_net_sal.PasswordChar = '\0';
            this.txt_net_sal.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_net_sal.PlaceholderText = "Net Salary";
            this.txt_net_sal.ReadOnly = true;
            this.txt_net_sal.SelectedText = "";
            this.txt_net_sal.Size = new System.Drawing.Size(289, 44);
            this.txt_net_sal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_net_sal.TabIndex = 161;
            // 
            // CalculateSalary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.month_end_date);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.cmb_id_selector);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.txt_epf);
            this.Controls.Add(this.txt_allowance);
            this.Controls.Add(this.txt_etf);
            this.Controls.Add(this.txt_basic_sal);
            this.Controls.Add(this.cmb_type_selector);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.txt_ref_id);
            this.Controls.Add(this.month_start_date);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_net_sal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculateSalary";
            this.Text = "CalculateSalary";
            this.Load += new System.EventHandler(this.CalculateSalary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DateTimePicker month_end_date;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_id_selector;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txt_epf;
        private Guna.UI2.WinForms.Guna2TextBox txt_allowance;
        private Guna.UI2.WinForms.Guna2TextBox txt_etf;
        private Guna.UI2.WinForms.Guna2TextBox txt_basic_sal;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_type_selector;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btn_cal;
        private Guna.UI2.WinForms.Guna2TextBox txt_ref_id;
        private Guna.UI2.WinForms.Guna2DateTimePicker month_start_date;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_net_sal;
    }
}