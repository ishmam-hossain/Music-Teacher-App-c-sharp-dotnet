namespace MusicTeacher
{
    partial class home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.practiseHome = new System.Windows.Forms.Button();
            this.theoryHome = new System.Windows.Forms.Button();
            this.InstrumentHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progress_bar_instruments = new MusicTeacher.CircleProgressBar();
            this.progress_bar_theory = new MusicTeacher.CircleProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(186, 143);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 44);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 97);
            this.panel1.TabIndex = 12;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tarzan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(270, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Music Master";
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(3, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(760, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 57);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // practiseHome
            // 
            this.practiseHome.BackColor = System.Drawing.Color.Transparent;
            this.practiseHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("practiseHome.BackgroundImage")));
            this.practiseHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.practiseHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.practiseHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.practiseHome.ForeColor = System.Drawing.Color.Transparent;
            this.practiseHome.Location = new System.Drawing.Point(534, 326);
            this.practiseHome.Margin = new System.Windows.Forms.Padding(0);
            this.practiseHome.Name = "practiseHome";
            this.practiseHome.Size = new System.Drawing.Size(236, 165);
            this.practiseHome.TabIndex = 14;
            this.practiseHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.practiseHome.UseVisualStyleBackColor = false;
            this.practiseHome.Click += new System.EventHandler(this.practiseHome_Click);
            // 
            // theoryHome
            // 
            this.theoryHome.BackColor = System.Drawing.Color.Transparent;
            this.theoryHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("theoryHome.BackgroundImage")));
            this.theoryHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.theoryHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.theoryHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theoryHome.ForeColor = System.Drawing.Color.Transparent;
            this.theoryHome.Location = new System.Drawing.Point(24, 326);
            this.theoryHome.Margin = new System.Windows.Forms.Padding(0);
            this.theoryHome.Name = "theoryHome";
            this.theoryHome.Size = new System.Drawing.Size(258, 165);
            this.theoryHome.TabIndex = 15;
            this.theoryHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.theoryHome.UseVisualStyleBackColor = false;
            this.theoryHome.UseWaitCursor = true;
            this.theoryHome.Click += new System.EventHandler(this.theoryHome_Click);
            // 
            // InstrumentHome
            // 
            this.InstrumentHome.BackColor = System.Drawing.Color.Transparent;
            this.InstrumentHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InstrumentHome.BackgroundImage")));
            this.InstrumentHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InstrumentHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstrumentHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstrumentHome.ForeColor = System.Drawing.Color.Transparent;
            this.InstrumentHome.Location = new System.Drawing.Point(282, 326);
            this.InstrumentHome.Margin = new System.Windows.Forms.Padding(0);
            this.InstrumentHome.Name = "InstrumentHome";
            this.InstrumentHome.Size = new System.Drawing.Size(252, 165);
            this.InstrumentHome.TabIndex = 16;
            this.InstrumentHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.InstrumentHome.UseVisualStyleBackColor = false;
            this.InstrumentHome.Click += new System.EventHandler(this.InstrumentHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(425, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Theory Quiz Progress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label3.Location = new System.Drawing.Point(603, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Instruments Quiz Progress";
            // 
            // progress_bar_instruments
            // 
            this.progress_bar_instruments.BarWidth = 15;
            this.progress_bar_instruments.EmptyBarColor = System.Drawing.Color.Gainsboro;
            this.progress_bar_instruments.Location = new System.Drawing.Point(637, 132);
            this.progress_bar_instruments.Name = "progress_bar_instruments";
            this.progress_bar_instruments.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.progress_bar_instruments.ProgressValue = 72;
            this.progress_bar_instruments.Size = new System.Drawing.Size(150, 150);
            this.progress_bar_instruments.StatusFont = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_bar_instruments.StatusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.progress_bar_instruments.TabIndex = 27;
            // 
            // progress_bar_theory
            // 
            this.progress_bar_theory.BarWidth = 15;
            this.progress_bar_theory.EmptyBarColor = System.Drawing.Color.Gainsboro;
            this.progress_bar_theory.Location = new System.Drawing.Point(435, 132);
            this.progress_bar_theory.Name = "progress_bar_theory";
            this.progress_bar_theory.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.progress_bar_theory.ProgressValue = 58;
            this.progress_bar_theory.Size = new System.Drawing.Size(150, 150);
            this.progress_bar_theory.StatusFont = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_bar_theory.StatusFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.progress_bar_theory.TabIndex = 26;
            this.progress_bar_theory.Load += new System.EventHandler(this.progress_bar_Load);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label4.Location = new System.Drawing.Point(114, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Music Theory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label5.Location = new System.Drawing.Point(365, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Instruments";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            this.label6.Location = new System.Drawing.Point(623, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Practise";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("November", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label7.Location = new System.Drawing.Point(17, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 30);
            this.label7.TabIndex = 33;
            this.label7.Text = "Learn Music, Play it !";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("November", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.label8.Location = new System.Drawing.Point(111, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 30);
            this.label8.TabIndex = 34;
            this.label8.Text = "Rock !";
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progress_bar_instruments);
            this.Controls.Add(this.progress_bar_theory);
            this.Controls.Add(this.InstrumentHome);
            this.Controls.Add(this.theoryHome);
            this.Controls.Add(this.practiseHome);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button practiseHome;
        private System.Windows.Forms.Button theoryHome;
        private System.Windows.Forms.Button InstrumentHome;
        private CircleProgressBar progress_bar_theory;
        private CircleProgressBar progress_bar_instruments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}