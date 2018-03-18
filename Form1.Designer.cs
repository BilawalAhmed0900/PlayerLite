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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.songBox = new System.Windows.Forms.ListBox();
            this.play_pause = new System.Windows.Forms.Button();
            this.volume_bar = new System.Windows.Forms.TrackBar();
            this.progress_bar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // songBox
            // 
            this.songBox.AllowDrop = true;
            this.songBox.FormattingEnabled = true;
            this.songBox.Location = new System.Drawing.Point(12, 12);
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
            this.play_pause.Location = new System.Drawing.Point(12, 152);
            this.play_pause.Name = "play_pause";
            this.play_pause.Size = new System.Drawing.Size(32, 28);
            this.play_pause.TabIndex = 1;
            this.play_pause.Text = "▶";
            this.play_pause.UseVisualStyleBackColor = true;
            this.play_pause.Click += new System.EventHandler(this.play_pause_Click);
            // 
            // volume_bar
            // 
            this.volume_bar.Location = new System.Drawing.Point(400, 152);
            this.volume_bar.Maximum = 100;
            this.volume_bar.Name = "volume_bar";
            this.volume_bar.Size = new System.Drawing.Size(104, 45);
            this.volume_bar.TabIndex = 2;
            this.volume_bar.Scroll += new System.EventHandler(this.volume_bar_Scroll);
            // 
            // progress_bar
            // 
            this.progress_bar.Location = new System.Drawing.Point(50, 152);
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(344, 45);
            this.progress_bar.TabIndex = 3;
            this.progress_bar.TickFrequency = 0;
            this.progress_bar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.progress_bar.Scroll += new System.EventHandler(this.progress_bar_Scroll);
            this.progress_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.progress_bar_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 192);
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
            ((System.ComponentModel.ISupportInitialize)(this.volume_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progress_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox songBox;
        private System.Windows.Forms.Button play_pause;
        private System.Windows.Forms.TrackBar volume_bar;
        private System.Windows.Forms.TrackBar progress_bar;
    }
}

