
namespace Dreamron_College
{
    partial class ViewCourse
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_all_data = new Guna.UI2.WinForms.Guna2Button();
            this.txt_coursename = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.Datagrid_view_course = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_couse_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dreamronDBDataSet1 = new Dreamron_College.DreamronDBDataSet1();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Dreamron_College.DreamronDBDataSet1TableAdapters.CourseTableAdapter();
            this.cIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDuratinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view_course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dreamronDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btn_all_data
            // 
            this.btn_all_data.Animated = true;
            this.btn_all_data.AutoRoundedCorners = true;
            this.btn_all_data.BorderRadius = 16;
            this.btn_all_data.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_all_data.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_all_data.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_all_data.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_all_data.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_all_data.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_all_data.ForeColor = System.Drawing.Color.White;
            this.btn_all_data.Location = new System.Drawing.Point(692, 61);
            this.btn_all_data.Margin = new System.Windows.Forms.Padding(4);
            this.btn_all_data.Name = "btn_all_data";
            this.btn_all_data.Size = new System.Drawing.Size(202, 35);
            this.btn_all_data.TabIndex = 133;
            this.btn_all_data.Text = "Get All Details";
            this.btn_all_data.Click += new System.EventHandler(this.btn_all_data_Click);
            // 
            // txt_coursename
            // 
            this.txt_coursename.Animated = true;
            this.txt_coursename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_coursename.DefaultText = "";
            this.txt_coursename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_coursename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_coursename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_coursename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_coursename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_coursename.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_coursename.ForeColor = System.Drawing.Color.DimGray;
            this.txt_coursename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_coursename.Location = new System.Drawing.Point(354, 85);
            this.txt_coursename.Margin = new System.Windows.Forms.Padding(4);
            this.txt_coursename.Name = "txt_coursename";
            this.txt_coursename.PasswordChar = '\0';
            this.txt_coursename.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_coursename.PlaceholderText = "Type Course Name";
            this.txt_coursename.SelectedText = "";
            this.txt_coursename.Size = new System.Drawing.Size(301, 54);
            this.txt_coursename.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_coursename.TabIndex = 132;
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
            this.btn_clear.Location = new System.Drawing.Point(797, 104);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 35);
            this.btn_clear.TabIndex = 131;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Datagrid_view_course
            // 
            this.Datagrid_view_course.AllowUserToAddRows = false;
            this.Datagrid_view_course.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_course.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Datagrid_view_course.AutoGenerateColumns = false;
            this.Datagrid_view_course.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Datagrid_view_course.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid_view_course.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid_view_course.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view_course.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_view_course.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Datagrid_view_course.ColumnHeadersHeight = 27;
            this.Datagrid_view_course.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDataGridViewTextBoxColumn,
            this.cNameDataGridViewTextBoxColumn,
            this.cDuratinDataGridViewTextBoxColumn,
            this.cFeeDataGridViewTextBoxColumn});
            this.Datagrid_view_course.DataSource = this.courseBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid_view_course.DefaultCellStyle = dataGridViewCellStyle9;
            this.Datagrid_view_course.EnableHeadersVisualStyles = false;
            this.Datagrid_view_course.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_course.Location = new System.Drawing.Point(31, 163);
            this.Datagrid_view_course.Name = "Datagrid_view_course";
            this.Datagrid_view_course.ReadOnly = true;
            this.Datagrid_view_course.RowHeadersVisible = false;
            this.Datagrid_view_course.RowHeadersWidth = 51;
            this.Datagrid_view_course.RowTemplate.Height = 24;
            this.Datagrid_view_course.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_view_course.Size = new System.Drawing.Size(863, 499);
            this.Datagrid_view_course.TabIndex = 130;
            this.Datagrid_view_course.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_course.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Datagrid_view_course.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view_course.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Datagrid_view_course.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view_course.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_course.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_course.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Datagrid_view_course.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Datagrid_view_course.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view_course.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Datagrid_view_course.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Datagrid_view_course.ThemeStyle.HeaderStyle.Height = 27;
            this.Datagrid_view_course.ThemeStyle.ReadOnly = true;
            this.Datagrid_view_course.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_course.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view_course.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view_course.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Datagrid_view_course.ThemeStyle.RowsStyle.Height = 24;
            this.Datagrid_view_course.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_course.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btn_search
            // 
            this.btn_search.Animated = true;
            this.btn_search.AutoRoundedCorners = true;
            this.btn_search.BorderRadius = 16;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(692, 104);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 35);
            this.btn_search.TabIndex = 129;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_couse_id
            // 
            this.txt_couse_id.Animated = true;
            this.txt_couse_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_couse_id.DefaultText = "";
            this.txt_couse_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_couse_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_couse_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_couse_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_couse_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_couse_id.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_couse_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_couse_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_couse_id.Location = new System.Drawing.Point(31, 85);
            this.txt_couse_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_couse_id.Name = "txt_couse_id";
            this.txt_couse_id.PasswordChar = '\0';
            this.txt_couse_id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_couse_id.PlaceholderText = "Type Course ID ";
            this.txt_couse_id.SelectedText = "";
            this.txt_couse_id.Size = new System.Drawing.Size(301, 54);
            this.txt_couse_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_couse_id.TabIndex = 128;
            // 
            // viewheaderlabel
            // 
            this.viewheaderlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewheaderlabel.BackColor = System.Drawing.Color.Transparent;
            this.viewheaderlabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewheaderlabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.viewheaderlabel.Location = new System.Drawing.Point(33, 21);
            this.viewheaderlabel.Name = "viewheaderlabel";
            this.viewheaderlabel.Size = new System.Drawing.Size(221, 43);
            this.viewheaderlabel.TabIndex = 127;
            this.viewheaderlabel.Text = "VIEW COURSES";
            // 
            // dreamronDBDataSet1
            // 
            this.dreamronDBDataSet1.DataSetName = "DreamronDBDataSet1";
            this.dreamronDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.dreamronDBDataSet1;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // cIDDataGridViewTextBoxColumn
            // 
            this.cIDDataGridViewTextBoxColumn.DataPropertyName = "CID";
            this.cIDDataGridViewTextBoxColumn.HeaderText = "CID";
            this.cIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cIDDataGridViewTextBoxColumn.Name = "cIDDataGridViewTextBoxColumn";
            this.cIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIDDataGridViewTextBoxColumn.Width = 68;
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "CName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "CName";
            this.cNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cNameDataGridViewTextBoxColumn.Width = 97;
            // 
            // cDuratinDataGridViewTextBoxColumn
            // 
            this.cDuratinDataGridViewTextBoxColumn.DataPropertyName = "CDuratin";
            this.cDuratinDataGridViewTextBoxColumn.HeaderText = "CDuratin";
            this.cDuratinDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cDuratinDataGridViewTextBoxColumn.Name = "cDuratinDataGridViewTextBoxColumn";
            this.cDuratinDataGridViewTextBoxColumn.ReadOnly = true;
            this.cDuratinDataGridViewTextBoxColumn.Width = 108;
            // 
            // cFeeDataGridViewTextBoxColumn
            // 
            this.cFeeDataGridViewTextBoxColumn.DataPropertyName = "CFee";
            this.cFeeDataGridViewTextBoxColumn.HeaderText = "CFee";
            this.cFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cFeeDataGridViewTextBoxColumn.Name = "cFeeDataGridViewTextBoxColumn";
            this.cFeeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cFeeDataGridViewTextBoxColumn.Width = 77;
            // 
            // ViewCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.btn_all_data);
            this.Controls.Add(this.txt_coursename);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.Datagrid_view_course);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_couse_id);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewCourse";
            this.Text = "ViewCourse";
            this.Load += new System.EventHandler(this.ViewCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view_course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dreamronDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_all_data;
        private Guna.UI2.WinForms.Guna2TextBox txt_coursename;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2DataGridView Datagrid_view_course;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_couse_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private DreamronDBDataSet1 dreamronDBDataSet1;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private DreamronDBDataSet1TableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDuratinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFeeDataGridViewTextBoxColumn;
    }
}