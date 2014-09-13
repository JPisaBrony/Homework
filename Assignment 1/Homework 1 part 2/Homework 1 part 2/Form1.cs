using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_1_part_2
{
    public partial class Form1 : Form
    {
        // form1 constructor
        public Form1()
        {
            // initilize everything so that you can see something
            InitializeComponent();
        }

        // fires when the add item button is hit
        private void button1_Click(object sender, EventArgs e)
        {
            // try block
            // this block is responisble for making sure the user input valid information
            try
            {
                // gets the description of the item from the first text box 
                string desc = textBox1.Text;
                // gets the unitsOnHand from the second text box and converts it to an int
                int unit = Convert.ToInt32(textBox2.Text);
                // gets the price fromt he third text box and converts it to a deciaml
                decimal price = Convert.ToDecimal(textBox3.Text);

                // creates the RetailItem object with the information provided by the user
                RetailItem myItem = new RetailItem(desc, unit, price);
                // adds the RetailItem object to the list in RetailItemStore
                RetailItemStore.AddItem(myItem);

                // clears the text boxes so that the user see's something different
                // and so that the user doesn't just spam the "add" button
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            // catches when the user formats something incorectly
            catch (FormatException exep)
            {
                // shows a message describing what the use did wrong
                MessageBox.Show("You did not input valid data for one or more feilds.");
            }
            // catches when the user inputs a number that is too large
            catch (OverflowException overflow)
            {
                // shows a message describing what the use did wrong
                MessageBox.Show("You input a number that is too large.");
            }
        }

        // fires when the show list button is hit
        private void button2_Click(object sender, EventArgs e)
        {
            // creates a new form2 object
            Form2 form2 = new Form2();
            // shows the form2
            form2.ShowDialog();
        }

    }
}
