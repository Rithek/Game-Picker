namespace Game_Picker_2._0._0
{
    partial class RandomizerWindow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_SelectedGame = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.cbx_Rand_Speedrun = new System.Windows.Forms.CheckBox();
            this.btn_Randomizer_Close = new System.Windows.Forms.Button();
            this.btn_Randomize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_SelectedGame
            // 
            this.lbl_SelectedGame.AutoSize = true;
            this.lbl_SelectedGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lbl_SelectedGame.Location = new System.Drawing.Point(36, 45);
            this.lbl_SelectedGame.Name = "lbl_SelectedGame";
            this.lbl_SelectedGame.Size = new System.Drawing.Size(286, 37);
            this.lbl_SelectedGame.TabIndex = 0;
            this.lbl_SelectedGame.Text = "No Game Selected";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Items.AddRange(new object[] {
            "Any",
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
            this.checkedListBox2.Location = new System.Drawing.Point(43, 100);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(187, 394);
            this.checkedListBox2.TabIndex = 1;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Any",
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
            this.checkedListBox1.Location = new System.Drawing.Point(262, 100);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 169);
            this.checkedListBox1.TabIndex = 2;
            // 
            // cbx_Rand_Speedrun
            // 
            this.cbx_Rand_Speedrun.AutoSize = true;
            this.cbx_Rand_Speedrun.Location = new System.Drawing.Point(265, 278);
            this.cbx_Rand_Speedrun.Name = "cbx_Rand_Speedrun";
            this.cbx_Rand_Speedrun.Size = new System.Drawing.Size(107, 17);
            this.cbx_Rand_Speedrun.TabIndex = 3;
            this.cbx_Rand_Speedrun.TabStop = false;
            this.cbx_Rand_Speedrun.Text = "Speedruns Only?";
            this.cbx_Rand_Speedrun.UseVisualStyleBackColor = true;
            // 
            // btn_Randomizer_Close
            // 
            this.btn_Randomizer_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Randomizer_Close.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btn_Randomizer_Close.Location = new System.Drawing.Point(480, 7);
            this.btn_Randomizer_Close.Name = "btn_Randomizer_Close";
            this.btn_Randomizer_Close.Size = new System.Drawing.Size(38, 35);
            this.btn_Randomizer_Close.TabIndex = 4;
            this.btn_Randomizer_Close.TabStop = false;
            this.btn_Randomizer_Close.Text = "𐌢";
            this.btn_Randomizer_Close.UseVisualStyleBackColor = true;
            this.btn_Randomizer_Close.Click += new System.EventHandler(this.btn_Randomizer_Close_Click);
            // 
            // btn_Randomize
            // 
            this.btn_Randomize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_Randomize.Location = new System.Drawing.Point(262, 410);
            this.btn_Randomize.Name = "btn_Randomize";
            this.btn_Randomize.Size = new System.Drawing.Size(120, 35);
            this.btn_Randomize.TabIndex = 5;
            this.btn_Randomize.TabStop = false;
            this.btn_Randomize.Text = "Randomize";
            this.btn_Randomize.UseVisualStyleBackColor = true;
            this.btn_Randomize.Click += new System.EventHandler(this.btn_Randomize_Click);
            // 
            // RandomizerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Randomize);
            this.Controls.Add(this.btn_Randomizer_Close);
            this.Controls.Add(this.cbx_Rand_Speedrun);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.lbl_SelectedGame);
            this.Name = "RandomizerWindow";
            this.Size = new System.Drawing.Size(525, 518);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SelectedGame;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox cbx_Rand_Speedrun;
        private System.Windows.Forms.Button btn_Randomizer_Close;
        private System.Windows.Forms.Button btn_Randomize;
    }
}
