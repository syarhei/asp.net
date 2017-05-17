using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_06 {
    public partial class BBB : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void CustomValidatorPass_ServerValidate(object source, ServerValidateEventArgs args) {
            try {
                string password = args.Value as string;

                HashSet<char> passHash = new HashSet<char>(password);

                if (passHash.Count() != password.Count() || password.Length > 7)
                    args.IsValid = false;
            }
            catch {
                args.IsValid = false;
            }
        }
    }
}