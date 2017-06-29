using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PIS_lab_13_WF_sergvm {
    public partial class Form1 : Form {
        sergvm.Service1Client client;

        public Form1() {
            InitializeComponent();
            this.client = new sergvm.Service1Client();
            this.client.Open();
            string sss = this.client.GetData(777);
            sergvm.CompositeType ct = new sergvm.CompositeType();
            ct.BoolValue = true;
            ct.StringValue = "stringi";
            sergvm.CompositeType rc = this.client.GetDataUsingDataContract(ct);
        }

        private void button1_Click(object sender, EventArgs e) {
            this.client = new sergvm.Service1Client();
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Convert.ToString(this.client.Sum(x, y));
        }

        private void button2_Click(object sender, EventArgs e) {
            this.client = new sergvm.Service1Client();
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            textBox3.Text = Convert.ToString(this.client.Min(x, y));
        }

        private void button3_Click(object sender, EventArgs e) {
            this.client = new sergvm.Service1Client();
            textBox3.Text = this.client.Concat(textBox1.Text, textBox2.Text);
        }
    }
}
