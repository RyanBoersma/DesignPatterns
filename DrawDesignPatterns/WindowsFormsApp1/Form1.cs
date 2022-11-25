using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Pen p = new Pen(Color.Black, 5);


        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);//2d weergave van tekeninglijn

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)//size
        {
            old = e.Location;
            if (radioButton1.Checked)
                p.Width = 1;
            else if (radioButton2.Checked)
                p.Width = 5;
            else if (radioButton3.Checked)
                p.Width = 10;
            else if (radioButton4.Checked)
                p.Width = 30;

        }
        private void canvas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                old = current;


            }
        }

        private void button1_Click(object sender, EventArgs e)//choose color
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                p.Color = cd.Color;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//clear
        {
            panel1.Invalidate();
        }

        private void button5_Click(object sender, EventArgs e)//undo
        {

        }
       

        private void button4_Click_1(object sender, EventArgs e)//Rectangle
        {
        g.DrawRectangle(p, 10, 10, 100, 50);
        }

        private void button3_Click(object sender, EventArgs e)//Circle
        {
            g.DrawEllipse(p, 10, 10, 100, 100);
        }

        private void button6_Click(object sender, EventArgs e)//Redo
        {

        }
    }
}
