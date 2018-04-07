using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MusicTeacher
{
    public partial class splashForm : Form
    {
        public splashForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeLeft = 20 ;
            timer1.Start();
        }

        public int timeLeft { get; set;}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
                timeLeft--;
            else
            {
                timer1.Stop();
                new home().Show();
                this.Hide();
            }
        }
    }
}
