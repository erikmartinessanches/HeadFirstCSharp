using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3_Guys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            joe = new Guy() { Cash = 50, Name = "Joe" };
            bob = new Guy() { Cash = 100, Name = "Bob"};
            UpdateForm();
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            } else
            {
                MessageBox.Show("The bank is bankrupt.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (joe.Cash >= 10)
            {
                bob.ReceiveCash(joe.GiveCash(10));
                UpdateForm();
            } else
            {
                MessageBox.Show("Joe doesn't have enough cash to give to " +
                    "Bob.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bob.Cash >= 5)
            {
                joe.ReceiveCash(bob.GiveCash(5));
                UpdateForm();
            }
            else
            {
                MessageBox.Show("Bob doesn't have enough cash to give to " +
                    "Joe.");
            }
        }
    }
}
