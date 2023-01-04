using System;
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
        public Form1()
        {
            InitializeComponent();
           // timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            //form1.timer1_Tick();
            //Point point1 = new Point(270, 78);
            //Point point2 = new Point(524, 78);
            //Point point3 = new Point(571, 156);
            //Point point4 = new Point(472, 156);
            //Point point5 = new Point(218,156);
            //Point point6 = new Point(218, 322);
            //Point point7 = new Point(472, 322);
            //Point point8 = new Point(571, 311);
            //Point[] points = { point1, point2, point3, point4, point2, point4, point5, point1, point5, point6, point7, point8, point3, point4, point7 };
            //this.CreateGraphics().DrawLines(Pens.Blue, points);// لرسم خطوط
            //this.CreateGraphics().FillEllipse(Brushes.Blue, 40,50,100,100); رسم شكل بيضوي ممتلئ
           //this.CreateGraphics().FillRectangle(Brushes.Blue, 40, 50, 100, 100); لرسم شكل مستطيل ممتلئ
            //this.CreateGraphics().DrawPie(Pens.Blue, 40, 50, 100, 120, 10,90);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point point1 = new Point(270, 78);
            Point point2 = new Point(524, 78);
            Point point3 = new Point(571, 156);
            Point point4 = new Point(472, 156);
            Point point5 = new Point(218, 156);

            Point point6 = new Point(218, 322);
            Point point7 = new Point(472, 322);
            Point point8 = new Point(571, 311);
            Point[] points = { point1, point2, point3, point4, point2, point4, point5, point1, point5, point6, point7, point8, point3, point4, point7 };
            this.CreateGraphics().DrawLines(Pens.Blue, points);// لرسم خطوط
            
            this.CreateGraphics().DrawLine(Pens.Black, point1,point7);// لرسم خطوط
        }
    }
}
