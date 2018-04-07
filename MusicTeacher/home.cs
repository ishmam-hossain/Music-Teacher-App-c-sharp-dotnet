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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            setUI();
        }

        private void setUI()
        {
            string q = "select progress from score where section_id=1";
            DataSet data = DatabaseManager.resultQuery(q);
            progress_bar_theory.ProgressValue = Convert.ToInt32(data.Tables[0].Rows[0][0].ToString()) * 10;


            q = "select progress from score where section_id=2";
            data = DatabaseManager.resultQuery(q);
            progress_bar_instruments.ProgressValue = Convert.ToInt32(data.Tables[0].Rows[0][0].ToString()) * 10;

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            new exit().Show();
        }

        private void theoryHome_Click(object sender, EventArgs e)
        {
            new theory().Show();
            this.Hide();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void InstrumentHome_Click(object sender, EventArgs e)
        {
            new instruments().Show();
            this.Hide();
        }

        private void progress_bar_Load(object sender, EventArgs e)
        {
            //progress_bar.ProgressValue=prog
        }

        private void home_Load(object sender, EventArgs e)
        {

        }

        private void practiseHome_Click(object sender, EventArgs e)
        {
            new play().Show();
            this.Hide();
        }
    }
}
