using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_10_Web {
    public partial class _default : System.Web.UI.Page {

        MSUWS.MSUWSSoapClient client;

        protected void Page_Load(object sender, EventArgs e) {
            client = new MSUWS.MSUWSSoapClient();
        }

        protected void BtnAdd_Click(object sender, EventArgs e) {
            int x = Int32.Parse(TextBoxX.Text.ToString());
            int y = Int32.Parse(TextBoxY.Text.ToString());
            TextBoxRes.Text = this.client.Add(x, y).ToString();
        }

        protected void BtnSub_Click(object sender, EventArgs e) {
            int x = Int32.Parse(TextBoxX.Text.ToString());
            int y = Int32.Parse(TextBoxY.Text.ToString());
            TextBoxRes.Text = this.client.Sub(x, y).ToString();
        }

        protected void BtnMul_Click(object sender, EventArgs e) {
            int x = Int32.Parse(TextBoxX.Text.ToString());
            int y = Int32.Parse(TextBoxY.Text.ToString());
            TextBoxRes.Text = this.client.Mul(x, y).ToString();
        }

        protected void BtnGet_Click(object sender, EventArgs e) {
            TextBoxSessionValue.Text = this.client.GetSessionValue().ToString();
        }

        protected void BtnSet_Click(object sender, EventArgs e) {
            int value = Int32.Parse(TextBoxSessionValue.Text.ToString());
            this.client.SetSessionValue(value);
        }

        protected void btnHistory_Click(object sender, EventArgs e) {
            TextBoxHistory.Text = this.client.GetHistory();
        }
    }
}