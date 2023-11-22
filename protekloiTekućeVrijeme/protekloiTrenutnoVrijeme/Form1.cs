using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protekloiTrenutnoVrijeme
{
    public partial class Form1 : Form
    {
        DateTime pocetak = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = new TimeSpan();
            proteklo = DateTime.Now - pocetak;
            toolStripStatusLabel1.Text = "Proteklo: " +proteklo.Hours.ToString() + ":" + proteklo.Minutes.ToString() + ":" + proteklo.Seconds.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
