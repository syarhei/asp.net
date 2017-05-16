using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_06 {
    public partial class _default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                DropDownList1.Items.Add("item1");
                DropDownList1.Items.Add("item2");
                DropDownList1.Items.Add("item3");
            }
        }

        // проверка простого числа
        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args) {
            bool isSimple = true;
            int digit = Convert.ToInt32(args.Value);
            for (long i = 2; i < digit; i++)
                if (digit % i == 0) {
                    isSimple = false; // если это число не простое isSimple = false
                    break;
                }
            if (!isSimple) args.IsValid = false;
        }
    }
}