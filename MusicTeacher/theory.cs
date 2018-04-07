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
    public partial class theory : Form
    {
        public theory()
        {
            InitializeComponent();
            looad_quiz_progress_value();
            load_ui_elements();
        }

        private int progress_value;
        private void looad_quiz_progress_value() {
            string qryString = "select progress from score where section_id=1";
            DataSet dataset = DatabaseManager.resultQuery(qryString);
            progress_value = Convert.ToInt32(dataset.Tables[0].Rows[0][0].ToString());
        }

        private void load_ui_elements() {
            progress_bar.ProgressValue = progress_value * 10;
            if (progress_value < 10)
            {
                reset_progress.Visible = false;
                theory_quiz_buttom.Visible = true;
            }
            else {
                reset_progress.Visible = true;
                theory_quiz_buttom.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            new exit().Show(); //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void intervalBtn_Click(object sender, EventArgs e)
        {
            new frm_intervals().Show();
            this.Hide();
        }

        private void scalebtn_Click(object sender, EventArgs e)
        {
            new frm_scale().Show();
            this.Hide();
        }

        private void rhythmbtn_Click(object sender, EventArgs e)
        {
            new frm_rhythm().Show();
            this.Hide();
        }

        private void rhythmbtn_Click_1(object sender, EventArgs e)
        {
            new frm_rhythm().Show();
            this.Hide();
        }

        private void chordbtn_Click(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void freqbtn_Click(object sender, EventArgs e)
        {
            new frm_freq().Show();
            this.Hide();
        }

        private void theory_quiz_buttom_Click(object sender, EventArgs e)
        {
            if (progress_value < 10) {
                new quiz(1).Show();
            }
        }

        private void reset_progress_Click(object sender, EventArgs e)
        {
            string qryString = "update score set progress=0 where section_id=1";
            DatabaseManager.processQuery(qryString);
            looad_quiz_progress_value();
            load_ui_elements();
        }
    }
}
