namespace MusicTeacher
{
    partial class play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(play));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cb_g_maj = new System.Windows.Forms.CheckBox();
            this.cb_d_min = new System.Windows.Forms.CheckBox();
            this.cb_e_lyd = new System.Windows.Forms.CheckBox();
            this.cb_c_min = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.textBox1.Location = new System.Drawing.Point(53, 203);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(718, 117);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "Here are some backing of different scale provided . You can play this tracks and " +
                "practise along with with it .\r\n\r\nEnjoy !";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaGreen;
            this.label2.Font = new System.Drawing.Font("Tarzan", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(242, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 45);
            this.label2.TabIndex = 33;
            this.label2.Text = "Practise Section";
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
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(746, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "X";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 97);
            this.panel1.TabIndex = 34;
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
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.Gainsboro;
            this.close.Location = new System.Drawing.Point(810, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(37, 25);
            this.close.TabIndex = 5;
            this.close.Text = "X";
            this.close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.close.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(186, 143);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(184, 44);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // cb_g_maj
            // 
            this.cb_g_maj.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_g_maj.AutoSize = true;
            this.cb_g_maj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.cb_g_maj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_g_maj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_g_maj.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_g_maj.ForeColor = System.Drawing.Color.Gainsboro;
            this.cb_g_maj.Location = new System.Drawing.Point(0, 0);
            this.cb_g_maj.Margin = new System.Windows.Forms.Padding(0);
            this.cb_g_maj.Name = "cb_g_maj";
            this.cb_g_maj.Size = new System.Drawing.Size(225, 88);
            this.cb_g_maj.TabIndex = 36;
            this.cb_g_maj.Text = "G major Slash style";
            this.cb_g_maj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_g_maj.UseVisualStyleBackColor = false;
            this.cb_g_maj.CheckedChanged += new System.EventHandler(this.cb_g_maj_CheckedChanged);
            // 
            // cb_d_min
            // 
            this.cb_d_min.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_d_min.AutoSize = true;
            this.cb_d_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.cb_d_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_d_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_d_min.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_d_min.ForeColor = System.Drawing.Color.Gainsboro;
            this.cb_d_min.Location = new System.Drawing.Point(225, 0);
            this.cb_d_min.Margin = new System.Windows.Forms.Padding(0);
            this.cb_d_min.Name = "cb_d_min";
            this.cb_d_min.Size = new System.Drawing.Size(226, 88);
            this.cb_d_min.TabIndex = 37;
            this.cb_d_min.Text = "D minor Joe Satriani style";
            this.cb_d_min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_d_min.UseVisualStyleBackColor = false;
            this.cb_d_min.CheckedChanged += new System.EventHandler(this.cb_d_min_CheckedChanged);
            // 
            // cb_e_lyd
            // 
            this.cb_e_lyd.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_e_lyd.AutoSize = true;
            this.cb_e_lyd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.cb_e_lyd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_e_lyd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_e_lyd.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_e_lyd.ForeColor = System.Drawing.Color.Gainsboro;
            this.cb_e_lyd.Location = new System.Drawing.Point(0, 88);
            this.cb_e_lyd.Margin = new System.Windows.Forms.Padding(0);
            this.cb_e_lyd.Name = "cb_e_lyd";
            this.cb_e_lyd.Size = new System.Drawing.Size(225, 88);
            this.cb_e_lyd.TabIndex = 38;
            this.cb_e_lyd.Text = "E  lydian Steve Vai style";
            this.cb_e_lyd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_e_lyd.UseVisualStyleBackColor = false;
            this.cb_e_lyd.CheckedChanged += new System.EventHandler(this.cb_e_lyd_CheckedChanged);
            // 
            // cb_c_min
            // 
            this.cb_c_min.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb_c_min.AutoSize = true;
            this.cb_c_min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(102)))));
            this.cb_c_min.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_c_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_c_min.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_c_min.ForeColor = System.Drawing.Color.Gainsboro;
            this.cb_c_min.Location = new System.Drawing.Point(225, 88);
            this.cb_c_min.Margin = new System.Windows.Forms.Padding(0);
            this.cb_c_min.Name = "cb_c_min";
            this.cb_c_min.Size = new System.Drawing.Size(226, 88);
            this.cb_c_min.TabIndex = 39;
            this.cb_c_min.Text = "C minor John Petrucchi style";
            this.cb_c_min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_c_min.UseVisualStyleBackColor = false;
            this.cb_c_min.CheckedChanged += new System.EventHandler(this.cb_c_min_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 522);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 100);
            this.panel2.TabIndex = 40;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cb_c_min, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_d_min, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_e_lyd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cb_g_maj, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(176, 346);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(451, 176);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Location = new System.Drawing.Point(83, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 28);
            this.button5.TabIndex = 17;
            this.button5.Text = "Practise";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(62, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 28);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "play";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "try";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox cb_g_maj;
        private System.Windows.Forms.CheckBox cb_d_min;
        private System.Windows.Forms.CheckBox cb_e_lyd;
        private System.Windows.Forms.CheckBox cb_c_min;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}