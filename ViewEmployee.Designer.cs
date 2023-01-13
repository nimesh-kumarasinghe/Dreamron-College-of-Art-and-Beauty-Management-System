
namespace Dreamron_College
{
    partial class ViewEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.Datagrid_view_emp = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_userID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.datasetForAllRep = new Dreamron_College.DatasetForAllRep();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Dreamron_College.DatasetForAllRepTableAdapters.EmployeeTableAdapter();
            this.empIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSurenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eIniNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNICDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eGenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eBasicSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view_emp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetForAllRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
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
            this.btn_clear.Location = new System.Drawing.Point(797, 104);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(97, 35);
            this.btn_clear.TabIndex = 110;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Datagrid_view_emp
            // 
            this.Datagrid_view_emp.AllowUserToAddRows = false;
            this.Datagrid_view_emp.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_emp.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Datagrid_view_emp.AutoGenerateColumns = false;
            this.Datagrid_view_emp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Datagrid_view_emp.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid_view_emp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid_view_emp.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view_emp.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_view_emp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Datagrid_view_emp.ColumnHeadersHeight = 27;
            this.Datagrid_view_emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empIDDataGridViewTextBoxColumn,
            this.eTypeDataGridViewTextBoxColumn,
            this.eFirstNameDataGridViewTextBoxColumn,
            this.eLastNameDataGridViewTextBoxColumn,
            this.eSurenameDataGridViewTextBoxColumn,
            this.eIniNameDataGridViewTextBoxColumn,
            this.eNICDataGridViewTextBoxColumn,
            this.eGenderDataGridViewTextBoxColumn,
            this.eDOBDataGridViewTextBoxColumn,
            this.noDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.eMobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.eBasicSalaryDataGridViewTextBoxColumn,
            this.allowanceDataGridViewTextBoxColumn,
            this.ePFDataGridViewTextBoxColumn,
            this.eTFDataGridViewTextBoxColumn});
            this.Datagrid_view_emp.DataSource = this.employeeBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid_view_emp.DefaultCellStyle = dataGridViewCellStyle6;
            this.Datagrid_view_emp.EnableHeadersVisualStyles = false;
            this.Datagrid_view_emp.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_emp.Location = new System.Drawing.Point(31, 163);
            this.Datagrid_view_emp.Name = "Datagrid_view_emp";
            this.Datagrid_view_emp.ReadOnly = true;
            this.Datagrid_view_emp.RowHeadersVisible = false;
            this.Datagrid_view_emp.RowHeadersWidth = 51;
            this.Datagrid_view_emp.RowTemplate.Height = 24;
            this.Datagrid_view_emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_view_emp.Size = new System.Drawing.Size(863, 499);
            this.Datagrid_view_emp.TabIndex = 109;
            this.Datagrid_view_emp.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_emp.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Datagrid_view_emp.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view_emp.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Datagrid_view_emp.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view_emp.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_emp.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_emp.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Datagrid_view_emp.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Datagrid_view_emp.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view_emp.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Datagrid_view_emp.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Datagrid_view_emp.ThemeStyle.HeaderStyle.Height = 27;
            this.Datagrid_view_emp.ThemeStyle.ReadOnly = true;
            this.Datagrid_view_emp.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_emp.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view_emp.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view_emp.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Datagrid_view_emp.ThemeStyle.RowsStyle.Height = 24;
            this.Datagrid_view_emp.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_emp.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btn_search.TabIndex = 108;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_userID
            // 
            this.txt_userID.Animated = true;
            this.txt_userID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_userID.DefaultText = "";
            this.txt_userID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_userID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_userID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_userID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userID.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_userID.ForeColor = System.Drawing.Color.DimGray;
            this.txt_userID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_userID.Location = new System.Drawing.Point(230, 86);
            this.txt_userID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_userID.Name = "txt_userID";
            this.txt_userID.PasswordChar = '\0';
            this.txt_userID.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_userID.PlaceholderText = "Type Employee ID ";
            this.txt_userID.SelectedText = "";
            this.txt_userID.Size = new System.Drawing.Size(301, 54);
            this.txt_userID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_userID.TabIndex = 107;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(33, 73);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(89, 25);
            this.guna2HtmlLabel3.TabIndex = 106;
            this.guna2HtmlLabel3.Text = "Select Type     \r\n";
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
            this.viewheaderlabel.Size = new System.Drawing.Size(238, 43);
            this.viewheaderlabel.TabIndex = 105;
            this.viewheaderlabel.Text = "VIEW EMPLOYEE\r\n";
            // 
            // cmbtype
            // 
            this.cmbtype.BackColor = System.Drawing.Color.Transparent;
            this.cmbtype.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.cmbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbtype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbtype.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbtype.ForeColor = System.Drawing.Color.DimGray;
            this.cmbtype.ItemHeight = 30;
            this.cmbtype.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Manager",
            "Show All"});
            this.cmbtype.Location = new System.Drawing.Point(33, 104);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(181, 36);
            this.cmbtype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbtype.TabIndex = 104;
            // 
            // datasetForAllRep
            // 
            this.datasetForAllRep.DataSetName = "DatasetForAllRep";
            this.datasetForAllRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.datasetForAllRep;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // empIDDataGridViewTextBoxColumn
            // 
            this.empIDDataGridViewTextBoxColumn.DataPropertyName = "EmpID";
            this.empIDDataGridViewTextBoxColumn.HeaderText = "EmpID";
            this.empIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empIDDataGridViewTextBoxColumn.Name = "empIDDataGridViewTextBoxColumn";
            this.empIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.empIDDataGridViewTextBoxColumn.Width = 93;
            // 
            // eTypeDataGridViewTextBoxColumn
            // 
            this.eTypeDataGridViewTextBoxColumn.DataPropertyName = "EType";
            this.eTypeDataGridViewTextBoxColumn.HeaderText = "EType";
            this.eTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eTypeDataGridViewTextBoxColumn.Name = "eTypeDataGridViewTextBoxColumn";
            this.eTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.eTypeDataGridViewTextBoxColumn.Width = 85;
            // 
            // eFirstNameDataGridViewTextBoxColumn
            // 
            this.eFirstNameDataGridViewTextBoxColumn.DataPropertyName = "EFirstName";
            this.eFirstNameDataGridViewTextBoxColumn.HeaderText = "EFirstName";
            this.eFirstNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eFirstNameDataGridViewTextBoxColumn.Name = "eFirstNameDataGridViewTextBoxColumn";
            this.eFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eFirstNameDataGridViewTextBoxColumn.Width = 128;
            // 
            // eLastNameDataGridViewTextBoxColumn
            // 
            this.eLastNameDataGridViewTextBoxColumn.DataPropertyName = "ELastName";
            this.eLastNameDataGridViewTextBoxColumn.HeaderText = "ELastName";
            this.eLastNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eLastNameDataGridViewTextBoxColumn.Name = "eLastNameDataGridViewTextBoxColumn";
            this.eLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eLastNameDataGridViewTextBoxColumn.Width = 126;
            // 
            // eSurenameDataGridViewTextBoxColumn
            // 
            this.eSurenameDataGridViewTextBoxColumn.DataPropertyName = "ESurename";
            this.eSurenameDataGridViewTextBoxColumn.HeaderText = "ESurename";
            this.eSurenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eSurenameDataGridViewTextBoxColumn.Name = "eSurenameDataGridViewTextBoxColumn";
            this.eSurenameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eSurenameDataGridViewTextBoxColumn.Width = 127;
            // 
            // eIniNameDataGridViewTextBoxColumn
            // 
            this.eIniNameDataGridViewTextBoxColumn.DataPropertyName = "EIniName";
            this.eIniNameDataGridViewTextBoxColumn.HeaderText = "EIniName";
            this.eIniNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eIniNameDataGridViewTextBoxColumn.Name = "eIniNameDataGridViewTextBoxColumn";
            this.eIniNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.eIniNameDataGridViewTextBoxColumn.Width = 114;
            // 
            // eNICDataGridViewTextBoxColumn
            // 
            this.eNICDataGridViewTextBoxColumn.DataPropertyName = "ENIC";
            this.eNICDataGridViewTextBoxColumn.HeaderText = "ENIC";
            this.eNICDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eNICDataGridViewTextBoxColumn.Name = "eNICDataGridViewTextBoxColumn";
            this.eNICDataGridViewTextBoxColumn.ReadOnly = true;
            this.eNICDataGridViewTextBoxColumn.Width = 77;
            // 
            // eGenderDataGridViewTextBoxColumn
            // 
            this.eGenderDataGridViewTextBoxColumn.DataPropertyName = "EGender";
            this.eGenderDataGridViewTextBoxColumn.HeaderText = "EGender";
            this.eGenderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eGenderDataGridViewTextBoxColumn.Name = "eGenderDataGridViewTextBoxColumn";
            this.eGenderDataGridViewTextBoxColumn.ReadOnly = true;
            this.eGenderDataGridViewTextBoxColumn.Width = 105;
            // 
            // eDOBDataGridViewTextBoxColumn
            // 
            this.eDOBDataGridViewTextBoxColumn.DataPropertyName = "EDOB";
            this.eDOBDataGridViewTextBoxColumn.HeaderText = "EDOB";
            this.eDOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eDOBDataGridViewTextBoxColumn.Name = "eDOBDataGridViewTextBoxColumn";
            this.eDOBDataGridViewTextBoxColumn.ReadOnly = true;
            this.eDOBDataGridViewTextBoxColumn.Width = 85;
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
            // eMobileDataGridViewTextBoxColumn
            // 
            this.eMobileDataGridViewTextBoxColumn.DataPropertyName = "EMobile";
            this.eMobileDataGridViewTextBoxColumn.HeaderText = "EMobile";
            this.eMobileDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eMobileDataGridViewTextBoxColumn.Name = "eMobileDataGridViewTextBoxColumn";
            this.eMobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.eMobileDataGridViewTextBoxColumn.Width = 103;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 81;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 114;
            // 
            // eBasicSalaryDataGridViewTextBoxColumn
            // 
            this.eBasicSalaryDataGridViewTextBoxColumn.DataPropertyName = "EBasicSalary";
            this.eBasicSalaryDataGridViewTextBoxColumn.HeaderText = "EBasicSalary";
            this.eBasicSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eBasicSalaryDataGridViewTextBoxColumn.Name = "eBasicSalaryDataGridViewTextBoxColumn";
            this.eBasicSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            this.eBasicSalaryDataGridViewTextBoxColumn.Width = 134;
            // 
            // allowanceDataGridViewTextBoxColumn
            // 
            this.allowanceDataGridViewTextBoxColumn.DataPropertyName = "Allowance";
            this.allowanceDataGridViewTextBoxColumn.HeaderText = "Allowance";
            this.allowanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.allowanceDataGridViewTextBoxColumn.Name = "allowanceDataGridViewTextBoxColumn";
            this.allowanceDataGridViewTextBoxColumn.ReadOnly = true;
            this.allowanceDataGridViewTextBoxColumn.Width = 119;
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
            // ViewEmployee
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.Datagrid_view_emp);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.viewheaderlabel);
            this.Controls.Add(this.cmbtype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewEmployee";
            this.Text = "ViewAdminStaff";
            this.Load += new System.EventHandler(this.ViewAdminStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view_emp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetForAllRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2DataGridView Datagrid_view_emp;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_userID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbtype;
        private DatasetForAllRep datasetForAllRep;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DatasetForAllRepTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSurenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eIniNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNICDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eGenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eBasicSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTFDataGridViewTextBoxColumn;
    }
}