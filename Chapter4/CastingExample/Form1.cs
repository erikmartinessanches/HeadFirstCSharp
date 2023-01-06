using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CastingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int myOriginalValue = 259;
            byte myConvertedValue = (byte)myOriginalValue;
            MessageBox.Show("The converted (cast) value is " + myConvertedValue
                + ".");

            /* If I use +, *, / or - with two different types, it automatically
             * converts the smaller type into the bigger one: */
            int myInt = 36;
            float myFloat = 16.4F;
            myFloat = myInt + myFloat;
            MessageBox.Show("myFloat is " + myFloat + ".");
        }

        /* Examples of various casts. */
        private void button2_Click(object sender, EventArgs e)
        {
            int myInt = 10;
            byte myByte = (byte)myInt;
            double myDouble = (double)myByte;
            //bool myBool = (bool)myDouble; //Doesn't work
            string myString = "false";
            //myBool = (bool)myString; //Doesn't work
            //myString = (string)myInt; //Doesn't work
            myString = myInt.ToString();
            //myBool = (bool)myByte; //Doesn't work
            //myByte = (byte)myBool;    //Doesn't work
            short myShort = (short)myInt;
            char myChar = 'x';
            //myString = (string)myChar; //Doesn't work
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + myByte + myDouble + myChar;


        }
    }
}
