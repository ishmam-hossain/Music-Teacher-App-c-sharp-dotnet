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
    public partial class quiz : Form
    {
        public quiz()
        {
            InitializeComponent();
        }

        private int section;
        private int progress;
        private string question, ans, op1, op2, op3;
        private RadioButton[] options;
        public quiz(int sec) {
            InitializeComponent();

            section = sec;

            options = new RadioButton[4];
            options[0] = radioButton1;
            options[1] = radioButton2;
            options[2] = radioButton3;
            options[3] = radioButton4;
            
            refreshData();
            refreshUI();
        }

        private void refreshData() { 
            string qry = "select progress from score where section_id="+section.ToString();
            DataSet dataset = DatabaseManager.resultQuery(qry);
            progress = Convert.ToInt32(dataset.Tables[0].Rows[0][0].ToString());

            if (progress > 9) return;

            qry = "select * from questions where section="+section.ToString()+" and id="+progress.ToString();
            dataset = DatabaseManager.resultQuery(qry);
            question = dataset.Tables[0].Rows[0]["q"].ToString();
            ans = dataset.Tables[0].Rows[0]["ans"].ToString();
            op1 = dataset.Tables[0].Rows[0]["op1"].ToString();
            op2 = dataset.Tables[0].Rows[0]["op2"].ToString();
            op3 = dataset.Tables[0].Rows[0]["op3"].ToString();
        }

        private void refreshUI() {
            progress_bar.ProgressValue = progress*10;
            
            question_box.Text = question;

            //options[0].Text = ans;
            //return;

            clearOptions();
            Random rand = new Random();
            int opin;
            
            do{
                opin = rand.Next(0,4);
            } while(options[opin].Text!="empty");
            options[opin].Text = ans;

            do
            {
                opin = rand.Next(0, 4);
            } while (options[opin].Text != "empty");
            options[opin].Text = op1;

            do
            {
                opin = rand.Next(0, 4);
            } while (options[opin].Text != "empty");
            options[opin].Text = op2;

            do
            {
                opin = rand.Next(0, 4);
            } while (options[opin].Text != "empty");
            options[opin].Text = op3;
        }

        private void clearOptions() { 
            foreach (RadioButton option in options) {
                option.Text = "empty";
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            new exit().Show();
        }

        private void nextQuestion() {
            if (progress < 10) {
                progress++;

                // query
                string qryString = "update score set progress=" + progress.ToString() + " where section_id=" + section.ToString();
                DatabaseManager.processQuery(qryString);

                refreshData();
                refreshUI();
            }
        }

        private RadioButton getSelectedRadioButton() {
            foreach (RadioButton btn in options) {
                if (btn.Checked) {
                    return btn;
                }
            }
            return null;
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            RadioButton btn = getSelectedRadioButton();
            if (btn!=null && btn.Text==ans) {
                nextQuestion();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new home().Show();
            this.Hide();
        }
    }
}
