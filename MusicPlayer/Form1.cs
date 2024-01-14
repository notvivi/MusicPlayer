using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private List<string> musicFiles;
        private string currentSong;
        private bool isPaused;
        private bool isChangingPosition;

        public Form1()
        {
            InitializeComponent();
            musicFiles = new List<string>();
            isPaused = false;
            isChangingPosition = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
        OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "MP3 Files| *.mp3";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog.FileNames)
                {
                    musicFiles.Add(file);
                    songBox.Items.Add(Path.GetFileName(file));
                }

                if(musicFiles.Count > 0)
                {
                    btnStart.Enabled = true;
                }
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(songBox.SelectedIndex >= 0)
            {
                if (isPaused)
                {
                    musicPlayer.Ctlcontrols.play();
                    isPaused = false;
                }
                else
                {
                    currentSong = musicFiles[songBox.SelectedIndex];
                    musicPlayer.URL = currentSong;
                    musicPlayer.Ctlcontrols.play();
                }
                timerPlayBack.Enabled = true;
            }
        }

       

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (isPaused == false)
            {
                btnPause.Text = "Resume";
                musicPlayer.Ctlcontrols.pause();
                isPaused = true;
            }

            else
            {
                btnPause.Text = "Pause";
                musicPlayer.Ctlcontrols.play();
                isPaused = false;
            }
        }

        private void timerPlayBack_Tick(object sender, EventArgs e)
        {
            if (!isChangingPosition)
            {
                lbl_timeDuration.Text = FormatTime(musicPlayer.Ctlcontrols.currentPosition) + " / " + FormatTime(musicPlayer.currentMedia.duration);
               
                progressBar.Maximum = (int)musicPlayer.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)musicPlayer.Ctlcontrols.currentPosition;
            }
        }

        private string FormatTime(double seconds)
        {
            TimeSpan time = TimeSpan.FromSeconds(seconds);
            return time.ToString(@"mm\:ss");
        }

        private void musicPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                int nextIndex = songBox.SelectedIndex += 1;

                if(nextIndex < musicFiles.Count)
                {
                    songBox.SelectedIndex = nextIndex;
                    currentSong = musicFiles[nextIndex];
                    musicPlayer.URL = currentSong;
                    musicPlayer.Ctlcontrols.play();
                    isPaused = false;
                }

                else
                {
                    musicPlayer.Ctlcontrols.stop();
                    isPaused = false;
                }
            }
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            musicPlayer.settings.volume = volumeBar.Value;
        }

        
    }
}
