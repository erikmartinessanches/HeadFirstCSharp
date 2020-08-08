using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive
{
    public partial class Form1 : Form
    {
        private Queen Queen { get; set; }
        private Worker[] Workers { get; set; }

        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Workers = new Worker[4];
            Workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            Workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            Workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            Workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });

            Queen = new Queen(Workers); //Passed by reference or value here?
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = Queen.WorkTheNextShift();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) == false)
            {
                MessageBox.Show($"No workers are available to do the job '{workerBeeJob.Text}'.", "The system says...");
            }
            else
            {
                MessageBox.Show($"The job '{workerBeeJob.Text}' will be done in {shifts.Value} shifts.",
                    "The system says...");
            }
        }
    }
}
