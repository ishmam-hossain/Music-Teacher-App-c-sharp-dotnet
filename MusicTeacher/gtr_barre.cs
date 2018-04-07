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
    public partial class gtr_barre : Form
    {
        public gtr_barre()
        {
            InitializeComponent();
        }

        SoundPlayer c_maj = new SoundPlayer(@"c_maj.wav");
        SoundPlayer d_maj = new SoundPlayer(@"d_maj.wav");
        SoundPlayer g_maj = new SoundPlayer(@"D:\C#\Music\g_maj.wav");
        SoundPlayer a_min = new SoundPlayer(@"D:\C#\Music\a_min.wav");
        SoundPlayer e_min = new SoundPlayer(@"D:\C#\Music\e_min.wav");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void intervalBtn_Click(object sender, EventArgs e)
        {
            new gtr_brief().Show();
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

        private void button10_Click(object sender, EventArgs e)
        {
            new gtr_arpegio().Show();
            this.Hide();
        }

        private void chordbtn_Click(object sender, EventArgs e)
        {

            new gtr_barre().Show();
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

        private void button7_Click(object sender, EventArgs e)
        {
            g_maj.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            c_maj.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            d_maj.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            e_min.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a_min.Play();
        }
    }
}
