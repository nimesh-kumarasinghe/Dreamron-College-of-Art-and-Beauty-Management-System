
namespace Dreamron_College
{
    partial class AddBatch
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
            this.btn_addbatch = new Guna.UI2.WinForms.Guna2Button();
            this.txt_batch_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.start_date_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_no_of_seats = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_course_selector = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.end_date_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btn_addbatch
            // 
            this.btn_addbatch.Animated = true;
            this.btn_addbatch.AutoRoundedCorners = true;
            this.btn_addbatch.BorderRadius = 19;
            this.btn_addbatch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addbatch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addbatch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addbatch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addbatch.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_addbatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addbatch.ForeColor = System.Drawing.Color.White;
            this.btn_addbatch.Location = new System.Drawing.Point(704, 627);
            this.btn_addbatch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addbatch.Name = "btn_addbatch";
            this.btn_addbatch.Size = new System.Drawing.Size(176, 41);
            this.btn_addbatch.TabIndex = 133;
            this.btn_addbatch.Text = "ADD";
            this.btn_addbatch.Click += new System.EventHandler(this.btn_addbatch_Click);
            // 
            // txt_batch_id
            // 
            this.txt_batch_id.Animated = true;
            this.txt_batch_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_batch_id.DefaultText = "";
            this.txt_batch_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_batch_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_batch_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_batch_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_batch_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_batch_id.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_batch_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_batch_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_batch_id.Location = new System.Drawing.Point(44, 97);
            this.txt_batch_id.Margin = new System.Windows.Forms.Padding(7);
            this.txt_batch_id.Name = "txt_batch_id";
            this.txt_batch_id.PasswordChar = '\0';
            this.txt_batch_id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_batch_id.PlaceholderText = "Batch ID";
            this.txt_batch_id.SelectedText = "";
            this.txt_batch_id.Size = new System.Drawing.Size(400, 44);
            this.txt_batch_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_batch_id.TabIndex = 132;
            // 
            // start_date_picker
            // 
            this.start_date_picker.Animated = true;
            this.start_date_picker.Checked = true;
            this.start_date_picker.FillColor = System.Drawing.Color.White;
            this.start_date_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.start_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.start_date_picker.Location = new System.Drawing.Point(44, 210);
            this.start_date_picker.Margin = new System.Windows.Forms.Padding(4);
            this.start_date_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.start_date_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.start_date_picker.Name = "start_date_picker";
            this.start_date_picker.Size = new System.Drawing.Size(288, 44);
            this.start_date_picker.TabIndex = 130;
            this.start_date_picker.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(44, 179);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(72, 23);
            this.guna2HtmlLabel4.TabIndex = 129;
            this.guna2HtmlLabel4.Text = "Start Date";
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
            this.btn_clear.Location = new System.Drawing.Point(480, 627);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(176, 41);
            this.btn_clear.TabIndex = 128;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(44, 15);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(176, 43);
            this.guna2HtmlLabel1.TabIndex = 127;
            this.guna2HtmlLabel1.Text = "ADD BATCH";
            // 
            // txt_no_of_seats
            // 
            this.txt_no_of_seats.Animated = true;
            this.txt_no_of_seats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_no_of_seats.DefaultText = "";
            this.txt_no_of_seats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_no_of_seats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_no_of_seats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_no_of_seats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_no_of_seats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_no_of_seats.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_no_of_seats.ForeColor = System.Drawing.Color.DimGray;
            this.txt_no_of_seats.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_no_of_seats.Location = new System.Drawing.Point(44, 296);
            this.txt_no_of_seats.Margin = new System.Windows.Forms.Padding(7);
            this.txt_no_of_seats.Name = "txt_no_of_seats";
            this.txt_no_of_seats.PasswordChar = '\0';
            this.txt_no_of_seats.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_no_of_seats.PlaceholderText = "Seats";
            this.txt_no_of_seats.SelectedText = "";
            this.txt_no_of_seats.Size = new System.Drawing.Size(400, 44);
            this.txt_no_of_seats.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_no_of_seats.TabIndex = 125;
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
            this.cmb_course_selector.Location = new System.Drawing.Point(44, 417);
            this.cmb_course_selector.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_course_selector.Name = "cmb_course_selector";
            this.cmb_course_selector.Size = new System.Drawing.Size(399, 36);
            this.cmb_course_selector.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmb_course_selector.TabIndex = 135;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(44, 386);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(109, 23);
            this.guna2HtmlLabel2.TabIndex = 134;
            this.guna2HtmlLabel2.Text = "Select a Course";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(470, 179);
            this.guna2HtmlLabel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(65, 23);
            this.guna2HtmlLabel3.TabIndex = 136;
            this.guna2HtmlLabel3.Text = "End Date";
            // 
            // end_date_picker
            // 
            this.end_date_picker.Animated = true;
            this.end_date_picker.Checked = true;
            this.end_date_picker.FillColor = System.Drawing.Color.White;
            this.end_date_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.end_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.end_date_picker.Location = new System.Drawing.Point(470, 210);
            this.end_date_picker.Margin = new System.Windows.Forms.Padding(4);
            this.end_date_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.end_date_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.end_date_picker.Name = "end_date_picker";
            this.end_date_picker.Size = new System.Drawing.Size(288, 44);
            this.end_date_picker.TabIndex = 137;
            this.end_date_picker.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // AddBatch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.end_date_picker);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.cmb_course_selector);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_addbatch);
            this.Controls.Add(this.txt_batch_id);
            this.Controls.Add(this.start_date_picker);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_no_of_seats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBatch";
            this.Text = "AddBatch";
            this.Load += new System.EventHandler(this.AddBatch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_addbatch;
        private Guna.UI2.WinForms.Guna2TextBox txt_batch_id;
        private Guna.UI2.WinForms.Guna2DateTimePicker start_date_picker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_no_of_seats;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_course_selector;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker end_date_picker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}