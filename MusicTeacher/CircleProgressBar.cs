using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace MusicTeacher {
    public partial class CircleProgressBar : UserControl {
        private int progress;
        public int ProgressValue {
            set {
                progress = value;
                repaint();
            }
            get {
                return progress;
            }
        }

        private Color progress_color;
        public Color ProgressBarColor {
            set {
                progress_color = value;
                repaint();
            }
            get {
                return progress_color;
            }
        }

        private Color empty_color;
        public Color EmptyBarColor {
            set {
                empty_color = value;
                repaint();
            }
            get {
                return empty_color;
            }
        }

        private Color status_font_color;
        public Color StatusFontColor {
            set {
                status_font_color = value;
                repaint();
            }
            get {
                return status_font_color;
            }
        }

        private int barWidth;
        public int BarWidth {
            set {
                barWidth = value;
                if (barWidth > Math.Min(this.Width/2, this.Height/2)) barWidth = Math.Min(this.Width/2, this.Height/2);
                repaint();
            }
            get {
                return barWidth;
            }
        }

        private Font statusFont;
        public Font StatusFont {
            set {
                statusFont = value;
                repaint();
            }
            get {
                return statusFont;
            }
        }
        
        public CircleProgressBar() {
            InitializeComponent();
            progress = 80;
            barWidth = 15;
            progress_color = Color.Red;
            empty_color = Color.Black;
            statusFont = new Font("Arial",10);
            status_font_color = Color.Black;
        }

        private void CircularProgressBar_Paint(object sender, PaintEventArgs e) {
            // anti aliasing
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // empty pie
            e.Graphics.FillPie(new SolidBrush(empty_color), this.ClientRectangle, 0, 360);

            // progress pie
            e.Graphics.FillPie(new SolidBrush(progress_color), this.ClientRectangle, 0, (int)(progress * 3.6));

            // cover pie
            Rectangle coverRect = new Rectangle( 0+barWidth, 0+barWidth, this.Width-(2*barWidth), this.Height-(2*barWidth) );
            e.Graphics.FillPie(new SolidBrush(this.BackColor),coverRect, 0, 360);

            // status string
            StringFormat statusStringFormat = new StringFormat();
            statusStringFormat.LineAlignment = StringAlignment.Center;
            statusStringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(progress.ToString() + "%", statusFont, new SolidBrush(status_font_color), coverRect, statusStringFormat);
        }

        private void repaint() {
            this.Invalidate();
            this.Refresh();
        }
    }
}
