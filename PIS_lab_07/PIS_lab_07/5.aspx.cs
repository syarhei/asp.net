using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_07 {
    public partial class _5 : System.Web.UI.Page {

        private static string GetDate(HttpContext context) {
            return "<b>" + DateTime.Now.ToString() + "</b>";
        }

        protected void Page_Load(object sender, EventArgs e) {
            //Response.WriteSubstitution(new HttpResponseSubstitutionCallback(GetDate));
            labeldate.Text = DateTime.Now.ToString();
        }
    }
}