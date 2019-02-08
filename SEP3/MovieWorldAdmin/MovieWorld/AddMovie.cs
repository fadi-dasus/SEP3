using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieWorld
{
    public partial class AddMovie : Form
    {
        public Form RefToMain { get; set; }

        private bool _dragging;
        private Point _offset;

        public AddMovie()
        {
            InitializeComponent();
        }


        private void AddMovie_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }



        private void AddMovie_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point
                    (currentScreenPos.X - _offset.X,
                     currentScreenPos.Y - _offset.Y);
            }

        }

        private void AddMovie_MouseDown(object sender, MouseEventArgs e)
        {
            _offset.X = e.X;
            _offset.Y = e.Y;
            _dragging = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.RefToMain.Show();
            Close();
        }



        private void button_Save_Click(object sender, EventArgs e)
        {


                Movie movie = new Movie();
                movie.title = textBox_Title.Text;
                movie.director = textBox_Director.Text;
                movie.description = textBox_Description.Text;
                movie.duration = textBox_Duration.Text;
                movie.urlTrailer = GetContainerSASToken(textBox_TrailerURL.Text);
                movie.urlFullMovie = GetContainerSASToken(textBox_MovieURL.Text);
                movie.urlImage = GetContainerSASToken(textBox_ImageURL.Text);
                movie.category = comboBox_Genre.Text;

                var json = JsonConvert.SerializeObject(movie);

                var restClient = new RestClient("https://localhost:8443/sep3");
                var restRequest = new RestRequest("movie", Method.POST);

                restRequest.AddParameter("application/json", json, ParameterType.RequestBody);

                var response = restClient.Execute(restRequest);
            
                if (response.IsSuccessful)
                {
                    MessageBox.Show("The Movie is added succsefully");

                    textBox_Title.Text = "";
                    textBox_Director.Text = "";
                    textBox_Description.Text = "";
                    textBox_Duration.Text = "";
                    textBox_TrailerURL.Text = "";
                    textBox_MovieURL.Text = "";
                    textBox_ImageURL.Text = "";
                    comboBox_Genre.Text = "Select Genres";
                }

                else
                {
                    MessageBox.Show("Error!");
                }


        }

        private static string GetContainerSASToken(string xURL)
        {
            string containerName = "mediacontainer";
            string azureStorageSharedKey = "gGzDkZqtx3T++aAeF7pvT3XqN3F2ZqMPsg9icOEHnURBUqpogrspFzd/JBiDRZ4VfmgGVn4k9sfXhBc9eR4qBQ==";
            string canonicalPathToResource = string.Empty;
            string storageConnectionString = "DefaultEndpointsProtocol=https;AccountName=sep3;AccountKey=gGzDkZqtx3T++aAeF7pvT3XqN3F2ZqMPsg9icOEHnURBUqpogrspFzd/JBiDRZ4VfmgGVn4k9sfXhBc9eR4qBQ==;EndpointSuffix=core.windows.net";
            string[] tokens = storageConnectionString.Split(';');
            string storageAccountName = tokens[1].Remove(0, 12);
            string permissions = "r";
            DateTime startTime = DateTime.UtcNow;
            DateTime expiryTime = startTime.AddHours(867240);
            string policyIdentifer = "tempAccess";
            string signature = string.Empty;

            //Parse the connection string and return a reference to the storage account.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(storageConnectionString);
            //Create the blob client object.
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            //Get a reference to a container to use for the sample code, and create it if it does not exist.
            CloudBlobContainer container = null;

            container = blobClient.GetContainerReference(containerName);
            canonicalPathToResource = ("/" + storageAccountName.Trim() + "/" + containerName).Trim();
            //Get a reference to a blob within the container.
            byte[] keyForSigning = System.Convert.FromBase64String(azureStorageSharedKey.Trim());

            string sStartTime = startTime.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");
            string sExpiryTime = expiryTime.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");

            string stringtosign = permissions + "\n" +
                   sStartTime + "\n" +
                   sExpiryTime + "\n" +
                   canonicalPathToResource + "\n" +
                   policyIdentifer;

            using (var hmac = new HMACSHA256(keyForSigning))
            {
                signature = System.Convert.ToBase64String(
                   hmac.ComputeHash(Encoding.UTF8.GetBytes(stringtosign))
                );
            }

            BlobContainerPermissions bcPermissions = new BlobContainerPermissions();
            bcPermissions.SharedAccessPolicies.Add(policyIdentifer, new SharedAccessBlobPolicy { });
            container.SetPermissionsAsync(bcPermissions);

            string sharedAccessSignature = string.Format("st={0}&se={1}&sr=c&sp=r&sig={2}&si={3}",
                Uri.EscapeDataString(sStartTime),
                Uri.EscapeDataString(sExpiryTime),
                Uri.EscapeDataString(signature),
                Uri.EscapeDataString(policyIdentifer));
            string url = xURL+"?" + string.Format(sharedAccessSignature);

            return url;
        }
    }
}
