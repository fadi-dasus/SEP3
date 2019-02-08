using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RestSharp;
using RestSharp.Serializers;
using Newtonsoft.Json;

namespace MovieWorld
{
    public partial class AllGenres : UserControl
    {

        BackgroundWorker worker;
        private delegate void Delegate();
        
        public AllGenres()
        {
            InitializeComponent();
            worker = new BackgroundWorker();

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void worker_doWork(object sender, DoWorkEventArgs e)
        {
            Delegate del = new Delegate(CreateLayout);
            this.Invoke(del);

        }


        public void CreateLayout()
        {



            var client = new RestClient("https://localhost:8443/sep3");

            var request = new RestRequest("movies", Method.GET);

            var list = client.Execute(request).Content;


            List<Movie> mlist = JsonConvert.DeserializeObject<List<Movie>>(list);

            MovieList.movies = mlist;



            foreach (Movie m in MovieList.movies)
            {

                MoviePanel moviePanel = new MoviePanel();

                moviePanel.Title = m.title;
                moviePanel.Link = m.urlFullMovie;
                moviePanel.Image = m.urlImage;
                moviePanel.Height = 230;
                moviePanel.Width = 150;
                flowLayoutPanel1.Controls.Add(moviePanel);

            }


        }

        private void Movies_Load(object sender, EventArgs e)
        {
            worker.DoWork += worker_doWork;
            worker.RunWorkerAsync();
        }
    }
}
