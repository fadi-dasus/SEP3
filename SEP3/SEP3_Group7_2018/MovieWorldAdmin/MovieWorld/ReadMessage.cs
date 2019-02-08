using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
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
    public partial class ReadMessage : Form
    {
        List<string> _names = new List<string>();

        List<String[]> _dataArray = new List<string[]>();

        public ReadMessage()
        {
            InitializeComponent();


            _names.Add("From");
            _names.Add("Email");
            _names.Add("Message");

            // Render the DataGridView.
            dataGridView_MeassageTable.DataSource = GetResultsTable();

        }
        public DataTable GetResultsTable()
        {


            var client = new RestClient("https://localhost:8443/sep3");

            var request = new RestRequest("message", Method.GET);

            var list = client.Execute(request).Content;


            List<Message> mlist = JsonConvert.DeserializeObject<List<Message>>(list);

            var from = new List<string>();
            var email = new List<string>();
            var message = new List<string>();


            foreach (Message m in mlist)


            {

                from.Add(m.name);
                email.Add(m.email);
                message.Add(m.body);

            }




            _dataArray.Add(from.ToArray());
            _dataArray.Add(email.ToArray());
            _dataArray.Add(message.ToArray());


            // Create the output table.
            DataTable d = new DataTable();

            // Loop through all process names.
            for (int i = 0; i < this._dataArray.Count; i++)
            {
                // The current process name.
                string name = this._names[i];

                // Add the program name to our columns.
                d.Columns.Add(name);

                // Add all of the memory numbers to an object list.
                List<object> item = new List<object>();

                // Put every column's numbers in this List.
                foreach (string number in this._dataArray[i])
                {
                    item.Add((object)number);
                }

                // Keep adding rows until we have enough.
                while (d.Rows.Count < item.Count)
                {
                    d.Rows.Add();
                }

                // Add each item to the cells in the column.
                for (int a = 0; a < item.Count; a++)
                {
                    d.Rows[a][i] = item[a];
                }
            }
            return d;
        }

    }
}
