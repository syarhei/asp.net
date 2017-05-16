using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_02 {
    public partial class _default : System.Web.UI.Page {
        protected void Page_Init(object sender, EventArgs e) {
            l1.Text += " Init ";
        }

        protected void Page_Load(object sender, EventArgs e) {
            l1.Text += " <br/>  Load ";
        }

        protected void Page_Prerender(object sender, EventArgs e) {
            l1.Text += " Prerender ";
        }

        protected void b1_Click(object sender, EventArgs e) {
            l1.Text += " Click ";
        }

        protected void Page_Unload(object sender, EventArgs e) {
            l1.Text += " Unload ";
        }

        protected void cb1_CheckedChanged(object sender, EventArgs e) {
            l1.Text += " Checked ";
        }

        protected void b2_Click(object sender, EventArgs e) {
            ta1.Value += (System.Environment.MachineName) + "\n";
            ta1.Value += (System.Environment.OSVersion) + "\n";
            ta1.Value += (System.Environment.WorkingSet) + "\n";
            ta1.Value += (System.Environment.Version.ToString()) + "\n";
            ta1.Value += (HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"]) + "\n";
            ta1.Value += (Environment.GetEnvironmentVariable("TEMP")) + "\n";
            ta1.Value += (Request.IsLocal ? "local" : "no local") + "\n";
            ta1.Value += (Request.IsSecureConnection ? "secure" : "no secure") + "\n";
            ta1.Value += (Request.Browser.Version) + "\n";
            ta1.Value += (Request.Browser.MinorVersion) + "\n";
            ta1.Value += (Request.Browser.MajorVersion) + "\n";
        }
    }
}