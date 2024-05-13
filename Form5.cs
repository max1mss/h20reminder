using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2Oreminder
{
    public partial class Form5 : Form
    {

        private Timer timer;
        private const int TimerDurationInSeconds = 3600; // 1 hour

        public Form5()
        {
            InitializeComponent();
            SetupTimer();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void SetupTimer()
        {
            timer = new Timer();
            timer.Interval = TimerDurationInSeconds * 1000; // Convert seconds to milliseconds
            timer.Tick += timer1_Tick;
            timer.Start();
        }



        

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Stop the timer when it elapses
            MessageBox.Show("Time to drink water!", "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            timer.Start(); // Restart the timer if you want it to repeat
        }

        // Other methods and event handlers
    }
}
