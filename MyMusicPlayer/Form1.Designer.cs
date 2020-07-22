namespace MyMusicPlayer
{
    partial class MyMusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyMusicPlayer));
            this.topPanel = new System.Windows.Forms.Panel();
            this.minimize_Btn = new System.Windows.Forms.PictureBox();
            this.close_PictureBox = new System.Windows.Forms.PictureBox();
            this.logo_Label = new System.Windows.Forms.Label();
            this.select_Btn = new System.Windows.Forms.Button();
            this.developedLogo_Label = new System.Windows.Forms.Label();
            this.songs_ListBox = new System.Windows.Forms.ListBox();
            this.windowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.removeSong_Btn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.topPanel.Controls.Add(this.minimize_Btn);
            this.topPanel.Controls.Add(this.close_PictureBox);
            this.topPanel.Controls.Add(this.logo_Label);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(919, 41);
            this.topPanel.TabIndex = 0;
            // 
            // minimize_Btn
            // 
            this.minimize_Btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_Btn.Image")));
            this.minimize_Btn.Location = new System.Drawing.Point(830, 5);
            this.minimize_Btn.Name = "minimize_Btn";
            this.minimize_Btn.Size = new System.Drawing.Size(40, 33);
            this.minimize_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_Btn.TabIndex = 2;
            this.minimize_Btn.TabStop = false;
            this.minimize_Btn.Click += new System.EventHandler(this.Minimize_Btn_Click);
            // 
            // close_PictureBox
            // 
            this.close_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("close_PictureBox.Image")));
            this.close_PictureBox.Location = new System.Drawing.Point(865, 5);
            this.close_PictureBox.Name = "close_PictureBox";
            this.close_PictureBox.Size = new System.Drawing.Size(42, 33);
            this.close_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_PictureBox.TabIndex = 1;
            this.close_PictureBox.TabStop = false;
            this.close_PictureBox.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // logo_Label
            // 
            this.logo_Label.AutoSize = true;
            this.logo_Label.Font = new System.Drawing.Font("Ink Free", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_Label.Location = new System.Drawing.Point(32, 9);
            this.logo_Label.Name = "logo_Label";
            this.logo_Label.Size = new System.Drawing.Size(139, 21);
            this.logo_Label.TabIndex = 0;
            this.logo_Label.Text = "My Music Player";
            // 
            // select_Btn
            // 
            this.select_Btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.select_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.select_Btn.ForeColor = System.Drawing.Color.White;
            this.select_Btn.Location = new System.Drawing.Point(688, 457);
            this.select_Btn.Name = "select_Btn";
            this.select_Btn.Size = new System.Drawing.Size(95, 44);
            this.select_Btn.TabIndex = 3;
            this.select_Btn.Text = "Add";
            this.select_Btn.UseVisualStyleBackColor = false;
            this.select_Btn.Click += new System.EventHandler(this.Select_Btn_Click);
            // 
            // developedLogo_Label
            // 
            this.developedLogo_Label.AutoSize = true;
            this.developedLogo_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.developedLogo_Label.Location = new System.Drawing.Point(435, 504);
            this.developedLogo_Label.Name = "developedLogo_Label";
            this.developedLogo_Label.Size = new System.Drawing.Size(191, 17);
            this.developedLogo_Label.TabIndex = 5;
            this.developedLogo_Label.Text = "Developed by: Tony Jimenez";
            // 
            // songs_ListBox
            // 
            this.songs_ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songs_ListBox.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songs_ListBox.FormattingEnabled = true;
            this.songs_ListBox.ItemHeight = 20;
            this.songs_ListBox.Location = new System.Drawing.Point(688, 47);
            this.songs_ListBox.Name = "songs_ListBox";
            this.songs_ListBox.Size = new System.Drawing.Size(219, 404);
            this.songs_ListBox.TabIndex = 2;
            this.songs_ListBox.SelectedIndexChanged += new System.EventHandler(this.Songs_ListBox_SelectedIndexChanged);
            // 
            // windowsMediaPlayer
            // 
            this.windowsMediaPlayer.Enabled = true;
            this.windowsMediaPlayer.Location = new System.Drawing.Point(12, 47);
            this.windowsMediaPlayer.Name = "windowsMediaPlayer";
            this.windowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("windowsMediaPlayer.OcxState")));
            this.windowsMediaPlayer.Size = new System.Drawing.Size(659, 454);
            this.windowsMediaPlayer.TabIndex = 6;
            // 
            // removeSong_Btn
            // 
            this.removeSong_Btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.removeSong_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeSong_Btn.ForeColor = System.Drawing.Color.White;
            this.removeSong_Btn.Location = new System.Drawing.Point(812, 457);
            this.removeSong_Btn.Name = "removeSong_Btn";
            this.removeSong_Btn.Size = new System.Drawing.Size(95, 44);
            this.removeSong_Btn.TabIndex = 7;
            this.removeSong_Btn.Text = "Remove";
            this.removeSong_Btn.UseVisualStyleBackColor = false;
            this.removeSong_Btn.Click += new System.EventHandler(this.RemoveSong_Btn_Click);
            // 
            // MyMusicPlayer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(919, 524);
            this.Controls.Add(this.removeSong_Btn);
            this.Controls.Add(this.windowsMediaPlayer);
            this.Controls.Add(this.developedLogo_Label);
            this.Controls.Add(this.select_Btn);
            this.Controls.Add(this.songs_ListBox);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyMusicPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox close_PictureBox;
        private System.Windows.Forms.Label logo_Label;
        private System.Windows.Forms.Button select_Btn;
        private System.Windows.Forms.Label developedLogo_Label;
        private System.Windows.Forms.ListBox songs_ListBox;
        private AxWMPLib.AxWindowsMediaPlayer windowsMediaPlayer;
        private System.Windows.Forms.Button removeSong_Btn;
        private System.Windows.Forms.PictureBox minimize_Btn;
    }
}

