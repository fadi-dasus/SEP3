namespace MovieWorld
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.labellogging = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.about1 = new MovieWorld.About();
            this.horror1 = new MovieWorld.Horror();
            this.drama1 = new MovieWorld.Drama();
            this.crime1 = new MovieWorld.Crime();
            this.comedy1 = new MovieWorld.Comedy();
            this.action1 = new MovieWorld.Action();
            this.adventure1 = new MovieWorld.Adventure();
            this.allGenres1 = new MovieWorld.AllGenres();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxLogging = new System.Windows.Forms.PictureBox();
            this.pictureBoxInfo = new System.Windows.Forms.PictureBox();
            this.pictureBoxPowerOff = new System.Windows.Forms.PictureBox();
            this.buttonAllGenres = new System.Windows.Forms.Button();
            this.buttonDrama = new System.Windows.Forms.Button();
            this.buttonComedy = new System.Windows.Forms.Button();
            this.buttonAction = new System.Windows.Forms.Button();
            this.buttonCrime = new System.Windows.Forms.Button();
            this.buttonHorror = new System.Windows.Forms.Button();
            this.buttonAdventure = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogging)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBoxLogging);
            this.panel1.Controls.Add(this.pictureBoxInfo);
            this.panel1.Controls.Add(this.pictureBoxPowerOff);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labellogging);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 652);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "PowerOff";
            // 
            // labellogging
            // 
            this.labellogging.AutoSize = true;
            this.labellogging.Location = new System.Drawing.Point(58, 619);
            this.labellogging.Name = "labellogging";
            this.labellogging.Size = new System.Drawing.Size(91, 17);
            this.labellogging.TabIndex = 19;
            this.labellogging.Text = "Login/Logout";
            this.labellogging.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "About";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonAllGenres);
            this.panel5.Controls.Add(this.buttonDrama);
            this.panel5.Controls.Add(this.MenuPanel);
            this.panel5.Controls.Add(this.buttonComedy);
            this.panel5.Controls.Add(this.buttonAction);
            this.panel5.Controls.Add(this.buttonCrime);
            this.panel5.Controls.Add(this.buttonHorror);
            this.panel5.Controls.Add(this.buttonAdventure);
            this.panel5.Location = new System.Drawing.Point(0, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(228, 285);
            this.panel5.TabIndex = 2;
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MenuPanel.Location = new System.Drawing.Point(1, 9);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(5, 39);
            this.MenuPanel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 128);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bringing the world inside!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Movie World";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // about1
            // 
            this.about1.BackColor = System.Drawing.Color.White;
            this.about1.Location = new System.Drawing.Point(226, 3);
            this.about1.Name = "about1";
            this.about1.Size = new System.Drawing.Size(1067, 649);
            this.about1.TabIndex = 8;
            // 
            // horror1
            // 
            this.horror1.AutoScroll = true;
            this.horror1.BackColor = System.Drawing.SystemColors.Control;
            this.horror1.Location = new System.Drawing.Point(226, 25);
            this.horror1.Name = "horror1";
            this.horror1.Size = new System.Drawing.Size(1067, 627);
            this.horror1.TabIndex = 7;
            // 
            // drama1
            // 
            this.drama1.AutoScroll = true;
            this.drama1.BackColor = System.Drawing.SystemColors.Control;
            this.drama1.Location = new System.Drawing.Point(226, 25);
            this.drama1.Name = "drama1";
            this.drama1.Size = new System.Drawing.Size(1067, 627);
            this.drama1.TabIndex = 6;
            // 
            // crime1
            // 
            this.crime1.AutoScroll = true;
            this.crime1.BackColor = System.Drawing.SystemColors.Control;
            this.crime1.Location = new System.Drawing.Point(226, 25);
            this.crime1.Name = "crime1";
            this.crime1.Size = new System.Drawing.Size(1067, 627);
            this.crime1.TabIndex = 5;
            // 
            // comedy1
            // 
            this.comedy1.AutoScroll = true;
            this.comedy1.BackColor = System.Drawing.SystemColors.Control;
            this.comedy1.Location = new System.Drawing.Point(226, 25);
            this.comedy1.Name = "comedy1";
            this.comedy1.Size = new System.Drawing.Size(1067, 627);
            this.comedy1.TabIndex = 4;
            // 
            // action1
            // 
            this.action1.AutoScroll = true;
            this.action1.BackColor = System.Drawing.SystemColors.Control;
            this.action1.Location = new System.Drawing.Point(226, 25);
            this.action1.Name = "action1";
            this.action1.Size = new System.Drawing.Size(1067, 627);
            this.action1.TabIndex = 3;
            // 
            // adventure1
            // 
            this.adventure1.AutoScroll = true;
            this.adventure1.BackColor = System.Drawing.SystemColors.Control;
            this.adventure1.Location = new System.Drawing.Point(226, 25);
            this.adventure1.Name = "adventure1";
            this.adventure1.Size = new System.Drawing.Size(1067, 627);
            this.adventure1.TabIndex = 2;
            // 
            // allGenres1
            // 
            this.allGenres1.AutoScroll = true;
            this.allGenres1.BackColor = System.Drawing.SystemColors.Control;
            this.allGenres1.Location = new System.Drawing.Point(226, 25);
            this.allGenres1.Name = "allGenres1";
            this.allGenres1.Size = new System.Drawing.Size(1067, 627);
            this.allGenres1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MovieWorld.Properties.Resources.message_2_24;
            this.pictureBox2.Location = new System.Drawing.Point(90, 146);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBoxLogging
            // 
            this.pictureBoxLogging.Image = global::MovieWorld.Properties.Resources.login_241;
            this.pictureBoxLogging.Location = new System.Drawing.Point(90, 582);
            this.pictureBoxLogging.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogging.Name = "pictureBoxLogging";
            this.pictureBoxLogging.Size = new System.Drawing.Size(39, 38);
            this.pictureBoxLogging.TabIndex = 11;
            this.pictureBoxLogging.TabStop = false;
            this.pictureBoxLogging.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBoxInfo
            // 
            this.pictureBoxInfo.Image = global::MovieWorld.Properties.Resources.info_2_241;
            this.pictureBoxInfo.Location = new System.Drawing.Point(14, 582);
            this.pictureBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxInfo.Name = "pictureBoxInfo";
            this.pictureBoxInfo.Size = new System.Drawing.Size(39, 38);
            this.pictureBoxInfo.TabIndex = 10;
            this.pictureBoxInfo.TabStop = false;
            this.pictureBoxInfo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBoxPowerOff
            // 
            this.pictureBoxPowerOff.Image = global::MovieWorld.Properties.Resources.power_241;
            this.pictureBoxPowerOff.Location = new System.Drawing.Point(174, 582);
            this.pictureBoxPowerOff.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPowerOff.Name = "pictureBoxPowerOff";
            this.pictureBoxPowerOff.Size = new System.Drawing.Size(39, 38);
            this.pictureBoxPowerOff.TabIndex = 2;
            this.pictureBoxPowerOff.TabStop = false;
            this.pictureBoxPowerOff.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonAllGenres
            // 
            this.buttonAllGenres.FlatAppearance.BorderSize = 0;
            this.buttonAllGenres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllGenres.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAllGenres.Image = global::MovieWorld.Properties.Resources.video_multi_241;
            this.buttonAllGenres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAllGenres.Location = new System.Drawing.Point(7, 9);
            this.buttonAllGenres.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAllGenres.Name = "buttonAllGenres";
            this.buttonAllGenres.Size = new System.Drawing.Size(219, 39);
            this.buttonAllGenres.TabIndex = 3;
            this.buttonAllGenres.Text = "All Genres";
            this.buttonAllGenres.UseVisualStyleBackColor = true;
            this.buttonAllGenres.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDrama
            // 
            this.buttonDrama.FlatAppearance.BorderSize = 0;
            this.buttonDrama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrama.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrama.Image = global::MovieWorld.Properties.Resources.drama_241;
            this.buttonDrama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrama.Location = new System.Drawing.Point(7, 200);
            this.buttonDrama.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDrama.Name = "buttonDrama";
            this.buttonDrama.Size = new System.Drawing.Size(219, 39);
            this.buttonDrama.TabIndex = 8;
            this.buttonDrama.Text = "Drama";
            this.buttonDrama.UseVisualStyleBackColor = true;
            this.buttonDrama.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // buttonComedy
            // 
            this.buttonComedy.FlatAppearance.BorderSize = 0;
            this.buttonComedy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComedy.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComedy.Image = global::MovieWorld.Properties.Resources.comedy_2_241;
            this.buttonComedy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComedy.Location = new System.Drawing.Point(7, 124);
            this.buttonComedy.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComedy.Name = "buttonComedy";
            this.buttonComedy.Size = new System.Drawing.Size(219, 39);
            this.buttonComedy.TabIndex = 6;
            this.buttonComedy.Text = "Comedy";
            this.buttonComedy.UseVisualStyleBackColor = true;
            this.buttonComedy.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // buttonAction
            // 
            this.buttonAction.FlatAppearance.BorderSize = 0;
            this.buttonAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAction.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAction.Image = global::MovieWorld.Properties.Resources.action_241;
            this.buttonAction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAction.Location = new System.Drawing.Point(7, 47);
            this.buttonAction.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAction.Name = "buttonAction";
            this.buttonAction.Size = new System.Drawing.Size(219, 39);
            this.buttonAction.TabIndex = 4;
            this.buttonAction.Text = "Action";
            this.buttonAction.UseVisualStyleBackColor = true;
            this.buttonAction.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonCrime
            // 
            this.buttonCrime.FlatAppearance.BorderSize = 0;
            this.buttonCrime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCrime.Image = global::MovieWorld.Properties.Resources.crime_241;
            this.buttonCrime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCrime.Location = new System.Drawing.Point(7, 162);
            this.buttonCrime.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCrime.Name = "buttonCrime";
            this.buttonCrime.Size = new System.Drawing.Size(219, 39);
            this.buttonCrime.TabIndex = 7;
            this.buttonCrime.Text = "Crime";
            this.buttonCrime.UseVisualStyleBackColor = true;
            this.buttonCrime.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // buttonHorror
            // 
            this.buttonHorror.FlatAppearance.BorderSize = 0;
            this.buttonHorror.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHorror.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHorror.Image = global::MovieWorld.Properties.Resources.horror_241;
            this.buttonHorror.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHorror.Location = new System.Drawing.Point(7, 239);
            this.buttonHorror.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHorror.Name = "buttonHorror";
            this.buttonHorror.Size = new System.Drawing.Size(219, 39);
            this.buttonHorror.TabIndex = 9;
            this.buttonHorror.Text = "Horror";
            this.buttonHorror.UseVisualStyleBackColor = true;
            this.buttonHorror.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // buttonAdventure
            // 
            this.buttonAdventure.FlatAppearance.BorderSize = 0;
            this.buttonAdventure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdventure.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdventure.Image = global::MovieWorld.Properties.Resources.adventures_241;
            this.buttonAdventure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdventure.Location = new System.Drawing.Point(7, 86);
            this.buttonAdventure.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdventure.Name = "buttonAdventure";
            this.buttonAdventure.Size = new System.Drawing.Size(219, 39);
            this.buttonAdventure.TabIndex = 5;
            this.buttonAdventure.Text = "Adventure";
            this.buttonAdventure.UseVisualStyleBackColor = true;
            this.buttonAdventure.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieWorld.Properties.Resources.popcorn_576599_960_7201;
            this.pictureBox1.Location = new System.Drawing.Point(75, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Message us";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1293, 652);
            this.Controls.Add(this.about1);
            this.Controls.Add(this.horror1);
            this.Controls.Add(this.drama1);
            this.Controls.Add(this.crime1);
            this.Controls.Add(this.comedy1);
            this.Controls.Add(this.action1);
            this.Controls.Add(this.adventure1);
            this.Controls.Add(this.allGenres1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogging)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPowerOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAllGenres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDrama;
        private System.Windows.Forms.Button buttonCrime;
        private System.Windows.Forms.Button buttonComedy;
        private System.Windows.Forms.Button buttonAdventure;
        private System.Windows.Forms.Button buttonAction;
        private System.Windows.Forms.Button buttonHorror;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.PictureBox pictureBoxPowerOff;
        private System.Windows.Forms.PictureBox pictureBoxInfo;
        public System.Windows.Forms.PictureBox pictureBoxLogging;
        private AllGenres allGenres1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labellogging;
        private Adventure adventure1;
        private Action action1;
        private Comedy comedy1  ;
        private Crime crime1;
        private Drama drama1;
        private Horror horror1;
        private About about1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
    }
}

