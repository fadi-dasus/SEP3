using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWorld
{
    public partial class Subscribe : Form
    {
        private bool _dragging;
        private Point _offset;

        public Subscribe()
        {
            InitializeComponent();
        }

        private void Subscribe_MouseDown(object sender, MouseEventArgs e)
        {
            {
                _offset.X = e.X;
                _offset.Y = e.Y;
                _dragging = true;
            }
        }

        private void Subscribe_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }
        }

        private void Subscribe_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(textBox_Email.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Invalid Email.");
            } else if(textBox_Password.Text != textBox_ConfirmPassword.Text)
            {
                MessageBox.Show("The password doesn't matchs the confirmation");

            }
            else {


                var restClient = new RestClient("https://localhost:8443/sep3/customer");
                var restRequest = new RestRequest("link", Method.GET);
                restRequest.AddParameter("username", textBox_Username.Text);

                var response = restClient.Execute(restRequest);

                if (response.IsSuccessful)
                {
                    System.Diagnostics.Process.Start(response.Content);

                    comboBox_Subscription.Enabled = false;
                    textBox_Username.Enabled = false;
                    textBox_Password.Enabled = false;
                    textBox_ConfirmPassword.Enabled = false;
                    textBox_Email.Enabled = false;


                }
                else
                 {

                    MessageBox.Show("The username is already exist");
                 }


            }

        }
        private void button_Subscribe_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.expiryDate = comboBox_Subscription.Text;
            customer.username = textBox_Username.Text;
            customer.password = MD5Hash(textBox_Password.Text);
            customer.email = textBox_Email.Text;

            var json = JsonConvert.SerializeObject(customer);

            var restClient = new RestClient("https://localhost:8443/sep3");
            var restRequest = new RestRequest("customer", Method.POST);

            restRequest.AddParameter("application/json", json, ParameterType.RequestBody);

            var response = restClient.Execute(restRequest);

            if (response.IsSuccessful)
            {
                MessageBox.Show("the subscription has been created");
                Session.IsSession = true;
            }
            else
            {
                MessageBox.Show("please pay and try again");
            }


        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public static string MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text  
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it  
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits for each byte  
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }


    }
}
