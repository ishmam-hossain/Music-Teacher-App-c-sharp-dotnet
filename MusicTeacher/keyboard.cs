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
    public partial class keyboard : Form
    {
        public keyboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            new exit().Show(); //this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            new instruments().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            new home().Show();
            this.Hide();
        }

        private void intervalBtn_Click(object sender, EventArgs e)
        {

            new key_basics().Show();
            this.Hide();
        }

        private void chordbtn_Click(object sender, EventArgs e)
        {

            new key_notes().Show();
            this.Hide();
        }

        private void rhythmbtn_Click(object sender, EventArgs e)
        {

            new Visual_Ex().Show();
            this.Hide();
           
        }

        private void freqbtn_Click(object sender, EventArgs e)
        {

            new key_relative().Show();
            this.Hide();
        }
    }
}
