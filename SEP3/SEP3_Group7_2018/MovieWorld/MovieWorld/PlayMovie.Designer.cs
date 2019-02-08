namespace MovieWorld
{
    partial class PlayMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param title="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMovie));
            this.label_Title = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_fullScreen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.ForeColor = System.Drawing.Color.DimGray;
            this.label_Title.Location = new System.Drawing.Point(130, 3);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(0, 30);
            this.label_Title.TabIndex = 13;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(10, 32);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(637, 361);
            this.axWindowsMediaPlayer.TabIndex = 0;
            this.axWindowsMediaPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer_Trailer_PlayStateChange);
            this.axWindowsMediaPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer_Trailer_Enter);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(613, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MovieWorld.Properties.Resources.close_window_24__1_2;
            this.pictureBox2.Location = new System.Drawing.Point(836, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button_fullScreen
            // 
            this.button_fullScreen.FlatAppearance.BorderSize = 0;
            this.button_fullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fullScreen.Image = global::MovieWorld.Properties.Resources.expand_24__2_1;
            this.button_fullScreen.Location = new System.Drawing.Point(814, 444);
            this.button_fullScreen.Name = "button_fullScreen";
            this.button_fullScreen.Size = new System.Drawing.Size(47, 32);
            this.button_fullScreen.TabIndex = 1;
            this.button_fullScreen.UseVisualStyleBackColor = true;
            this.button_fullScreen.Click += new System.EventHandler(this.button1_Click);
            // 
            // PlayMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(879, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_fullScreen);
            this.Controls.Add(this.axWindowsMediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayMovie";
            this.Load += new System.EventHandler(this.Trailer_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Trailer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Trailer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Trailer_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.Button button_fullScreen;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button1;
    }
}