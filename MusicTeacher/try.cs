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
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
        }


        SoundPlayer g_maj_back = new SoundPlayer(@"back_g_major.wav");
        SoundPlayer d_min_back = new SoundPlayer(@"back_d_minor.wav");
        SoundPlayer c_min_back = new SoundPlayer(@"back_c_min.wav");
        SoundPlayer e_lyd_back = new SoundPlayer(@"back_e_lyd.wav");

        private void button2_Click(object sender, EventArgs e)
        {
            new exit().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void cb_g_maj_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_g_maj.Checked)
            {
                cb_g_maj.Text = "Stop";
                g_maj_back.Play();

            }
            else
            {
                cb_g_maj.Text = "G major Slash style";
                g_maj_back.Stop();
            }
        }

        private void cb_d_min_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_d_min.Checked)
            {
                cb_d_min.Text = "Stop";
                d_min_back.Play();

            }
            else
            {
                cb_d_min.Text = "G major Slash style";
                d_min_back.Stop();
            }
        }

        private void cb_e_lyd_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_e_lyd.Checked)
            {
                cb_e_lyd.Text = "Stop";
                e_lyd_back.Play();

            }
            else
            {
                cb_e_lyd.Text = "G major Slash style";
                e_lyd_back.Stop();
            }
        }

        private void cb_c_min_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_c_min.Checked)
            {
                cb_c_min.Text = "Stop";
                c_min_back.Play();

            }
            else
            {
                cb_c_min.Text = "G major Slash style";
                c_min_back.Stop();
            }
        }
    }
}
