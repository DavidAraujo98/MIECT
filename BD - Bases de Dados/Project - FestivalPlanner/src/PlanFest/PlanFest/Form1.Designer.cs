using System.Drawing;

namespace PlanFest
{
    partial class PlanFest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanFest));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.server_input = new System.Windows.Forms.TextBox();
            this.server_label = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.server = new System.Windows.Forms.FlowLayoutPanel();
            this.user = new System.Windows.Forms.FlowLayoutPanel();
            this.user_label = new System.Windows.Forms.Label();
            this.user_input = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.FlowLayoutPanel();
            this.password_label = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.form_login = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_connect = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_festivals = new System.Windows.Forms.Button();
            this.btn_concerts = new System.Windows.Forms.Button();
            this.btn_stages = new System.Windows.Forms.Button();
            this.btn_bands = new System.Windows.Forms.Button();
            this.btn_meals = new System.Windows.Forms.Button();
            this.btn_staff = new System.Windows.Forms.Button();
            this.panel_base = new System.Windows.Forms.Panel();
            this.panel_concerts = new System.Windows.Forms.Panel();
            this.textBox_soundckduration = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.dateTimePicker_soundcheck = new System.Windows.Forms.DateTimePicker();
            this.comboBox_bandslist = new System.Windows.Forms.ComboBox();
            this.comboBox_stages = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox_concertduration = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.dateTimePicker_concert = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_saveeditconcert = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.dataGridView_concerts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBox_concertid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBox_stageid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBox_bandid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBox_datebegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBox_concertduration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBox_soundckduration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBox_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBox_lotation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBox_bandname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBox_soundid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addconcert = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.panel_openinglist = new System.Windows.Forms.Panel();
            this.btn_searchfestival = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox_searchbandname = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox_searchpromoteremail = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_searchpromoterphone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_searchpromotername = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_searchndays = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_searchfestivalname = new System.Windows.Forms.TextBox();
            this.gridview_festivals = new System.Windows.Forms.DataGridView();
            this.gridview_festivalid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_datebegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_ndays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_promotername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_promoteremail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_promoterphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridview_bandname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_openfestival = new System.Windows.Forms.Button();
            this.btn_addfestival = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_festival = new System.Windows.Forms.Panel();
            this.manager_type = new System.Windows.Forms.ComboBox();
            this.promoter_type = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.datepicker_proposal = new System.Windows.Forms.DateTimePicker();
            this.textBox_manager_cc = new System.Windows.Forms.TextBox();
            this.textBox_promoter_cc = new System.Windows.Forms.TextBox();
            this.manager_sex = new System.Windows.Forms.Label();
            this.manager_phone = new System.Windows.Forms.Label();
            this.manager_email = new System.Windows.Forms.Label();
            this.manager_name = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.promoter_sex = new System.Windows.Forms.Label();
            this.promoter_phone = new System.Windows.Forms.Label();
            this.promoter_email = new System.Windows.Forms.Label();
            this.promoter_name = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numericUpDown_ticketssold = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_festivalname = new System.Windows.Forms.TextBox();
            this.label_promotername = new System.Windows.Forms.Label();
            this.btn_changefestival = new System.Windows.Forms.Button();
            this.btn_deletefestival = new System.Windows.Forms.Button();
            this.label_festivalid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datepicker_festivalend = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.datepicker_festivalbegin = new System.Windows.Forms.DateTimePicker();
            this.btn_editfestival = new System.Windows.Forms.Button();
            this.server.SuspendLayout();
            this.user.SuspendLayout();
            this.password.SuspendLayout();
            this.form_login.SuspendLayout();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel_base.SuspendLayout();
            this.panel_concerts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_concerts)).BeginInit();
            this.panel_openinglist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_festivals)).BeginInit();
            this.panel_festival.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ticketssold)).BeginInit();
            this.SuspendLayout();
            // 
            // server_input
            // 
            this.server_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_input.Location = new System.Drawing.Point(3, 23);
            this.server_input.Name = "server_input";
            this.server_input.Size = new System.Drawing.Size(259, 22);
            this.server_input.TabIndex = 0;
            // 
            // server_label
            // 
            this.server_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.server_label.AutoSize = true;
            this.server_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.server_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(128)))));
            this.server_label.Location = new System.Drawing.Point(3, 0);
            this.server_label.Name = "server_label";
            this.server_label.Size = new System.Drawing.Size(259, 20);
            this.server_label.TabIndex = 1;
            this.server_label.Text = "Server name";
            this.server_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // server
            // 
            this.server.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.server.AutoSize = true;
            this.server.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.server.Controls.Add(this.server_label);
            this.server.Controls.Add(this.server_input);
            this.server.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.server.Location = new System.Drawing.Point(40, 48);
            this.server.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(265, 48);
            this.server.TabIndex = 2;
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user.AutoSize = true;
            this.user.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.user.Controls.Add(this.user_label);
            this.user.Controls.Add(this.user_input);
            this.user.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.user.Location = new System.Drawing.Point(40, 112);
            this.user.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(265, 48);
            this.user.TabIndex = 3;
            // 
            // user_label
            // 
            this.user_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(128)))));
            this.user_label.Location = new System.Drawing.Point(3, 0);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(259, 20);
            this.user_label.TabIndex = 1;
            this.user_label.Text = "Login";
            this.user_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // user_input
            // 
            this.user_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_input.Location = new System.Drawing.Point(3, 23);
            this.user_input.Name = "user_input";
            this.user_input.Size = new System.Drawing.Size(259, 22);
            this.user_input.TabIndex = 0;
            // 
            // password
            // 
            this.password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password.AutoSize = true;
            this.password.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.password.Controls.Add(this.password_label);
            this.password.Controls.Add(this.password_input);
            this.password.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.password.Location = new System.Drawing.Point(40, 176);
            this.password.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(265, 48);
            this.password.TabIndex = 4;
            // 
            // password_label
            // 
            this.password_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(50)))), ((int)(((byte)(128)))));
            this.password_label.Location = new System.Drawing.Point(3, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(259, 20);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            this.password_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // password_input
            // 
            this.password_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_input.Location = new System.Drawing.Point(3, 23);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '●';
            this.password_input.Size = new System.Drawing.Size(259, 22);
            this.password_input.TabIndex = 0;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // form_login
            // 
            this.form_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.form_login.AutoSize = true;
            this.form_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.form_login.BackColor = System.Drawing.Color.White;
            this.form_login.Controls.Add(this.server);
            this.form_login.Controls.Add(this.user);
            this.form_login.Controls.Add(this.password);
            this.form_login.Controls.Add(this.btn_connect);
            this.form_login.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.form_login.Location = new System.Drawing.Point(273, 120);
            this.form_login.Margin = new System.Windows.Forms.Padding(0);
            this.form_login.Name = "form_login";
            this.form_login.Padding = new System.Windows.Forms.Padding(40);
            this.form_login.Size = new System.Drawing.Size(345, 311);
            this.form_login.TabIndex = 5;
            // 
            // btn_connect
            // 
            this.btn_connect.AutoSize = true;
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_connect.FlatAppearance.BorderSize = 0;
            this.btn_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_connect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Location = new System.Drawing.Point(40, 248);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(0, 16, 0, 0);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(265, 23);
            this.btn_connect.TabIndex = 5;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menu.Controls.Add(this.logo);
            this.menu.Controls.Add(this.btn_festivals);
            this.menu.Controls.Add(this.btn_concerts);
            this.menu.Controls.Add(this.btn_stages);
            this.menu.Controls.Add(this.btn_bands);
            this.menu.Controls.Add(this.btn_meals);
            this.menu.Controls.Add(this.btn_staff);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(173, 542);
            this.menu.TabIndex = 6;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Margin = new System.Windows.Forms.Padding(0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(173, 75);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // btn_festivals
            // 
            this.btn_festivals.AutoSize = true;
            this.btn_festivals.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_festivals.Enabled = false;
            this.btn_festivals.FlatAppearance.BorderSize = 0;
            this.btn_festivals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_festivals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_festivals.ForeColor = System.Drawing.Color.Magenta;
            this.btn_festivals.Location = new System.Drawing.Point(0, 125);
            this.btn_festivals.Margin = new System.Windows.Forms.Padding(0, 50, 0, 3);
            this.btn_festivals.Name = "btn_festivals";
            this.btn_festivals.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_festivals.Size = new System.Drawing.Size(173, 50);
            this.btn_festivals.TabIndex = 1;
            this.btn_festivals.Text = "Festivals";
            this.btn_festivals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_festivals.UseVisualStyleBackColor = false;
            this.btn_festivals.Click += new System.EventHandler(this.btn_festivals_Click);
            // 
            // btn_concerts
            // 
            this.btn_concerts.AutoSize = true;
            this.btn_concerts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_concerts.Enabled = false;
            this.btn_concerts.FlatAppearance.BorderSize = 0;
            this.btn_concerts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_concerts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concerts.ForeColor = System.Drawing.Color.Magenta;
            this.btn_concerts.Location = new System.Drawing.Point(0, 178);
            this.btn_concerts.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_concerts.Name = "btn_concerts";
            this.btn_concerts.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_concerts.Size = new System.Drawing.Size(173, 50);
            this.btn_concerts.TabIndex = 2;
            this.btn_concerts.Text = "Concerts";
            this.btn_concerts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_concerts.UseVisualStyleBackColor = false;
            this.btn_concerts.Click += new System.EventHandler(this.btn_concerts_Click);
            // 
            // btn_stages
            // 
            this.btn_stages.AutoSize = true;
            this.btn_stages.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_stages.Enabled = false;
            this.btn_stages.FlatAppearance.BorderSize = 0;
            this.btn_stages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stages.ForeColor = System.Drawing.Color.Magenta;
            this.btn_stages.Location = new System.Drawing.Point(0, 231);
            this.btn_stages.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_stages.Name = "btn_stages";
            this.btn_stages.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_stages.Size = new System.Drawing.Size(173, 50);
            this.btn_stages.TabIndex = 3;
            this.btn_stages.Text = "Stages";
            this.btn_stages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stages.UseVisualStyleBackColor = false;
            this.btn_stages.Click += new System.EventHandler(this.btn_stages_Click);
            // 
            // btn_bands
            // 
            this.btn_bands.AutoSize = true;
            this.btn_bands.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_bands.Enabled = false;
            this.btn_bands.FlatAppearance.BorderSize = 0;
            this.btn_bands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bands.ForeColor = System.Drawing.Color.Magenta;
            this.btn_bands.Location = new System.Drawing.Point(0, 284);
            this.btn_bands.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_bands.Name = "btn_bands";
            this.btn_bands.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_bands.Size = new System.Drawing.Size(173, 50);
            this.btn_bands.TabIndex = 4;
            this.btn_bands.Text = "Bands";
            this.btn_bands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bands.UseVisualStyleBackColor = false;
            this.btn_bands.Click += new System.EventHandler(this.btn_bands_Click);
            // 
            // btn_meals
            // 
            this.btn_meals.AutoSize = true;
            this.btn_meals.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_meals.Enabled = false;
            this.btn_meals.FlatAppearance.BorderSize = 0;
            this.btn_meals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_meals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_meals.ForeColor = System.Drawing.Color.Magenta;
            this.btn_meals.Location = new System.Drawing.Point(0, 337);
            this.btn_meals.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_meals.Name = "btn_meals";
            this.btn_meals.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_meals.Size = new System.Drawing.Size(173, 50);
            this.btn_meals.TabIndex = 5;
            this.btn_meals.Text = "Meals";
            this.btn_meals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_meals.UseVisualStyleBackColor = false;
            this.btn_meals.Click += new System.EventHandler(this.btn_meals_Click);
            // 
            // btn_staff
            // 
            this.btn_staff.AutoSize = true;
            this.btn_staff.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_staff.Enabled = false;
            this.btn_staff.FlatAppearance.BorderSize = 0;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_staff.ForeColor = System.Drawing.Color.Magenta;
            this.btn_staff.Location = new System.Drawing.Point(0, 390);
            this.btn_staff.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.btn_staff.Size = new System.Drawing.Size(173, 50);
            this.btn_staff.TabIndex = 6;
            this.btn_staff.Text = "Staff";
            this.btn_staff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_staff.UseVisualStyleBackColor = false;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // panel_base
            // 
            this.panel_base.Controls.Add(this.menu);
            this.panel_base.Controls.Add(this.panel_concerts);
            this.panel_base.Controls.Add(this.panel_openinglist);
            this.panel_base.Controls.Add(this.panel_festival);
            this.panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_base.Location = new System.Drawing.Point(0, 0);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(910, 542);
            this.panel_base.TabIndex = 7;
            // 
            // panel_concerts
            // 
            this.panel_concerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_concerts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_concerts.Controls.Add(this.textBox_soundckduration);
            this.panel_concerts.Controls.Add(this.label34);
            this.panel_concerts.Controls.Add(this.label32);
            this.panel_concerts.Controls.Add(this.dateTimePicker_soundcheck);
            this.panel_concerts.Controls.Add(this.comboBox_bandslist);
            this.panel_concerts.Controls.Add(this.comboBox_stages);
            this.panel_concerts.Controls.Add(this.label31);
            this.panel_concerts.Controls.Add(this.textBox_concertduration);
            this.panel_concerts.Controls.Add(this.label30);
            this.panel_concerts.Controls.Add(this.label29);
            this.panel_concerts.Controls.Add(this.label28);
            this.panel_concerts.Controls.Add(this.dateTimePicker_concert);
            this.panel_concerts.Controls.Add(this.button1);
            this.panel_concerts.Controls.Add(this.btn_saveeditconcert);
            this.panel_concerts.Controls.Add(this.label33);
            this.panel_concerts.Controls.Add(this.dataGridView_concerts);
            this.panel_concerts.Controls.Add(this.btn_addconcert);
            this.panel_concerts.Controls.Add(this.label35);
            this.panel_concerts.Location = new System.Drawing.Point(176, 0);
            this.panel_concerts.Name = "panel_concerts";
            this.panel_concerts.Size = new System.Drawing.Size(734, 542);
            this.panel_concerts.TabIndex = 42;
            this.panel_concerts.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_concerts_Paint);
            // 
            // textBox_soundckduration
            // 
            this.textBox_soundckduration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_soundckduration.Location = new System.Drawing.Point(491, 423);
            this.textBox_soundckduration.Name = "textBox_soundckduration";
            this.textBox_soundckduration.Size = new System.Drawing.Size(211, 20);
            this.textBox_soundckduration.TabIndex = 42;
            // 
            // label34
            // 
            this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label34.AutoSize = true;
            this.label34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label34.Location = new System.Drawing.Point(490, 404);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(109, 13);
            this.label34.TabIndex = 41;
            this.label34.Text = "Soundcheck duration";
            this.label34.UseWaitCursor = true;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label32.Location = new System.Drawing.Point(228, 400);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(114, 13);
            this.label32.TabIndex = 40;
            this.label32.Text = "SoundCheck Datetime";
            this.label32.UseWaitCursor = true;
            // 
            // dateTimePicker_soundcheck
            // 
            this.dateTimePicker_soundcheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_soundcheck.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateTimePicker_soundcheck.Location = new System.Drawing.Point(231, 420);
            this.dateTimePicker_soundcheck.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dateTimePicker_soundcheck.Name = "dateTimePicker_soundcheck";
            this.dateTimePicker_soundcheck.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker_soundcheck.TabIndex = 39;
            this.dateTimePicker_soundcheck.UseWaitCursor = true;
            // 
            // comboBox_bandslist
            // 
            this.comboBox_bandslist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_bandslist.FormattingEnabled = true;
            this.comboBox_bandslist.Location = new System.Drawing.Point(491, 365);
            this.comboBox_bandslist.Name = "comboBox_bandslist";
            this.comboBox_bandslist.Size = new System.Drawing.Size(211, 21);
            this.comboBox_bandslist.TabIndex = 38;
            // 
            // comboBox_stages
            // 
            this.comboBox_stages.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.comboBox_stages.FormattingEnabled = true;
            this.comboBox_stages.Location = new System.Drawing.Point(231, 365);
            this.comboBox_stages.Name = "comboBox_stages";
            this.comboBox_stages.Size = new System.Drawing.Size(211, 21);
            this.comboBox_stages.TabIndex = 37;
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label31.Location = new System.Drawing.Point(488, 346);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(32, 13);
            this.label31.TabIndex = 36;
            this.label31.Text = "Band";
            this.label31.UseWaitCursor = true;
            // 
            // textBox_concertduration
            // 
            this.textBox_concertduration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox_concertduration.Location = new System.Drawing.Point(20, 419);
            this.textBox_concertduration.Name = "textBox_concertduration";
            this.textBox_concertduration.Size = new System.Drawing.Size(170, 20);
            this.textBox_concertduration.TabIndex = 35;
            // 
            // label30
            // 
            this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label30.Location = new System.Drawing.Point(19, 400);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(85, 13);
            this.label30.TabIndex = 34;
            this.label30.Text = "Concert duration";
            this.label30.UseWaitCursor = true;
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label29.Location = new System.Drawing.Point(228, 346);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(35, 13);
            this.label29.TabIndex = 32;
            this.label29.Text = "Stage";
            this.label29.UseWaitCursor = true;
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label28.Location = new System.Drawing.Point(17, 346);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(55, 13);
            this.label28.TabIndex = 31;
            this.label28.Text = "Start Date";
            this.label28.UseWaitCursor = true;
            // 
            // dateTimePicker_concert
            // 
            this.dateTimePicker_concert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePicker_concert.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dateTimePicker_concert.Location = new System.Drawing.Point(20, 368);
            this.dateTimePicker_concert.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.dateTimePicker_concert.Name = "dateTimePicker_concert";
            this.dateTimePicker_concert.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker_concert.TabIndex = 30;
            this.dateTimePicker_concert.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(598, 494);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 30);
            this.button1.TabIndex = 29;
            this.button1.Text = "Delete Festival";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_saveeditconcert
            // 
            this.btn_saveeditconcert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_saveeditconcert.AutoSize = true;
            this.btn_saveeditconcert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_saveeditconcert.Enabled = false;
            this.btn_saveeditconcert.FlatAppearance.BorderSize = 0;
            this.btn_saveeditconcert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveeditconcert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_saveeditconcert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_saveeditconcert.Location = new System.Drawing.Point(22, 458);
            this.btn_saveeditconcert.Name = "btn_saveeditconcert";
            this.btn_saveeditconcert.Size = new System.Drawing.Size(168, 23);
            this.btn_saveeditconcert.TabIndex = 28;
            this.btn_saveeditconcert.Text = "Save";
            this.btn_saveeditconcert.UseVisualStyleBackColor = false;
            this.btn_saveeditconcert.Click += new System.EventHandler(this.btn_saveeditconcert_Click);
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label33.Location = new System.Drawing.Point(16, 317);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(37, 20);
            this.label33.TabIndex = 17;
            this.label33.Text = "Edit";
            this.label33.UseWaitCursor = true;
            // 
            // dataGridView_concerts
            // 
            this.dataGridView_concerts.AllowUserToAddRows = false;
            this.dataGridView_concerts.AllowUserToDeleteRows = false;
            this.dataGridView_concerts.AllowUserToResizeRows = false;
            this.dataGridView_concerts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_concerts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_concerts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_concerts.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView_concerts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_concerts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_concerts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBox_concertid,
            this.dataGridViewTextBox_stageid,
            this.dataGridViewTextBox_bandid,
            this.dataGridViewTextBox_datebegin,
            this.dataGridViewTextBox_concertduration,
            this.dataGridViewTextBox_soundckduration,
            this.dataGridViewTextBox_address,
            this.dataGridViewTextBox_lotation,
            this.dataGridViewTextBox_bandname,
            this.dataGridViewTextBox_soundid});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_concerts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_concerts.Location = new System.Drawing.Point(17, 78);
            this.dataGridView_concerts.MultiSelect = false;
            this.dataGridView_concerts.Name = "dataGridView_concerts";
            this.dataGridView_concerts.ReadOnly = true;
            this.dataGridView_concerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_concerts.Size = new System.Drawing.Size(705, 235);
            this.dataGridView_concerts.TabIndex = 10;
            this.dataGridView_concerts.Click += new System.EventHandler(this.loadEditors);
            // 
            // dataGridViewTextBox_concertid
            // 
            this.dataGridViewTextBox_concertid.HeaderText = "Concert ID";
            this.dataGridViewTextBox_concertid.Name = "dataGridViewTextBox_concertid";
            this.dataGridViewTextBox_concertid.ReadOnly = true;
            this.dataGridViewTextBox_concertid.Visible = false;
            // 
            // dataGridViewTextBox_stageid
            // 
            this.dataGridViewTextBox_stageid.HeaderText = "Stage ID";
            this.dataGridViewTextBox_stageid.Name = "dataGridViewTextBox_stageid";
            this.dataGridViewTextBox_stageid.ReadOnly = true;
            this.dataGridViewTextBox_stageid.Visible = false;
            // 
            // dataGridViewTextBox_bandid
            // 
            this.dataGridViewTextBox_bandid.HeaderText = "Band ID";
            this.dataGridViewTextBox_bandid.Name = "dataGridViewTextBox_bandid";
            this.dataGridViewTextBox_bandid.ReadOnly = true;
            this.dataGridViewTextBox_bandid.Visible = false;
            // 
            // dataGridViewTextBox_datebegin
            // 
            this.dataGridViewTextBox_datebegin.HeaderText = "Date";
            this.dataGridViewTextBox_datebegin.Name = "dataGridViewTextBox_datebegin";
            this.dataGridViewTextBox_datebegin.ReadOnly = true;
            // 
            // dataGridViewTextBox_concertduration
            // 
            this.dataGridViewTextBox_concertduration.HeaderText = "Concert Duration";
            this.dataGridViewTextBox_concertduration.Name = "dataGridViewTextBox_concertduration";
            this.dataGridViewTextBox_concertduration.ReadOnly = true;
            // 
            // dataGridViewTextBox_soundckduration
            // 
            this.dataGridViewTextBox_soundckduration.HeaderText = "SoundCheck duration";
            this.dataGridViewTextBox_soundckduration.Name = "dataGridViewTextBox_soundckduration";
            this.dataGridViewTextBox_soundckduration.ReadOnly = true;
            // 
            // dataGridViewTextBox_address
            // 
            this.dataGridViewTextBox_address.HeaderText = "Address location";
            this.dataGridViewTextBox_address.Name = "dataGridViewTextBox_address";
            this.dataGridViewTextBox_address.ReadOnly = true;
            // 
            // dataGridViewTextBox_lotation
            // 
            this.dataGridViewTextBox_lotation.HeaderText = "Lotation";
            this.dataGridViewTextBox_lotation.Name = "dataGridViewTextBox_lotation";
            this.dataGridViewTextBox_lotation.ReadOnly = true;
            // 
            // dataGridViewTextBox_bandname
            // 
            this.dataGridViewTextBox_bandname.HeaderText = "Band";
            this.dataGridViewTextBox_bandname.Name = "dataGridViewTextBox_bandname";
            this.dataGridViewTextBox_bandname.ReadOnly = true;
            // 
            // dataGridViewTextBox_soundid
            // 
            this.dataGridViewTextBox_soundid.HeaderText = "SoundCk_id";
            this.dataGridViewTextBox_soundid.Name = "dataGridViewTextBox_soundid";
            this.dataGridViewTextBox_soundid.ReadOnly = true;
            this.dataGridViewTextBox_soundid.Visible = false;
            // 
            // btn_addconcert
            // 
            this.btn_addconcert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addconcert.AutoSize = true;
            this.btn_addconcert.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_addconcert.FlatAppearance.BorderSize = 0;
            this.btn_addconcert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addconcert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addconcert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_addconcert.Location = new System.Drawing.Point(405, 494);
            this.btn_addconcert.Name = "btn_addconcert";
            this.btn_addconcert.Size = new System.Drawing.Size(182, 30);
            this.btn_addconcert.TabIndex = 8;
            this.btn_addconcert.Text = "Add Concert";
            this.btn_addconcert.UseVisualStyleBackColor = false;
            this.btn_addconcert.Click += new System.EventHandler(this.btn_addconcert_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label35.Location = new System.Drawing.Point(15, 25);
            this.label35.Margin = new System.Windows.Forms.Padding(3);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(131, 25);
            this.label35.TabIndex = 9;
            this.label35.Text = "Concerts list";
            // 
            // panel_openinglist
            // 
            this.panel_openinglist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_openinglist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_openinglist.Controls.Add(this.btn_searchfestival);
            this.panel_openinglist.Controls.Add(this.label27);
            this.panel_openinglist.Controls.Add(this.textBox_searchbandname);
            this.panel_openinglist.Controls.Add(this.label26);
            this.panel_openinglist.Controls.Add(this.textBox_searchpromoteremail);
            this.panel_openinglist.Controls.Add(this.label16);
            this.panel_openinglist.Controls.Add(this.textBox_searchpromoterphone);
            this.panel_openinglist.Controls.Add(this.label15);
            this.panel_openinglist.Controls.Add(this.textBox_searchpromotername);
            this.panel_openinglist.Controls.Add(this.label14);
            this.panel_openinglist.Controls.Add(this.textBox_searchndays);
            this.panel_openinglist.Controls.Add(this.label12);
            this.panel_openinglist.Controls.Add(this.label13);
            this.panel_openinglist.Controls.Add(this.textBox_searchfestivalname);
            this.panel_openinglist.Controls.Add(this.gridview_festivals);
            this.panel_openinglist.Controls.Add(this.btn_openfestival);
            this.panel_openinglist.Controls.Add(this.btn_addfestival);
            this.panel_openinglist.Controls.Add(this.label1);
            this.panel_openinglist.Location = new System.Drawing.Point(176, 6);
            this.panel_openinglist.Name = "panel_openinglist";
            this.panel_openinglist.Size = new System.Drawing.Size(734, 536);
            this.panel_openinglist.TabIndex = 41;
            // 
            // btn_searchfestival
            // 
            this.btn_searchfestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_searchfestival.AutoSize = true;
            this.btn_searchfestival.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_searchfestival.FlatAppearance.BorderSize = 0;
            this.btn_searchfestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_searchfestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchfestival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_searchfestival.Location = new System.Drawing.Point(607, 429);
            this.btn_searchfestival.Name = "btn_searchfestival";
            this.btn_searchfestival.Size = new System.Drawing.Size(121, 26);
            this.btn_searchfestival.TabIndex = 28;
            this.btn_searchfestival.Text = "Filter";
            this.btn_searchfestival.UseVisualStyleBackColor = false;
            this.btn_searchfestival.Click += new System.EventHandler(this.btn_searchfestival_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(19, 436);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(61, 13);
            this.label27.TabIndex = 27;
            this.label27.Text = "Band name";
            // 
            // textBox_searchbandname
            // 
            this.textBox_searchbandname.Location = new System.Drawing.Point(103, 431);
            this.textBox_searchbandname.Name = "textBox_searchbandname";
            this.textBox_searchbandname.Size = new System.Drawing.Size(483, 20);
            this.textBox_searchbandname.TabIndex = 26;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(19, 363);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(76, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "Promoter email";
            // 
            // textBox_searchpromoteremail
            // 
            this.textBox_searchpromoteremail.Location = new System.Drawing.Point(103, 360);
            this.textBox_searchpromoteremail.Name = "textBox_searchpromoteremail";
            this.textBox_searchpromoteremail.Size = new System.Drawing.Size(324, 20);
            this.textBox_searchpromoteremail.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(433, 363);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Promoter phone number";
            // 
            // textBox_searchpromoterphone
            // 
            this.textBox_searchpromoterphone.Location = new System.Drawing.Point(559, 360);
            this.textBox_searchpromoterphone.Name = "textBox_searchpromoterphone";
            this.textBox_searchpromoterphone.Size = new System.Drawing.Size(163, 20);
            this.textBox_searchpromoterphone.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 328);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Promoter name";
            // 
            // textBox_searchpromotername
            // 
            this.textBox_searchpromotername.Location = new System.Drawing.Point(105, 323);
            this.textBox_searchpromotername.Name = "textBox_searchpromotername";
            this.textBox_searchpromotername.Size = new System.Drawing.Size(619, 20);
            this.textBox_searchpromotername.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(473, 398);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Number of days";
            // 
            // textBox_searchndays
            // 
            this.textBox_searchndays.Location = new System.Drawing.Point(559, 393);
            this.textBox_searchndays.Name = "textBox_searchndays";
            this.textBox_searchndays.Size = new System.Drawing.Size(163, 20);
            this.textBox_searchndays.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label12.Location = new System.Drawing.Point(16, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Search by";
            this.label12.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 400);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Festival name";
            // 
            // textBox_searchfestivalname
            // 
            this.textBox_searchfestivalname.Location = new System.Drawing.Point(103, 395);
            this.textBox_searchfestivalname.Name = "textBox_searchfestivalname";
            this.textBox_searchfestivalname.Size = new System.Drawing.Size(364, 20);
            this.textBox_searchfestivalname.TabIndex = 15;
            // 
            // gridview_festivals
            // 
            this.gridview_festivals.AllowUserToAddRows = false;
            this.gridview_festivals.AllowUserToDeleteRows = false;
            this.gridview_festivals.AllowUserToResizeRows = false;
            this.gridview_festivals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridview_festivals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridview_festivals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridview_festivals.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.gridview_festivals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridview_festivals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview_festivals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridview_festivalid,
            this.gridview_name,
            this.gridview_datebegin,
            this.gridview_ndays,
            this.gridview_promotername,
            this.gridview_promoteremail,
            this.gridview_promoterphone,
            this.gridview_bandname});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridview_festivals.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridview_festivals.Location = new System.Drawing.Point(17, 78);
            this.gridview_festivals.MultiSelect = false;
            this.gridview_festivals.Name = "gridview_festivals";
            this.gridview_festivals.ReadOnly = true;
            this.gridview_festivals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview_festivals.Size = new System.Drawing.Size(705, 197);
            this.gridview_festivals.TabIndex = 10;
            this.gridview_festivals.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridview_festivals_SelectChange);
            // 
            // gridview_festivalid
            // 
            this.gridview_festivalid.FillWeight = 1F;
            this.gridview_festivalid.HeaderText = "Festival ID";
            this.gridview_festivalid.MinimumWidth = 2;
            this.gridview_festivalid.Name = "gridview_festivalid";
            this.gridview_festivalid.ReadOnly = true;
            this.gridview_festivalid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridview_festivalid.Visible = false;
            // 
            // gridview_name
            // 
            this.gridview_name.HeaderText = "Name";
            this.gridview_name.Name = "gridview_name";
            this.gridview_name.ReadOnly = true;
            // 
            // gridview_datebegin
            // 
            this.gridview_datebegin.HeaderText = "Date Beginning";
            this.gridview_datebegin.Name = "gridview_datebegin";
            this.gridview_datebegin.ReadOnly = true;
            // 
            // gridview_ndays
            // 
            this.gridview_ndays.HeaderText = "Number of Days";
            this.gridview_ndays.Name = "gridview_ndays";
            this.gridview_ndays.ReadOnly = true;
            // 
            // gridview_promotername
            // 
            this.gridview_promotername.HeaderText = "Promoter Name";
            this.gridview_promotername.Name = "gridview_promotername";
            this.gridview_promotername.ReadOnly = true;
            // 
            // gridview_promoteremail
            // 
            this.gridview_promoteremail.HeaderText = "Promoter Email";
            this.gridview_promoteremail.Name = "gridview_promoteremail";
            this.gridview_promoteremail.ReadOnly = true;
            // 
            // gridview_promoterphone
            // 
            this.gridview_promoterphone.HeaderText = "Promoter Phone Number";
            this.gridview_promoterphone.Name = "gridview_promoterphone";
            this.gridview_promoterphone.ReadOnly = true;
            // 
            // gridview_bandname
            // 
            this.gridview_bandname.HeaderText = "Band Name";
            this.gridview_bandname.Name = "gridview_bandname";
            this.gridview_bandname.ReadOnly = true;
            // 
            // btn_openfestival
            // 
            this.btn_openfestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_openfestival.AutoSize = true;
            this.btn_openfestival.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_openfestival.Enabled = false;
            this.btn_openfestival.FlatAppearance.BorderSize = 0;
            this.btn_openfestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openfestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openfestival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_openfestival.Location = new System.Drawing.Point(358, 495);
            this.btn_openfestival.Name = "btn_openfestival";
            this.btn_openfestival.Size = new System.Drawing.Size(182, 30);
            this.btn_openfestival.TabIndex = 7;
            this.btn_openfestival.Text = "Open Festival";
            this.btn_openfestival.UseVisualStyleBackColor = false;
            this.btn_openfestival.Click += new System.EventHandler(this.btn_openfestival_Click);
            // 
            // btn_addfestival
            // 
            this.btn_addfestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addfestival.AutoSize = true;
            this.btn_addfestival.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_addfestival.FlatAppearance.BorderSize = 0;
            this.btn_addfestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addfestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addfestival.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.btn_addfestival.Location = new System.Drawing.Point(546, 495);
            this.btn_addfestival.Name = "btn_addfestival";
            this.btn_addfestival.Size = new System.Drawing.Size(182, 30);
            this.btn_addfestival.TabIndex = 8;
            this.btn_addfestival.Text = "Add Festival";
            this.btn_addfestival.UseVisualStyleBackColor = false;
            this.btn_addfestival.Click += new System.EventHandler(this.btn_addfestival_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label1.Location = new System.Drawing.Point(15, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Festivals list";
            // 
            // panel_festival
            // 
            this.panel_festival.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_festival.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_festival.Controls.Add(this.manager_type);
            this.panel_festival.Controls.Add(this.promoter_type);
            this.panel_festival.Controls.Add(this.label11);
            this.panel_festival.Controls.Add(this.datepicker_proposal);
            this.panel_festival.Controls.Add(this.textBox_manager_cc);
            this.panel_festival.Controls.Add(this.textBox_promoter_cc);
            this.panel_festival.Controls.Add(this.manager_sex);
            this.panel_festival.Controls.Add(this.manager_phone);
            this.panel_festival.Controls.Add(this.manager_email);
            this.panel_festival.Controls.Add(this.manager_name);
            this.panel_festival.Controls.Add(this.label20);
            this.panel_festival.Controls.Add(this.label21);
            this.panel_festival.Controls.Add(this.label22);
            this.panel_festival.Controls.Add(this.label23);
            this.panel_festival.Controls.Add(this.label24);
            this.panel_festival.Controls.Add(this.label25);
            this.panel_festival.Controls.Add(this.promoter_sex);
            this.panel_festival.Controls.Add(this.promoter_phone);
            this.panel_festival.Controls.Add(this.promoter_email);
            this.panel_festival.Controls.Add(this.promoter_name);
            this.panel_festival.Controls.Add(this.label19);
            this.panel_festival.Controls.Add(this.numericUpDown_ticketssold);
            this.panel_festival.Controls.Add(this.label18);
            this.panel_festival.Controls.Add(this.label17);
            this.panel_festival.Controls.Add(this.label10);
            this.panel_festival.Controls.Add(this.label9);
            this.panel_festival.Controls.Add(this.label8);
            this.panel_festival.Controls.Add(this.label7);
            this.panel_festival.Controls.Add(this.label6);
            this.panel_festival.Controls.Add(this.label5);
            this.panel_festival.Controls.Add(this.label4);
            this.panel_festival.Controls.Add(this.textBox_festivalname);
            this.panel_festival.Controls.Add(this.label_promotername);
            this.panel_festival.Controls.Add(this.btn_changefestival);
            this.panel_festival.Controls.Add(this.btn_deletefestival);
            this.panel_festival.Controls.Add(this.label_festivalid);
            this.panel_festival.Controls.Add(this.label3);
            this.panel_festival.Controls.Add(this.datepicker_festivalend);
            this.panel_festival.Controls.Add(this.label2);
            this.panel_festival.Controls.Add(this.datepicker_festivalbegin);
            this.panel_festival.Controls.Add(this.btn_editfestival);
            this.panel_festival.Location = new System.Drawing.Point(176, 3);
            this.panel_festival.Name = "panel_festival";
            this.panel_festival.Size = new System.Drawing.Size(734, 539);
            this.panel_festival.TabIndex = 10;
            this.panel_festival.UseWaitCursor = true;
            // 
            // manager_type
            // 
            this.manager_type.Enabled = false;
            this.manager_type.FormattingEnabled = true;
            this.manager_type.Items.AddRange(new object[] {
            "Nacional",
            "Internacional"});
            this.manager_type.Location = new System.Drawing.Point(405, 318);
            this.manager_type.Name = "manager_type";
            this.manager_type.Size = new System.Drawing.Size(158, 21);
            this.manager_type.TabIndex = 66;
            this.manager_type.UseWaitCursor = true;
            // 
            // promoter_type
            // 
            this.promoter_type.Enabled = false;
            this.promoter_type.FormattingEnabled = true;
            this.promoter_type.Items.AddRange(new object[] {
            "Nacional",
            "Internacional"});
            this.promoter_type.Location = new System.Drawing.Point(51, 318);
            this.promoter_type.Name = "promoter_type";
            this.promoter_type.Size = new System.Drawing.Size(158, 21);
            this.promoter_type.TabIndex = 65;
            this.promoter_type.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(335, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Proposal Date";
            this.label11.UseWaitCursor = true;
            // 
            // datepicker_proposal
            // 
            this.datepicker_proposal.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datepicker_proposal.Enabled = false;
            this.datepicker_proposal.Location = new System.Drawing.Point(338, 168);
            this.datepicker_proposal.Name = "datepicker_proposal";
            this.datepicker_proposal.Size = new System.Drawing.Size(133, 20);
            this.datepicker_proposal.TabIndex = 61;
            this.datepicker_proposal.UseWaitCursor = true;
            // 
            // textBox_manager_cc
            // 
            this.textBox_manager_cc.Enabled = false;
            this.textBox_manager_cc.Location = new System.Drawing.Point(461, 372);
            this.textBox_manager_cc.Name = "textBox_manager_cc";
            this.textBox_manager_cc.Size = new System.Drawing.Size(158, 20);
            this.textBox_manager_cc.TabIndex = 60;
            this.textBox_manager_cc.UseWaitCursor = true;
            // 
            // textBox_promoter_cc
            // 
            this.textBox_promoter_cc.Enabled = false;
            this.textBox_promoter_cc.Location = new System.Drawing.Point(123, 372);
            this.textBox_promoter_cc.Name = "textBox_promoter_cc";
            this.textBox_promoter_cc.Size = new System.Drawing.Size(158, 20);
            this.textBox_promoter_cc.TabIndex = 59;
            this.textBox_promoter_cc.UseWaitCursor = true;
            // 
            // manager_sex
            // 
            this.manager_sex.AutoSize = true;
            this.manager_sex.Enabled = false;
            this.manager_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manager_sex.Location = new System.Drawing.Point(386, 347);
            this.manager_sex.Name = "manager_sex";
            this.manager_sex.Size = new System.Drawing.Size(70, 13);
            this.manager_sex.TabIndex = 58;
            this.manager_sex.Text = "manager_sex";
            this.manager_sex.UseWaitCursor = true;
            // 
            // manager_phone
            // 
            this.manager_phone.AutoSize = true;
            this.manager_phone.Enabled = false;
            this.manager_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manager_phone.Location = new System.Drawing.Point(419, 300);
            this.manager_phone.Name = "manager_phone";
            this.manager_phone.Size = new System.Drawing.Size(84, 13);
            this.manager_phone.TabIndex = 55;
            this.manager_phone.Text = "manager_phone";
            this.manager_phone.UseWaitCursor = true;
            // 
            // manager_email
            // 
            this.manager_email.AutoSize = true;
            this.manager_email.Enabled = false;
            this.manager_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manager_email.Location = new System.Drawing.Point(393, 278);
            this.manager_email.Name = "manager_email";
            this.manager_email.Size = new System.Drawing.Size(78, 13);
            this.manager_email.TabIndex = 54;
            this.manager_email.Text = "manager_email";
            this.manager_email.UseWaitCursor = true;
            // 
            // manager_name
            // 
            this.manager_name.AutoSize = true;
            this.manager_name.Enabled = false;
            this.manager_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.manager_name.Location = new System.Drawing.Point(396, 257);
            this.manager_name.Name = "manager_name";
            this.manager_name.Size = new System.Drawing.Size(80, 13);
            this.manager_name.TabIndex = 53;
            this.manager_name.Text = "manager_name";
            this.manager_name.UseWaitCursor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(355, 321);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(31, 13);
            this.label20.TabIndex = 52;
            this.label20.Text = "Type";
            this.label20.UseWaitCursor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(355, 375);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "Personal ID number";
            this.label21.UseWaitCursor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(355, 300);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 50;
            this.label22.Text = "Telephone";
            this.label22.UseWaitCursor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label23.Location = new System.Drawing.Point(355, 347);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(25, 13);
            this.label23.TabIndex = 49;
            this.label23.Text = "Sex";
            this.label23.UseWaitCursor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label24.Location = new System.Drawing.Point(355, 278);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 13);
            this.label24.TabIndex = 48;
            this.label24.Text = "Email";
            this.label24.UseWaitCursor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label25.Location = new System.Drawing.Point(355, 257);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(35, 13);
            this.label25.TabIndex = 47;
            this.label25.Text = "Name";
            this.label25.UseWaitCursor = true;
            // 
            // promoter_sex
            // 
            this.promoter_sex.AutoSize = true;
            this.promoter_sex.Enabled = false;
            this.promoter_sex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promoter_sex.Location = new System.Drawing.Point(48, 347);
            this.promoter_sex.Name = "promoter_sex";
            this.promoter_sex.Size = new System.Drawing.Size(70, 13);
            this.promoter_sex.TabIndex = 46;
            this.promoter_sex.Text = "promoter_sex";
            this.promoter_sex.UseWaitCursor = true;
            // 
            // promoter_phone
            // 
            this.promoter_phone.AutoSize = true;
            this.promoter_phone.Enabled = false;
            this.promoter_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promoter_phone.Location = new System.Drawing.Point(78, 300);
            this.promoter_phone.Name = "promoter_phone";
            this.promoter_phone.Size = new System.Drawing.Size(84, 13);
            this.promoter_phone.TabIndex = 43;
            this.promoter_phone.Text = "promoter_phone";
            this.promoter_phone.UseWaitCursor = true;
            // 
            // promoter_email
            // 
            this.promoter_email.AutoSize = true;
            this.promoter_email.Enabled = false;
            this.promoter_email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promoter_email.Location = new System.Drawing.Point(52, 278);
            this.promoter_email.Name = "promoter_email";
            this.promoter_email.Size = new System.Drawing.Size(78, 13);
            this.promoter_email.TabIndex = 42;
            this.promoter_email.Text = "promoter_email";
            this.promoter_email.UseWaitCursor = true;
            // 
            // promoter_name
            // 
            this.promoter_name.AutoSize = true;
            this.promoter_name.Enabled = false;
            this.promoter_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.promoter_name.Location = new System.Drawing.Point(55, 257);
            this.promoter_name.Name = "promoter_name";
            this.promoter_name.Size = new System.Drawing.Size(80, 13);
            this.promoter_name.TabIndex = 41;
            this.promoter_name.Text = "promoter_name";
            this.promoter_name.UseWaitCursor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(496, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Total of tickets sold";
            this.label19.UseWaitCursor = true;
            // 
            // numericUpDown_ticketssold
            // 
            this.numericUpDown_ticketssold.Enabled = false;
            this.numericUpDown_ticketssold.Location = new System.Drawing.Point(499, 167);
            this.numericUpDown_ticketssold.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.numericUpDown_ticketssold.Name = "numericUpDown_ticketssold";
            this.numericUpDown_ticketssold.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_ticketssold.TabIndex = 39;
            this.numericUpDown_ticketssold.UseWaitCursor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label18.Location = new System.Drawing.Point(495, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 20);
            this.label18.TabIndex = 38;
            this.label18.Text = "Tickets";
            this.label18.UseWaitCursor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Magenta;
            this.label17.Location = new System.Drawing.Point(13, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Calendar";
            this.label17.UseWaitCursor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label10.Location = new System.Drawing.Point(351, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Manager";
            this.label10.UseWaitCursor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(14, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Type";
            this.label9.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(17, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Personal ID number";
            this.label8.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(14, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telephone";
            this.label7.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(17, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Sex";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(14, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(14, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            this.label4.UseWaitCursor = true;
            // 
            // textBox_festivalname
            // 
            this.textBox_festivalname.Enabled = false;
            this.textBox_festivalname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_festivalname.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_festivalname.Location = new System.Drawing.Point(17, 34);
            this.textBox_festivalname.Name = "textBox_festivalname";
            this.textBox_festivalname.Size = new System.Drawing.Size(708, 38);
            this.textBox_festivalname.TabIndex = 11;
            this.textBox_festivalname.UseWaitCursor = true;
            // 
            // label_promotername
            // 
            this.label_promotername.AutoSize = true;
            this.label_promotername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_promotername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(51)))), ((int)(((byte)(204)))));
            this.label_promotername.Location = new System.Drawing.Point(13, 221);
            this.label_promotername.Name = "label_promotername";
            this.label_promotername.Size = new System.Drawing.Size(74, 20);
            this.label_promotername.TabIndex = 10;
            this.label_promotername.Text = "Promoter";
            this.label_promotername.UseWaitCursor = true;
            // 
            // btn_changefestival
            // 
            this.btn_changefestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_changefestival.AutoSize = true;
            this.btn_changefestival.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_changefestival.FlatAppearance.BorderSize = 0;
            this.btn_changefestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_changefestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_changefestival.ForeColor = System.Drawing.Color.Magenta;
            this.btn_changefestival.Location = new System.Drawing.Point(17, 491);
            this.btn_changefestival.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_changefestival.Name = "btn_changefestival";
            this.btn_changefestival.Size = new System.Drawing.Size(133, 30);
            this.btn_changefestival.TabIndex = 9;
            this.btn_changefestival.Text = "Change Festival";
            this.btn_changefestival.UseVisualStyleBackColor = false;
            this.btn_changefestival.UseWaitCursor = true;
            this.btn_changefestival.Click += new System.EventHandler(this.btn_changefestival_Click);
            // 
            // btn_deletefestival
            // 
            this.btn_deletefestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deletefestival.AutoSize = true;
            this.btn_deletefestival.BackColor = System.Drawing.Color.Red;
            this.btn_deletefestival.FlatAppearance.BorderSize = 0;
            this.btn_deletefestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletefestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletefestival.ForeColor = System.Drawing.Color.White;
            this.btn_deletefestival.Location = new System.Drawing.Point(604, 497);
            this.btn_deletefestival.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_deletefestival.Name = "btn_deletefestival";
            this.btn_deletefestival.Size = new System.Drawing.Size(124, 30);
            this.btn_deletefestival.TabIndex = 8;
            this.btn_deletefestival.Text = "Delete Festival";
            this.btn_deletefestival.UseVisualStyleBackColor = false;
            this.btn_deletefestival.UseWaitCursor = true;
            this.btn_deletefestival.Click += new System.EventHandler(this.btn_deletefestival_Click);
            // 
            // label_festivalid
            // 
            this.label_festivalid.AutoSize = true;
            this.label_festivalid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label_festivalid.Location = new System.Drawing.Point(14, 75);
            this.label_festivalid.Name = "label_festivalid";
            this.label_festivalid.Size = new System.Drawing.Size(57, 13);
            this.label_festivalid.TabIndex = 5;
            this.label_festivalid.Text = "[festival id]";
            this.label_festivalid.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(176, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "End Date";
            this.label3.UseWaitCursor = true;
            // 
            // datepicker_festivalend
            // 
            this.datepicker_festivalend.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datepicker_festivalend.Enabled = false;
            this.datepicker_festivalend.Location = new System.Drawing.Point(179, 168);
            this.datepicker_festivalend.Name = "datepicker_festivalend";
            this.datepicker_festivalend.Size = new System.Drawing.Size(133, 20);
            this.datepicker_festivalend.TabIndex = 3;
            this.datepicker_festivalend.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(14, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            this.label2.UseWaitCursor = true;
            // 
            // datepicker_festivalbegin
            // 
            this.datepicker_festivalbegin.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.datepicker_festivalbegin.Enabled = false;
            this.datepicker_festivalbegin.Location = new System.Drawing.Point(17, 167);
            this.datepicker_festivalbegin.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.datepicker_festivalbegin.Name = "datepicker_festivalbegin";
            this.datepicker_festivalbegin.Size = new System.Drawing.Size(133, 20);
            this.datepicker_festivalbegin.TabIndex = 1;
            this.datepicker_festivalbegin.UseWaitCursor = true;
            // 
            // btn_editfestival
            // 
            this.btn_editfestival.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_editfestival.AutoSize = true;
            this.btn_editfestival.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_editfestival.FlatAppearance.BorderSize = 0;
            this.btn_editfestival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editfestival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editfestival.ForeColor = System.Drawing.Color.Magenta;
            this.btn_editfestival.Location = new System.Drawing.Point(170, 491);
            this.btn_editfestival.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_editfestival.Name = "btn_editfestival";
            this.btn_editfestival.Size = new System.Drawing.Size(111, 30);
            this.btn_editfestival.TabIndex = 7;
            this.btn_editfestival.Text = "Edit";
            this.btn_editfestival.UseVisualStyleBackColor = false;
            this.btn_editfestival.UseWaitCursor = true;
            this.btn_editfestival.Click += new System.EventHandler(this.btn_editfestival_Click);
            // 
            // PlanFest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(910, 542);
            this.Controls.Add(this.panel_base);
            this.Controls.Add(this.form_login);
            this.Name = "PlanFest";
            this.Text = "PlanFest";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.server.ResumeLayout(false);
            this.server.PerformLayout();
            this.user.ResumeLayout(false);
            this.user.PerformLayout();
            this.password.ResumeLayout(false);
            this.password.PerformLayout();
            this.form_login.ResumeLayout(false);
            this.form_login.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel_base.ResumeLayout(false);
            this.panel_base.PerformLayout();
            this.panel_concerts.ResumeLayout(false);
            this.panel_concerts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_concerts)).EndInit();
            this.panel_openinglist.ResumeLayout(false);
            this.panel_openinglist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview_festivals)).EndInit();
            this.panel_festival.ResumeLayout(false);
            this.panel_festival.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ticketssold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server_input;
        private System.Windows.Forms.Label server_label;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel server;
        private System.Windows.Forms.FlowLayoutPanel user;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.TextBox user_input;
        private System.Windows.Forms.FlowLayoutPanel password;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.FlowLayoutPanel form_login;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_festivals;
        private System.Windows.Forms.Button btn_concerts;
        private System.Windows.Forms.Button btn_stages;
        private System.Windows.Forms.Panel panel_base;
        private System.Windows.Forms.Button btn_bands;
        private System.Windows.Forms.Button btn_meals;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Button btn_openfestival;
        private System.Windows.Forms.Button btn_addfestival;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_openinglist;
        private System.Windows.Forms.DataGridView gridview_festivals;
        private System.Windows.Forms.Panel panel_festival;
        private System.Windows.Forms.ComboBox manager_type;
        private System.Windows.Forms.ComboBox promoter_type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datepicker_proposal;
        private System.Windows.Forms.TextBox textBox_manager_cc;
        private System.Windows.Forms.TextBox textBox_promoter_cc;
        private System.Windows.Forms.Label manager_sex;
        private System.Windows.Forms.Label manager_phone;
        private System.Windows.Forms.Label manager_email;
        private System.Windows.Forms.Label manager_name;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label promoter_sex;
        private System.Windows.Forms.Label promoter_phone;
        private System.Windows.Forms.Label promoter_email;
        private System.Windows.Forms.Label promoter_name;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericUpDown_ticketssold;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_festivalname;
        private System.Windows.Forms.Label label_promotername;
        private System.Windows.Forms.Button btn_changefestival;
        private System.Windows.Forms.Button btn_deletefestival;
        private System.Windows.Forms.Label label_festivalid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datepicker_festivalend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datepicker_festivalbegin;
        private System.Windows.Forms.Button btn_editfestival;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_festivalid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_datebegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_ndays;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_promotername;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_promoteremail;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_promoterphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridview_bandname;
        private System.Windows.Forms.TextBox textBox_searchfestivalname;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_searchndays;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_searchpromotername;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox_searchpromoteremail;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox_searchpromoterphone;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox_searchbandname;
        private System.Windows.Forms.Button btn_searchfestival;
        private System.Windows.Forms.Panel panel_concerts;
        private System.Windows.Forms.Button btn_saveeditconcert;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dataGridView_concerts;
        private System.Windows.Forms.Button btn_addconcert;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox_concertduration;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dateTimePicker_concert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_stages;
        private System.Windows.Forms.ComboBox comboBox_bandslist;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DateTimePicker dateTimePicker_soundcheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_concertid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_stageid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_bandid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_datebegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_concertduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_soundckduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_lotation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_bandname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBox_soundid;
        private System.Windows.Forms.TextBox textBox_soundckduration;
        private System.Windows.Forms.Label label34;
    }
}

