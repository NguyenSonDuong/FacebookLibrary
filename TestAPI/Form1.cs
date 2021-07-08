using FacebookLibrary.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            API api = new API();
            api.Cookie = "sb=tL3FYGpoizse6y_WCXljL8EU; datr=tL3FYGnOiPTa6_JT4wX1l7IJ; wd=1600x757; locale=vi_VN; c_user=100025221310339; spin=r.1004089422_b.trunk_t.1625722929_s.1_v.2_; presence=C%7B%22t3%22%3A%5B%7B%22i%22%3A%22u.100010625562840%22%7D%2C%7B%22i%22%3A%22g.3305468549567681%22%7D%2C%7B%22i%22%3A%22u.100005482159267%22%7D%2C%7B%22i%22%3A%22g.4029833093780078%22%7D%5D%2C%22utc3%22%3A1625723911298%2C%22lm3%22%3A%22u.100010625562840%22%2C%22v%22%3A1%7D; xs=44%3AH3c5mDzHmBpGeQ%3A2%3A1625317417%3A-1%3A6370%3A%3AAcXurpR0ZC2df2ueYf0g29obquewqHlXGL33Vifyj-M; fr=1KIWJiM6VYd0mUCAN.AWVlg3H4vA0-FG5o2R9qJFQwGXA.Bg5xtZ.1Q.AAA.0.0.Bg5xtZ.AWVO5stlqjo";
            api.RequestData = new FacebookLibrary.model.RequestData();
            api.RequestData.Fb_dtsg = "AQEVzkWNvFktQxM:AQGtqLE7rAo3bEQ";
            api.RequestData.Fb_api_req_friendly_name = "CometUFISharesCountTooltipContentQuery";
            api.RequestData.Variables = "{\"feedbackTargetID\":\"ZmVlZGJhY2s6MzIwNjAwMzg5NjM0NzU1MQ==\"}";
            api.RequestData.Doc_id = "3733849556714301";
            richTextBox1.Text = api.POST();
        }
    }
}
