namespace Dreamron_College
{
    partial class AddStudentAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2BorderlessForm2 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.table_view = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.in_time = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.out_time = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.addStudentAttendanceClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_course_selector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.date_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmb_batch_selector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add = new Guna.UI2.WinForms.Guna2Button();
            this.addEmployeeAttendaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.table_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentAttendanceClassBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeeAttendaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2BorderlessForm2
            // 
            this.guna2BorderlessForm2.ContainerControl = this;
            this.guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm2.TransparentWhileDrag = true;
            // 
            // table_view
            // 
            this.table_view.AllowUserToAddRows = false;
            this.table_view.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.table_view.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.table_view.AutoGenerateColumns = false;
            this.table_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_view.BackgroundColor = System.Drawing.Color.White;
            this.table_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_view.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_view.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_view.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.table_view.ColumnHeadersHeight = 25;
            this.table_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.inameDataGridViewTextBoxColumn,
            this.in_time,
            this.out_time,
            this.status});
            this.table_view.DataSource = this.addStudentAttendanceClassBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_view.DefaultCellStyle = dataGridViewCellStyle3;
            this.table_view.EnableHeadersVisualStyles = false;
            this.table_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_view.Location = new System.Drawing.Point(16, 162);
            this.table_view.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.table_view.Name = "table_view";
            this.table_view.RowHeadersVisible = false;
            this.table_view.RowHeadersWidth = 51;
            this.table_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.table_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_view.Size = new System.Drawing.Size(896, 508);
            this.table_view.TabIndex = 138;
            this.table_view.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.table_view.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.table_view.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.table_view.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.table_view.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.table_view.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.table_view.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_view.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.table_view.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.table_view.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table_view.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.table_view.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.table_view.ThemeStyle.HeaderStyle.Height = 25;
            this.table_view.ThemeStyle.ReadOnly = false;
            this.table_view.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.table_view.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_view.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.table_view.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.table_view.ThemeStyle.RowsStyle.Height = 22;
            this.table_view.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.table_view.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // inameDataGridViewTextBoxColumn
            // 
            this.inameDataGridViewTextBoxColumn.DataPropertyName = "i_name";
            this.inameDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.inameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inameDataGridViewTextBoxColumn.Name = "inameDataGridViewTextBoxColumn";
            // 
            // in_time
            // 
            this.in_time.HeaderText = "In Time";
            this.in_time.Items.AddRange(new object[] {
            "8:30 AM",
            "12:30 PM"});
            this.in_time.MinimumWidth = 6;
            this.in_time.Name = "in_time";
            // 
            // out_time
            // 
            this.out_time.HeaderText = "Out Time";
            this.out_time.Items.AddRange(new object[] {
            "12:30 PM",
            "4:30 PM"});
            this.out_time.MinimumWidth = 6;
            this.out_time.Name = "out_time";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Items.AddRange(new object[] {
            "Present",
            "Absent"});
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            // 
            // addStudentAttendanceClassBindingSource
            // 
            this.addStudentAttendanceClassBindingSource.DataSource = typeof(Dreamron_College.AddStudentAttendanceClass);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(17, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(420, 43);
            this.guna2HtmlLabel1.TabIndex = 135;
            this.guna2HtmlLabel1.Text = "ADD STUDENT ATTENDANCE";
            // 
            // cmb_course_selector
            // 
            this.cmb_course_selector.BackColor = System.Drawing.Color.Transparent;
            this.cmb_course_selector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_course_selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_course_selector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_course_selector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_course_selector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_course_selector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_course_selector.ItemHeight = 30;
            this.cmb_course_selector.Location = new System.Drawing.Point(183, 95);
            this.cmb_course_selector.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmb_course_selector.Name = "cmb_course_selector";
            this.cmb_course_selector.Size = new System.Drawing.Size(128, 36);
            this.cmb_course_selector.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_course_selector.TabIndex = 143;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(183, 62);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(109, 23);
            this.guna2HtmlLabel2.TabIndex = 142;
            this.guna2HtmlLabel2.Text = "Select a Course";
            // 
            // btn_delete
            // 
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(794, 110);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(83, 29);
            this.btn_delete.TabIndex = 141;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // date_picker
            // 
            this.date_picker.Animated = true;
            this.date_picker.Checked = true;
            this.date_picker.FillColor = System.Drawing.Color.White;
            this.date_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.date_picker.Location = new System.Drawing.Point(348, 96);
            this.date_picker.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.date_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_picker.Name = "date_picker";
            this.date_picker.Size = new System.Drawing.Size(269, 43);
            this.date_picker.TabIndex = 140;
            this.date_picker.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            this.date_picker.ValueChanged += new System.EventHandler(this.date_picker_ValueChanged);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(348, 62);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(35, 23);
            this.guna2HtmlLabel4.TabIndex = 139;
            this.guna2HtmlLabel4.Text = "Date";
            // 
            // cmb_batch_selector
            // 
            this.cmb_batch_selector.BackColor = System.Drawing.Color.Transparent;
            this.cmb_batch_selector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_batch_selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_batch_selector.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_batch_selector.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_batch_selector.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_batch_selector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_batch_selector.ItemHeight = 30;
            this.cmb_batch_selector.Location = new System.Drawing.Point(17, 95);
            this.cmb_batch_selector.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmb_batch_selector.Name = "cmb_batch_selector";
            this.cmb_batch_selector.Size = new System.Drawing.Size(128, 36);
            this.cmb_batch_selector.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_batch_selector.TabIndex = 145;
            this.cmb_batch_selector.SelectedIndexChanged += new System.EventHandler(this.cmb_batch_selector_SelectedIndexChanged);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(17, 62);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(98, 23);
            this.guna2HtmlLabel3.TabIndex = 144;
            this.guna2HtmlLabel3.Text = "Select a Batch";
            // 
            // btn_update
            // 
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(695, 110);
            this.btn_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(91, 29);
            this.btn_update.TabIndex = 146;
            this.btn_update.Text = "UPDATE";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(626, 109);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(61, 29);
            this.btn_add.TabIndex = 147;
            this.btn_add.Text = "ADD";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // addEmployeeAttendaceBindingSource
            // 
            this.addEmployeeAttendaceBindingSource.DataSource = typeof(Dreamron_College.addEmployeeAttendace);
            // 
            // AddStudentAttendance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.cmb_batch_selector);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cmb_course_selector);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.date_picker);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.table_view);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddStudentAttendance";
            this.Text = "AddStudentAttendance";
            this.Load += new System.EventHandler(this.AddStudentAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addStudentAttendanceClassBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addEmployeeAttendaceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView table_view;
        private System.Windows.Forms.BindingSource addEmployeeAttendaceBindingSource;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm2;
        private System.Windows.Forms.BindingSource addStudentAttendanceClassBindingSource;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_course_selector;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_picker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_batch_selector;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn in_time;
        private System.Windows.Forms.DataGridViewComboBoxColumn out_time;
        private System.Windows.Forms.DataGridViewComboBoxColumn status;
        private Guna.UI2.WinForms.Guna2Button btn_add;
        private Guna.UI2.WinForms.Guna2Button btn_update;
    }
}