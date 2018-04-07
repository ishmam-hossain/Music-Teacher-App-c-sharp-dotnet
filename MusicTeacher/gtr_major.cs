using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace MusicTeacher
{
    public partial class gtr_major : Form
    {
        public gtr_major()
        {
            InitializeComponent();
        }

        SoundPlayer c_maj_scale = new SoundPlayer(@"D:\C#\Music\c_maj_scale.wav");

        private void intervalBtn_Click(object sender, EventArgs e)
        {
            new gtr_brief().Show();
            this.Hide();
        }

        private void chordbtn_Click(object sender, EventArgs e)
        {
            new gtr_barre().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            new guitar().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new instruments().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new gtr_arpegio().Show();
            this.Hide();
        }

        private void rhythmbtn_Click(object sender, EventArgs e)
        {

            new gtr_major().Show();
            this.Hide();
        }

        private void freqbtn_Click(object sender, EventArgs e)
        {

            new gtr_minor().Show();
            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            new exit().Show(); //this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new guitar().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new instruments().Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void intervalBtn_Click_1(object sender, EventArgs e)
        {
            new gtr_brief().Show();
            this.Hide();
        }

        private void chordbtn_Click_1(object sender, EventArgs e)
        {
            new gtr_barre().Show();
            this.Hide();
        }

        private void rhythmbtn_Click_1(object sender, EventArgs e)
        {
            new gtr_major().Show();
            this.Hide();
        }

        private void freqbtn_Click_1(object sender, EventArgs e)
        {
            new gtr_minor().Show();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            new gtr_arpegio().Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            c_maj_scale.Play();
        }
    }
}
