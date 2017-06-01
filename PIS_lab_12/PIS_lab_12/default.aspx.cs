using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_12 {
    public partial class _default : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            lb.Text += "load <br />";
            if (IsPostBack) {
                
            }
        }

        protected void btr_Click(object sender, EventArgs e) {
            Random rand = new Random();
            tb1.Text = rand.Next(1, 20).ToString();
            tb2.Text = rand.Next(1, 20).ToString();
        }

        protected void mth_Click(object sender, EventArgs e) {
            
            float a, b, c = 0;
            if (Single.TryParse(tb1.Text, out a) && Single.TryParse(tb2.Text, out b)) {
                if (op.SelectedValue == "1") { c = (a + b); }
                if (op.SelectedValue == "0") { c = (a * b); }
                if (modul.Checked) { c = Math.Abs(c); }
                res.Text = c.ToString();
            } else throw new ApplicationException("a or b is not a Digit");
        }

        protected void timer_Tick(object sender, EventArgs e) {
            btr_Click(sender, e);
        }

        protected void bttest_Click(object sender, EventArgs e) {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
            tbtest.Text = res.Text;
        }
    }
}