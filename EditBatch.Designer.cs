
namespace Dreamron_College
{
    partial class EditBatch
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
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_batch_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.startdate_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_clear = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txt_course_id = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_seat = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_update_batch = new Guna.UI2.WinForms.Guna2Button();
            this.endtdate_picker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
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
            this.btn_search.Location = new System.Drawing.Point(783, 99);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(97, 35);
            this.btn_search.TabIndex = 122;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            this.txt_batch_id.Location = new System.Drawing.Point(480, 99);
            this.txt_batch_id.Margin = new System.Windows.Forms.Padding(7);
            this.txt_batch_id.Name = "txt_batch_id";
            this.txt_batch_id.PasswordChar = '\0';
            this.txt_batch_id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_batch_id.PlaceholderText = "Type Batch ID to get Details";
            this.txt_batch_id.SelectedText = "";
            this.txt_batch_id.Size = new System.Drawing.Size(400, 44);
            this.txt_batch_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_batch_id.TabIndex = 123;
            // 
            // startdate_picker
            // 
            this.startdate_picker.Animated = true;
            this.startdate_picker.Checked = true;
            this.startdate_picker.FillColor = System.Drawing.Color.White;
            this.startdate_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.startdate_picker.Location = new System.Drawing.Point(44, 198);
            this.startdate_picker.Margin = new System.Windows.Forms.Padding(4);
            this.startdate_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.startdate_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.startdate_picker.Name = "startdate_picker";
            this.startdate_picker.Size = new System.Drawing.Size(400, 44);
            this.startdate_picker.TabIndex = 117;
            this.startdate_picker.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(44, 167);
            this.guna2HtmlLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(72, 23);
            this.guna2HtmlLabel4.TabIndex = 115;
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
            this.btn_clear.TabIndex = 111;
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
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(304, 43);
            this.guna2HtmlLabel1.TabIndex = 110;
            this.guna2HtmlLabel1.Text = "EDIT BATCH DETAILS";
            // 
            // txt_course_id
            // 
            this.txt_course_id.Animated = true;
            this.txt_course_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_course_id.DefaultText = "";
            this.txt_course_id.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_course_id.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_course_id.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_course_id.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_course_id.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_course_id.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_course_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_course_id.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_course_id.Location = new System.Drawing.Point(44, 395);
            this.txt_course_id.Margin = new System.Windows.Forms.Padding(7);
            this.txt_course_id.Name = "txt_course_id";
            this.txt_course_id.PasswordChar = '\0';
            this.txt_course_id.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_course_id.PlaceholderText = "Course ID";
            this.txt_course_id.SelectedText = "";
            this.txt_course_id.Size = new System.Drawing.Size(400, 44);
            this.txt_course_id.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_course_id.TabIndex = 105;
            // 
            // txt_seat
            // 
            this.txt_seat.Animated = true;
            this.txt_seat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_seat.DefaultText = "";
            this.txt_seat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_seat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_seat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_seat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_seat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_seat.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txt_seat.ForeColor = System.Drawing.Color.DimGray;
            this.txt_seat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_seat.Location = new System.Drawing.Point(44, 296);
            this.txt_seat.Margin = new System.Windows.Forms.Padding(7);
            this.txt_seat.Name = "txt_seat";
            this.txt_seat.PasswordChar = '\0';
            this.txt_seat.PlaceholderForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txt_seat.PlaceholderText = "Seats";
            this.txt_seat.SelectedText = "";
            this.txt_seat.Size = new System.Drawing.Size(400, 44);
            this.txt_seat.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_seat.TabIndex = 103;
            // 
            // btn_update_batch
            // 
            this.btn_update_batch.Animated = true;
            this.btn_update_batch.AutoRoundedCorners = true;
            this.btn_update_batch.BorderRadius = 19;
            this.btn_update_batch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_batch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update_batch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update_batch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update_batch.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_update_batch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_batch.ForeColor = System.Drawing.Color.White;
            this.btn_update_batch.Location = new System.Drawing.Point(704, 627);
            this.btn_update_batch.Margin = new System.Windows.Forms.Padding(4);
            this.btn_update_batch.Name = "btn_update_batch";
            this.btn_update_batch.Size = new System.Drawing.Size(176, 41);
            this.btn_update_batch.TabIndex = 124;
            this.btn_update_batch.Text = "UPDATE";
            this.btn_update_batch.Click += new System.EventHandler(this.btn_update_batch_Click);
            // 
            // endtdate_picker
            // 
            this.endtdate_picker.Animated = true;
            this.endtdate_picker.Checked = true;
            this.endtdate_picker.FillColor = System.Drawing.Color.White;
            this.endtdate_picker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.endtdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.endtdate_picker.Location = new System.Drawing.Point(480, 198);
            this.endtdate_picker.Margin = new System.Windows.Forms.Padding(4);
            this.endtdate_picker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.endtdate_picker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.endtdate_picker.Name = "endtdate_picker";
            this.endtdate_picker.Size = new System.Drawing.Size(400, 44);
            this.endtdate_picker.TabIndex = 126;
            this.endtdate_picker.Value = new System.DateTime(2021, 12, 2, 11, 14, 20, 111);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(480, 167);
            this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(65, 23);
            this.guna2HtmlLabel2.TabIndex = 125;
            this.guna2HtmlLabel2.Text = " End Date";
            // 
            // EditBatch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 683);
            this.Controls.Add(this.endtdate_picker);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.btn_update_batch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_batch_id);
            this.Controls.Add(this.startdate_picker);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.txt_course_id);
            this.Controls.Add(this.txt_seat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBatch";
            this.Text = "EditBatch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_batch_id;
        private Guna.UI2.WinForms.Guna2DateTimePicker startdate_picker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btn_clear;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_course_id;
        private Guna.UI2.WinForms.Guna2TextBox txt_seat;
        private Guna.UI2.WinForms.Guna2Button btn_update_batch;
        private Guna.UI2.WinForms.Guna2DateTimePicker endtdate_picker;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
    }
}