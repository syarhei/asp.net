using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace PIS_lab_13_Host {
    public partial class Form1 : Form {

        ServiceHost sh;

        public Form1() {
            InitializeComponent();
            sh = new ServiceHost(typeof(PIS_lab_13.Service1));
            sh.Open();
        }
    }
}
