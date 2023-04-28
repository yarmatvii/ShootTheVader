using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME
{
    public partial class Form1 : Form
    {
        private int k = -1, o = -2, i = 3, j = 4, count = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

            button1.Left += i;
            button1.Top += j;

            if (button1.Location.X > 550 || button1.Location.X < 10)
                i *= -1;          

            if (button1.Location.Y > 300 || button1.Location.Y < 10)
                j *= -1;

        }

        private void button1_LocationChanged(object sender, EventArgs e)
        {
            button2.Left += k;
            button2.Top += o;

            if (button2.Location.X > 550 || button2.Location.X < 10)
                k *= -1;

            if (button2.Location.Y > 300 || button2.Location.Y < 10)
                o *= -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count -= 1;
            string c = count.ToString();
            MessageBox.Show("Oops, you've killed Anakin! -1 point. \n Your total score: " + c);
            Random rnd1 = new Random();
            button2.Location = new Point(rnd1.Next(0, 510), rnd1.Next(0, 260));
        }

        private void button2_LocationChanged(object sender, EventArgs e)
        {

            
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            //Random rnd = new Random();
            //button2.Location = new Point(rnd.Next(0, 510), rnd.Next(0, 260));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count += 1;
            string c = count.ToString();
            MessageBox.Show("Congrats! +1 point. \n Your total score: " + c);
            Random rnd = new Random();
            button1.Location = new Point(rnd.Next(0, 510), rnd.Next(0, 260));

            //p1:
            //Random rnd = new Random();
            //Random rnd1 = new Random();
            //i = rnd.Next(-1,1);
            //if (i == 0) goto p1;
            //j = rnd1.Next(-2, 2);
            //if (j == 0) goto p1;
        }

        //private void label1_Click(object sender, EventArgs e)
        //{
        //    label1.Text = button1.Left.ToString();
        //}
    }
}
