using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsansörUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = "1";
            label5.BackColor = Color.LightSeaGreen;
            label6.BackColor = Color.LightSeaGreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = "0";
            label7.BackColor = Color.LightSeaGreen;
            label8.BackColor = Color.LightSeaGreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label4.Text == "1")
            {
                pictureBox3.Top -= 5;
            }
            if (label4.Text == "0")
            {
                pictureBox3.Top += 5;
            }
            if(pictureBox3.Location.Y <= 147)
            {
                timer1.Stop();
                label7.BackColor = Color.Yellow;
                label8.BackColor = Color.Yellow;
            }
            if(pictureBox3.Location.Y >= 384)
            {
                timer1.Stop();
                label5.BackColor = Color.Yellow;
                label6.BackColor = Color.Yellow;
            }
        }
    }
}
