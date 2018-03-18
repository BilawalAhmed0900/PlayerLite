using System;
using System.Threading;
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

        // Strings for play/pause button
        string play = "▶";
        string pause = "⏸";

        public Form1()
        {
            InitializeComponent();
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

                wplayer.controls.play();
                play_pause.Text = pause;
            }
        }

        // When the program exits
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            wplayer.controls.stop();
        }

        // Play/pause button clicked
        private void play_pause_Click(object sender, EventArgs e)
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
    }
}
