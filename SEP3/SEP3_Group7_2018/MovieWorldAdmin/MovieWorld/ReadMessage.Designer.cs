namespace MovieWorld
{
    partial class ReadMessage
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
            this.dataGridView_MeassageTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MeassageTable)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_MeassageTable
            // 
            this.dataGridView_MeassageTable.AllowUserToAddRows = false;
            this.dataGridView_MeassageTable.AllowUserToDeleteRows = false;
            this.dataGridView_MeassageTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MeassageTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_MeassageTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MeassageTable.Location = new System.Drawing.Point(60, 35);
            this.dataGridView_MeassageTable.Name = "dataGridView_MeassageTable";
            this.dataGridView_MeassageTable.ReadOnly = true;
            this.dataGridView_MeassageTable.RowTemplate.Height = 24;
            this.dataGridView_MeassageTable.Size = new System.Drawing.Size(943, 473);
            this.dataGridView_MeassageTable.TabIndex = 0;
            // 
            // ReadMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(964, 556);
            this.Controls.Add(this.dataGridView_MeassageTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReadMessage";
            this.Text = "ReadMessage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MeassageTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MeassageTable;
    }
}