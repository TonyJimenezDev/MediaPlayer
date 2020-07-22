using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
/// <summary>
/// Quick Media player - fully functional
/// </summary>

namespace MyMusicPlayer
{
    public partial class MyMusicPlayer : Form
    {
        string[] nameTrack, paths;
        List<string> trackPaths = new List<string>();

        public MyMusicPlayer()
        {
            InitializeComponent();
            //windowsMediaPlayer.uiMode = "full";
        }
        // Lets me move the window from the form rather than it being static - Currently only movable when clicking form itself
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void Select_Btn_Click(object sender, EventArgs e)
        {
            // Browser diaglog
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            // File selected or not
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                nameTrack = ofd.SafeFileNames; // Saving names of track
                paths = ofd.FileNames; // Saving file paths

                // Display music titles in listbox
                for (int i = 0; i < nameTrack.Length; i++) songs_ListBox.Items.Add(nameTrack[i]);

                // Store paths in list
                for(int i = 0; i < paths.Length; i++) trackPaths.Add(paths[i]);
            }
        }

        private void RemoveSong_Btn_Click(object sender, EventArgs e)
        {
            if(songs_ListBox.SelectedItem != null)
            {
                trackPaths.RemoveAt(songs_ListBox.SelectedIndex);
                songs_ListBox.Items.RemoveAt(songs_ListBox.SelectedIndex);

            }
        }

        private void Songs_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Play player if index exist
            if(trackPaths.ElementAtOrDefault(songs_ListBox.SelectedIndex) != null)
                windowsMediaPlayer.URL = trackPaths[songs_ListBox.SelectedIndex];
        }

        private void Minimize_Btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PictureBox1_Click(object sender, EventArgs e) => Application.Exit();

   
    }
}
