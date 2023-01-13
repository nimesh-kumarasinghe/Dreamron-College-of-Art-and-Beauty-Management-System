
namespace Dreamron_College
{
    partial class ViewLecturer
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
            this.txt_nic = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.Datagrid_view_lecturer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_lecturer_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.datasetForAllRep = new Dreamron_College.DatasetForAllRep();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerTableAdapter = new Dreamron_College.DatasetForAllRepTableAdapters.LecturerTableAdapter();
            this.lIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lSurenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIniNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lBasicSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view_lecturer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetForAllRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
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
            this.btn_all_data.TabIndex = 126;
            this.btn_all_data.Text = "Get All Details";
            this.btn_all_data.Click += new System.EventHandler(this.btn_all_data_Click);
            // 
            // txt_nic
            // 
            this.txt_nic.Animated = true;
            this.txt_nic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nic.DefaultText = "";
            this.txt_nic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nic.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_nic.ForeColor = System.Drawing.Color.DimGray;
            this.txt_nic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nic.Location = new System.Drawing.Point(354, 85);
            this.txt_nic.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nic.Name = "txt_nic";
            this.txt_nic.PasswordChar = '\0';
            this.txt_nic.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_nic.PlaceholderText = "Type NIC ";
            this.txt_nic.SelectedText = "";
            this.txt_nic.Size = new System.Drawing.Size(301, 54);
            this.txt_nic.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_nic.TabIndex = 125;
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
            this.btn_clear.TabIndex = 124;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Datagrid_view_lecturer
            // 
            this.Datagrid_view_lecturer.AllowUserToAddRows = false;
            this.Datagrid_view_lecturer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_lecturer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Datagrid_view_lecturer.AutoGenerateColumns = false;
            this.Datagrid_view_lecturer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Datagrid_view_lecturer.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid_view_lecturer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid_view_lecturer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view_lecturer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_view_lecturer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.Datagrid_view_lecturer.ColumnHeadersHeight = 27;
            this.Datagrid_view_lecturer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lIDDataGridViewTextBoxColumn,
            this.lFirstNameDataGridViewTextBoxColumn,
            this.lLastNameDataGridViewTextBoxColumn,
            this.lSurenameDataGridViewTextBoxColumn,
            this.lIniNameDataGridViewTextBoxColumn,
            this.lNICDataGridViewTextBoxColumn,
            this.lGenderDataGridViewTextBoxColumn,
            this.lDOBDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.lMobileDataGridViewTextBoxColumn,
            this.lEmailDataGridViewTextBoxColumn,
            this.lBasicSalaryDataGridViewTextBoxColumn,
            this.ePFDataGridViewTextBoxColumn,
            this.eTFDataGridViewTextBoxColumn});
            this.Datagrid_view_lecturer.DataSource = this.lecturerBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid_view_lecturer.DefaultCellStyle = dataGridViewCellStyle9;
            this.Datagrid_view_lecturer.EnableHeadersVisualStyles = false;
            this.Datagrid_view_lecturer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_lecturer.Location = new System.Drawing.Point(31, 163);
            this.Datagrid_view_lecturer.Name = "Datagrid_view_lecturer";
            this.Datagrid_view_lecturer.ReadOnly = true;
            this.Datagrid_view_lecturer.RowHeadersVisible = false;
            this.Datagrid_view_lecturer.RowHeadersWidth = 51;
            this.Datagrid_view_lecturer.RowTemplate.Height = 24;
            this.Datagrid_view_lecturer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_view_lecturer.Size = new System.Drawing.Size(863, 499);
            this.Datagrid_view_lecturer.TabIndex = 123;
            this.Datagrid_view_lecturer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_lecturer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Datagrid_view_lecturer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view_lecturer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Datagrid_view_lecturer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view_lecturer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_lecturer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_lecturer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Datagrid_view_lecturer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Datagrid_view_lecturer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view_lecturer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Datagrid_view_lecturer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Datagrid_view_lecturer.ThemeStyle.HeaderStyle.Height = 27;
            this.Datagrid_view_lecturer.ThemeStyle.ReadOnly = true;
            this.Datagrid_view_lecturer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_lecturer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view_lecturer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view_lecturer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Datagrid_view_lecturer.ThemeStyle.RowsStyle.Height = 24;
            this.Datagrid_view_lecturer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_lecturer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btn_search.TabIndex = 122;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_lecturer_id
            // 
            this.txt_lecturer_id.Animated = true;
            this.txt_lecturer_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lecturer_id.DefaultText = "";
            this.txt_lecturer_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_lecturer_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_lecturer_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lecturer_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lecturer_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lecturer_id.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_lecturer_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_lecturer_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lecturer_id.Location = new System.Drawing.Point(31, 85);
            this.txt_lecturer_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lecturer_id.Name = "txt_lecturer_id";
            this.txt_lecturer_id.PasswordChar = '\0';
            this.txt_lecturer_id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_lecturer_id.PlaceholderText = "Type Lecturer ID ";
            this.txt_lecturer_id.SelectedText = "";
            this.txt_lecturer_id.Size = new System.Drawing.Size(301, 54);
            this.txt_lecturer_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_lecturer_id.TabIndex = 121;
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
            this.viewheaderlabel.Size = new System.Drawing.Size(233, 43);
            this.viewheaderlabel.TabIndex = 120;
            this.viewheaderlabel.Text = "VIEW LECTURER";
            // 
            // datasetForAllRep
            // 
            this.datasetForAllRep.DataSetName = "DatasetForAllRep";
            this.datasetForAllRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.datasetForAllRep;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // lIDDataGridViewTextBoxColumn
            // 
            this.lIDDataGridViewTextBoxColumn.DataPropertyName = "LID";
            this.lIDDataGridViewTextBoxColumn.HeaderText = "LID";
            this.lIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lIDDataGridViewTextBoxColumn.Name = "lIDDataGridViewTextBoxColumn";
            this.lIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.lIDDataGridViewTextBoxColumn.Width = 65;
            // 
            // lFirstNameDataGridViewTextBoxColumn
            // 
            this.lFirstNameDataGridViewTextBoxColumn.DataPropertyName = "LFirstName";
            this.lFirstNameDataGridViewTextBoxColumn.HeaderText = "LFirstName";
            this.lFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lFirstNameDataGridViewTextBoxColumn.Name = "lFirstNameDataGridViewTextBoxColumn";
            this.lFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lFirstNameDataGridViewTextBoxColumn.Width = 127;
            // 
            // lLastNameDataGridViewTextBoxColumn
            // 
            this.lLastNameDataGridViewTextBoxColumn.DataPropertyName = "LLastName";
            this.lLastNameDataGridViewTextBoxColumn.HeaderText = "LLastName";
            this.lLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lLastNameDataGridViewTextBoxColumn.Name = "lLastNameDataGridViewTextBoxColumn";
            this.lLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lLastNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lSurenameDataGridViewTextBoxColumn
            // 
            this.lSurenameDataGridViewTextBoxColumn.DataPropertyName = "LSurename";
            this.lSurenameDataGridViewTextBoxColumn.HeaderText = "LSurename";
            this.lSurenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lSurenameDataGridViewTextBoxColumn.Name = "lSurenameDataGridViewTextBoxColumn";
            this.lSurenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lSurenameDataGridViewTextBoxColumn.Width = 126;
            // 
            // lIniNameDataGridViewTextBoxColumn
            // 
            this.lIniNameDataGridViewTextBoxColumn.DataPropertyName = "LIniName";
            this.lIniNameDataGridViewTextBoxColumn.HeaderText = "LIniName";
            this.lIniNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lIniNameDataGridViewTextBoxColumn.Name = "lIniNameDataGridViewTextBoxColumn";
            this.lIniNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lIniNameDataGridViewTextBoxColumn.Width = 113;
            // 
            // lNICDataGridViewTextBoxColumn
            // 
            this.lNICDataGridViewTextBoxColumn.DataPropertyName = "LNIC";
            this.lNICDataGridViewTextBoxColumn.HeaderText = "LNIC";
            this.lNICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lNICDataGridViewTextBoxColumn.Name = "lNICDataGridViewTextBoxColumn";
            this.lNICDataGridViewTextBoxColumn.ReadOnly = true;
            this.lNICDataGridViewTextBoxColumn.Width = 76;
            // 
            // lGenderDataGridViewTextBoxColumn
            // 
            this.lGenderDataGridViewTextBoxColumn.DataPropertyName = "LGender";
            this.lGenderDataGridViewTextBoxColumn.HeaderText = "LGender";
            this.lGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lGenderDataGridViewTextBoxColumn.Name = "lGenderDataGridViewTextBoxColumn";
            this.lGenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.lGenderDataGridViewTextBoxColumn.Width = 103;
            // 
            // lDOBDataGridViewTextBoxColumn
            // 
            this.lDOBDataGridViewTextBoxColumn.DataPropertyName = "LDOB";
            this.lDOBDataGridViewTextBoxColumn.HeaderText = "LDOB";
            this.lDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lDOBDataGridViewTextBoxColumn.Name = "lDOBDataGridViewTextBoxColumn";
            this.lDOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.lDOBDataGridViewTextBoxColumn.Width = 84;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            this.noDataGridViewTextBoxColumn.HeaderText = "No";
            this.noDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Width = 63;
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            this.streetDataGridViewTextBoxColumn.ReadOnly = true;
            this.streetDataGridViewTextBoxColumn.Width = 84;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 69;
            // 
            // lMobileDataGridViewTextBoxColumn
            // 
            this.lMobileDataGridViewTextBoxColumn.DataPropertyName = "LMobile";
            this.lMobileDataGridViewTextBoxColumn.HeaderText = "LMobile";
            this.lMobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lMobileDataGridViewTextBoxColumn.Name = "lMobileDataGridViewTextBoxColumn";
            this.lMobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.lMobileDataGridViewTextBoxColumn.Width = 102;
            // 
            // lEmailDataGridViewTextBoxColumn
            // 
            this.lEmailDataGridViewTextBoxColumn.DataPropertyName = "LEmail";
            this.lEmailDataGridViewTextBoxColumn.HeaderText = "LEmail";
            this.lEmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lEmailDataGridViewTextBoxColumn.Name = "lEmailDataGridViewTextBoxColumn";
            this.lEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.lEmailDataGridViewTextBoxColumn.Width = 89;
            // 
            // lBasicSalaryDataGridViewTextBoxColumn
            // 
            this.lBasicSalaryDataGridViewTextBoxColumn.DataPropertyName = "LBasicSalary";
            this.lBasicSalaryDataGridViewTextBoxColumn.HeaderText = "LBasicSalary";
            this.lBasicSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lBasicSalaryDataGridViewTextBoxColumn.Name = "lBasicSalaryDataGridViewTextBoxColumn";
            this.lBasicSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.lBasicSalaryDataGridViewTextBoxColumn.Width = 133;
            // 
            // ePFDataGridViewTextBoxColumn
            // 
            this.ePFDataGridViewTextBoxColumn.DataPropertyName = "EPF";
            this.ePFDataGridViewTextBoxColumn.HeaderText = "EPF";
            this.ePFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ePFDataGridViewTextBoxColumn.Name = "ePFDataGridViewTextBoxColumn";
            this.ePFDataGridViewTextBoxColumn.ReadOnly = true;
            this.ePFDataGridViewTextBoxColumn.Width = 67;
            // 
            // eTFDataGridViewTextBoxColumn
            // 
            this.eTFDataGridViewTextBoxColumn.DataPropertyName = "ETF";
            this.eTFDataGridViewTextBoxColumn.HeaderText = "ETF";
            this.eTFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eTFDataGridViewTextBoxColumn.Name = "eTFDataGridViewTextBoxColumn";
            this.eTFDataGridViewTextBoxColumn.ReadOnly = true;
            this.eTFDataGridViewTextBoxColumn.Width = 66;
            // 
            // ViewLecturer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.btn_all_data);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.Datagrid_view_lecturer);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_lecturer_id);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewLecturer";
            this.Text = "ViewLecturer";
            this.Load += new System.EventHandler(this.ViewLecturer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view_lecturer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetForAllRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_all_data;
        private Guna.UI2.WinForms.Guna2TextBox txt_nic;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2DataGridView Datagrid_view_lecturer;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_lecturer_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private DatasetForAllRep datasetForAllRep;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private DatasetForAllRepTableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lSurenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIniNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lBasicSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTFDataGridViewTextBoxColumn;
    }
}