﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public int i;
        public int y ;
        public int z;
        public int b = 78;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            timer1.Enabled = true;
            //i = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p1 = new Point();
            Point p2 = new Point();
            //squre point ==>
            Point req = new Point(509, 113);

            //house points ==>
            Point point1 = new Point(270, 78);
            Point point2 = new Point(524, 78);
            Point point3 = new Point(571, 156);
            Point point4 = new Point(472, 156);
            Point point5 = new Point(218, 156);
            Point point6 = new Point(218, 322);
            Point point7 = new Point(472, 322);
            Point point8 = new Point(571, 311);
            Point[] points = { point1, point2, point3, point4, point2, point4, point5, point1, point5, point6, point7, point8, point3, point4, point7 }; // house array

            //door points ==>
            Point point9 = new Point(490, 190);
            Point point10 = new Point(552, 188);
            Point point11 = new Point(552, 288);
            Point point12 = new Point(490, 290);
            Point[] door = { point9, point10, point11, point12, point9 };

            //windo points ==>
            Point point13 = new Point(406, 199);
            Point point14 = new Point(336, 199);
            Point point15 = new Point(336, 254);
            Point point16 = new Point(406, 254);
            Point[] windo = { point13, point14, point15, point16, point13 };


            if (i < points.Length - 1)
            {
                p1 = points[i];
                p2 = points[i+1];
                this.CreateGraphics().DrawLine(Pens.Blue, p1, p2);
                i++;
               
            }
            if (i == points.Length - 1)
            {
                this.CreateGraphics().DrawEllipse(Pens.Blue, 509, 113, 30,30);
                i++;
            }
            if (y < door.Length - 1 && i== points.Length)
            {

                p1 = door[y];
                p2 = door[y + 1];
                this.CreateGraphics().DrawLine(Pens.Blue, p1, p2);
                y++;
                
            }

            if (z < windo.Length - 1 && y == door.Length - 1)
            {

                p1 = windo[z];
                p2 = windo[z + 1];
                this.CreateGraphics().DrawLine(Pens.Blue, p1, p2);
                z++;

            }

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
