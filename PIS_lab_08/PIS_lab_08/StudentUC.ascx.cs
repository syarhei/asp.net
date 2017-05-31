using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PIS_lab_08 {
    public partial class StudentUC : System.Web.UI.UserControl {

        public String Name { get; set; }
        public String SurName { get; set; }
        public String FatherName { get; set; }
        public String Date { get; set; }
        public String Sex { get; set; }
        public String Faculty { get; set; }
        public String Group { get; set; }
        public String Year { get; set; }
        public String Input { get; set; }

        protected void Page_Load(object sender, EventArgs e) {
            name.Text = Name;
            sname.Text = SurName;
            fname.Text = FatherName;
            group.Text = Group;
            input.Text = Input;
        }
    }
}