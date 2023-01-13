
namespace Dreamron_College
{
    partial class ViewStudent
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
            this.btn_all_data = new Guna.UI2.WinForms.Guna2Button();
            this.txt_nic = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.datasetForAllRep = new Dreamron_College.DatasetForAllRep();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_student_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.studentTableAdapter = new Dreamron_College.DatasetForAllRepTableAdapters.StudentTableAdapter();
            this.Datagrid_view_student = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetForAllRep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view_student)).BeginInit();
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
            this.btn_all_data.TabIndex = 119;
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
            this.txt_nic.TabIndex = 118;
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
            this.btn_clear.TabIndex = 117;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.datasetForAllRep;
            // 
            // datasetForAllRep
            // 
            this.datasetForAllRep.DataSetName = "DatasetForAllRep";
            this.datasetForAllRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.btn_search.TabIndex = 115;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_student_id
            // 
            this.txt_student_id.Animated = true;
            this.txt_student_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_student_id.DefaultText = "";
            this.txt_student_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_student_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_student_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_student_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_student_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_student_id.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txt_student_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_student_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_student_id.Location = new System.Drawing.Point(31, 85);
            this.txt_student_id.Margin = new System.Windows.Forms.Padding(4);
            this.txt_student_id.Name = "txt_student_id";
            this.txt_student_id.PasswordChar = '\0';
            this.txt_student_id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_student_id.PlaceholderText = "Type Student ID ";
            this.txt_student_id.SelectedText = "";
            this.txt_student_id.Size = new System.Drawing.Size(301, 54);
            this.txt_student_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_student_id.TabIndex = 114;
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
            this.viewheaderlabel.Size = new System.Drawing.Size(179, 34);
            this.viewheaderlabel.TabIndex = 113;
            this.viewheaderlabel.Text = "VIEW STUDENT";
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // Datagrid_view_student
            // 
            this.Datagrid_view_student.AllowUserToAddRows = false;
            this.Datagrid_view_student.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Datagrid_view_student.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Datagrid_view_student.BackgroundColor = System.Drawing.Color.White;
            this.Datagrid_view_student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Datagrid_view_student.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view_student.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagrid_view_student.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Datagrid_view_student.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagrid_view_student.DefaultCellStyle = dataGridViewCellStyle3;
            this.Datagrid_view_student.EnableHeadersVisualStyles = false;
            this.Datagrid_view_student.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_student.Location = new System.Drawing.Point(12, 169);
            this.Datagrid_view_student.Name = "Datagrid_view_student";
            this.Datagrid_view_student.ReadOnly = true;
            this.Datagrid_view_student.RowHeadersVisible = false;
            this.Datagrid_view_student.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Datagrid_view_student.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagrid_view_student.Size = new System.Drawing.Size(901, 442);
            this.Datagrid_view_student.TabIndex = 120;
            this.Datagrid_view_student.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_student.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Datagrid_view_student.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view_student.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Datagrid_view_student.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Datagrid_view_student.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_student.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_student.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Datagrid_view_student.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Datagrid_view_student.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view_student.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Datagrid_view_student.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Datagrid_view_student.ThemeStyle.HeaderStyle.Height = 4;
            this.Datagrid_view_student.ThemeStyle.ReadOnly = true;
            this.Datagrid_view_student.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagrid_view_student.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagrid_view_student.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagrid_view_student.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Datagrid_view_student.ThemeStyle.RowsStyle.Height = 22;
            this.Datagrid_view_student.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagrid_view_student.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ViewStudent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.Datagrid_view_student);
            this.Controls.Add(this.btn_all_data);
            this.Controls.Add(this.txt_nic);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_student_id);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewStudent";
            this.Text = "ViewStudent";
            this.Load += new System.EventHandler(this.ViewStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datasetForAllRep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagrid_view_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_all_data;
        private Guna.UI2.WinForms.Guna2TextBox txt_nic;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_student_id;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private DatasetForAllRep datasetForAllRep;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DatasetForAllRepTableAdapters.StudentTableAdapter studentTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView Datagrid_view_student;
    }
}