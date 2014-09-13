using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1
{
    public partial class Form2 : Form
    {
        // main form constructor
        // this constructor initializes everything in the form2
        public Form2(char[] userAnswers, char[] answers, int total)
        {
            // pre generated, initialize all the components
            InitializeComponent();
            // varible used in for loops
            int i;
            // add a hook into FormClosed
            this.FormClosed += new FormClosedEventHandler(Form2_FormClosing);
            // iterate through each answer from the user with the correct ones
            for (i = 0; i < 20; i++)
                // check to see if the answers the user input are not equal to the correct answers
                if (userAnswers[i] != answers[i])
                    // adds that number to the list box, specifiying which numbers the user answered incorectly
                    listBox1.Items.Add(i+1);
            // put the total number of correctly answered questions into the list box
            listBox2.Items.Add(total);
            // put the total number of incorrectly answered questions into the list box
            listBox3.Items.Add(20 - total);
        }

        // method hook
        private void Form2_FormClosing(object sender, FormClosedEventArgs e) {
            // close all the forms when the user closes the application
            Application.Exit();
        }

        // close button method
        private void button1_Click(object sender, EventArgs e)
        {
            // close all the forms when the user closes the application
            Application.Exit();
        }
    }
}
