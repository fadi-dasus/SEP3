using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWorld
{
    public partial class MovieDetail : Form
    {
        

        private bool _dragging;
        private Point _offset;

        public MovieDetail()
        {
            InitializeComponent();

            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MovieDetail_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void MovieDetail_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;

        }

        private void MovieDetail_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void MovieDetail_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_detailed_Click(object sender, EventArgs e)
        {
            
        }

        private void button_trailer_Click(object sender, EventArgs e)
        {
            

        }

        private void label_desc_Click(object sender, EventArgs e)
        {

        }

        private void button_buy_Click(object sender, EventArgs e)
        {
            
        }

        private void button_watch_Click(object sender, EventArgs e)
        {

        }
    }
}
