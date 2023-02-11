using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_10_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //------------------------------------------------------------
        private Label RandomLabel()
        {
            Label l = new Label();
            Random r = new Random(DateTime.Now.Millisecond);
            l.Left = r.Next(this.Width);
            l.Top = r.Next(this.Height);
            l.Width = r.Next(50);
            l.Height = r.Next(50);
            l.Text = "";
            l.BorderStyle = BorderStyle.FixedSingle;
            l.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
            return l;
        }
        //------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Controls.Add(RandomLabel());
            timer1.Interval = 10;
            timer1.Start();
        }
        //------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Controls.Add(RandomLabel());
        }
    }
}
