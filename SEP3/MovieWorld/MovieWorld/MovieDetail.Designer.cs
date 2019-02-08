namespace MovieWorld
{
    public partial class MovieDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieDetail));
            this.button_buy = new System.Windows.Forms.Button();
            this.button_watch = new System.Windows.Forms.Button();
            this.label_desc = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.button_trailer = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_detailed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_detailed)).BeginInit();
            this.SuspendLayout();
            // 
            // button_buy
            // 
            this.button_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_buy.FlatAppearance.BorderSize = 0;
            this.button_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_buy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buy.ForeColor = System.Drawing.Color.White;
            this.button_buy.Location = new System.Drawing.Point(563, 433);
            this.button_buy.Margin = new System.Windows.Forms.Padding(4);
            this.button_buy.Name = "button_buy";
            this.button_buy.Size = new System.Drawing.Size(393, 37);
            this.button_buy.TabIndex = 9;
            this.button_buy.Text = "Buy Ticket";
            this.button_buy.UseVisualStyleBackColor = false;
            this.button_buy.Click += new System.EventHandler(this.button_buy_Click);
            // 
            // button_watch
            // 
            this.button_watch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_watch.FlatAppearance.BorderSize = 0;
            this.button_watch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_watch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_watch.ForeColor = System.Drawing.Color.White;
            this.button_watch.Location = new System.Drawing.Point(563, 488);
            this.button_watch.Margin = new System.Windows.Forms.Padding(4);
            this.button_watch.Name = "button_watch";
            this.button_watch.Size = new System.Drawing.Size(393, 37);
            this.button_watch.TabIndex = 7;
            this.button_watch.Text = "Watch Online";
            this.button_watch.UseVisualStyleBackColor = false;
            this.button_watch.Click += new System.EventHandler(this.button_watch_Click);
            // 
            // label_desc
            // 
            this.label_desc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_desc.Location = new System.Drawing.Point(507, 113);
            this.label_desc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_desc.Name = "label_desc";
            this.label_desc.Size = new System.Drawing.Size(489, 311);
            this.label_desc.TabIndex = 5;
            this.label_desc.Text = "\r\n";
            this.label_desc.Click += new System.EventHandler(this.label_desc_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(507, 59);
            this.label_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(0, 34);
            this.label_title.TabIndex = 6;
            // 
            // button_trailer
            // 
            this.button_trailer.BackColor = System.Drawing.Color.Red;
            this.button_trailer.FlatAppearance.BorderSize = 0;
            this.button_trailer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_trailer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_trailer.ForeColor = System.Drawing.Color.White;
            this.button_trailer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_trailer.Location = new System.Drawing.Point(563, 543);
            this.button_trailer.Margin = new System.Windows.Forms.Padding(4);
            this.button_trailer.Name = "button_trailer";
            this.button_trailer.Size = new System.Drawing.Size(393, 37);
            this.button_trailer.TabIndex = 10;
            this.button_trailer.Text = "Trailer";
            this.button_trailer.UseVisualStyleBackColor = false;
            this.button_trailer.Click += new System.EventHandler(this.button_trailer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MovieWorld.Properties.Resources.close_window_24__1_3;
            this.pictureBox2.Location = new System.Drawing.Point(972, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox_detailed
            // 
            this.pictureBox_detailed.Location = new System.Drawing.Point(16, 13);
            this.pictureBox_detailed.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_detailed.Name = "pictureBox_detailed";
            this.pictureBox_detailed.Size = new System.Drawing.Size(448, 582);
            this.pictureBox_detailed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_detailed.TabIndex = 8;
            this.pictureBox_detailed.TabStop = false;
            this.pictureBox_detailed.Click += new System.EventHandler(this.pictureBox_detailed_Click);
            // 
            // MovieDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 608);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_trailer);
            this.Controls.Add(this.button_buy);
            this.Controls.Add(this.pictureBox_detailed);
            this.Controls.Add(this.button_watch);
            this.Controls.Add(this.label_desc);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MovieDetail";
            this.Text = " ";
            this.Load += new System.EventHandler(this.MovieDetail_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovieDetail_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovieDetail_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MovieDetail_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_detailed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button_trailer;
        public System.Windows.Forms.Button button_buy;
        public System.Windows.Forms.Button button_watch;
        public System.Windows.Forms.Label label_desc;
        public System.Windows.Forms.Label label_title;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox_detailed;
    }
}