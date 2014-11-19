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
    public partial class Form1 : Form
    {
        // this array holds all the correct answers to the questions
        private char[] answers = new char[20] {
            'B', 'D', 'A', 'A', 'C', 'A', 'B', 'A', 'C', 'D', 'B', 'C', 'D', 'A', 'D', 'C', 'C', 'B', 'D', 'A'
        };

        // this array holds the answers input by the user
        private char[] userAnswers = new char[20];

        // this variable holds the total number of questions answered correctly
        private int total;

        // form1 constructor
        public Form1()
        {
            // Initialize everything
            InitializeComponent();
        }

        // fires when the "submit" button is hit
        private void button1_Click(object sender, EventArgs e)
        {
            // variable used in for loops
            int i;

            // input the answers from the user into the array for checking
            userAnswers[0] = Convert.ToChar(listBox1.SelectedItem);
            userAnswers[1] = Convert.ToChar(listBox2.SelectedItem);
            userAnswers[2] = Convert.ToChar(listBox3.SelectedItem);
            userAnswers[3] = Convert.ToChar(listBox4.SelectedItem);
            userAnswers[4] = Convert.ToChar(listBox5.SelectedItem);
            userAnswers[5] = Convert.ToChar(listBox6.SelectedItem);
            userAnswers[6] = Convert.ToChar(listBox7.SelectedItem);
            userAnswers[7] = Convert.ToChar(listBox8.SelectedItem);
            userAnswers[8] = Convert.ToChar(listBox9.SelectedItem);
            userAnswers[9] = Convert.ToChar(listBox10.SelectedItem);
            userAnswers[10] = Convert.ToChar(listBox11.SelectedItem);
            userAnswers[11] = Convert.ToChar(listBox12.SelectedItem);
            userAnswers[12] = Convert.ToChar(listBox13.SelectedItem);
            userAnswers[13] = Convert.ToChar(listBox14.SelectedItem);
            userAnswers[14] = Convert.ToChar(listBox15.SelectedItem);
            userAnswers[15] = Convert.ToChar(listBox16.SelectedItem);
            userAnswers[16] = Convert.ToChar(listBox17.SelectedItem);
            userAnswers[17] = Convert.ToChar(listBox18.SelectedItem);
            userAnswers[18] = Convert.ToChar(listBox19.SelectedItem);
            userAnswers[19] = Convert.ToChar(listBox20.SelectedItem);

            // iterate through the user input data
            for (i = 0; i < 20; i++)
            {
                // check to see if the user has made a selection for each question
                if (userAnswers[i] == '\0')
                {
                    // if the user has not made a selection for a question, display an error message
                    MessageBox.Show("You didn't answer all the questions");
                    // quit the method
                    return;
                }
            }

            // iterate through each answer the user input
            for (i = 0; i < 20; i++)
                // compare the answers the user input with the correct answers
                if (userAnswers[i] == answers[i])
                    // add 1 for each time that the answer is correct
                    total++;
            // check to see if the user input atleast 15 to pass the test
            if(total >= 15)
                // show a message box saying that you passed
                MessageBox.Show("you passed");
            // if they didn't pass
            else
                // show a message box saying that you failed 
                MessageBox.Show("you failed");
        }

        // fires when show results button is hit
        private void button2_Click(object sender, EventArgs e)
        {
            // hide the current form so that the user can not interace with it anymore
            this.Hide();
            // open up the new form that displays the results
            Form2 form2 = new Form2(userAnswers, answers, total);
            // make the form visible
            form2.Show();
        }
    }
}
