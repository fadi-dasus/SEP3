using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieWorld
{
    class PrintableTicket
    {

        private string firstName;
        private string lastName;
        private string movieDate;
        private string time;
        private string movieTitle;
        private string category;
        private string director;
        private string description;
        private string duration;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MovieDate { get => movieDate; set => movieDate = value; }
        public string Time { get => time; set => time = value; }
        public string MovieTitle { get => movieTitle; set => movieTitle = value; }
        public string Category { get => category; set => category = value; }
        public string Director { get => director; set => director = value; }
        public string Description { get => description; set => description = value; }
        public string Duration { get => duration; set => duration = value; }
    }

}
