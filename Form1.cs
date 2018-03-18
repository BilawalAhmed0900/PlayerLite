using System;
using System.Windows.Forms;

namespace PlayerLite
{
    public partial class Form1 : Form
    {
        // The actual player
        WMPLib.WindowsMediaPlayer wplayer;

        // The playlist, to add media in
        WMPLib.IWMPPlaylist playlist;

        // Media
        WMPLib.IWMPMedia media;

        // Timer for keeping progress
        Timer timer_1;

        // How much each scroll account for in term of volume increment or decrement
        const int Delta = 5;

        // Strings for play/pause button
        string play = "▶";
        string pause = "⏸";

        public Form1()
        {
            InitializeComponent();
            MouseWheel += Form_MouseWheel;
        }

        void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            /* 
             Each 'click'(120 in number) in Wheel will increase or decrease
             volume by 5
            */
            int byHowMuch = (e.Delta / 120) * Delta;

            // If the change is in range
            if (volume_bar.Value + byHowMuch <= volume_bar.Maximum
                && volume_bar.Value + byHowMuch >= volume_bar.Minimum)
            {
                volume_bar.Value += byHowMuch;
                wplayer.settings.volume += byHowMuch;
            }           
        }

        // If an item is dragged into list box
        private void songBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        // Add filename to playlist
        private void Add_To_Playlist(string filename)
        {
            songBox.Items.Add(filename);
            media = wplayer.newMedia(filename);
            playlist.appendItem(media);
        }

        // When file is dropped on list box
        private void songBox_DragDrop(object sender, DragEventArgs e)
        {
            // Add files to it and playlist
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                int previous = songBox.Items.Count;

                Add_To_Playlist(file);
                if (previous == 0)
                {
                    progress_bar.Value = 0;
                    wplayer.controls.currentPosition = 0;
                    wplayer.controls.play();
                    play_pause.Text = pause;
                }
            }              
        }
        
        // When a key is pressed for list
        private void songBox_KeyDown(object sender, KeyEventArgs e)
        {
            // If it is delete button
            if (e.KeyCode == Keys.Delete)
            {
                // If a song is selected, remove it from list
                if (songBox.SelectedIndex != -1)
                {
                    playlist.removeItem(playlist.Item[songBox.SelectedIndex]);
                    songBox.Items.RemoveAt(songBox.SelectedIndex);
                }            
            }
            else if (e.KeyCode == Keys.Space)
            {
                play_pause_inversion();
            }
        }

        /*
            When the form loads  
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            // Make the player invisible, add a playlist to it
            wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.uiMode = "invisible";
            playlist = wplayer.playlistCollection.newPlaylist("pLIST");
            wplayer.currentPlaylist = playlist;

            // Default volume
            wplayer.settings.volume = 75;
            volume_bar.Value = wplayer.settings.volume;

            // If arguments are more than 1, play the media
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                foreach (string file in Environment.GetCommandLineArgs())
                {
                    // If it is the exec name, skip adding
                    if (file == Environment.GetCommandLineArgs()[0])
                    {
                        continue;
                    }

                    Add_To_Playlist(file);
                }

                progress_bar.Value = 0;
                wplayer.controls.currentPosition = 0;
                wplayer.controls.play();
                play_pause.Text = pause;
            }

            // Timer for setting value in progress_bar
            timer_1 = new Timer();
            timer_1.Tick += new EventHandler(update_progress);
            timer_1.Interval = 100;
            timer_1.Enabled = true;
        }

        private void update_progress(object source, EventArgs e)
        {
            if ((int)wplayer.playState == 3)
            {
                if (progress_bar.Maximum != Convert.ToInt32(wplayer.currentMedia.duration))
                {
                    progress_bar.Maximum = Convert.ToInt32(wplayer.currentMedia.duration);
                }

                progress_bar.Value = Convert.ToInt32(wplayer.controls.currentPosition);
            }
        }

        // When the program exits
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            wplayer.controls.stop();
            timer_1.Enabled = false;

            WMPLib.IWMPPlaylistArray plCollection = wplayer.playlistCollection.getByName("pLIST");
            if (plCollection.count > 0)
            {
                WMPLib.IWMPPlaylist pl = plCollection.Item(0);
                wplayer.playlistCollection.remove(pl);
            }
        }

        // Invert state of playing
        private void play_pause_inversion()
        {
            if (play_pause.Text == pause)
            {
                wplayer.controls.pause();
                play_pause.Text = play;
            }
            else if (play_pause.Text == play)
            {
                wplayer.controls.play();
                play_pause.Text = pause;
            }
        }

        // Play/pause button clicked
        private void play_pause_Click(object sender, EventArgs e)
        {
            play_pause_inversion();
        }

        // Volume controller
        private void volume_bar_Scroll(object sender, EventArgs e)
        {
            wplayer.settings.volume = volume_bar.Value;
        }

        // When double clicked on listbox
        private void songBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // If a name is selected play it
            if (songBox.SelectedIndex != -1)
            {
                media = wplayer.currentPlaylist.Item[songBox.SelectedIndex];
                wplayer.controls.playItem(media);

                play_pause.Text = pause;
            }
        }

        // A button is pressed
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Space pressed
            if (e.KeyCode == Keys.Space)
            {
                play_pause_inversion();
            }
        }

        // When progress_bar is scrolled
        private void progress_bar_Scroll(object sender, EventArgs e)
        {
            wplayer.controls.currentPosition = progress_bar.Value;
        }

        // When progress_bar is clicked, slightly missing on the edges
        private void progress_bar_MouseDown(object sender, MouseEventArgs e)
        {
            double actual_value = ((double)e.X / progress_bar.Width) *
                (progress_bar.Maximum - progress_bar.Minimum);

            progress_bar.Value = Convert.ToInt32(actual_value);
            wplayer.controls.currentPosition = progress_bar.Value;
        }
    }
}
