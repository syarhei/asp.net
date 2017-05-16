using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace PIS_lab_03_client {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void SumButton_Click(object sender, EventArgs e) {
            int X, Y;
            if (int.TryParse(x.Text, out X) && int.TryParse(y.Text, out Y)) {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:40305/lab_03/test.msus");
                request.Method = "POST";
                //request.MaximumResponseHeadersLength = 100;  // максимальная длина заголовков ответа

                string postData = String.Format("n={0}&s={1}", x.Text, y.Text);
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream postDataStream = request.GetRequestStream();
                postDataStream.Write(byteArray, 0, byteArray.Length);
                postDataStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                sum.Text = reader.ReadToEnd();
            }
            else {
                sum.Text = "Put only digits";
            }
        }
    }
}
