using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int i=10;
        public Form1()
        {
            InitializeComponent();
        }

        protected void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
          


        private void button2_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild1 = new Form3();
            // Set the Parent Form of the Child window.
            newMDIChild1.MdiParent = this;
            // Display the new form.
            newMDIChild1.Show();
        }

        void CreateB (Control parent)
        {
            i *= 2;
            Button btn = new Button();
            btn.Location = new Point(100, i); //расположение
            btn.Size = new Size(50, 60); // размер
            btn.Text = "йоу"; //текст
            //далее можно еще добавить свойств, на Ваше усмотрение
            parent.Controls.Add(btn); //добавляем кнопку на родительский контрол
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateB(panel1);
        }
    }
}
