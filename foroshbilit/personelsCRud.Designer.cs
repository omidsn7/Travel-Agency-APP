
namespace foroshbilit
{
    partial class personelsCRud
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_personels = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cms_activedeactive = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.btn_active = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_deactive = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_new = new Guna.UI2.WinForms.Guna2Button();
            this.btn_edit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbx_status = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_code = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personels)).BeginInit();
            this.cms_activedeactive.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_personels);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 333);
            this.panel1.TabIndex = 0;
            // 
            // dgv_personels
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_personels.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_personels.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_personels.BackgroundColor = System.Drawing.Color.White;
            this.dgv_personels.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_personels.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_personels.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_personels.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_personels.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_personels.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_personels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_personels.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_personels.EnableHeadersVisualStyles = false;
            this.dgv_personels.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_personels.Location = new System.Drawing.Point(0, 0);
            this.dgv_personels.Name = "dgv_personels";
            this.dgv_personels.RowHeadersVisible = false;
            this.dgv_personels.RowTemplate.Height = 32;
            this.dgv_personels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_personels.Size = new System.Drawing.Size(992, 333);
            this.dgv_personels.TabIndex = 0;
            this.dgv_personels.TabStop = false;
            this.dgv_personels.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_personels.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_personels.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_personels.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_personels.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_personels.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_personels.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_personels.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_personels.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_personels.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgv_personels.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_personels.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_personels.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_personels.ThemeStyle.ReadOnly = false;
            this.dgv_personels.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_personels.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_personels.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dgv_personels.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_personels.ThemeStyle.RowsStyle.Height = 32;
            this.dgv_personels.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_personels.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_personels.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgv_personels_RowPostPaint);
            // 
            // cms_activedeactive
            // 
            this.cms_activedeactive.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cms_activedeactive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_active,
            this.btn_deactive});
            this.cms_activedeactive.Name = "guna2ContextMenuStrip1";
            this.cms_activedeactive.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cms_activedeactive.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cms_activedeactive.RenderStyle.ColorTable = null;
            this.cms_activedeactive.RenderStyle.RoundedEdges = true;
            this.cms_activedeactive.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cms_activedeactive.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cms_activedeactive.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cms_activedeactive.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cms_activedeactive.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cms_activedeactive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cms_activedeactive.Size = new System.Drawing.Size(152, 52);
            // 
            // btn_active
            // 
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(151, 24);
            this.btn_active.Text = "فعال کردن";
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // btn_deactive
            // 
            this.btn_deactive.Name = "btn_deactive";
            this.btn_deactive.Size = new System.Drawing.Size(151, 24);
            this.btn_deactive.Text = "غیرفعال کردن";
            this.btn_deactive.Click += new System.EventHandler(this.btn_deactive_Click);
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
            this.btn_exit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_exit.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.btn_exit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_exit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_exit.HoverState.Parent = this.btn_exit;
            this.btn_exit.Location = new System.Drawing.Point(21, 7);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.ShadowDecoration.Parent = this.btn_exit;
            this.btn_exit.Size = new System.Drawing.Size(213, 43);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "خروج";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_new
            // 
            this.btn_new.CheckedState.Parent = this.btn_new;
            this.btn_new.CustomImages.Parent = this.btn_new;
            this.btn_new.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_new.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_new.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_new.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_new.DisabledState.Parent = this.btn_new;
            this.btn_new.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_new.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_new.ForeColor = System.Drawing.Color.Black;
            this.btn_new.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_new.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_new.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_new.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_new.HoverState.Parent = this.btn_new;
            this.btn_new.Location = new System.Drawing.Point(756, 7);
            this.btn_new.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_new.Name = "btn_new";
            this.btn_new.ShadowDecoration.Parent = this.btn_new;
            this.btn_new.Size = new System.Drawing.Size(213, 43);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جدید";
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.CheckedState.Parent = this.btn_edit;
            this.btn_edit.CustomImages.Parent = this.btn_edit;
            this.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_edit.DisabledState.Parent = this.btn_edit;
            this.btn_edit.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_edit.ForeColor = System.Drawing.Color.Black;
            this.btn_edit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_edit.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_edit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_edit.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_edit.HoverState.Parent = this.btn_edit;
            this.btn_edit.Location = new System.Drawing.Point(511, 7);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.ShadowDecoration.Parent = this.btn_edit;
            this.btn_edit.Size = new System.Drawing.Size(213, 43);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.CheckedState.Parent = this.btn_delete;
            this.btn_delete.CustomImages.Parent = this.btn_delete;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.DisabledState.Parent = this.btn_delete;
            this.btn_delete.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_delete.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_delete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_delete.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_delete.HoverState.Parent = this.btn_delete;
            this.btn_delete.Location = new System.Drawing.Point(266, 7);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.ShadowDecoration.Parent = this.btn_delete;
            this.btn_delete.Size = new System.Drawing.Size(213, 43);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cbx_status);
            this.panel3.Controls.Add(this.txt_code);
            this.panel3.Controls.Add(this.txt_name);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 333);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(992, 68);
            this.panel3.TabIndex = 2;
            // 
            // cbx_status
            // 
            this.cbx_status.BackColor = System.Drawing.Color.Transparent;
            this.cbx_status.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_status.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_status.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_status.FocusedState.Parent = this.cbx_status;
            this.cbx_status.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbx_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbx_status.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbx_status.HoverState.Parent = this.cbx_status;
            this.cbx_status.ItemHeight = 30;
            this.cbx_status.Items.AddRange(new object[] {
            "فعال",
            "غیر فعال",
            "همه"});
            this.cbx_status.ItemsAppearance.Parent = this.cbx_status;
            this.cbx_status.Location = new System.Drawing.Point(189, 14);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbx_status.ShadowDecoration.Parent = this.cbx_status;
            this.cbx_status.Size = new System.Drawing.Size(109, 36);
            this.cbx_status.TabIndex = 2;
            this.cbx_status.SelectedIndexChanged += new System.EventHandler(this.cbx_status_SelectedIndexChanged);
            // 
            // txt_code
            // 
            this.txt_code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_code.DefaultText = "";
            this.txt_code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_code.DisabledState.Parent = this.txt_code;
            this.txt_code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_code.FocusedState.Parent = this.txt_code;
            this.txt_code.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_code.HoverState.Parent = this.txt_code;
            this.txt_code.Location = new System.Drawing.Point(394, 14);
            this.txt_code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_code.MaxLength = 10;
            this.txt_code.Name = "txt_code";
            this.txt_code.PasswordChar = '\0';
            this.txt_code.PlaceholderText = "";
            this.txt_code.SelectedText = "";
            this.txt_code.ShadowDecoration.Parent = this.txt_code;
            this.txt_code.Size = new System.Drawing.Size(178, 38);
            this.txt_code.TabIndex = 1;
            this.txt_code.TextChanged += new System.EventHandler(this.txt_code_TextChanged);
            this.txt_code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_code_KeyPress);
            // 
            // txt_name
            // 
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultText = "";
            this.txt_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.DisabledState.Parent = this.txt_name;
            this.txt_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.FocusedState.Parent = this.txt_name;
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_name.HoverState.Parent = this.txt_name;
            this.txt_name.Location = new System.Drawing.Point(635, 14);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_name.MaxLength = 40;
            this.txt_name.Name = "txt_name";
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderText = "";
            this.txt_name.SelectedText = "";
            this.txt_name.ShadowDecoration.Parent = this.txt_name;
            this.txt_name.Size = new System.Drawing.Size(230, 38);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txt_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_name_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::foroshbilit.Properties.Resources.icons8_search;
            this.pictureBox1.Location = new System.Drawing.Point(11, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Baran", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(304, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "وضعیت";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Baran", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(578, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 34);
            this.label3.TabIndex = 0;
            this.label3.Text = "کدملی";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Baran", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(870, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام و نام خانوادگی";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_new);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 60);
            this.panel2.TabIndex = 4;
            // 
            // personelsCRud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(992, 462);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "personelsCRud";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ا0";
            this.Load += new System.EventHandler(this.personelsCRud_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_personels)).EndInit();
            this.cms_activedeactive.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_code;
        private Guna.UI2.WinForms.Guna2TextBox txt_name;
        private Guna.UI2.WinForms.Guna2Button btn_new;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_edit;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        public Guna.UI2.WinForms.Guna2DataGridView dgv_personels;
        private Guna.UI2.WinForms.Guna2ComboBox cbx_status;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cms_activedeactive;
        private System.Windows.Forms.ToolStripMenuItem btn_active;
        private System.Windows.Forms.ToolStripMenuItem btn_deactive;
        private System.Windows.Forms.Panel panel2;
    }
}