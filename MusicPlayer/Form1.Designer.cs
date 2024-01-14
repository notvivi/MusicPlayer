namespace MusicPlayer
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.lbl_min = new System.Windows.Forms.Label();
            this.songBox = new System.Windows.Forms.ListBox();
            this.lbl_importedSongs = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_timeDuration = new System.Windows.Forms.Label();
            this.timerPlayBack = new System.Windows.Forms.Timer(this.components);
            this.lbl_max = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Silver;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Location = new System.Drawing.Point(348, 500);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(159, 58);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Silver;
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Location = new System.Drawing.Point(526, 500);
            this.btnPause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(159, 58);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.Silver;
            this.volumeBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.volumeBar.Location = new System.Drawing.Point(12, 4);
            this.volumeBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.volumeBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.volumeBar.Size = new System.Drawing.Size(45, 502);
            this.volumeBar.TabIndex = 5;
            this.volumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.BackColor = System.Drawing.Color.Silver;
            this.lbl_min.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_min.Location = new System.Drawing.Point(37, 484);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(32, 17);
            this.lbl_min.TabIndex = 6;
            this.lbl_min.Text = "Min";
            // 
            // songBox
            // 
            this.songBox.BackColor = System.Drawing.Color.Silver;
            this.songBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songBox.FormattingEnabled = true;
            this.songBox.ItemHeight = 25;
            this.songBox.Location = new System.Drawing.Point(12, 103);
            this.songBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.songBox.Name = "songBox";
            this.songBox.Size = new System.Drawing.Size(673, 279);
            this.songBox.TabIndex = 7;
            // 
            // lbl_importedSongs
            // 
            this.lbl_importedSongs.AutoSize = true;
            this.lbl_importedSongs.BackColor = System.Drawing.Color.Silver;
            this.lbl_importedSongs.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_importedSongs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_importedSongs.Location = new System.Drawing.Point(4, 13);
            this.lbl_importedSongs.Name = "lbl_importedSongs";
            this.lbl_importedSongs.Size = new System.Drawing.Size(243, 40);
            this.lbl_importedSongs.TabIndex = 8;
            this.lbl_importedSongs.Text = "Imported songs:";
            // 
            // lbl_timeDuration
            // 
            this.lbl_timeDuration.AutoSize = true;
            this.lbl_timeDuration.BackColor = System.Drawing.Color.Silver;
            this.lbl_timeDuration.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeDuration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_timeDuration.Location = new System.Drawing.Point(274, 417);
            this.lbl_timeDuration.Name = "lbl_timeDuration";
            this.lbl_timeDuration.Size = new System.Drawing.Size(133, 25);
            this.lbl_timeDuration.TabIndex = 10;
            this.lbl_timeDuration.Text = " 00:00 / 00:00";
            // 
            // timerPlayBack
            // 
            this.timerPlayBack.Interval = 850;
            this.timerPlayBack.Tick += new System.EventHandler(this.timerPlayBack_Tick);
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.BackColor = System.Drawing.Color.Silver;
            this.lbl_max.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_max.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_max.Location = new System.Drawing.Point(35, 12);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(34, 17);
            this.lbl_max.TabIndex = 11;
            this.lbl_max.Text = "Max";
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(115)))), ((int)(((byte)(141)))));
            this.progressBar.Location = new System.Drawing.Point(26, 456);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(637, 14);
            this.progressBar.TabIndex = 12;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(1, 0);
            this.musicPlayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(1072, 26);
            this.musicPlayer.TabIndex = 0;
            this.musicPlayer.Visible = false;
            this.musicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.musicPlayer_PlayStateChange);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbl_max);
            this.panel1.Controls.Add(this.lbl_min);
            this.panel1.Controls.Add(this.volumeBar);
            this.panel1.Location = new System.Drawing.Point(715, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 519);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(16, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 72);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.lbl_importedSongs);
            this.panel3.Location = new System.Drawing.Point(15, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(667, 57);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(708, 33);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 525);
            this.panel4.TabIndex = 17;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Silver;
            this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoad.Location = new System.Drawing.Point(12, 500);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(318, 58);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(12, 403);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(670, 78);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(12, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(673, 63);
            this.panel6.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(809, 588);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lbl_timeDuration);
            this.Controls.Add(this.songBox);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.musicPlayer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fake Spotify";
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.ListBox songBox;
        private System.Windows.Forms.Label lbl_importedSongs;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lbl_timeDuration;
        private System.Windows.Forms.Timer timerPlayBack;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

