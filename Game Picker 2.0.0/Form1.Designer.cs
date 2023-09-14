namespace Game_Picker_2._0._0
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DataGridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setLastPlayedToTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setCompletionDateToTodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.btn_Randomizer = new System.Windows.Forms.Button();
            this.btn_BackupData = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.lbl_Platform = new System.Windows.Forms.Label();
            this.cmb_Sortby = new System.Windows.Forms.ComboBox();
            this.btn_ResetSearch = new System.Windows.Forms.Button();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tags = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Playthroughs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsSpeedrun = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmb_DateSetting = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmb_Rating = new System.Windows.Forms.ComboBox();
            this.cbx_ShowSpeedrunsOnly = new System.Windows.Forms.CheckBox();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.cmb_Platform = new System.Windows.Forms.ComboBox();
            this.dtp_DateRangeHigh = new System.Windows.Forms.DateTimePicker();
            this.dtp_DateRangeLow = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.randomizerWindow = new Game_Picker_2._0._0.RandomizerWindow();
            this.addEditMode = new Game_Picker_2._0._0.AddEditMode();
            this.DataGridContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridContextMenu
            // 
            this.DataGridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.setLastPlayedToTodayToolStripMenuItem,
            this.setCompletionDateToTodayToolStripMenuItem});
            this.DataGridContextMenu.Name = "DataGridContextMenu";
            this.DataGridContextMenu.Size = new System.Drawing.Size(231, 92);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // setLastPlayedToTodayToolStripMenuItem
            // 
            this.setLastPlayedToTodayToolStripMenuItem.Name = "setLastPlayedToTodayToolStripMenuItem";
            this.setLastPlayedToTodayToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.setLastPlayedToTodayToolStripMenuItem.Text = "Set Last Played to today";
            this.setLastPlayedToTodayToolStripMenuItem.Click += new System.EventHandler(this.setLastPlayedToTodayToolStripMenuItem_Click);
            // 
            // setCompletionDateToTodayToolStripMenuItem
            // 
            this.setCompletionDateToTodayToolStripMenuItem.Name = "setCompletionDateToTodayToolStripMenuItem";
            this.setCompletionDateToTodayToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.setCompletionDateToTodayToolStripMenuItem.Text = "Set Completion Date to today";
            this.setCompletionDateToTodayToolStripMenuItem.Click += new System.EventHandler(this.setCompletionDateToTodayToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game_Picker_2._0._0.Properties.Resources.GamePickerimg;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAppTitle.Location = new System.Drawing.Point(37, 15);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(115, 16);
            this.lblAppTitle.TabIndex = 30;
            this.lblAppTitle.Text = "Game Picker 2.0.0";
            // 
            // btn_Randomizer
            // 
            this.btn_Randomizer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Randomizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Randomizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Randomizer.ForeColor = System.Drawing.Color.Black;
            this.btn_Randomizer.Location = new System.Drawing.Point(418, 202);
            this.btn_Randomizer.Name = "btn_Randomizer";
            this.btn_Randomizer.Size = new System.Drawing.Size(103, 31);
            this.btn_Randomizer.TabIndex = 49;
            this.btn_Randomizer.TabStop = false;
            this.btn_Randomizer.Text = "Randomize";
            this.btn_Randomizer.UseVisualStyleBackColor = false;
            this.btn_Randomizer.Click += new System.EventHandler(this.btn_Randomizer_Click);
            // 
            // btn_BackupData
            // 
            this.btn_BackupData.Location = new System.Drawing.Point(20, 778);
            this.btn_BackupData.Name = "btn_BackupData";
            this.btn_BackupData.Size = new System.Drawing.Size(88, 23);
            this.btn_BackupData.TabIndex = 48;
            this.btn_BackupData.TabStop = false;
            this.btn_BackupData.Text = "Backup Data";
            this.btn_BackupData.UseVisualStyleBackColor = true;
            this.btn_BackupData.Click += new System.EventHandler(this.btn_BackupData_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.Black;
            this.btn_Minimize.Location = new System.Drawing.Point(805, 5);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_Minimize.Size = new System.Drawing.Size(42, 33);
            this.btn_Minimize.TabIndex = 47;
            this.btn_Minimize.TabStop = false;
            this.btn_Minimize.Text = "–";
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.Location = new System.Drawing.Point(851, 5);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_Close.Size = new System.Drawing.Size(46, 33);
            this.btn_Close.TabIndex = 46;
            this.btn_Close.TabStop = false;
            this.btn_Close.Text = "𐌢";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Status.Location = new System.Drawing.Point(414, 82);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(56, 20);
            this.lbl_Status.TabIndex = 45;
            this.lbl_Status.Text = "Status";
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rating.Location = new System.Drawing.Point(269, 82);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(56, 20);
            this.lbl_rating.TabIndex = 44;
            this.lbl_rating.Text = "Rating";
            // 
            // lbl_Platform
            // 
            this.lbl_Platform.AutoSize = true;
            this.lbl_Platform.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Platform.Location = new System.Drawing.Point(16, 82);
            this.lbl_Platform.Name = "lbl_Platform";
            this.lbl_Platform.Size = new System.Drawing.Size(68, 20);
            this.lbl_Platform.TabIndex = 32;
            this.lbl_Platform.Text = "Platform";
            // 
            // cmb_Sortby
            // 
            this.cmb_Sortby.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_Sortby.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Sortby.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Sortby.FormattingEnabled = true;
            this.cmb_Sortby.Items.AddRange(new object[] {
            "",
            "Completion Date (Asc)",
            "Completion Date (Desc)",
            "Game Name (Asc)",
            "Game Name (Desc)",
            "Last Played (Asc)",
            "Last Played (Desc)",
            "Platform (Asc)",
            "Platform (Desc)",
            "Rating (Asc)",
            "Rating (Desc)",
            "Status (Asc)",
            "Status (Desc)"});
            this.cmb_Sortby.Location = new System.Drawing.Point(143, 204);
            this.cmb_Sortby.Name = "cmb_Sortby";
            this.cmb_Sortby.Size = new System.Drawing.Size(202, 28);
            this.cmb_Sortby.TabIndex = 43;
            this.cmb_Sortby.SelectedIndexChanged += new System.EventHandler(this.cbx_Sortby_SelectedIndexChanged);
            // 
            // btn_ResetSearch
            // 
            this.btn_ResetSearch.BackColor = System.Drawing.Color.Transparent;
            this.btn_ResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetSearch.Location = new System.Drawing.Point(20, 202);
            this.btn_ResetSearch.Name = "btn_ResetSearch";
            this.btn_ResetSearch.Size = new System.Drawing.Size(92, 31);
            this.btn_ResetSearch.TabIndex = 29;
            this.btn_ResetSearch.TabStop = false;
            this.btn_ResetSearch.Text = "Reset";
            this.btn_ResetSearch.UseVisualStyleBackColor = false;
            this.btn_ResetSearch.Click += new System.EventHandler(this.btn_ResetSearch_Click);
            // 
            // btnAddGame
            // 
            this.btnAddGame.BackColor = System.Drawing.Color.Transparent;
            this.btnAddGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGame.ForeColor = System.Drawing.Color.Black;
            this.btnAddGame.Location = new System.Drawing.Point(840, 193);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(40, 40);
            this.btnAddGame.TabIndex = 33;
            this.btnAddGame.TabStop = false;
            this.btnAddGame.Text = " +";
            this.btnAddGame.UseVisualStyleBackColor = false;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GameName,
            this.Platform,
            this.Rating,
            this.Status,
            this.Tags,
            this.Playthroughs,
            this.LastPlayed,
            this.CompletionDate,
            this.IsSpeedrun});
            this.dataGridView1.ContextMenuStrip = this.DataGridContextMenu;
            this.dataGridView1.Location = new System.Drawing.Point(20, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 533);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridView1_RowPrePaint);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // GameName
            // 
            this.GameName.DataPropertyName = "GameName";
            this.GameName.FillWeight = 75F;
            this.GameName.HeaderText = "Game Name";
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            // 
            // Platform
            // 
            this.Platform.DataPropertyName = "Platform";
            this.Platform.FillWeight = 54.53232F;
            this.Platform.HeaderText = "Platform";
            this.Platform.Name = "Platform";
            this.Platform.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.DataPropertyName = "Rating";
            this.Rating.FillWeight = 26F;
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 50F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Tags
            // 
            this.Tags.DataPropertyName = "Tags";
            this.Tags.FillWeight = 54.53232F;
            this.Tags.HeaderText = "Tags";
            this.Tags.Name = "Tags";
            this.Tags.ReadOnly = true;
            // 
            // Playthroughs
            // 
            this.Playthroughs.HeaderText = "Playthroughs";
            this.Playthroughs.Name = "Playthroughs";
            this.Playthroughs.ReadOnly = true;
            this.Playthroughs.Visible = false;
            // 
            // LastPlayed
            // 
            this.LastPlayed.DataPropertyName = "LastPlayed";
            this.LastPlayed.FillWeight = 54.53232F;
            this.LastPlayed.HeaderText = "Last Played";
            this.LastPlayed.Name = "LastPlayed";
            this.LastPlayed.ReadOnly = true;
            // 
            // CompletionDate
            // 
            this.CompletionDate.DataPropertyName = "CompletionDate";
            this.CompletionDate.FillWeight = 60F;
            this.CompletionDate.HeaderText = "Completion Date";
            this.CompletionDate.Name = "CompletionDate";
            this.CompletionDate.ReadOnly = true;
            // 
            // IsSpeedrun
            // 
            this.IsSpeedrun.DataPropertyName = "IsSpeedrun";
            this.IsSpeedrun.FillWeight = 54.53232F;
            this.IsSpeedrun.HeaderText = "Speedrun?";
            this.IsSpeedrun.Name = "IsSpeedrun";
            this.IsSpeedrun.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(370, 358);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(8, 8);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(0, 0);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(0, 0);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmb_DateSetting
            // 
            this.cmb_DateSetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_DateSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_DateSetting.FormattingEnabled = true;
            this.cmb_DateSetting.Items.AddRange(new object[] {
            "Any Date",
            "Last Played",
            "Completion Date"});
            this.cmb_DateSetting.Location = new System.Drawing.Point(20, 157);
            this.cmb_DateSetting.Name = "cmb_DateSetting";
            this.cmb_DateSetting.Size = new System.Drawing.Size(148, 28);
            this.cmb_DateSetting.TabIndex = 39;
            this.cmb_DateSetting.SelectedIndexChanged += new System.EventHandler(this.cmb_DateSetting_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(20, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(860, 29);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmb_Rating
            // 
            this.cmb_Rating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Rating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Rating.FormattingEnabled = true;
            this.cmb_Rating.Items.AddRange(new object[] {
            "Any",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1",
            "0"});
            this.cmb_Rating.Location = new System.Drawing.Point(273, 105);
            this.cmb_Rating.Name = "cmb_Rating";
            this.cmb_Rating.Size = new System.Drawing.Size(72, 28);
            this.cmb_Rating.TabIndex = 37;
            this.cmb_Rating.SelectedIndexChanged += new System.EventHandler(this.cmb_Rating_SelectedIndexChanged);
            // 
            // cbx_ShowSpeedrunsOnly
            // 
            this.cbx_ShowSpeedrunsOnly.AutoSize = true;
            this.cbx_ShowSpeedrunsOnly.BackColor = System.Drawing.Color.Transparent;
            this.cbx_ShowSpeedrunsOnly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_ShowSpeedrunsOnly.Location = new System.Drawing.Point(588, 109);
            this.cbx_ShowSpeedrunsOnly.Name = "cbx_ShowSpeedrunsOnly";
            this.cbx_ShowSpeedrunsOnly.Size = new System.Drawing.Size(194, 24);
            this.cbx_ShowSpeedrunsOnly.TabIndex = 31;
            this.cbx_ShowSpeedrunsOnly.TabStop = false;
            this.cbx_ShowSpeedrunsOnly.Text = "Show Speedruns Only?";
            this.cbx_ShowSpeedrunsOnly.UseVisualStyleBackColor = false;
            this.cbx_ShowSpeedrunsOnly.CheckedChanged += new System.EventHandler(this.cbx_ShowSpeedrunsOnly_CheckedChanged);
            // 
            // cmb_Status
            // 
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "100% Completed",
            "Completed",
            "Ongoing",
            "On Hold",
            "Upcoming",
            "Recurring",
            "Replaying",
            "Backlog",
            "Unreleased",
            "Flushed"});
            this.cmb_Status.Location = new System.Drawing.Point(418, 105);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(146, 28);
            this.cmb_Status.TabIndex = 38;
            this.cmb_Status.SelectedIndexChanged += new System.EventHandler(this.cmb_Status_SelectedIndexChanged);
            // 
            // cmb_Platform
            // 
            this.cmb_Platform.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Platform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Platform.FormattingEnabled = true;
            this.cmb_Platform.Items.AddRange(new object[] {
            "PC",
            "Nintendo Switch",
            "Nintendo 3DS",
            "Nintendo DS",
            "Nintendo 64",
            "Nintendo Gamecube",
            "Nintendo Game Boy Advance",
            "Nintendo Game Boy",
            "Nintendo Wii",
            "Nintendo Wii U",
            "SNES",
            "Playstation 1",
            "Playstation 2",
            "Playstation 3",
            "Playstation 4",
            "Playstation 5",
            "PSP",
            "PS Vita",
            "Sega Dreamcast",
            "Neogeo Pocket Color",
            "Xbox",
            "Xbox 360",
            "Xbox One",
            "Xbox One X",
            "Other"});
            this.cmb_Platform.Location = new System.Drawing.Point(20, 105);
            this.cmb_Platform.Name = "cmb_Platform";
            this.cmb_Platform.Size = new System.Drawing.Size(225, 28);
            this.cmb_Platform.TabIndex = 34;
            this.cmb_Platform.SelectedIndexChanged += new System.EventHandler(this.cmb_Platform_SelectedIndexChanged);
            // 
            // dtp_DateRangeHigh
            // 
            this.dtp_DateRangeHigh.Enabled = false;
            this.dtp_DateRangeHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateRangeHigh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateRangeHigh.Location = new System.Drawing.Point(418, 159);
            this.dtp_DateRangeHigh.Name = "dtp_DateRangeHigh";
            this.dtp_DateRangeHigh.Size = new System.Drawing.Size(109, 26);
            this.dtp_DateRangeHigh.TabIndex = 42;
            this.dtp_DateRangeHigh.ValueChanged += new System.EventHandler(this.dtp_DateRangeHigh_ValueChanged);
            // 
            // dtp_DateRangeLow
            // 
            this.dtp_DateRangeLow.Enabled = false;
            this.dtp_DateRangeLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DateRangeLow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_DateRangeLow.Location = new System.Drawing.Point(273, 159);
            this.dtp_DateRangeLow.Name = "dtp_DateRangeLow";
            this.dtp_DateRangeLow.Size = new System.Drawing.Size(104, 26);
            this.dtp_DateRangeLow.TabIndex = 40;
            this.dtp_DateRangeLow.ValueChanged += new System.EventHandler(this.dtp_DateRangeLow_ValueChanged);
            // 
            // randomizerWindow
            // 
            this.randomizerWindow.Games = null;
            this.randomizerWindow.Location = new System.Drawing.Point(187, 146);
            this.randomizerWindow.Name = "randomizerWindow";
            this.randomizerWindow.Size = new System.Drawing.Size(525, 518);
            this.randomizerWindow.TabIndex = 52;
            this.randomizerWindow.Visible = false;
            // 
            // addEditMode
            // 
            this.addEditMode.GameData = null;
            this.addEditMode.Location = new System.Drawing.Point(187, 146);
            this.addEditMode.Name = "addEditMode";
            this.addEditMode.Size = new System.Drawing.Size(525, 326);
            this.addEditMode.TabIndex = 51;
            this.addEditMode.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 807);
            this.Controls.Add(this.randomizerWindow);
            this.Controls.Add(this.addEditMode);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAppTitle);
            this.Controls.Add(this.btn_Randomizer);
            this.Controls.Add(this.btn_BackupData);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.lbl_rating);
            this.Controls.Add(this.lbl_Platform);
            this.Controls.Add(this.cmb_Sortby);
            this.Controls.Add(this.btn_ResetSearch);
            this.Controls.Add(this.btnAddGame);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.cmb_DateSetting);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmb_Rating);
            this.Controls.Add(this.cbx_ShowSpeedrunsOnly);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.cmb_Platform);
            this.Controls.Add(this.dtp_DateRangeHigh);
            this.Controls.Add(this.dtp_DateRangeLow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DataGridContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip DataGridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setLastPlayedToTodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setCompletionDateToTodayToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btn_Randomizer;
        private System.Windows.Forms.Button btn_BackupData;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Label lbl_Platform;
        private System.Windows.Forms.ComboBox cmb_Sortby;
        private System.Windows.Forms.Button btn_ResetSearch;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmb_DateSetting;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmb_Rating;
        private System.Windows.Forms.CheckBox cbx_ShowSpeedrunsOnly;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.ComboBox cmb_Platform;
        private System.Windows.Forms.DateTimePicker dtp_DateRangeHigh;
        private System.Windows.Forms.DateTimePicker dtp_DateRangeLow;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AddEditMode addEditMode;
        private RandomizerWindow randomizerWindow;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tags;
        private System.Windows.Forms.DataGridViewTextBoxColumn Playthroughs;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompletionDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsSpeedrun;
    }
}

