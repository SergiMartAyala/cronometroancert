using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Cronometro
{
    public partial class Cronometro : Form
    {
        //Object that's going to create the count
        Stopwatch watch = new Stopwatch();
        public Cronometro()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //When "iniciar" button is pressed, the timer turns enabled so it starts running
            watch.Start();
            timerCount.Enabled = true;
        }
     
        private void timerCount_Tick(object sender, EventArgs e)
        {
            /*This function is activated when the timer turns enabled, then we set the Timespan
             * It will count the time that has passed since the button started
             */
            TimeSpan time = new TimeSpan(0,0,0,0,(int)watch.ElapsedMilliseconds);
            /*Now that we get the time passed, we have to fill the textbox with the time messure desired
             */
            txtMiliseconds.Text = time.Milliseconds.ToString();
            txtSeconds.Text = time.Seconds.ToString().Length < 2 ? "0" + time.Seconds.ToString() : time.Seconds.ToString();
            txtMinutes.Text = time.Minutes.ToString().Length < 2 ? "0" + time.Minutes.ToString() : time.Minutes.ToString();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            /*when "parar" button it's pressed the object StopWatch stop
             */
            watch.Stop();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            /*If "parar" button ist's pressed, the cronometer restart and 0s replace the values
            */
             watch.Restart();
             txtMiliseconds.Text = "000";
             txtSeconds.Text = "00";
             txtMinutes.Text = "00";
             /*the timer is disabled so it stops the count
              */
             timerCount.Enabled = false;
        }
    }
}
