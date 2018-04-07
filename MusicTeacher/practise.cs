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
    public partial class g_maj_slash : Form
    {
        public g_maj_slash()
        {
            InitializeComponent();
        }

        SoundPlayer g_maj_back =  new SoundPlayer(@"back_g_major");
        SoundPlayer d_min_back =  new SoundPlayer(@"back_d_minor");
        //SoundPlayer g_maj_back = new SoundPlayer(@"back_g_major");
        //SoundPlayer g_maj_back = new SoundPlayer(@"back_g_major");



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_g_maj.Checked)
            {
                cb_g_maj.Text = "Stop";
                d_min_back.Play();

            }
            else
            {
                cb_g_maj.Text = "G major Slash style";
                d_min_back.Stop();
            }
        }
    }
}
