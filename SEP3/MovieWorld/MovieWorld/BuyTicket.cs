using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWorld
{
    public partial class BuyTicket : Form
    {
        

        private bool _dragging;
        private Point _offset;

        Movie movie = new Movie();

        private string movieId;

        public string MovieId { get => movieId; set => movieId = value; }

        public BuyTicket()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void BuyTicket_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;
        }

        private void BuyTicket_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void BuyTicket_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox_FirstName.Text = "";
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox_LastName.Text = "";
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
           
        }

        private void button_GoToPayment_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(textBox_email.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email.");
            }
            else
            {
                var restClient = new RestClient("https://localhost:8443/sep3/ticket");
                var restRequest = new RestRequest("link", Method.GET);


                var response = restClient.Execute(restRequest);

                System.Diagnostics.Process.Start(response.Content);
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Movie m in MovieList.movies)
            {
                if (m.id == this.movieId)
                {
                    this.movie = m;

                }
            }

            Ticket ticket = new Ticket();
            ticket.firstName = textBox_FirstName.Text;
            ticket.lastName = textBox_LastName.Text;
            ticket.time = comboBox_SelectTime.Text;
            ticket.movieDate =dateTimePicker_SelectDate.Text;
            //ticket.movieDate = Convert.ToDateTime(dateTimePicker_SelectDate.Text);
            ticket.dateOfBirth = dateTimePicker_DOB.Text;
            ticket.movie = this.movie;


            var json = JsonConvert.SerializeObject(ticket);

            var restClient = new RestClient("https://localhost:8443/sep3");
            var restRequest = new RestRequest("ticket", Method.POST);

            restRequest.AddParameter("application/json", json, ParameterType.RequestBody);

            var response = restClient.Execute(restRequest);

            Ticket Ticketobj = JsonConvert.DeserializeObject<Ticket>(response.Content);
            //Movie json = JsonConvert.DeserializeObject<Movie>(list);




            if (response.IsSuccessful)
            {
                PrintableTicket printableTicket = new PrintableTicket();

                printableTicket.FirstName = Ticketobj.firstName;
                printableTicket.LastName = Ticketobj.lastName;
                printableTicket.MovieDate = Ticketobj.movieDate;
                printableTicket.Time = Ticketobj.time;
                printableTicket.MovieTitle = Ticketobj.movie.title;
                printableTicket.Category = Ticketobj.movie.category;
                printableTicket.Director = Ticketobj.movie.director;
                printableTicket.Description = Ticketobj.movie.description;
                printableTicket.Duration = Ticketobj.movie.duration;

                //---------------------------------------------------------------------
                string from = "movieworldvia@gmail.com";
                string to = textBox_email.Text;
                string subject = "Ticket";
                string body = JsonConvert.SerializeObject(printableTicket);
                string password = "&2Qc8Dj6K689IW";

                try
                {
                    MailMessage mail = new MailMessage(from, to, subject, body);
                    SmtpClient client = new SmtpClient();
                    client.Port = 587;
                    client.Host = "smtp.gmail.com";
                    client.Credentials = new System.Net.NetworkCredential(from, password);
                    client.EnableSsl = true;
                    client.Send(mail);
                    MessageBox.Show("The Ticket has been sent to: " + to);
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

                //---------------------------------------------------------------------
                MessageBox.Show(body);
                
                this.Close();
            }
            else
            {
                MessageBox.Show("please pay and try again");
            }
        }
    }
}
