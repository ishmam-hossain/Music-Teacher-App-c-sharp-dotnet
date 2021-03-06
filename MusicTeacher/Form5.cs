﻿using System;
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
    public partial class frm_scale : Form
    {
        public frm_scale()
        {
            InitializeComponent();
        }

        SoundPlayer c_maj_scale = new SoundPlayer(@"D:\C#\Music\c_maj_scale.wav");

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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new theory().Show();
            this.Hide();

        }

        private void button3_Click_1(object sender, EventArgs e)
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

        }

        private void chordbtn_Click_1(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
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

        private void close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            new theory().Show();
            this.Hide();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            new home().Show();
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
            new Form4().Show();
            this.Hide();
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

        private void button4_Click(object sender, EventArgs e)
        {

            new exit().Show(); //this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            c_maj_scale.Play();
        }


      
    }
}
