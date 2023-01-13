namespace Dreamron_College
{
    partial class RequestLeave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestLeave));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.cmb_id_selector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_type_selector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_leave_type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.date_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add_emp = new Guna.UI2.WinForms.Guna2Button();
            this.txt_reason = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.cmb_id_selector.Location = new System.Drawing.Point(17, 201);
            this.cmb_id_selector.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_id_selector.Name = "cmb_id_selector";
            this.cmb_id_selector.Size = new System.Drawing.Size(325, 36);
            this.cmb_id_selector.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_id_selector.TabIndex = 174;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(17, 162);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(53, 19);
            this.guna2HtmlLabel3.TabIndex = 173;
            this.guna2HtmlLabel3.Text = "Select ID";
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
            this.cmb_type_selector.Location = new System.Drawing.Point(17, 90);
            this.cmb_type_selector.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_type_selector.Name = "cmb_type_selector";
            this.cmb_type_selector.Size = new System.Drawing.Size(325, 36);
            this.cmb_type_selector.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_type_selector.TabIndex = 172;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(17, 65);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(80, 19);
            this.guna2HtmlLabel2.TabIndex = 171;
            this.guna2HtmlLabel2.Text = "Select a Type";
            // 
            // cmb_leave_type
            // 
            this.cmb_leave_type.BackColor = System.Drawing.Color.Transparent;
            this.cmb_leave_type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_leave_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_leave_type.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_leave_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_leave_type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_leave_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_leave_type.ItemHeight = 30;
            this.cmb_leave_type.Items.AddRange(new object[] {
            "Casual",
            "Medical",
            "Maternity"});
            this.cmb_leave_type.Location = new System.Drawing.Point(17, 289);
            this.cmb_leave_type.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_leave_type.Name = "cmb_leave_type";
            this.cmb_leave_type.Size = new System.Drawing.Size(203, 36);
            this.cmb_leave_type.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_leave_type.TabIndex = 170;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 256);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(118, 19);
            this.guna2HtmlLabel1.TabIndex = 169;
            this.guna2HtmlLabel1.Text = "Select A Leave Type";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(17, 353);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(5);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(30, 19);
            this.guna2HtmlLabel4.TabIndex = 168;
            this.guna2HtmlLabel4.Text = "Date";
            // 
            // date_picker
            // 
            this.date_picker.Animated = true;
            this.date_picker.Checked = true;
            this.date_picker.FillColor = System.Drawing.Color.White;
            this.date_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_picker.Location = new System.Drawing.Point(17, 387);
            this.date_picker.Margin = new System.Windows.Forms.Padding(5);
            this.date_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(533, 54);
            this.date_picker.TabIndex = 167;
            this.date_picker.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // btn_clear
            // 
            this.btn_clear.Animated = true;
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BorderRadius = 18;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.Gray;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(583, 629);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(149, 39);
            this.btn_clear.TabIndex = 166;
            this.btn_clear.Text = "CLEAR";
            // 
            // btn_add_emp
            // 
            this.btn_add_emp.Animated = true;
            this.btn_add_emp.AutoRoundedCorners = true;
            this.btn_add_emp.BorderRadius = 18;
            this.btn_add_emp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_emp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_emp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_emp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_emp.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_add_emp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_emp.ForeColor = System.Drawing.Color.White;
            this.btn_add_emp.Location = new System.Drawing.Point(758, 629);
            this.btn_add_emp.Margin = new System.Windows.Forms.Padding(5);
            this.btn_add_emp.Name = "btn_add_emp";
            this.btn_add_emp.Size = new System.Drawing.Size(149, 39);
            this.btn_add_emp.TabIndex = 165;
            this.btn_add_emp.Text = "ADD";
            // 
            // txt_reason
            // 
            this.txt_reason.Animated = true;
            this.txt_reason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reason.DefaultText = "";
            this.txt_reason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_reason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_reason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reason.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_reason.ForeColor = System.Drawing.Color.DimGray;
            this.txt_reason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reason.Location = new System.Drawing.Point(17, 480);
            this.txt_reason.Margin = new System.Windows.Forms.Padding(9);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.PasswordChar = '\0';
            this.txt_reason.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_reason.PlaceholderText = "Reason";
            this.txt_reason.SelectedText = "";
            this.txt_reason.Size = new System.Drawing.Size(891, 123);
            this.txt_reason.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_reason.TabIndex = 164;
            // 
            // viewheaderlabel
            // 
            this.viewheaderlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewheaderlabel.BackColor = System.Drawing.Color.Transparent;
            this.viewheaderlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewheaderlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.viewheaderlabel.Location = new System.Drawing.Point(16, 14);
            this.viewheaderlabel.Margin = new System.Windows.Forms.Padding(4);
            this.viewheaderlabel.Name = "viewheaderlabel";
            this.viewheaderlabel.Size = new System.Drawing.Size(185, 34);
            this.viewheaderlabel.TabIndex = 163;
            this.viewheaderlabel.Text = "REQUEST LEAVE";
            // 
            // RequestLeave
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.cmb_id_selector);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cmb_type_selector);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.cmb_leave_type);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add_emp);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RequestLeave";
            this.Text = "RequestLeave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_id_selector;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_type_selector;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_leave_type;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_picker;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_add_emp;
        private Guna.UI2.WinForms.Guna2TextBox txt_reason;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
    }
}