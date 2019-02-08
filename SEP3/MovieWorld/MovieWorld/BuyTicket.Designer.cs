namespace MovieWorld
{
    partial class BuyTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyTicket));
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_SelectTime = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_GoToPayment = new System.Windows.Forms.Button();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_DOB = new System.Windows.Forms.DateTimePicker();
            this.pictureBox_buy = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker_SelectDate = new System.Windows.Forms.DateTimePicker();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_buy)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(382, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Date of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(382, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(382, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(382, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Select Time";
            // 
            // comboBox_SelectTime
            // 
            this.comboBox_SelectTime.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SelectTime.ForeColor = System.Drawing.Color.Black;
            this.comboBox_SelectTime.FormattingEnabled = true;
            this.comboBox_SelectTime.Items.AddRange(new object[] {
            "13:30",
            "15:30",
            "17:30",
            "19:30",
            "21:30"});
            this.comboBox_SelectTime.Location = new System.Drawing.Point(536, 163);
            this.comboBox_SelectTime.Name = "comboBox_SelectTime";
            this.comboBox_SelectTime.Size = new System.Drawing.Size(365, 29);
            this.comboBox_SelectTime.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieWorld.Properties.Resources.close_window_241;
            this.pictureBox1.Location = new System.Drawing.Point(904, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_GoToPayment
            // 
            this.button_GoToPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GoToPayment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoToPayment.ForeColor = System.Drawing.Color.White;
            this.button_GoToPayment.Location = new System.Drawing.Point(626, 419);
            this.button_GoToPayment.Name = "button_GoToPayment";
            this.button_GoToPayment.Size = new System.Drawing.Size(175, 42);
            this.button_GoToPayment.TabIndex = 7;
            this.button_GoToPayment.Text = "Go To Payment";
            this.button_GoToPayment.UseVisualStyleBackColor = true;
            this.button_GoToPayment.Click += new System.EventHandler(this.button_GoToPayment_Click);
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_LastName.ForeColor = System.Drawing.Color.Black;
            this.textBox_LastName.Location = new System.Drawing.Point(536, 254);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(365, 30);
            this.textBox_LastName.TabIndex = 4;
            this.textBox_LastName.Enter += new System.EventHandler(this.textBox4_Enter);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_FirstName.ForeColor = System.Drawing.Color.Black;
            this.textBox_FirstName.Location = new System.Drawing.Point(536, 208);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(365, 30);
            this.textBox_FirstName.TabIndex = 3;
            this.textBox_FirstName.Enter += new System.EventHandler(this.textBox3_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(342, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buy Ticket";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(382, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 22);
            this.label9.TabIndex = 27;
            this.label9.Text = "Select Date";
            // 
            // dateTimePicker_DOB
            // 
            this.dateTimePicker_DOB.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.dateTimePicker_DOB.Location = new System.Drawing.Point(536, 346);
            this.dateTimePicker_DOB.Name = "dateTimePicker_DOB";
            this.dateTimePicker_DOB.Size = new System.Drawing.Size(365, 30);
            this.dateTimePicker_DOB.TabIndex = 6;
            this.dateTimePicker_DOB.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // pictureBox_buy
            // 
            this.pictureBox_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox_buy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_buy.Location = new System.Drawing.Point(34, 92);
            this.pictureBox_buy.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_buy.Name = "pictureBox_buy";
            this.pictureBox_buy.Size = new System.Drawing.Size(294, 410);
            this.pictureBox_buy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_buy.TabIndex = 29;
            this.pictureBox_buy.TabStop = false;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(626, 490);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 42);
            this.button2.TabIndex = 30;
            this.button2.Text = "Get Ticket";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker_SelectDate
            // 
            this.dateTimePicker_SelectDate.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.dateTimePicker_SelectDate.Location = new System.Drawing.Point(536, 117);
            this.dateTimePicker_SelectDate.Name = "dateTimePicker_SelectDate";
            this.dateTimePicker_SelectDate.Size = new System.Drawing.Size(365, 30);
            this.dateTimePicker_SelectDate.TabIndex = 1;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.ForeColor = System.Drawing.Color.Black;
            this.textBox_email.Location = new System.Drawing.Point(536, 300);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(365, 30);
            this.textBox_email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(382, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 32;
            this.label2.Text = "Email";
            // 
            // BuyTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(964, 556);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.dateTimePicker_SelectDate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox_buy);
            this.Controls.Add(this.dateTimePicker_DOB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_SelectTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_GoToPayment);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuyTicket";
            this.Text = "BuyTicket";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BuyTicket_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BuyTicket_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BuyTicket_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_buy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_SelectTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_GoToPayment;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DOB;
        public System.Windows.Forms.PictureBox pictureBox_buy;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SelectDate;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.Label label2;
    }
}