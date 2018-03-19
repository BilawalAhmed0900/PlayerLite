namespace PlayerLite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.songBox = new System.Windows.Forms.ListBox();
            this.play_pause = new System.Windows.Forms.Button();
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.progress_bar = new System.Windows.Forms.TrackBar();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stop_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress_bar)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // songBox
            // 
            this.songBox.AllowDrop = true;
            this.songBox.FormattingEnabled = true;
            this.songBox.Location = new System.Drawing.Point(12, 30);
            this.songBox.Name = "songBox";
            this.songBox.Size = new System.Drawing.Size(492, 134);
            this.songBox.TabIndex = 0;
            this.songBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.songBox_DragDrop);
            this.songBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.songBox_DragEnter);
            this.songBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.songBox_KeyDown);
            this.songBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.songBox_MouseDoubleClick);
            // 
            // play_pause
            // 
            this.play_pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play_pause.Location = new System.Drawing.Point(12, 170);
            this.play_pause.Name = "play_pause";
            this.play_pause.Size = new System.Drawing.Size(32, 28);
            this.play_pause.TabIndex = 1;
            this.play_pause.Text = "▶";
            this.play_pause.UseVisualStyleBackColor = true;
            this.play_pause.Click += new System.EventHandler(this.play_pause_Click);
            // 
            // volume_bar
            // 
            this.volume_bar.Location = new System.Drawing.Point(400, 170);
            this.volume_bar.Maximum = 100;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.Size = new System.Drawing.Size(104, 45);
            this.volume_bar.TabIndex = 2;
            this.volume_bar.Scroll += new System.EventHandler(this.volume_bar_Scroll);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(91, 170);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(303, 45);
            this.progress_bar.TabIndex = 3;
            this.progress_bar.TickFrequency = 0;
            this.progress_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.progress_bar.Scroll += new System.EventHandler(this.progress_bar_Scroll);
            this.progress_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progress_bar_MouseDown);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "PlayerLite";
            this.notifyIcon.BalloonTipTitle = "PlayerLite";
            this.notifyIcon.ContextMenuStrip = this.contextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "PlayerLite";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.nextSongToolStripMenuItem,
            this.previousSongToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(150, 136);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.pauseToolStripMenuItem.Text = "Pause";
            this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // nextSongToolStripMenuItem
            // 
            this.nextSongToolStripMenuItem.Name = "nextSongToolStripMenuItem";
            this.nextSongToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nextSongToolStripMenuItem.Text = "Next Song";
            this.nextSongToolStripMenuItem.Click += new System.EventHandler(this.nextSongToolStripMenuItem_Click);
            // 
            // previousSongToolStripMenuItem
            // 
            this.previousSongToolStripMenuItem.Name = "previousSongToolStripMenuItem";
            this.previousSongToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.previousSongToolStripMenuItem.Text = "Previous Song";
            this.previousSongToolStripMenuItem.Click += new System.EventHandler(this.previousSongToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // stop_button
            // 
            this.stop_button.Location = new System.Drawing.Point(50, 170);
            this.stop_button.Name = "stop_button";
            this.stop_button.Size = new System.Drawing.Size(32, 28);
            this.stop_button.TabIndex = 5;
            this.stop_button.Text = "\t█";
            this.stop_button.UseVisualStyleBackColor = true;
            this.stop_button.Click += new System.EventHandler(this.stop_button_Click);
            // 
            // about_button
            // 
            this.about_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_button.Location = new System.Drawing.Point(483, 5);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(21, 19);
            this.about_button.TabIndex = 6;
            this.about_button.Text = "?";
            this.about_button.UseVisualStyleBackColor = true;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 210);
            this.Controls.Add(this.about_button);
            this.Controls.Add(this.stop_button);
            this.Controls.Add(this.progress_bar);
            this.Controls.Add(this.volume_bar);
            this.Controls.Add(this.play_pause);
            this.Controls.Add(this.songBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PlayerLite";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress_bar)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox songBox;
        private System.Windows.Forms.Button play_pause;
        private System.Windows.Forms.TrackBar volume_bar;
        private System.Windows.Forms.TrackBar progress_bar;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousSongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button stop_button;
        private System.Windows.Forms.Button about_button;
    }
}

