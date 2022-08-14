
namespace foroshbilit
{
    partial class sqlcon
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_minimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btn_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.btn_testcon = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmb_databases = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.cmb_server = new System.Windows.Forms.ComboBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.btn_minimize);
            this.guna2Panel1.Controls.Add(this.btn_exit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(369, 30);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Connection String";
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_minimize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_minimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.btn_minimize.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_minimize.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_minimize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_minimize.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_minimize.HoverState.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btn_minimize.HoverState.Parent = this.btn_minimize;
            this.btn_minimize.IconColor = System.Drawing.Color.Black;
            this.btn_minimize.Location = new System.Drawing.Point(295, 4);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.ShadowDecoration.Parent = this.btn_minimize;
            this.btn_minimize.Size = new System.Drawing.Size(34, 23);
            this.btn_minimize.TabIndex = 0;
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_exit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_exit.HoverState.IconColor = System.Drawing.Color.Red;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.IconColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(331, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(34, 23);
            this.btn_exit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(279, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "نام سرور :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(282, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "دیتابیس :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(278, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "شناسه ورود:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(281, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "رمز عبور :";
            // 
            // txt_username
            // 
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.Parent = this.txt_username;
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_username.FocusedState.Parent = this.txt_username;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_username.HoverState.Parent = this.txt_username;
            this.txt_username.Location = new System.Drawing.Point(12, 87);
            this.txt_username.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_username.MaxLength = 100;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_username.SelectedText = "";
            this.txt_username.ShadowDecoration.Parent = this.txt_username;
            this.txt_username.Size = new System.Drawing.Size(263, 28);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.Parent = this.txt_password;
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.FocusedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_password.FocusedState.Parent = this.txt_password;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txt_password.HoverState.Parent = this.txt_password;
            this.txt_password.Location = new System.Drawing.Point(12, 124);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_password.MaxLength = 40;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.PlaceholderText = "";
            this.txt_password.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_password.SelectedText = "";
            this.txt_password.ShadowDecoration.Parent = this.txt_password;
            this.txt_password.Size = new System.Drawing.Size(263, 28);
            this.txt_password.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.CheckedState.Parent = this.btn_save;
            this.btn_save.CustomImages.Parent = this.btn_save;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.DisabledState.Parent = this.btn_save;
            this.btn_save.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_save.Font = new System.Drawing.Font("B Nazanin", 12F);
            this.btn_save.ForeColor = System.Drawing.Color.Black;
            this.btn_save.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_save.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btn_save.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.Image = global::foroshbilit.Properties.Resources.floppy_disk__1_;
            this.btn_save.HoverState.Parent = this.btn_save;
            this.btn_save.Image = global::foroshbilit.Properties.Resources.floppy_disk;
            this.btn_save.Location = new System.Drawing.Point(13, 222);
            this.btn_save.Name = "btn_save";
            this.btn_save.ShadowDecoration.Parent = this.btn_save;
            this.btn_save.Size = new System.Drawing.Size(124, 30);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "ذخیره";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_testcon
            // 
            this.btn_testcon.CheckedState.Parent = this.btn_testcon;
            this.btn_testcon.CustomImages.Parent = this.btn_testcon;
            this.btn_testcon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_testcon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_testcon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_testcon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_testcon.DisabledState.Parent = this.btn_testcon;
            this.btn_testcon.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_testcon.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_testcon.ForeColor = System.Drawing.Color.Black;
            this.btn_testcon.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_testcon.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_testcon.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_testcon.HoverState.Image = global::foroshbilit.Properties.Resources.url__1_;
            this.btn_testcon.HoverState.Parent = this.btn_testcon;
            this.btn_testcon.Image = global::foroshbilit.Properties.Resources.url;
            this.btn_testcon.Location = new System.Drawing.Point(151, 222);
            this.btn_testcon.Name = "btn_testcon";
            this.btn_testcon.ShadowDecoration.Parent = this.btn_testcon;
            this.btn_testcon.Size = new System.Drawing.Size(124, 30);
            this.btn_testcon.TabIndex = 4;
            this.btn_testcon.Text = "تست";
            this.btn_testcon.Click += new System.EventHandler(this.btn_testcon_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox1.Image = global::foroshbilit.Properties.Resources.database;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(284, 209);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(63, 52);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cmb_databases
            // 
            this.cmb_databases.BackColor = System.Drawing.Color.Transparent;
            this.cmb_databases.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_databases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_databases.Enabled = false;
            this.cmb_databases.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_databases.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_databases.FocusedState.Parent = this.cmb_databases;
            this.cmb_databases.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_databases.ForeColor = System.Drawing.Color.Black;
            this.cmb_databases.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_databases.HoverState.Parent = this.cmb_databases;
            this.cmb_databases.ItemHeight = 30;
            this.cmb_databases.ItemsAppearance.Parent = this.cmb_databases;
            this.cmb_databases.Location = new System.Drawing.Point(92, 164);
            this.cmb_databases.Name = "cmb_databases";
            this.cmb_databases.ShadowDecoration.Parent = this.cmb_databases;
            this.cmb_databases.Size = new System.Drawing.Size(183, 36);
            this.cmb_databases.TabIndex = 0;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.HoverState.Image = global::foroshbilit.Properties.Resources.task__1_;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::foroshbilit.Properties.Resources.task;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(12, 164);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.ShadowDecoration.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(74, 36);
            this.guna2ImageButton1.TabIndex = 6;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // cmb_server
            // 
            this.cmb_server.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_server.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmb_server.ForeColor = System.Drawing.Color.Black;
            this.cmb_server.FormattingEnabled = true;
            this.cmb_server.Location = new System.Drawing.Point(13, 46);
            this.cmb_server.Name = "cmb_server";
            this.cmb_server.Size = new System.Drawing.Size(262, 25);
            this.cmb_server.TabIndex = 7;
            // 
            // sqlcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(369, 270);
            this.Controls.Add(this.cmb_server);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btn_testcon);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.cmb_databases);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sqlcon";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sqlcon";
            this.Load += new System.EventHandler(this.sqlcon_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox btn_exit;
        private Guna.UI2.WinForms.Guna2ControlBox btn_minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private Guna.UI2.WinForms.Guna2Button btn_testcon;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_databases;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.ComboBox cmb_server;
    }
}