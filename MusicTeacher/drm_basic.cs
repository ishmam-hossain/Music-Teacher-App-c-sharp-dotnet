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
    public partial class drm_basic : Form
    {
        public drm_basic()
        {
            InitializeComponent();
        }

        SoundPlayer four_beat = new SoundPlayer(@"4 beat 90 audio.wav");

        private void button4_Click(object sender, EventArgs e)
        {

            new exit().Show();
            //this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new drums().Show();
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

        private void button13_Click(object sender, EventArgs e)
        {
            new drm_know().Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            new drm_basic().Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            new drm_bar().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e) {

            four_beat.Play();
        }
    }
}
