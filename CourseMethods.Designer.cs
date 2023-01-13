
namespace Dreamron_College
{
    partial class CourseMethods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseMethods));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_home = new Guna.UI2.WinForms.Guna2Button();
            this.btn_view_course = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete_course = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit_course = new Guna.UI2.WinForms.Guna2Button();
            this.btn_add_course = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(19)))), ((int)(((byte)(104)))));
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Location = new System.Drawing.Point(276, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(925, 38);
            this.guna2Panel2.TabIndex = 53;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(16, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(68, 25);
            this.guna2HtmlLabel1.TabIndex = 49;
            this.guna2HtmlLabel1.Text = "COURSE";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Controls.Add(this.btn_home);
            this.guna2Panel1.Controls.Add(this.btn_view_course);
            this.guna2Panel1.Controls.Add(this.btn_delete_course);
            this.guna2Panel1.Controls.Add(this.btn_edit_course);
            this.guna2Panel1.Controls.Add(this.btn_add_course);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 167);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(277, 553);
            this.guna2Panel1.TabIndex = 51;
            // 
            // btn_home
            // 
            this.btn_home.Animated = true;
            this.btn_home.BorderRadius = 7;
            this.btn_home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_home.CheckedState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_home.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_home.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(19)))), ((int)(((byte)(104)))));
            this.btn_home.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.HoverState.FillColor = System.Drawing.Color.HotPink;
            this.btn_home.Location = new System.Drawing.Point(65, 470);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(146, 45);
            this.btn_home.TabIndex = 11;
            this.btn_home.Text = "Go to Home";
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_view_course
            // 
            this.btn_view_course.Animated = true;
            this.btn_view_course.BorderRadius = 7;
            this.btn_view_course.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_view_course.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(19)))), ((int)(((byte)(104)))));
            this.btn_view_course.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_view_course.CustomImages.Image = global::Dreamron_College.Properties.Resources.view_26px;
            this.btn_view_course.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_view_course.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_view_course.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_view_course.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_view_course.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_view_course.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_view_course.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view_course.ForeColor = System.Drawing.Color.White;
            this.btn_view_course.HoverState.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_view_course.Location = new System.Drawing.Point(17, 236);
            this.btn_view_course.Name = "btn_view_course";
            this.btn_view_course.Size = new System.Drawing.Size(242, 45);
            this.btn_view_course.TabIndex = 9;
            this.btn_view_course.Text = "View Course";
            this.btn_view_course.Click += new System.EventHandler(this.btn_view_course_Click);
            // 
            // btn_delete_course
            // 
            this.btn_delete_course.Animated = true;
            this.btn_delete_course.BorderRadius = 7;
            this.btn_delete_course.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_delete_course.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(19)))), ((int)(((byte)(104)))));
            this.btn_delete_course.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_delete_course.CustomImages.Image = global::Dreamron_College.Properties.Resources.delete_document_26px;
            this.btn_delete_course.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_delete_course.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_course.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete_course.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete_course.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete_course.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete_course.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_course.ForeColor = System.Drawing.Color.White;
            this.btn_delete_course.HoverState.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_delete_course.Location = new System.Drawing.Point(17, 168);
            this.btn_delete_course.Name = "btn_delete_course";
            this.btn_delete_course.Size = new System.Drawing.Size(242, 45);
            this.btn_delete_course.TabIndex = 2;
            this.btn_delete_course.Text = "  Delete Course";
            this.btn_delete_course.Click += new System.EventHandler(this.btn_delete_course_Click);
            // 
            // btn_edit_course
            // 
            this.btn_edit_course.Animated = true;
            this.btn_edit_course.BorderRadius = 7;
            this.btn_edit_course.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_edit_course.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(19)))), ((int)(((byte)(104)))));
            this.btn_edit_course.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_edit_course.CustomImages.Image = global::Dreamron_College.Properties.Resources.edit_property_26px;
            this.btn_edit_course.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_edit_course.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_course.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit_course.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit_course.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit_course.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit_course.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_course.ForeColor = System.Drawing.Color.White;
            this.btn_edit_course.HoverState.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_edit_course.Location = new System.Drawing.Point(17, 101);
            this.btn_edit_course.Name = "btn_edit_course";
            this.btn_edit_course.Size = new System.Drawing.Size(242, 45);
            this.btn_edit_course.TabIndex = 2;
            this.btn_edit_course.Text = "  Update Course";
            this.btn_edit_course.Click += new System.EventHandler(this.btn_edit_course_Click);
            // 
            // btn_add_course
            // 
            this.btn_add_course.Animated = true;
            this.btn_add_course.BorderRadius = 7;
            this.btn_add_course.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_add_course.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(19)))), ((int)(((byte)(104)))));
            this.btn_add_course.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btn_add_course.CustomImages.Image = global::Dreamron_College.Properties.Resources.new_copy_26px;
            this.btn_add_course.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_add_course.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_course.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add_course.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add_course.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add_course.FillColor = System.Drawing.Color.RoyalBlue;
            this.btn_add_course.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_course.ForeColor = System.Drawing.Color.White;
            this.btn_add_course.HoverState.FillColor = System.Drawing.Color.SlateBlue;
            this.btn_add_course.Location = new System.Drawing.Point(17, 35);
            this.btn_add_course.Name = "btn_add_course";
            this.btn_add_course.Size = new System.Drawing.Size(242, 45);
            this.btn_add_course.TabIndex = 1;
            this.btn_add_course.Text = "Add Course";
            this.btn_add_course.Click += new System.EventHandler(this.btn_add_course_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(276, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(925, 683);
            this.panel4.TabIndex = 58;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::Dreamron_College.Properties.Resources.login_logo;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(36, 14);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(203, 134);
            this.guna2PictureBox2.TabIndex = 52;
            this.guna2PictureBox2.TabStop = false;
            // 
            // CourseMethods
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CourseMethods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CourseMethods";
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_home;
        private Guna.UI2.WinForms.Guna2Button btn_view_course;
        private Guna.UI2.WinForms.Guna2Button btn_delete_course;
        private Guna.UI2.WinForms.Guna2Button btn_edit_course;
        private Guna.UI2.WinForms.Guna2Button btn_add_course;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel panel4;
    }
}