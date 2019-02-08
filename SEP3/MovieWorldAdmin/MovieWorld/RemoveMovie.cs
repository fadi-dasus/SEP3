using Newtonsoft.Json;
using RestSharp;
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
    public partial class RemoveMovie : Form
    {
        public Form RefToMain { get; set; }

        private bool _dragging;
        private Point _offset;

        List<Movie> mlist = new List<Movie>(); 

        List<Movie> actionMoviesList = new List<Movie>();
        List<Movie> adventureMoviesList = new List<Movie>();
        List<Movie> comedyMoviesList = new List<Movie>();
        List<Movie> crimeMoviesList = new List<Movie>();
        List<Movie> dramaMoviesList = new List<Movie>();
        List<Movie> horrorMoviesList = new List<Movie>();

        public RemoveMovie()
        {
            InitializeComponent();
        }

        private void RemoveMovie_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;
        }

        private void RemoveMovie_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void RemoveMovie_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.RefToMain.Show();
            Close();
        }

        private void RemoveMovie_Load(object sender, EventArgs e)
        {
            getMovies();
        }

        private void getMovies()
        {
            mlist.Clear();

            actionMoviesList.Clear();
            adventureMoviesList.Clear();
            comedyMoviesList.Clear();
            crimeMoviesList.Clear();
            dramaMoviesList.Clear();
            horrorMoviesList.Clear();


            var client = new RestClient("https://localhost:8443/sep3");

            var request = new RestRequest("movies", Method.GET);

            var list = client.Execute(request).Content;


            mlist = JsonConvert.DeserializeObject<List<Movie>>(list);

            MovieList.movies = mlist;

            foreach (Movie movie in mlist)
            {

                switch (movie.category)
                {
                    case "Action":
                        actionMoviesList.Add(movie);
                        break;
                    case "Adventure":
                        adventureMoviesList.Add(movie);
                        break;
                    case "Comedy":
                        comedyMoviesList.Add(movie);
                        break;
                    case "Crime":
                        crimeMoviesList.Add(movie);
                        break;
                    case "Drama":
                        
                        dramaMoviesList.Add(movie);
                        break;
                    case "Horror":
                        horrorMoviesList.Add(movie);
                        break;
                    default:
                        actionMoviesList.Add(movie);
                        break;
                }

            }

        }

        private void comboBoxSelectGenres_SelectedIndexChanged(object sender, EventArgs e)
        {

                switch (comboBoxSelectGenres.Text)
                    {
                        case "Action":
                            comboBoxSelectMovie.Items.Clear();
                            comboBoxSelectMovie.Text = "";
                            foreach (Movie action in actionMoviesList)
                            {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = action.title;
                            item.Value = action.id;
                            comboBoxSelectMovie.Items.Add(item);

                            }
                        break;

                        case "Adventure":
                            comboBoxSelectMovie.Items.Clear();
                            comboBoxSelectMovie.Text = "";
                            foreach (Movie adventure in adventureMoviesList)
                            {
                                ComboboxItem item = new ComboboxItem();
                                item.Text = adventure.title;
                                item.Value = adventure.id;
                                comboBoxSelectMovie.Items.Add(item);

                            }
                            break;

                        case "Comedy":
                            comboBoxSelectMovie.Items.Clear();
                            comboBoxSelectMovie.Text = "";
                            foreach (Movie comedy in comedyMoviesList)
                            {
                                ComboboxItem item = new ComboboxItem();
                                item.Text = comedy.title;
                                item.Value = comedy.id;
                                comboBoxSelectMovie.Items.Add(item);

                            }
                            break;

                        case "Crime":
                            comboBoxSelectMovie.Items.Clear();
                            comboBoxSelectMovie.Text = "";
                            foreach (Movie crime in crimeMoviesList)
                            {
                                ComboboxItem item = new ComboboxItem();
                                item.Text = crime.title;
                                item.Value = crime.id;
                                comboBoxSelectMovie.Items.Add(item);

                            }
                            break;

                        case "Drama":
                            comboBoxSelectMovie.Items.Clear();
                            comboBoxSelectMovie.Text = "";
                            foreach (Movie drama in dramaMoviesList)
                            {
                                ComboboxItem item = new ComboboxItem();
                                item.Text = drama.title;
                                item.Value = drama.id;
                                comboBoxSelectMovie.Items.Add(item);

                            }
                            break;

                        case "Horror":
                            comboBoxSelectMovie.Items.Clear();
                            comboBoxSelectMovie.Text = "";
                            foreach (Movie horror in horrorMoviesList)
                            {
                                ComboboxItem item = new ComboboxItem();
                                item.Text = horror.title;
                                item.Value = horror.id;
                                comboBoxSelectMovie.Items.Add(item);

                            }
                            break;

                        default:
                            comboBoxSelectMovie.Items.Clear();
                            comboBoxSelectMovie.Text = "";
                            foreach (Movie action in actionMoviesList)
                            {
                                ComboboxItem item = new ComboboxItem();
                                item.Text = action.title;
                                item.Value = action.id;
                                comboBoxSelectMovie.Items.Add(item);

                            }
                            break;

            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string id = (comboBoxSelectMovie.SelectedItem as ComboboxItem).Value.ToString();
            string title = (comboBoxSelectMovie.SelectedItem as ComboboxItem).Text;


            var restClient = new RestClient("https://localhost:8443/sep3");
            var restRequest = new RestRequest("movie/"+ id, Method.DELETE);

            var response = restClient.Execute(restRequest);

            if (response.IsSuccessful)
            {
                MessageBox.Show(title+ " is deleted succsefully");
                comboBoxSelectMovie.Text = "";
                getMovies();

            }

            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
