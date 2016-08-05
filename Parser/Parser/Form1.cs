using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HtmlAgilityPack;
using System.Net;

namespace Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string str;
            string myURL = textBox_URL.Text;
            myURL = "http://vegetarian.ru/forum/users/";
            Console.Write(myURL+"\n");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(myURL);
            HttpWebResponse respons = (HttpWebResponse)request.GetResponse();

            var webClient = new System.Net.WebClient();
            string HTML = webClient.DownloadString(myURL);
            textBox1.Text = HTML;
            

          

        }

    }
}
