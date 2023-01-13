
namespace Dreamron_College
{
    partial class ViewGrade
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
            this.viewheaderlabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.data_grid_view_grade = new Guna.UI2.WinForms.Guna2DataGridView();
            this.newDreamronDataSet = new Dreamron_College.NewDreamronDataSet();
            this.gradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradeTableAdapter = new Dreamron_College.NewDreamronDataSetTableAdapters.GradeTableAdapter();
            this.gradeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basicSalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eTFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavesPerMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_grade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDreamronDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.viewheaderlabel.Location = new System.Drawing.Point(23, 12);
            this.viewheaderlabel.Name = "viewheaderlabel";
            this.viewheaderlabel.Size = new System.Drawing.Size(187, 43);
            this.viewheaderlabel.TabIndex = 140;
            this.viewheaderlabel.Text = "VIEW GRADE";
            // 
            // data_grid_view_grade
            // 
            this.data_grid_view_grade.AllowUserToAddRows = false;
            this.data_grid_view_grade.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.data_grid_view_grade.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_view_grade.AutoGenerateColumns = false;
            this.data_grid_view_grade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_grid_view_grade.BackgroundColor = System.Drawing.Color.White;
            this.data_grid_view_grade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_grid_view_grade.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_grid_view_grade.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_view_grade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.data_grid_view_grade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view_grade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gradeIDDataGridViewTextBoxColumn,
            this.gradeNameDataGridViewTextBoxColumn,
            this.basicSalaryDataGridViewTextBoxColumn,
            this.ePFDataGridViewTextBoxColumn,
            this.eTFDataGridViewTextBoxColumn,
            this.leavesPerMonthDataGridViewTextBoxColumn,
            this.allowanceDataGridViewTextBoxColumn,
            this.salaryPerDayDataGridViewTextBoxColumn});
            this.data_grid_view_grade.DataSource = this.gradeBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_grid_view_grade.DefaultCellStyle = dataGridViewCellStyle3;
            this.data_grid_view_grade.EnableHeadersVisualStyles = false;
            this.data_grid_view_grade.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_grid_view_grade.Location = new System.Drawing.Point(12, 61);
            this.data_grid_view_grade.Name = "data_grid_view_grade";
            this.data_grid_view_grade.ReadOnly = true;
            this.data_grid_view_grade.RowHeadersVisible = false;
            this.data_grid_view_grade.RowHeadersWidth = 51;
            this.data_grid_view_grade.RowTemplate.Height = 24;
            this.data_grid_view_grade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_grid_view_grade.Size = new System.Drawing.Size(883, 481);
            this.data_grid_view_grade.TabIndex = 146;
            this.data_grid_view_grade.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data_grid_view_grade.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data_grid_view_grade.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data_grid_view_grade.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data_grid_view_grade.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data_grid_view_grade.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.data_grid_view_grade.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_grid_view_grade.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data_grid_view_grade.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data_grid_view_grade.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_grid_view_grade.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data_grid_view_grade.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view_grade.ThemeStyle.HeaderStyle.Height = 27;
            this.data_grid_view_grade.ThemeStyle.ReadOnly = true;
            this.data_grid_view_grade.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.data_grid_view_grade.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data_grid_view_grade.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.data_grid_view_grade.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data_grid_view_grade.ThemeStyle.RowsStyle.Height = 24;
            this.data_grid_view_grade.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data_grid_view_grade.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // newDreamronDataSet
            // 
            this.newDreamronDataSet.DataSetName = "NewDreamronDataSet";
            this.newDreamronDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradeBindingSource
            // 
            this.gradeBindingSource.DataMember = "Grade";
            this.gradeBindingSource.DataSource = this.newDreamronDataSet;
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // gradeIDDataGridViewTextBoxColumn
            // 
            this.gradeIDDataGridViewTextBoxColumn.DataPropertyName = "GradeID";
            this.gradeIDDataGridViewTextBoxColumn.HeaderText = "GradeID";
            this.gradeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeIDDataGridViewTextBoxColumn.Name = "gradeIDDataGridViewTextBoxColumn";
            this.gradeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gradeNameDataGridViewTextBoxColumn
            // 
            this.gradeNameDataGridViewTextBoxColumn.DataPropertyName = "GradeName";
            this.gradeNameDataGridViewTextBoxColumn.HeaderText = "GradeName";
            this.gradeNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gradeNameDataGridViewTextBoxColumn.Name = "gradeNameDataGridViewTextBoxColumn";
            this.gradeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // basicSalaryDataGridViewTextBoxColumn
            // 
            this.basicSalaryDataGridViewTextBoxColumn.DataPropertyName = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.HeaderText = "BasicSalary";
            this.basicSalaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.basicSalaryDataGridViewTextBoxColumn.Name = "basicSalaryDataGridViewTextBoxColumn";
            this.basicSalaryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ePFDataGridViewTextBoxColumn
            // 
            this.ePFDataGridViewTextBoxColumn.DataPropertyName = "EPF";
            this.ePFDataGridViewTextBoxColumn.HeaderText = "EPF";
            this.ePFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ePFDataGridViewTextBoxColumn.Name = "ePFDataGridViewTextBoxColumn";
            this.ePFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eTFDataGridViewTextBoxColumn
            // 
            this.eTFDataGridViewTextBoxColumn.DataPropertyName = "ETF";
            this.eTFDataGridViewTextBoxColumn.HeaderText = "ETF";
            this.eTFDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eTFDataGridViewTextBoxColumn.Name = "eTFDataGridViewTextBoxColumn";
            this.eTFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // leavesPerMonthDataGridViewTextBoxColumn
            // 
            this.leavesPerMonthDataGridViewTextBoxColumn.DataPropertyName = "LeavesPerMonth";
            this.leavesPerMonthDataGridViewTextBoxColumn.HeaderText = "LeavesPerMonth";
            this.leavesPerMonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.leavesPerMonthDataGridViewTextBoxColumn.Name = "leavesPerMonthDataGridViewTextBoxColumn";
            this.leavesPerMonthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // allowanceDataGridViewTextBoxColumn
            // 
            this.allowanceDataGridViewTextBoxColumn.DataPropertyName = "Allowance";
            this.allowanceDataGridViewTextBoxColumn.HeaderText = "Allowance";
            this.allowanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.allowanceDataGridViewTextBoxColumn.Name = "allowanceDataGridViewTextBoxColumn";
            this.allowanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salaryPerDayDataGridViewTextBoxColumn
            // 
            this.salaryPerDayDataGridViewTextBoxColumn.DataPropertyName = "SalaryPerDay";
            this.salaryPerDayDataGridViewTextBoxColumn.HeaderText = "SalaryPerDay";
            this.salaryPerDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryPerDayDataGridViewTextBoxColumn.Name = "salaryPerDayDataGridViewTextBoxColumn";
            this.salaryPerDayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ViewGrade
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(907, 636);
            this.Controls.Add(this.data_grid_view_grade);
            this.Controls.Add(this.viewheaderlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewGrade";
            this.Text = "ViewGrade";
            this.Load += new System.EventHandler(this.ViewGrade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view_grade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newDreamronDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2DataGridView data_grid_view_grade;
        private Guna.UI2.WinForms.Guna2HtmlLabel viewheaderlabel;
        private NewDreamronDataSet newDreamronDataSet;
        private System.Windows.Forms.BindingSource gradeBindingSource;
        private NewDreamronDataSetTableAdapters.GradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn basicSalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eTFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavesPerMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allowanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryPerDayDataGridViewTextBoxColumn;
    }
}