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
    public partial class drums : Form
    {
        public drums()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            new exit().Show(); //this.Close();
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

        private void button6_Click(object sender, EventArgs e) {
            new drm_4_beat().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new drm_2_beat().Show();
            this.Hide();
        }
    }
}
