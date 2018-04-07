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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            panel4.Visible = false;
        }

        SoundPlayer c_maj = new SoundPlayer(@"D:\C#\Music\c_maj.wav");
        SoundPlayer d_maj = new SoundPlayer(@"D:\C#\Music\d_maj.wav");
        SoundPlayer g_maj = new SoundPlayer(@"D:\C#\Music\g_maj.wav");
        SoundPlayer a_min = new SoundPlayer(@"D:\C#\Music\a_min.wav");
        SoundPlayer d_min = new SoundPlayer(@"D:\C#\Music\d_min.wav");




        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void scalebtn_Click(object sender, EventArgs e)
        {
            new frm_scale().Show();
            this.Hide();
        }

        private void intervalBtn_Click(object sender, EventArgs e)
        {
            new frm_freq().Show();
            this.Hide();
        }



        private void chordbtn_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void rhythmbtn_Click(object sender, EventArgs e)
        {
            new frm_rhythm().Show();
            this.Hide();
        }

        private void freqbtn_Click(object sender, EventArgs e)
        {
            new frm_freq().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new theory().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void intervalBtn_Click_1(object sender, EventArgs e)
        {
            new frm_intervals().Show();
            this.Hide();
        }

        private void scalebtn_Click_1(object sender, EventArgs e)
        {
            new frm_scale().Show();
            this.Hide();
        }

        private void chordbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void rhythmbtn_Click_1(object sender, EventArgs e)
        {
            new frm_rhythm().Show();
            this.Hide();
        }

        private void freqbtn_Click_1(object sender, EventArgs e)
        {
            new frm_freq().Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {

            new exit().Show(); //this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new theory().Show();
            this.Hide();
        }

        private void intervalBtn_Click_2(object sender, EventArgs e)
        {
            new frm_intervals().Show();
            this.Hide();
        }

        private void scalebtn_Click_2(object sender, EventArgs e)
        {
            new frm_scale().Show();
            this.Hide();
        }

        private void chordbtn_Click_2(object sender, EventArgs e)
        {

        }

        private void rhythmbtn_Click_2(object sender, EventArgs e)
        {
            new frm_rhythm().Show();
            this.Hide();
        }

        private void freqbtn_Click_2(object sender, EventArgs e)
        {
            new frm_freq().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            c_maj.Play();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            d_maj.Play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g_maj.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a_min.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            d_min.Play();
        }



      
    }
}
