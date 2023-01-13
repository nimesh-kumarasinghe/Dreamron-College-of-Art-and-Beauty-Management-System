
namespace Dreamron_College
{
    partial class ViewLeaves
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
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_userID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbtype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dsMonthlyLeave = new Dreamron_College.DsMonthlyLeave();
            this.leaveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveTableAdapter = new Dreamron_College.DsMonthlyLeaveTableAdapters.LeaveTableAdapter();
            this.leaveBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dreamronDBDataSet3 = new Dreamron_College.DreamronDBDataSet3();
            this.leaveTableAdapter1 = new Dreamron_College.DreamronDBDataSet3TableAdapters.LeaveTableAdapter();
            this.dg_leaves = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsMonthlyLeave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dreamronDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_leaves)).BeginInit();
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
            this.btn_clear.TabIndex = 117;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
            this.txt_userID.PlaceholderText = "Type Employee ID or Lecturer ID";
            this.txt_userID.SelectedText = "";
            this.txt_userID.Size = new System.Drawing.Size(301, 54);
            this.txt_userID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_userID.TabIndex = 114;
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
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(71, 21);
            this.guna2HtmlLabel3.TabIndex = 113;
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
            this.viewheaderlabel.Size = new System.Drawing.Size(155, 34);
            this.viewheaderlabel.TabIndex = 112;
            this.viewheaderlabel.Text = "VIEW LEAVES";
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
            "Employee",
            "Lecturer",
            "Show All"});
            this.cmbtype.Location = new System.Drawing.Point(33, 104);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(181, 36);
            this.cmbtype.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbtype.TabIndex = 111;
            // 
            // dsMonthlyLeave
            // 
            this.dsMonthlyLeave.DataSetName = "DsMonthlyLeave";
            this.dsMonthlyLeave.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveBindingSource
            // 
            this.leaveBindingSource.DataMember = "Leave";
            this.leaveBindingSource.DataSource = this.dsMonthlyLeave;
            // 
            // leaveTableAdapter
            // 
            this.leaveTableAdapter.ClearBeforeFill = true;
            // 
            // leaveBindingSource1
            // 
            this.leaveBindingSource1.DataMember = "Leave";
            this.leaveBindingSource1.DataSource = this.dreamronDBDataSet3;
            // 
            // dreamronDBDataSet3
            // 
            this.dreamronDBDataSet3.DataSetName = "DreamronDBDataSet3";
            this.dreamronDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // leaveTableAdapter1
            // 
            this.leaveTableAdapter1.ClearBeforeFill = true;
            // 
            // dg_leaves
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dg_leaves.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_leaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_leaves.BackgroundColor = System.Drawing.Color.White;
            this.dg_leaves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg_leaves.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_leaves.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_leaves.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dg_leaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_leaves.DefaultCellStyle = dataGridViewCellStyle3;
            this.dg_leaves.EnableHeadersVisualStyles = false;
            this.dg_leaves.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_leaves.Location = new System.Drawing.Point(33, 172);
            this.dg_leaves.Name = "dg_leaves";
            this.dg_leaves.RowHeadersVisible = false;
            this.dg_leaves.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_leaves.Size = new System.Drawing.Size(861, 437);
            this.dg_leaves.TabIndex = 118;
            this.dg_leaves.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_leaves.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dg_leaves.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dg_leaves.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dg_leaves.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dg_leaves.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dg_leaves.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_leaves.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dg_leaves.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dg_leaves.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dg_leaves.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dg_leaves.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_leaves.ThemeStyle.HeaderStyle.Height = 4;
            this.dg_leaves.ThemeStyle.ReadOnly = false;
            this.dg_leaves.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dg_leaves.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dg_leaves.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dg_leaves.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dg_leaves.ThemeStyle.RowsStyle.Height = 22;
            this.dg_leaves.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dg_leaves.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ViewLeaves
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.dg_leaves);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_userID);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.viewheaderlabel);
            this.Controls.Add(this.cmbtype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewLeaves";
            this.Text = "ViewLeaves";
            this.Load += new System.EventHandler(this.ViewLeaves_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsMonthlyLeave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dreamronDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_leaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_userID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbtype;
        private System.Windows.Forms.BindingSource leaveBindingSource;
        private DsMonthlyLeave dsMonthlyLeave;
        private DsMonthlyLeaveTableAdapters.LeaveTableAdapter leaveTableAdapter;
        private DreamronDBDataSet3 dreamronDBDataSet3;
        private System.Windows.Forms.BindingSource leaveBindingSource1;
        private DreamronDBDataSet3TableAdapters.LeaveTableAdapter leaveTableAdapter1;
        private Guna.UI2.WinForms.Guna2DataGridView dg_leaves;
    }
}