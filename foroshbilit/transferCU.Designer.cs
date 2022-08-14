
namespace foroshbilit
{
    partial class transferCU
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
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cmb_transfertype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_goandgoback = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmb_intflytype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Source = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Destination = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmb_passagetype = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_backdate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_backingdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtp_goingdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_money = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sabt = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox2);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(313, 26);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseDown);
            this.guna2Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseMove);
            this.guna2Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.guna2Panel1_MouseUp);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(228, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(41, 26);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(272, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(41, 26);
            this.guna2ControlBox1.TabIndex = 1;
            // 
            // cmb_transfertype
            // 
            this.cmb_transfertype.BackColor = System.Drawing.Color.Transparent;
            this.cmb_transfertype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_transfertype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_transfertype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_transfertype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_transfertype.FocusedState.Parent = this.cmb_transfertype;
            this.cmb_transfertype.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_transfertype.ForeColor = System.Drawing.Color.Black;
            this.cmb_transfertype.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_transfertype.HoverState.Parent = this.cmb_transfertype;
            this.cmb_transfertype.ItemHeight = 30;
            this.cmb_transfertype.Items.AddRange(new object[] {
            "پرواز داخلی",
            "پرواز خارجی",
            "قطار",
            "اتوبوس"});
            this.cmb_transfertype.ItemsAppearance.Parent = this.cmb_transfertype;
            this.cmb_transfertype.Location = new System.Drawing.Point(157, 50);
            this.cmb_transfertype.Name = "cmb_transfertype";
            this.cmb_transfertype.ShadowDecoration.Parent = this.cmb_transfertype;
            this.cmb_transfertype.Size = new System.Drawing.Size(142, 36);
            this.cmb_transfertype.StartIndex = 0;
            this.cmb_transfertype.TabIndex = 0;
            this.cmb_transfertype.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmb_transfertype.SelectedIndexChanged += new System.EventHandler(this.cmb_transfertype_SelectedIndexChanged);
            // 
            // cmb_goandgoback
            // 
            this.cmb_goandgoback.BackColor = System.Drawing.Color.Transparent;
            this.cmb_goandgoback.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_goandgoback.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_goandgoback.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_goandgoback.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_goandgoback.FocusedState.Parent = this.cmb_goandgoback;
            this.cmb_goandgoback.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_goandgoback.ForeColor = System.Drawing.Color.Black;
            this.cmb_goandgoback.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_goandgoback.HoverState.Parent = this.cmb_goandgoback;
            this.cmb_goandgoback.ItemHeight = 30;
            this.cmb_goandgoback.Items.AddRange(new object[] {
            "یک طرفه",
            "رفت و برگشت"});
            this.cmb_goandgoback.ItemsAppearance.Parent = this.cmb_goandgoback;
            this.cmb_goandgoback.Location = new System.Drawing.Point(157, 103);
            this.cmb_goandgoback.Name = "cmb_goandgoback";
            this.cmb_goandgoback.ShadowDecoration.Parent = this.cmb_goandgoback;
            this.cmb_goandgoback.Size = new System.Drawing.Size(142, 36);
            this.cmb_goandgoback.StartIndex = 0;
            this.cmb_goandgoback.TabIndex = 2;
            this.cmb_goandgoback.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmb_goandgoback.SelectedIndexChanged += new System.EventHandler(this.cmb_goandgoback_SelectedIndexChanged);
            // 
            // cmb_intflytype
            // 
            this.cmb_intflytype.BackColor = System.Drawing.Color.Transparent;
            this.cmb_intflytype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_intflytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_intflytype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_intflytype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_intflytype.FocusedState.Parent = this.cmb_intflytype;
            this.cmb_intflytype.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_intflytype.ForeColor = System.Drawing.Color.Black;
            this.cmb_intflytype.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_intflytype.HoverState.Parent = this.cmb_intflytype;
            this.cmb_intflytype.ItemHeight = 30;
            this.cmb_intflytype.Items.AddRange(new object[] {
            "اکونومی",
            "بیزینس",
            "فرست کلاس"});
            this.cmb_intflytype.ItemsAppearance.Parent = this.cmb_intflytype;
            this.cmb_intflytype.Location = new System.Drawing.Point(13, 50);
            this.cmb_intflytype.Name = "cmb_intflytype";
            this.cmb_intflytype.ShadowDecoration.Parent = this.cmb_intflytype;
            this.cmb_intflytype.Size = new System.Drawing.Size(138, 36);
            this.cmb_intflytype.StartIndex = 0;
            this.cmb_intflytype.TabIndex = 1;
            this.cmb_intflytype.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cmb_intflytype.Visible = false;
            // 
            // txt_Source
            // 
            this.txt_Source.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Source.DefaultText = "";
            this.txt_Source.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Source.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Source.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Source.DisabledState.Parent = this.txt_Source;
            this.txt_Source.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Source.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Source.FocusedState.Parent = this.txt_Source;
            this.txt_Source.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Source.ForeColor = System.Drawing.Color.Black;
            this.txt_Source.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Source.HoverState.Parent = this.txt_Source;
            this.txt_Source.Location = new System.Drawing.Point(13, 209);
            this.txt_Source.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Source.MaxLength = 40;
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.PasswordChar = '\0';
            this.txt_Source.PlaceholderText = "مبداء (شهر)";
            this.txt_Source.SelectedText = "";
            this.txt_Source.ShadowDecoration.Parent = this.txt_Source;
            this.txt_Source.Size = new System.Drawing.Size(286, 36);
            this.txt_Source.TabIndex = 4;
            this.txt_Source.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Source_KeyPress);
            // 
            // txt_Destination
            // 
            this.txt_Destination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Destination.DefaultText = "";
            this.txt_Destination.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Destination.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Destination.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Destination.DisabledState.Parent = this.txt_Destination;
            this.txt_Destination.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Destination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Destination.FocusedState.Parent = this.txt_Destination;
            this.txt_Destination.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Destination.ForeColor = System.Drawing.Color.Black;
            this.txt_Destination.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Destination.HoverState.Parent = this.txt_Destination;
            this.txt_Destination.Location = new System.Drawing.Point(13, 264);
            this.txt_Destination.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Destination.MaxLength = 40;
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.PasswordChar = '\0';
            this.txt_Destination.PlaceholderText = "مقصد (شهر)";
            this.txt_Destination.SelectedText = "";
            this.txt_Destination.ShadowDecoration.Parent = this.txt_Destination;
            this.txt_Destination.Size = new System.Drawing.Size(286, 36);
            this.txt_Destination.TabIndex = 5;
            this.txt_Destination.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Destination_KeyPress);
            // 
            // cmb_passagetype
            // 
            this.cmb_passagetype.BackColor = System.Drawing.Color.Transparent;
            this.cmb_passagetype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_passagetype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_passagetype.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_passagetype.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_passagetype.FocusedState.Parent = this.cmb_passagetype;
            this.cmb_passagetype.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_passagetype.ForeColor = System.Drawing.Color.Black;
            this.cmb_passagetype.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_passagetype.HoverState.Parent = this.cmb_passagetype;
            this.cmb_passagetype.ItemHeight = 30;
            this.cmb_passagetype.Items.AddRange(new object[] {
            "بزرگسال",
            "کودک",
            "نوزاد"});
            this.cmb_passagetype.ItemsAppearance.Parent = this.cmb_passagetype;
            this.cmb_passagetype.Location = new System.Drawing.Point(157, 156);
            this.cmb_passagetype.Name = "cmb_passagetype";
            this.cmb_passagetype.ShadowDecoration.Parent = this.cmb_passagetype;
            this.cmb_passagetype.Size = new System.Drawing.Size(142, 36);
            this.cmb_passagetype.StartIndex = 0;
            this.cmb_passagetype.TabIndex = 3;
            this.cmb_passagetype.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_backdate
            // 
            this.lbl_backdate.AutoSize = true;
            this.lbl_backdate.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_backdate.ForeColor = System.Drawing.Color.Black;
            this.lbl_backdate.Location = new System.Drawing.Point(210, 374);
            this.lbl_backdate.Name = "lbl_backdate";
            this.lbl_backdate.Size = new System.Drawing.Size(88, 28);
            this.lbl_backdate.TabIndex = 10;
            this.lbl_backdate.Text = "تاریخ برگشت";
            this.lbl_backdate.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(217, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "تاریخ رفت";
            // 
            // dtp_backingdate
            // 
            this.dtp_backingdate.AutoRoundedCorners = true;
            this.dtp_backingdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtp_backingdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtp_backingdate.BorderRadius = 17;
            this.dtp_backingdate.BorderThickness = 2;
            this.dtp_backingdate.CheckedState.Parent = this.dtp_backingdate;
            this.dtp_backingdate.FillColor = System.Drawing.Color.White;
            this.dtp_backingdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_backingdate.ForeColor = System.Drawing.Color.Black;
            this.dtp_backingdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_backingdate.HoverState.Parent = this.dtp_backingdate;
            this.dtp_backingdate.Location = new System.Drawing.Point(13, 370);
            this.dtp_backingdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_backingdate.MinDate = new System.DateTime(2019, 12, 18, 0, 0, 0, 0);
            this.dtp_backingdate.Name = "dtp_backingdate";
            this.dtp_backingdate.ShadowDecoration.Parent = this.dtp_backingdate;
            this.dtp_backingdate.Size = new System.Drawing.Size(191, 36);
            this.dtp_backingdate.TabIndex = 7;
            this.dtp_backingdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_backingdate.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            this.dtp_backingdate.Visible = false;
            // 
            // dtp_goingdate
            // 
            this.dtp_goingdate.AutoRoundedCorners = true;
            this.dtp_goingdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dtp_goingdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.dtp_goingdate.BorderRadius = 17;
            this.dtp_goingdate.BorderThickness = 2;
            this.dtp_goingdate.CheckedState.Parent = this.dtp_goingdate;
            this.dtp_goingdate.FillColor = System.Drawing.Color.White;
            this.dtp_goingdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_goingdate.ForeColor = System.Drawing.Color.Black;
            this.dtp_goingdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_goingdate.HoverState.Parent = this.dtp_goingdate;
            this.dtp_goingdate.Location = new System.Drawing.Point(13, 318);
            this.dtp_goingdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_goingdate.MinDate = new System.DateTime(2019, 12, 18, 0, 0, 0, 0);
            this.dtp_goingdate.Name = "dtp_goingdate";
            this.dtp_goingdate.ShadowDecoration.Parent = this.dtp_goingdate;
            this.dtp_goingdate.Size = new System.Drawing.Size(191, 36);
            this.dtp_goingdate.TabIndex = 6;
            this.dtp_goingdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtp_goingdate.Value = new System.DateTime(2021, 12, 28, 0, 0, 0, 0);
            // 
            // txt_money
            // 
            this.txt_money.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_money.DefaultText = "";
            this.txt_money.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_money.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_money.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_money.DisabledState.Parent = this.txt_money;
            this.txt_money.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_money.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_money.FocusedState.Parent = this.txt_money;
            this.txt_money.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_money.ForeColor = System.Drawing.Color.Black;
            this.txt_money.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_money.HoverState.Parent = this.txt_money;
            this.txt_money.Location = new System.Drawing.Point(64, 431);
            this.txt_money.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_money.MaxLength = 50;
            this.txt_money.Name = "txt_money";
            this.txt_money.PasswordChar = '\0';
            this.txt_money.PlaceholderText = "قیمت";
            this.txt_money.SelectedText = "";
            this.txt_money.ShadowDecoration.Parent = this.txt_money;
            this.txt_money.Size = new System.Drawing.Size(235, 36);
            this.txt_money.TabIndex = 8;
            this.txt_money.TextChanged += new System.EventHandler(this.txt_money_TextChanged);
            this.txt_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_money_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "تومان";
            // 
            // btn_exit
            // 
            this.btn_exit.CheckedState.Parent = this.btn_exit;
            this.btn_exit.CustomImages.Parent = this.btn_exit;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.DisabledState.Parent = this.btn_exit;
            this.btn_exit.FillColor = System.Drawing.Color.White;
            this.btn_exit.Font = new System.Drawing.Font("B Baran", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_exit.ForeColor = System.Drawing.Color.Red;
            this.btn_exit.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_exit.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_exit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_exit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.Location = new System.Drawing.Point(13, 542);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(286, 42);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_sabt
            // 
            this.btn_sabt.CheckedState.Parent = this.btn_sabt;
            this.btn_sabt.CustomImages.Parent = this.btn_sabt;
            this.btn_sabt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sabt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sabt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sabt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sabt.DisabledState.Parent = this.btn_sabt;
            this.btn_sabt.FillColor = System.Drawing.Color.White;
            this.btn_sabt.Font = new System.Drawing.Font("B Baran", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_sabt.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_sabt.HoverState.BorderColor = System.Drawing.Color.DarkGreen;
            this.btn_sabt.HoverState.CustomBorderColor = System.Drawing.Color.DarkGreen;
            this.btn_sabt.HoverState.FillColor = System.Drawing.Color.DarkGreen;
            this.btn_sabt.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_sabt.HoverState.Parent = this.btn_sabt;
            this.btn_sabt.Location = new System.Drawing.Point(15, 492);
            this.btn_sabt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sabt.Name = "btn_sabt";
            this.btn_sabt.ShadowDecoration.Parent = this.btn_sabt;
            this.btn_sabt.Size = new System.Drawing.Size(286, 42);
            this.btn_sabt.TabIndex = 9;
            this.btn_sabt.Text = "ثبت";
            this.btn_sabt.Click += new System.EventHandler(this.btn_sabt_Click);
            // 
            // transferCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(313, 593);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_sabt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_backdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_backingdate);
            this.Controls.Add(this.dtp_goingdate);
            this.Controls.Add(this.txt_money);
            this.Controls.Add(this.txt_Destination);
            this.Controls.Add(this.txt_Source);
            this.Controls.Add(this.cmb_intflytype);
            this.Controls.Add(this.cmb_passagetype);
            this.Controls.Add(this.cmb_goandgoback);
            this.Controls.Add(this.cmb_transfertype);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transferCU";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOrEditTransfer";
            this.Load += new System.EventHandler(this.transferCU_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_transfertype;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_goandgoback;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_intflytype;
        private Guna.UI2.WinForms.Guna2TextBox txt_Source;
        private Guna.UI2.WinForms.Guna2TextBox txt_Destination;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_passagetype;
        private System.Windows.Forms.Label lbl_backdate;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_money;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_sabt;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtp_backingdate;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtp_goingdate;
    }
}