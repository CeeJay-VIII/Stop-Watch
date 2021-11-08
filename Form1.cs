using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stop_Watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hours, minutes, seconds;
        private void btnStart_Click(object sender, EventArgs e)
        {
            Timer.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            if (!(hours == 0 && minutes == 0 && seconds == 0))
                btnStart.Text = "Continue";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btnStart.Text = "Start";
            lblOutput.Text = "00:00:00";
            hours = 0;
            minutes = 0;
            seconds = 0;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds > 60)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes > 60)
            {
                hours++;
                minutes = 0;
            }
            string hrs, min, sec;
            if (seconds < 10)
                sec = $"0{seconds}";
            else
                sec = seconds.ToString();
            if (minutes < 10)
                min = $"0{minutes}";
            else
                min = minutes.ToString();
            if (hours < 10)
                hrs = $"0{hours}";
            else
                hrs = hours.ToString();
            // Concatenate the Output
            lblOutput.Text = $"{hrs}:{min}:{sec}";
        }
    }
}
