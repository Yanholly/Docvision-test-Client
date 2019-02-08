using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using MessageClient.NewFolder1;
using System.Net;
using System.IO;

namespace MessageClient
{
  
    public partial class MainWindow : Form
    {
        public MainWindow()
        {

            InitializeComponent();
            UpdateTable();
            labelLogin.Text = MyUser.CurrentUser;

        }

   
        private async void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textTitle.Text.Length != 0 || textSender.Text.Length != 0 || textMessage.Text.Length != 0)
            {

                List<string> tags = new List<string>();
                for (int i = 0; i < textTags.Lines.Count(); i++)
                    tags.Add(textTags.Lines[i]);
                
                MyMessage myMessage = new MyMessage(0, textTitle.Text, tags, textSender.Text, "Kosyak", monthCalendar1.SelectionRange.Start.ToString(), textMessage.Text);

                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51569/Letter");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = await Task.Run(() => JsonConvert.SerializeObject(myMessage));
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                string result = null;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                if (result == "0" || result == "false")
                    MessageBox.Show("Неудача");
                else
                {
                    UpdateTable();
                    MessageBox.Show("Успешно");

                }
            }
            else
                MessageBox.Show("Заполните все поля!");
        }

        private void UpdateTable()
        {
            listView1.Items.Clear();
            var httpWebRequest = (HttpWebRequest)WebRequest.Create($"http://localhost:51569/Letter?userId={MyUser.UserId}");
            
            httpWebRequest.Method = "GET";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result = null;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            if (result == "0" || result == "false")
                MessageBox.Show("Неудача");
            else
            {
              string myMessagesSTR = JsonConvert.DeserializeObject<string>(result);
              List<MyMessage> myMessagesJSON = JsonConvert.DeserializeObject<List<MyMessage>>(myMessagesSTR);
                for (int i = 0; i < myMessagesJSON.Count;i++)
                {
                    string tags = string.Empty;
                    for (int j = 0; j < myMessagesJSON[i].Tags.Count; j++)
                        tags += myMessagesJSON[i].Tags[j] + "; ";

                    ListViewItem lvi = new ListViewItem(myMessagesJSON[i].Title);
                    lvi.SubItems.Add(myMessagesJSON[i].Sender);
                    lvi.SubItems.Add(tags);
                    lvi.SubItems.Add(myMessagesJSON[i].Content);
                    lvi.SubItems.Add(myMessagesJSON[i].Date);
                    lvi.SubItems.Add(myMessagesJSON[i].MessageId.ToString());
                    listView1.Items.Add(lvi);
                }

            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create($"http://localhost:51569/Letter?letterId={int.Parse(listView1.SelectedItems[0].SubItems[5].Text)}");

            httpWebRequest.Method = "DELETE";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result = null;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            if (result == "0" || result == "false")
                MessageBox.Show("Неудача");
            UpdateTable();
        }
    }
}
