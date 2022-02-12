using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Propuesta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox2;
            label4.Parent = pictureBox2;
            panel2.Hide();
            panel3.Hide();
        }
        public void MoverBoton()
        {
            Random r = new Random();
            int x = r.Next(0, this.Width - botonno.Width);
            int y = r.Next(0, this.Height - botonno.Height);
            botonno.Location = new Point(x, y);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void botonno_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if(botonno.Location == botonsi.Location || botonno.Location == label1.Location || botonno.Location == label2.Location)
            {
                MoverBoton();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel3.Show();
        }
    }
}
