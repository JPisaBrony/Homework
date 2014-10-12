using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Invoice Application written by
// Josh Pohl and Matt Leet

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // create a LineItem object for holding the list
        private LineItem lineitem = new LineItem();
        // create an address object for holding the address
        private Address address = new Address("John Doe", "11th street", "Fargo", "12345", "ND", "Canada");

        public Form1()
        {
            InitializeComponent();
            // set the address boxes to default values
            textBox4.Text = address.Name;
            textBox5.Text = address.Street;
            textBox6.Text = address.City;
            textBox7.Text = address.ZipCode;
            textBox8.Text = address.State;
            textBox9.Text = address.Country;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // create a product object with the information from what the user input
                Product p = new Product(textBox1.Text, Convert.ToDecimal(textBox2.Text), Convert.ToInt32(textBox3.Text));
                // clear the text boxes so that
                // the user can't spam to add an item
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                // add the item to the LineItemList
                lineitem.addItem(p);
                // add the object to the list box so the user can see
                // what is in the shopping cart
                listBox1.Items.Add(p);
            }
            // catches when the user formats something incorectly
            catch (FormatException exep)
            {
                // shows a message describing what the use did wrong
                MessageBox.Show("You did not input valid data for one or more fields.");
            }
            // catches when the user inputs a number that is too large
            catch (OverflowException overflow)
            {
                // shows a message describing what the use did wrong
                MessageBox.Show("You input a number that is too large.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // create a form 2 that accepts the LineItem and Address for display
            Form2 fm = new Form2(lineitem, address);
            // shows the form
            fm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // sets the address properties from the text boxes the user input
            address.Name = textBox4.Text;
            address.Street = textBox5.Text;
            address.City = textBox6.Text;
            address.ZipCode = textBox7.Text;
            address.State = textBox8.Text;
            address.Country = textBox9.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // removes the item from the list
                lineitem.removeAtIndex(listBox1.SelectedIndex);
                // remove the item from the list box
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (ArgumentOutOfRangeException exp)
            {
                MessageBox.Show("No item selected");
            }
        }

    }
}
