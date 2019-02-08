namespace MovieWorld
{
    partial class RemoveMovie
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSelectGenres = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSelectMovie = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(205, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Select Genre";
            // 
            // comboBoxSelectGenres
            // 
            this.comboBoxSelectGenres.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectGenres.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSelectGenres.FormattingEnabled = true;
            this.comboBoxSelectGenres.Items.AddRange(new object[] {
            "Action",
            "Adventure",
            "Comedy",
            "Crime",
            "Drama",
            "Horror"});
            this.comboBoxSelectGenres.Location = new System.Drawing.Point(364, 176);
            this.comboBoxSelectGenres.Name = "comboBoxSelectGenres";
            this.comboBoxSelectGenres.Size = new System.Drawing.Size(365, 29);
            this.comboBoxSelectGenres.TabIndex = 8;
            this.comboBoxSelectGenres.Text = "Select Genre";
            this.comboBoxSelectGenres.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectGenres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(205, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select Movie";
            // 
            // comboBoxSelectMovie
            // 
            this.comboBoxSelectMovie.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSelectMovie.ForeColor = System.Drawing.Color.Black;
            this.comboBoxSelectMovie.FormattingEnabled = true;
            this.comboBoxSelectMovie.Location = new System.Drawing.Point(364, 243);
            this.comboBoxSelectMovie.Name = "comboBoxSelectMovie";
            this.comboBoxSelectMovie.Size = new System.Drawing.Size(365, 29);
            this.comboBoxSelectMovie.TabIndex = 10;
            this.comboBoxSelectMovie.Text = "Select Movie";
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(439, 355);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(150, 42);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // RemoveMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(964, 556);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSelectMovie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSelectGenres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemoveMovie";
            this.Text = "RemoveMovie";
            this.Load += new System.EventHandler(this.RemoveMovie_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemoveMovie_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemoveMovie_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoveMovie_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSelectGenres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSelectMovie;
        private System.Windows.Forms.Button buttonDelete;
    }
}