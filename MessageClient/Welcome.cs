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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            MyUser myUser = new MyUser();
            myUser.Login = textBox1.Text;
            myUser.Password = textBox2.Text;
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51569/UserLogin");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = await Task.Run(() => JsonConvert.SerializeObject(myUser));
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result = null;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            if (result == "0")
                label3.Text = "Пользователь с такими \n логином/паролем не найден";
            else
            {
                label3.Text = "";
                MyUser.UserId = int.Parse(result);
                MyUser.CurrentUser = myUser.Login;
                
                this.Close();
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            MyUser myUser = new MyUser();
            myUser.Login = textBox1.Text;
            myUser.Password = textBox2.Text;

            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:51569/UserRegister");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = await Task.Run(() => JsonConvert.SerializeObject(myUser));
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result = null;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }
            if (result == "0")
                label3.Text = "Логин занят или логин/пароль \n длиннее 10 символов";
            else
            {
                label3.Text = "";
                MyUser.UserId = int.Parse(result);
                MyUser.CurrentUser = myUser.Login;
               
                this.Close();
            }
        }
    }
}
