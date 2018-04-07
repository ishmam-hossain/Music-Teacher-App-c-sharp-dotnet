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
    public partial class instruments : Form
    {
        public instruments()
        {
            InitializeComponent();
            looad_quiz_progress_value();
            load_ui_elements();
        }

        private int progress_value;
        private void looad_quiz_progress_value()
        {
            string qryString = "select progress from score where section_id=2";
            DataSet dataset = DatabaseManager.resultQuery(qryString);
            progress_value = Convert.ToInt32(dataset.Tables[0].Rows[0][0].ToString());
        }

        private void load_ui_elements()
        {
            progress_bar.ProgressValue = progress_value * 10;
            if (progress_value < 10)
            {
                reset_progress.Visible = false;
                theory_quiz_buttom.Visible = true;
            }
            else
            {
                reset_progress.Visible = true;
                theory_quiz_buttom.Visible = false;
            }
        }

        private void theoryHome_Click(object sender, EventArgs e)
        {
            new  guitar().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new exit().Show(); //this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }

        private void InstrumentHome_Click(object sender, EventArgs e)
        {
            new keyboard().Show();
            this.Hide();
        }

        private void practiseHome_Click(object sender, EventArgs e)
        {
            new drums().Show();
            this.Hide();
        }

        private void reset_progress_Click(object sender, EventArgs e)
        {
            string qryString = "update score set progress=0 where section_id=2";
            DatabaseManager.processQuery(qryString);
            looad_quiz_progress_value();
            load_ui_elements();
        }

        private void theory_quiz_buttom_Click(object sender, EventArgs e)
        {
            if (progress_value < 10)
            {
                new quiz(2).Show();
            }
        }
    }
}
