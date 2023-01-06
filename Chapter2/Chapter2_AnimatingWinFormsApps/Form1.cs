using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter2_AnimatingWinFormsApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible) //Visible is true as long as the form is displayed.
            {
                //Thee test for Visible in the for loop allows us to exit the 
                //loop as soon as the application is closed with "x"-button.
                for (int c = 0; c < 254 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);

                    /* Stop looping momentarily and do the other things it 
                     * needs to like refreshing the form, check for input, etc.
                     * If we omit this line, the form doesn't redraw itself, 
                     * because it waits for the loop to finish. This is kind 
                     * of a hack, to be used only for toy programs. */
                    Application.DoEvents();

                    System.Threading.Thread.Sleep(3); //In milliseconds.
                }

                for (int c = 254; c >= 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
            }

        }
    }
}
