using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace MusicTeacher {
    public partial class drm_4_beat : Form {
        public drm_4_beat() {
            InitializeComponent();
            initialize_beats();
        }

        //soundplayer object declaration
        SoundPlayer four_beat = new SoundPlayer(@"4 beat 85 bpm 10 bar.wav");
        

        private void play_btn_Click(object sender, EventArgs e) {
            four_beat.Play();
            start_beats();
        }

        private void stop_btn_Click(object sender, EventArgs e) {
            four_beat.Stop();
            clear_beats();
        }

        /*All code for running beat indicator*/
        // components
        bool beats_enabled;
        Panel[] beats;
        int index, bar, passed_time, beat_time=44, bar_limit=10;
        
        
        private void initialize_beats() {
            beats = new Panel[4];
            beats[0] = beat1;
            beats[1] = beat2;
            beats[2] = beat3;
            beats[3] = beat4;
        }
        
        private void clear_beats() {
            beats_enabled = false;
            foreach (Panel beat in beats) {
                beat.BackColor = Color.Silver;
            }
        }
        
        private void start_beats() {
            beats_enabled = true;
            index = 0;
            bar = 0;
            passed_time = 0;
            // light up first beat
            beats[index].BackColor = Color.Yellow;
        }
        
        private void update_beats() {
            if (!beats_enabled) return;

            //passed_time++;
            passed_time += timer1.Interval;
            if (passed_time > beat_time) {  // move to next beat
                // reset current beat
                beats[index].BackColor = Color.Silver;
                passed_time = 0;

                // next beat
                index++;
                if (index > 3) { // going to next bar
                    index = 0;
                    bar++;
                }

                // if 10 bars have passed
                if (bar >= bar_limit) {
                    clear_beats();
                    return;
                }

                // light up beat
                beats[index].BackColor = Color.Yellow;
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {
            update_beats();

            // debug
            idx.Text = index.ToString();
            br.Text = bar.ToString();
            tm.Text = passed_time.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Close();
            new exit().Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            new drm_2_beat().Show();
            this.Hide();
        }
        
    }
}
