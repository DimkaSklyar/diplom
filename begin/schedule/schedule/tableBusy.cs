using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schedule {
    public partial class tableBusy : UserControl {
        public tableBusy() {
            InitializeComponent();
            this.employeeTableAdapter.Fill(this.scheduleDataSet.employee);

            pictureBox1.Image = (Image)new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            Pen p = new Pen(Color.Black);
            for (int i = 0; i < 5; i++) {
                g.DrawLine(p, new Point((pictureBox1.Width / 6 * (i + 1)), 0), new Point((pictureBox1.Width / 6 * (i + 1)), pictureBox1.Height));
                g.DrawLine(p, new Point(0, (pictureBox1.Height / 6 * (i + 1))), new Point(pictureBox1.Width, (pictureBox1.Height / 6 * (i + 1))));
            }
        }


        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {

            int X = pictureBox1.Width / 6;
            int Y = pictureBox1.Height / 6;

            if (e.Button == MouseButtons.Left) {
                for (int i = 0; i < 7; i++) {
                    if (e.X <= (X * i)) {
                        for (int i1 = 0; i1 < 7; i1++) {
                            if (e.Y <= (Y * i1)) {
                                Graphics a = Graphics.FromImage(pictureBox1.Image);
                                a.FillRectangle(Brushes.Blue, (X * (i - 1)) + 1, (Y * (i1 - 1)) + 1, X - 1, Y - 1);
                                this.Refresh();

                                //MessageBox.Show((X * (i - 1)).ToString() + ":" + (X * i).ToString() + " - " + (Y * (i1 - 1)).ToString() + ":" + (Y * i1).ToString());
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e) {
            int X = pictureBox1.Width / 6;
            int Y = pictureBox1.Height / 6;

            for (int i = 0; i < 7; i++) {
                if (e.X <= (X * i)) {
                    for (int i1 = 0; i1 < 7; i1++) {
                        if (e.Y <= (Y * i1)) {
                            Graphics a = Graphics.FromImage(pictureBox1.Image);
                            a.FillRectangle(Brushes.Blue, (X * (i - 1)) + 1, (Y * (i1 - 1)) + 1, X - 1, Y - 1);
                            this.Refresh();

                            //MessageBox.Show((X * (i - 1)).ToString() + ":" + (X * i).ToString() + " - " + (Y * (i1 - 1)).ToString() + ":" + (Y * i1).ToString());
                            break;
                        }
                    }
                    break;
                }
            }
        }
    }
}
