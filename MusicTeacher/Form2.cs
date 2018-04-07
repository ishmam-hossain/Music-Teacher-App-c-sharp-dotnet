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
    public partial class frm_intervals : Form
    {
        public frm_intervals()
        {
            InitializeComponent();
            panel4.Visible = false;
        }

     

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void intervalBtn_Click(object sender, EventArgs e)
        {

        }

        private void scalebtn_Click(object sender, EventArgs e)
        {
            new frm_scale().Show();
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

        private void freqbtn_Click_1(object sender, EventArgs e)
        {
            new frm_freq().Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {

            new exit().Show(); //this.Close();
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

        private void scalebtn_Click_1(object sender, EventArgs e)
        {
            new frm_scale().Show();
            this.Hide();

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

        private void freqbtn_Click(object sender, EventArgs e)
        {
            new frm_freq().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void intervalBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }


       

      

      

      
    }
}
