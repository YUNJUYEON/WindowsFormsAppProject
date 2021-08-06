using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
            if (DateTime.Now.Hour == 08 && DateTime.Now.Minute == 00 && DateTime.Now.Second == 10)
            {
                playSimpleSound();
            }
            if (DateTime.Now.Hour == 09 && DateTime.Now.Minute == 00 && DateTime.Now.Second == 20)
            {
                playSimpleSound();
            }
        }

       private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\FAMILY\source\repos\WindowsFormsAppProject\[효과음]알람시계,알람음,따르릉.wav");
            simpleSound.Play();
        }
    }
}
