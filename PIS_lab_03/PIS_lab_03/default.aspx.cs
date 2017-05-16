using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_03_test {
    public partial class _default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void GetButton_Click(object sender, EventArgs e) {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:40305/lab_03/test.msu?n=sergei&s=murkou");
            request.Method = "GET";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Response.Write(reader.ReadToEnd());
        }

        protected void PostButton_Click(object sender, EventArgs e) {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:40305/lab_03/test.msu");
            request.Method = "POST";
            //request.MaximumResponseHeadersLength = 100;  // максимальная длина заголовков ответа

            string postData = "n=sergei&s=murkou";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream postDataStream = request.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Response.Write(reader.ReadToEnd());

        }

        protected void PutButton_Click(object sender, EventArgs e) {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:40305/lab_03/test.msu");
            request.Method = "PUT";
            //request.MaximumResponseHeadersLength = 100;  // максимальная длина заголовков ответа

            string postData = "n=sergei&s=murkou";
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream postDataStream = request.GetRequestStream();
            postDataStream.Write(byteArray, 0, byteArray.Length);
            postDataStream.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());
            Response.Write(reader.ReadToEnd());
        }

        protected void ErrorButton_Click(object sender, EventArgs e) {
            try {
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create("http://localhost:40305/lab_03/test.err?n=sergei&s=murkou");
                request.Method = "GET";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                Response.Write(reader.ReadToEnd());
            } catch (WebException error) {
                Response.Write(error.Status);
                Response.Write("<br/>" + error.Message);
                Response.Write("<br/>" + error.TargetSite);
                Response.Write("<br/>" + error.Source);
            }
        }
    }
}