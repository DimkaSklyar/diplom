using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {
    class Class1 {

        public void menu_stackHover(PictureBox parent) {
            parent.Width = 55;
            parent.Height = 55;
            parent.Location = new Point(parent.Location.X - 2, parent.Location.Y - 2);
        }

        public void menu_hover(PictureBox parent) {
            parent.Width = 50;
            parent.Height = 50;
            parent.Location = new Point(parent.Location.X+2,parent.Location.Y+2);
        }
    }
}
